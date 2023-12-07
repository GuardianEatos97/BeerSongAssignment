using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    internal class Lyrics
    {
        public static string Words() 
        {
            int beer = 100;

            for (int i = 1; i <= 99; i++)
            {
                beer--;
                if (beer > 1)
                {
                    Console.WriteLine($"{beer} bottles of beer on the wall, {beer} bottles of beer");
                    if (beer - 1 == 1)
                    {
                        Console.WriteLine($"Take one down and pass it around, {beer - 1} bottle of beer\n");
                    }
                    else 
                    {
                        Console.WriteLine($"Take one down and pass it around, {beer - 1} bottles of beer\n");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{beer} bottle of beer on the wall, {beer} bottle of beer");
                }

            }
            return "";
        } 
    }
}
