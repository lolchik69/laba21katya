using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ctrl + s
//git add .
//git commit -am "aaaaa"
//git push origin main


namespace pplab21katya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ДОБАВИЛА ИЗМЕНЕНИЕ
            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose action: +, -, /, *, e - exit");
            char c = char.Parse(Console.ReadLine());
            bool checker = true;
            while (checker == true)
            {
                //slkdjkjsdfhksjdfh
                //exei
                switch (c)
                {
                    case '+':
                        Console.WriteLine($"Result: {a+b}");
                        break;
                    case '-':
                        Console.WriteLine($"Result: {a-b}");
                        break;
                    case '*':
                        Console.WriteLine($"Result: {a*b}");
                        break;
                    case '/':
                        Console.WriteLine($"Result: {a/b}");
                        break;
                    case 'e':
                        checker = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect action");
                        break;
                }
            }
        }
    }
}
