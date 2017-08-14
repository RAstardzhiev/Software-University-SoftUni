namespace _01.Event_Implementation
{
    using System;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler(new ConsoleWriter());

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var dispatcherName = Console.ReadLine();

            while (dispatcherName != "End")
            {
                dispatcher.Name = dispatcherName;
                dispatcherName = Console.ReadLine();
            }
        }
    }
}
