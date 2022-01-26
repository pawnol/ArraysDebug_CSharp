/*
 * Arrays Debug
 * Pawelski
 * 1/25/2022
 * This program does not work! Debug this program so that it
 * displays all the words in the list to the console with each
 * word on its own line.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"apple", "orange", "grape", "watermelon",
                                "lime", "lemon", "pear", "pineapple", "banana"};
            for(int i = 1; i <= words.Length; i++)
            {
                Console.Write(words[i]);
            }
        }
    }
}
