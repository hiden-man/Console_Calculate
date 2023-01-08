using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, s;
            char c;
            Console.WriteLine("\t******Calculate******");
            Console.Write($"enter first Operand: ");
            f = double.Parse(Console.ReadLine());
            Console.Write($"enter second Operand: ");
            s = double.Parse(Console.ReadLine());

            Console.WriteLine("What do you want?");
            c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine(f+s);
                    break;
                case '-':
                    Console.WriteLine(f-s);
                    break;
                case '/':
                    Console.WriteLine(f/s);
                    break;
                case '*':
                    Console.WriteLine(f*s);
                    break;
                case '%':
                    Console.WriteLine(f%s);
                    break;
            }
        }

    }
}
