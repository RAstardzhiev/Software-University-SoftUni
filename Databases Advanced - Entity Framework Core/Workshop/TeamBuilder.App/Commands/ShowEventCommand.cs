namespace TeamBuilder.App.Commands
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class ShowEventCommand : Command
    {
        private const int ArgsExactLength = 1;

        private const string EventNotFoundExceptionMessage = "Event {0} not found!";

        public ShowEventCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <eventName>
        public override string Execute(TeamBuilderContext context)
        {
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var eventName = this.CmdArgs[0];
            var @event = this.GetEvent(context, eventName);

            var sb = new StringBuilder();
            sb.AppendLine($"{@event.Name} {@event.StartDate} {@event?.EndDate}");

            if (@event.Description != null)
            {
                sb.AppendLine(@event.Description);
            }

            sb.AppendLine("Teams:");
            foreach (var name in @event.EventTeams.Select(et => et.Team.Name))
            {
                sb.AppendLine($"-{name}");
            }

            return sb.ToString().TrimEnd();
        }

        private Event GetEvent(TeamBuilderContext context, string eventName)
        {
            var currentDate = DateTime.Now;
            var @event = context.Events
                .Include(e => e.EventTeams)
                .Where(e => e.StartDate != null)
                .OrderBy(e => (e.StartDate.Value - currentDate).Days)
                .FirstOrDefault(e => e.Name.Equals(eventName, StringComparison.OrdinalIgnoreCase));

            if (@event == null)
            {
                throw new ArgumentException(string.Format(EventNotFoundExceptionMessage, eventName));
            }

            return @event;
        }
    }
}
