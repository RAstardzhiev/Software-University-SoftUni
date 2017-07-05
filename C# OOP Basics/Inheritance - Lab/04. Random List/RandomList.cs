namespace _04.Random_List
{
    using System;
    using System.Collections;

    public class RandomList : ArrayList
    {
        private Random rdn;

        public RandomList()
        {
            this.rdn = new Random();
        }

        public int randomInteger()
        {
            return this.rdn.Next();
        }

        public int randomString() => randomInteger();
    }
}
