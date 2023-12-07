using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MilkSong
    {
        public static string Milk()
        {
            for (int i = 99; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i} bottle of milk on the wall, {i} bottle of milk.");
                    break;
                }

                Console.WriteLine($"{i} bottles of milk on the wall, {i} bottles of milk.");
                Console.WriteLine($"Take one down and past it around, {i - 1} bottles of milk.");
            }
            return "";
        }
    }
}
