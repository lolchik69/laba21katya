using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pplab21katya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose action: +, -, /, *, e - exit");
            char c = char.Parse(Console.ReadLine());
            bool checker = true;
            while (checker == true)
            {
                switch (c)
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    case '+':
                        Console.WriteLine($"Result: {a+b}");
=======
                    case '-':
                        Console.WriteLine($"Result: {a-b}");
>>>>>>> substract
=======
                    case '*':
                        Console.WriteLine($"Result: {a*b}");
>>>>>>> multiply
=======
                    case '/':
                        Console.WriteLine($"Result: {a/b}");
>>>>>>> divide
=======
                    case 'e':
                        checker = false;
>>>>>>> exit
                        break;
                    default:
                        Console.WriteLine("Incorrect action");
                        break;
                }
            }
        }
    }
}
