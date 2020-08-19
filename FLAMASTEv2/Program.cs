using System;

namespace FLAMASTEv2
{
    class Program
    {
        static void Main()
        {
            byte ile = Byte.Parse(Console.ReadLine());
            string[] words = new string[ile];
            for (byte i = 0; i < ile; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (byte i = 0; i < words.Length; i++)
            {
                string new_word = null;
                byte numbers_of_letters = 1;
                for (byte j = 0; j < words[i].Length; j++)
                {
                    if (j + 1 != words[i].Length)
                    {
                        if (words[i][j] == words[i][j + 1])
                        {
                            numbers_of_letters++;
                        }
                        else
                        {
                            new_word = Add_Letters(numbers_of_letters, words[i][j], new_word);
                            numbers_of_letters = 1;
                        }
                    }
                    else
                    {
                        new_word = Add_Letters(numbers_of_letters, words[i][j], new_word);
                    }
                }
                words[i] = new_word;
                Console.WriteLine(words[i]);
            }
        }

        static string Add_Letters(byte numbers_of_letters, char current_letter, string new_word)
        {
            if (numbers_of_letters >= 3)
            {
                return new_word + current_letter + numbers_of_letters.ToString();
            }
            else if (numbers_of_letters == 2)
            {
                return new_word + current_letter.ToString() + current_letter.ToString();
            }
            else if (numbers_of_letters == 1)
            {
                return new_word + current_letter.ToString();
            }
            return null;
        }
    }
}
