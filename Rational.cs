using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_RationalClass
{
    class Rational
    {
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }

        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public void IncreaseBy(Rational other)
        {
            if (Denominator == other.Denominator)
            {
                Numerator += other.Numerator;
            }
            else
            {
                Numerator = Numerator * other.Denominator + Denominator * other.Numerator;
                Denominator = Denominator * other.Denominator;
            }
            //Numerator = Numerator * other.Denominator + Denominator * other.Numerator;
            //Denominator = Denominator * other.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            if (Denominator == other.Denominator)
            {
                Numerator += other.Numerator;
            }
            else
            {
                Numerator = Numerator * other.Denominator - Denominator * other.Numerator;
                Denominator = Denominator * other.Denominator;
            }
            //Numerator = Numerator * other.Denominator - Denominator * other.Numerator;
            //Denominator = Denominator * other.Denominator;
        }
    }
}
