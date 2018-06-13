using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionMath
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fraction f1 = new Fraction("1/3");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 + f2;
            Console.WriteLine(
                f1.ToString() + " + " + f2.ToString() + "=" + f3.ToString());
            Fraction f4 = f1 * f2;
            Console.WriteLine(
                f1.ToString() + " * " + f2.ToString() + "=" + f4.ToString());

            if (f1 > f2)
                Console.WriteLine(f1.ToString() + ">" + f2.ToString());
            else if (f1 < f2)
                Console.WriteLine(f1.ToString() + "<" + f2.ToString());
            else
                Console.WriteLine(f1.ToString() + "=" + f2.ToString());
            Console.ReadKey();
        }
    }
}
