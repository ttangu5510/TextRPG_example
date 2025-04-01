using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    public class Util
    {
        public static void Print(string context, ConsoleColor textColor,int delay = 0)
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
