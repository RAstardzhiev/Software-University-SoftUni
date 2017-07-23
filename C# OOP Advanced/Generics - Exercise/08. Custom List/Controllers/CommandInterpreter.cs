namespace _08.Custom_List.Controllers
{
    using Models;
    using System;

    public class CommandInterpreter
    {
        private IMyList<string> myList;

        public CommandInterpreter()
        {
            this.myList = new MyList<string>();
        }

        public void InterpretCommand(string[] cmdArgs)
        {
            var command = cmdArgs[0];
            string element;

            switch (command)
            {
                case "Add": // Add <element> - Adds the given element to the end of the list
                    element = cmdArgs[1];
                    this.myList.Add(element);
                    break;
                case "Remove": // Remove <index> - Removes the element at the given index
                    var index = int.Parse(cmdArgs[1]);
                    this.myList.Remove(index);
                    break;
                case "Contains": // Contains <element> - Prints if the list contains the given element (True or False)
                    element = cmdArgs[1];
                    Console.WriteLine(this.myList.Contains(element));
                    break;
                case "Swap": // Swap <index> <index> - Swaps the elements at the given indexes
                    var firstIndex = int.Parse(cmdArgs[1]);
                    var secondIndex = int.Parse(cmdArgs[2]);
                    this.myList.Swap(firstIndex, secondIndex);
                    break;
                case "Greater": // Greater <element> - Counts the elements that are greater than the given element and prints their count
                    element = cmdArgs[1];
                    Console.WriteLine(this.myList.CountGreaterThan(element));
                    break;
                case "Max": // Max - Prints the maximum element in the list
                    Console.WriteLine(this.myList.Max());
                    break;
                case "Min": // Min - Prints the minimum element in the list
                    Console.WriteLine(this.myList.Min());
                    break;
                case "Print": // Print - Prints all elements in the list, each on a separate line
                    // Console.WriteLine(this.myList);
                    foreach (var item in this.myList)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case "Sort":
                    this.myList.Sort();
                    break;
                default:
                    break;
            }
        }
    }
}
