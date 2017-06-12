namespace _11.Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;

    public class PartyReservationFilterModule
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            var filters = GetFilters();
            names = FilterNames(filters, names);
            Console.WriteLine(string.Join(" ", names));
        }

        private static string[] FilterNames(HashSet<Filter> filters, string[] names)
        {
            foreach (Filter filter in filters)
            {
                switch (filter.Command)
                {
                    case "Starts":
                        names = Filter.FilterCollection(names, n => !n.StartsWith(filter.Arg));
                        break;
                    case "Ends":
                        names = Filter.FilterCollection(names, n => !n.EndsWith(filter.Arg));
                        break;
                    case "Length":
                        names = Filter.FilterCollection(names, n => n.Length != int.Parse(filter.Arg));
                        break;
                    case "Contains":
                        names = Filter.FilterCollection(names, n => !n.Contains(filter.Arg));
                        break;
                    default:
                        break;
                }
            }

            return names;
        }

        private static HashSet<Filter> GetFilters()
        {
            // The possible TPRF filter types are: "Starts with", "Ends with", "Length" and "Contains
            var filters = new HashSet<Filter>();
            var input = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Print")
            {
                if (input.Length != 5)
                {
                    input = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                var currentFilter = new Filter() { Command = input[2], Arg = input[4] };

                switch (input[0])
                {
                    case "Add":
                        filters.Add(currentFilter);
                        break;
                    case "Remove":
                        filters.RemoveWhere(f =>
                            f.Arg == currentFilter.Arg &&
                            f.Command == currentFilter.Command);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return filters;
        }
    }
}
