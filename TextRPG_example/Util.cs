using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    public class Util
    {
        public static void Print(string context, ConsoleColor textColor = ConsoleColor.White,int delay = 25)
        {
            Console.ForegroundColor = textColor;
            
            foreach(char c in context)
            {
                Thread.Sleep(delay);
                Console.Write(c);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
