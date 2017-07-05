namespace _04.Random_List
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var rl = new RandomList();
            Console.WriteLine(rl.randomInteger());
            rl.Add("ggg");
            rl.Add(1);
            rl.Add("ttt");

            var test = rl[0]; // Type - Object
            var test1 = rl[1]; // Type - Object
        }
    }
}
