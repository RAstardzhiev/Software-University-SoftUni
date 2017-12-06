namespace TeamBuilder.App.Commands
{
    using System;
    using System.Globalization;
    using TeamBuilder.App.Commands.Abstractions;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class CreateEventCommand : Command
    {
        private const string Success = "Event {0} was created successfully!";
        private const string DateFormat = "dd/MM/yyyy HH:mm";
        private const int ArgsExactLength = 6;

        private readonly string InvalidDateExceptionMessage = $"Please insert the dates in format: {DateFormat}!";
        private const string InvalidStartDateExceptionMessage = "Start date should be before end date.";

        public CreateEventCommand(string[] cmdArgs, IUserSession session) 
            : base(cmdArgs, session)
        {
        }

        // <name> <description> <startDate> <endDate>
        public override string Execute(TeamBuilderContext context)
        {
            base.MustBeLoggedIn();
            base.CmdArgsExactLengthValidation(ArgsExactLength);

            var creator = this.Session.User;
            var name = this.CmdArgs[0];
            var description = this.CmdArgs[1];
            var startDate = this.ParseDate(this.CmdArgs[2], this.CmdArgs[3]);
            var endDate = this.ParseDate(this.CmdArgs[4], this.CmdArgs[5]);

            if (startDate > endDate)
            {
                throw new ArgumentException(InvalidStartDateExceptionMessage);
            }

            /* ?????????????????????????????
             * There might be several events with the same name. 
             * Always pick the one with the latest start date! 
             */

            var @event = new Event();
            @event.Creator = creator;
            @event.Name = name;
            @event.Description = description;
            @event.StartDate = startDate;
            @event.EndDate = endDate;

            context.Events.Add(@event);
            context.SaveChanges();

            return string.Format(Success, name);
        }

        private DateTime ParseDate(string date, string hour)
        {
            var completeDateString = $"{date} {hour}";

            DateTime parsedDate;
            var isDateValid = DateTime.TryParseExact(completeDateString, 
                DateFormat, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out parsedDate);

            if (!isDateValid)
            {
                throw new ArgumentException(InvalidDateExceptionMessage);
            }

            return parsedDate;
        }
    }
}
