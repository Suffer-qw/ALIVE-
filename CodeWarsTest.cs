using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConsoleApp2
{
    internal class NeXochy
    {

        public List<string> BTwoB(string ptp, List<string> list)
        {
            List<string> Lazy = new List<string>();
            foreach (string s in list)
            {
                int z = 0;
                if (s.Length == ptp.Length)
                {

                    for (int i = 0; i < ptp.Length; i++)
                    {
                        for (int j = 0; j < s.Length; j++)
                        {
                            if (ptp[i] == s[j])
                                z++;
                        }
                    }
                }
                if (z-mod(ptp) == ptp.Length)
                    Lazy.Add(s);
            }

            return Lazy.ToList();
        }

        static public int mod(string g)
        {
            int y = 0;
            for (int i = 0; i < g.Length; i++)
            {
                for (int j = 0; j < g.Length; j++)
                {
                    if (g[i] == g[j])
                        y++;
                }
            }
            return y - g.Length;
        }



    }
}
/*


 static void Main(string[] args)
 {
     NeXochy neXochy = new NeXochy();
     string ptp = "elloh";
     List<string> list = new List<string>() { "hello", "tomato", "help"};
     List<string> help = new List<string>() ;

     help = neXochy.BTwoB(ptp, list);
    
     help.ForEach(x => Console.WriteLine(x));

     
 }


 */
