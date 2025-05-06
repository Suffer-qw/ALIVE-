using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithm
{

    public class Euclidean
    {
        public int gcd(int a, int b)
        {
            if(a == 0)
                return b;

            if(b == 0)
                return a;

            if (a < b)
            {  
                (a,b) = (b,a);
            }

            while (b != 0)
            {
                Console.WriteLine($" А {a}");
                Console.WriteLine($" B {b}\n");
                (a, b) = (b, a % b);
            }
            return a;

        }

        public void aspect_ratio(int a, int b)
        {
            int _gcd = gcd(a, b);

            Console.WriteLine($"wihit {a} , hihit {b} \nСоотногение сторон {a/_gcd}:{b / _gcd}");

        }
        public int mod_inverse(int a, int b)
        {
            int x0 = 1, x1 = 0;
            Console.WriteLine($"Исходные значения: a={a}, b={b}");
            while (b!= 0)
            {
                int q = a / b;
                Console.WriteLine($"Шаг q={q}, a={a}, b={b}");

                (a, b) = (b, a % b);
                (x0, x1) = (x1, x0 - q * x1);
                Console.WriteLine($"Новые коэффициенты: x0={x0}, x1={x1}\n");
            }

            if (x0 < 0)
                return x0 = -x0;
            return x0;
        }
        
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Euclidean euc = new Euclidean();
            int z = euc.gcd(-10, 15);
            euc.aspect_ratio(0, 100);
            int b = euc.mod_inverse(3, 11);
            Console.WriteLine($"z {z}\nb{b}");


        }
    }
}
