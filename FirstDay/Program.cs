using System;
using MyMath;

namespace CognizantProjectFirstDay
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Arithmetics();
            int num1;
            int num2;
            int sum;
            int sub;
            string temp;

            Console.WriteLine("Write first number:");
            temp = Console.ReadLine();
            num1 = int.Parse(temp);

            Console.WriteLine("Write second number:");
            temp = Console.ReadLine();
            num2 = int.Parse(temp);

            sum = math.Add(num1, num2);
            Console.WriteLine($"We added {num1} and {num2} and got --> {sum}");

            sub = math.Minus(num1, num2);
            Console.WriteLine($"We subtract {num1} and {num2} and got --> {sub}");
        }
    }
}
