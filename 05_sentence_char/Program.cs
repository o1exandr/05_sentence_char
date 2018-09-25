/*
 Завдання 5.
 Користувач вводить рядок і символ. У рядку знайти всі входження цього символа і перевести його у верхній регістр,
 а також видалити частину рядка, після останнього входження цього символу і до кінця.
(IndexOf, Remove, Replace)
 */

using System;

namespace _05_sentence_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence end press 'Enter':\t");
            string text = Console.ReadLine();
            //string text = "The quick brown fox jumps over the lazy dog.";
            Console.Write("Enter one letter:\t");
            char smb = Convert.ToChar(Console.Read());

            Console.WriteLine($"\n\tBefore\n{text}");

            int index = text.LastIndexOf(smb);
            if (index > -1)
            {
                text = text.Remove(index, text.Length - index);
                text = text.Replace(smb, Convert.ToChar(smb - 32));
            }
            else
                Console.WriteLine($"Symbol '{smb}' not find");
            
            Console.WriteLine($"\n\tAfter\n{text}\n");
        }
    };
}
