using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_control_Work {
    internal class Fraction {

        private int num { set; get; }//числитель
        private int deNum { set; get; }//знаменатель
        
        public Fraction(int num, int deNum) {
            if (deNum == 0) {
                Console.WriteLine("В знаменателе не может быть нуля");
                return;
            }
            this.num = num;
            this.deNum = deNum;
        }
        //перегрузки
        public static Fraction operator +(Fraction a, Fraction b) {
            Fraction t = new Fraction(1, 1);
            t.num = (a.num * b.deNum + a.deNum * b.num);
            t.deNum = a.deNum * b.deNum;
            Fraction.SetFormat(t);
            return t;
        }
        public static Fraction operator -(Fraction a, Fraction b){
            Fraction t = new Fraction(1, 1);
            t.num = (a.num * b.deNum - a.deNum * b.num);
            t.deNum = a.deNum * b.deNum;
            Fraction.SetFormat(t);
            return t;

        }
        public static Fraction operator *(Fraction a, Fraction b){
            Fraction t = new Fraction(1, 1);
            t.num = (a.num * b.num);
            t.deNum = a.deNum * b.deNum;
            Fraction.SetFormat(t);
            return t;

        }
        public static Fraction operator /(Fraction a, Fraction b){
            Fraction t = new Fraction(1, 1);
            t.num = (a.num / b.num);
            t.deNum = a.deNum / b.deNum;
            Fraction.SetFormat(t);
            return t;
        }

        //методы
        public void printFraction() {
            Console.WriteLine($"{num} / {deNum}");
        }
        public static Fraction SetFormat(Fraction a) {

            int max = 0;

            if (a.num > a.deNum)
                max = Math.Abs(a.deNum);
            else
                max = Math.Abs(a.num);
                                    
            for (int i = max; i >= 2; i--) {
                
                
                if ((a.num % i == 0) & (a.deNum % i == 0)) {
                    a.num = a.num / i;
                    a.deNum = a.deNum / i;
                }

            }
           
           
            if ((a.deNum < 0)) {
                a.num = -1 * (a.num);
                a.deNum = Math.Abs(a.deNum);
            }
            return (a);
        }

    }
}
