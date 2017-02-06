namespace Phonebook
{
    using System;
    using System.Collections.Generic;

    public class PhonebookPlusUpgrade
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            /* • A { name}{ phone} – adds entry to the phonebook.In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
               • S { name} – searches for a contact by given name and prints it in format "{name} -> {number}".In case the contact isn't found, print "Contact {name} does not exist.".
               • END – stop receiving more commands. */

            bool isWorking = true;
            while (isWorking)
            {
                string[] comand = Console.ReadLine().Split(' ');
                switch (comand[0])
                {
                    case "A":
                        phonebook[comand[1]] = comand[2];
                        break;
                    case "S":
                        Console.WriteLine(phonebook.ContainsKey(comand[1]) ? $"{comand[1]} -> {phonebook[comand[1]]}" : $"Contact {comand[1]} does not exist.");
                        break;
                    case "ListAll":
                        foreach (KeyValuePair<string, string> item in phonebook)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }

                        break;
                    default:
                        isWorking = false;
                        break;
                }
            }
        }
    }
}
