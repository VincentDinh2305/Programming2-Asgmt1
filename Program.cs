using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_RationalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Rational r1 = new Rational();
            Rational r2 = new Rational(denominator: 5);
            Rational r3 = new Rational(7, 4);
            Rational r4 = new Rational(8, 5);

            //#2
            Console.WriteLine($"Rational 01: {r1.ToString()}");
            Console.WriteLine($"Rational 01: {r2.ToString()}");
            r1.IncreaseBy(r2);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Rational 01: {r1.ToString()}");
            Console.WriteLine($"Rational 01: {r2.ToString()}");

            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");

            //#3
            Console.WriteLine($"Rational 03: {r3.ToString()}");
            Console.WriteLine($"Rational 04: {r4.ToString()}");
            r3.DecreaseBy(r4);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Rational 03: {r1.ToString()}");
            Console.WriteLine($"Rational 04: {r2.ToString()}");
        }
    }
}
