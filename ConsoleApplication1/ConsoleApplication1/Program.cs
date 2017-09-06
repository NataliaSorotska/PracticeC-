using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static string Reverse(string text)
        {
            if (text==" ")
            {
                return "Incorect data";
            }
            if ((text == null) || (text.Length <= 1))
            {
                return text;
            }
            return Reverse(text.Substring(1)) + text[0];
        }

        static void Main(string[] args)
        {
            string src = " ";
            Console.WriteLine(src);
            src = Reverse(src);
            Console.WriteLine(src);
            Console.ReadLine();
        }

    }
}
