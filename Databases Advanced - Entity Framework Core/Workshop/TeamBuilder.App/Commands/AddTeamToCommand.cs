namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class AddTeamToCommand : Command
    {
        private const string Success = "Team {0} added for {1}!";
        private const int ArgsExactLength = 2;

        private const string EventNotFoundExceptionMessage = "Event {0} not found!";
        private const string TeamNotFoundExceptionMessage = "Team {0} not found!";
        private const string NotCreatorExceptionMessage = "Not allowed!";
        private const string TeamAddedExceptionMessage = "Cannot add same team twice!";

        public AddTeamToCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <eventName> <teamName>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var eventName = this.CmdArgs[0];
            var teamName = this.CmdArgs[1];

            var team = this.GetTem(context, teamName);
            var @event = this.GetEvent(context, eventName, team);

            var mapping = new TeamEvent();
            mapping.Event = @event;
            mapping.Team = team;

            context.TeamsEvents.Add(mapping);
            context.SaveChanges();

            return string.Format(Success, teamName, eventName);
        }

        private Team GetTem(TeamBuilderContext context, string teamName)
        {
            var team = context.Teams
                .SingleOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));

            if (team == null)
            {
                throw new ArgumentException(string.Format(TeamNotFoundExceptionMessage, teamName));
            }

            return team;
        }

        private Event GetEvent(TeamBuilderContext context, string eventName, Team team)
        {
            var @event = context.Events
                .Include(e => e.EventTeams)
                .OrderByDescending(e => e.StartDate)
                .FirstOrDefault(e => e.Name.Equals(eventName, StringComparison.OrdinalIgnoreCase));

            if (@event == null)
            {
                throw new ArgumentException(string.Format(EventNotFoundExceptionMessage, eventName));
            }

            if (@event.CreatorId != this.Session.User.Id)
            {
                throw new InvalidOperationException(NotCreatorExceptionMessage);
            }

            if (@event.EventTeams.Any(et => et.TeamId == team.Id))
            {
                throw new InvalidOperationException(TeamAddedExceptionMessage);
            }

            return @event;
        }
    }
}
