namespace _01.Event_Implementation.Models
{
    using Interfaces;

    public class Handler
    {
        private IWriter writer;

        public Handler(IWriter writer)
        {
            this.writer = writer;
        }

        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            this.writer.WriteLine($"Dispatcher's name changed to {args.Name}.");
        }
    }
}
