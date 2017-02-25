namespace Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CubicMessages
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string encryptedMessage = Console.ReadLine();
                if (encryptedMessage.Equals("Over!"))
                {
                    break;
                }

                int messageLength = int.Parse(Console.ReadLine());

                if (!IsValid(encryptedMessage, messageLength))
                {
                    continue;
                }

                List<int> indexes = ExtractIndixes(encryptedMessage);
                string clearMessage = encryptedMessage.Substring(MessageStartIndex(encryptedMessage), messageLength);

                StringBuilder verificationCode = new StringBuilder();
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (indexes[i] >= clearMessage.Length)
                    {
                        verificationCode.Append(' ');
                    }
                    else
                    {
                        verificationCode.Append(clearMessage[indexes[i]]);
                    }
                }

                Console.WriteLine($"{clearMessage} == {verificationCode.ToString()}");
            }
        }

        private static List<int> ExtractIndixes(string message)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    indexes.Add((int)(message[i] - '0'));
                }
            }

            return indexes;
        }

        private static int MessageStartIndex(string message)
        {
            int messageStartIndex = -1;
            for (int i = 0; i < message.Length; i++)
            {
                if ((message[i] >= 'a' && message[i] <= 'z') || (message[i] >= 'A' && message[i] <= 'Z'))
                {
                    messageStartIndex = i;
                    break;
                }
            }

            return messageStartIndex;
        }

        private static bool IsValid(string encryptedMessage, int messageLength)
        {
            int letterCount = 0;
            int messageStartIndex = MessageStartIndex(encryptedMessage);

            // If there is not letters
            if (messageStartIndex < 0)
            {
                return false;
            }

            // Check whether before the message there is only digits
            for (int i = 0; i < messageStartIndex; i++)
            {
                if (!char.IsDigit(encryptedMessage[i]))
                {
                    return false;
                }
            }

            // Check whether the count is valid
            for (int i = messageStartIndex; i < messageStartIndex + messageLength && i < encryptedMessage.Length; i++)
            {
                if ((encryptedMessage[i] >= 'a' && encryptedMessage[i] <= 'z') || (encryptedMessage[i] >= 'A' && encryptedMessage[i] <= 'Z'))
                {
                    letterCount++;
                }
                else
                {
                    return false;
                }
            }

            // Check whether after the message there is letters
            for (int i = messageStartIndex + messageLength; i < encryptedMessage.Length; i++)
            {
                if ((encryptedMessage[i] >= 'a' && encryptedMessage[i] <= 'z') || (encryptedMessage[i] >= 'A' && encryptedMessage[i] <= 'Z'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
