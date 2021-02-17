using System;
using System.Collections.Generic;

namespace CaeserCipher
{
    class Program
    {
        static void Main()
        {
            Console.Write("What's Your text?:");
            string text=Console.ReadLine();
            for (int n = 1; n < 26; n++)
            {
                Console.Write(26-n+" ");
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        Console.Write(" ");
                        continue;
                    }
                    if (text[i] + n > 122) Console.Write(Convert.ToChar(text[i] + n - 26));
                    else if (text[i] < 91&&text[i]+n>90) Console.Write(Convert.ToChar(text[i] + n - 26));
                    else Console.Write(Convert.ToChar(text[i] + n));
                }
                Console.Write("\n");
            }
        }
    }
}