using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSort
{
    public class FS
    {
        public List<int> FastSort(List<int> list)
        {
            List<int> low = new List<int>();
            List<int> big = new List<int>();


            if (list.Count == 1|| list.Count == 0) 
                return list;
            if (list.Count == 2)
            {
                if (list[0]  >  list[1])
                    (list[0], list[1]) = (list[1], list[0]);
                return list;
            }
            int i = 1;
            while (big.Count + low.Count < list.Count-1)
            {
                if (list[i] > list[0])
                    big.Add(list[i]);
                else
                    low.Add(list[i]);
                i++;
                
            }
            low = FastSort(low);
            low.Add(list[0]);
            return low.Concat(big).ToList();


        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FS fs = new FS();
            List<int> nS = new List<int>() {10,11,35,4,8 };
            nS.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("\n");
            nS = fs.FastSort(nS);
            nS.ForEach(x=> Console.WriteLine(x));
        }
        //list.Sort() в C#,  реализует гибридный алгоритм (QuickSort + InsertionSort + HeapSort) и оптимизирована для всех случаев.
    }
}
