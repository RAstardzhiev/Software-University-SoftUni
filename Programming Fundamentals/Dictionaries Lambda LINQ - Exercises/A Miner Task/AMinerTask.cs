namespace A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> myWorehouse = new Dictionary<string, int>();

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand.Equals("stop"))
                {
                    break;
                }
                else if (myWorehouse.ContainsKey(comand))
                {
                    myWorehouse[comand] += int.Parse(Console.ReadLine());
                }
                else
                {
                    myWorehouse[comand] = int.Parse(Console.ReadLine());
                }
            }

            foreach (KeyValuePair<string, int> item in myWorehouse)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
