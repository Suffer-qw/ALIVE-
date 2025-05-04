using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> listint = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                listint.Add(random.Next(1, 100));
            }
            listint.ForEach(x => Console.WriteLine($"element list:{x}"));

            Console.WriteLine($"\nsort\n");
            for(int i = 0; i < listint.Count-1; i++)
            {
                int big_i = i;
                for (int x = i+1; x < listint.Count; x++)
                {
                    if (listint[x] < listint[big_i])
                        big_i = x;
                }
                int tmp = listint[i];
                listint[i] = listint[big_i];
                listint[big_i] = tmp;
               
            }
            listint.ForEach(x => Console.WriteLine($"element list sorted:{x}"));


            Console.WriteLine($"\narray\n");
            int[] ints = new int[10];


            int[] bigest = new int[10];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(1,100);
            }

            foreach (var item in ints)
            {
                Console.WriteLine($"element arr:{item}");
            }

            Console.WriteLine($"sort\n");

            for (int i = 0; i < ints.Length; i++)
            {
                int big = i;
                for (int x = i+1; x < ints.Length; x++)
                {
                    if (ints[big] != 0 && ints[x] != 0)
                        if (ints[x] < ints[big])
                            big = x;
                }
                bigest[i] = ints[big]; 
                ints[big] = ints[i];
            }

            foreach (var item in bigest)
            {
                Console.WriteLine($"element arr Biggest:{item}");
            }
        }
    }
}
