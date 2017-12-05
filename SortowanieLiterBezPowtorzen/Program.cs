using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieLiterBezPowtorzen
{
    class Program
    {

        static string Sortuj(string s1, string s2)
        {
            string sortedString = null;

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (s1.Contains(i) && s2.Contains(i))
                {
                    sortedString += i;
                }
            }
            return sortedString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("zaczynamy operacje");
            Console.WriteLine(Sortuj("aretheyhere", "yestheyarehere"));
            Console.WriteLine("skonczylismy");
            Console.ReadKey();
        }
    }
}
