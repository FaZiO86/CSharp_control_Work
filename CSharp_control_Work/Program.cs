using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_control_Work {
    internal class Program {
        static void Main(string[] args) {

            var fraction1 = new Fraction(2,20);
            var fraction2 = new Fraction(1,5);
            Console.WriteLine("Сложение");
            Fraction fraction = fraction1 + fraction2;
            fraction.printFraction();
            Console.WriteLine("Вычитание");
            Fraction fraction3 = fraction1 - fraction2;
            fraction3.printFraction();
            Console.WriteLine("Умножение");
            Fraction fraction4 = fraction1 * fraction2;
            fraction4.printFraction();
            Console.WriteLine("Деление");
            Fraction fraction5 = fraction1 / fraction2;
            fraction5.printFraction();
            
            Console.ReadKey();
        }
        
    }
}
