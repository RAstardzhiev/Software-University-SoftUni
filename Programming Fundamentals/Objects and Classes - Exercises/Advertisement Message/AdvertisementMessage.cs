namespace Advertisement_Message
{
    using System;

    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            int messagesQuantity = int.Parse(Console.ReadLine());
            PrintMessages(messagesQuantity);
        }

        private static void PrintMessages(int messagesQuantity)
        {
            string[] title = new string[]
            {
                "Excellent product."
                , "Such a great product."
                , "I always use that product."
                , "Best product of its category."
                , "Exceptional product."
                , "I can’t live without this product."
            };
            string[] description = new string[]
            {
                "Now I feel good."
                , "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!"
                , "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied."
                , "I feel great!."
            };
            string[] author = new string[]
            {
                "Diana"
                , "Petya"
                , "Stella"
                , "Elena"
                , "Katya"
                , "Iva"
                , "Annie"
                , "Eva"
            };
            string[] city = new string[]
            {
                "Burgas"
                , "Sofia"
                , "Plovdiv"
                , "Varna"
                , "Ruse"
            };

            Random random = new Random();
            for (int i = 0; i < messagesQuantity; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}", title[random.Next(title.Length)], description[random.Next(description.Length)], author[random.Next(author.Length)], city[random.Next(city.Length)]);
            }
        }
    }
}
