using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static List<int> ellements = new List<int>() { 200,1000,4, 39, 210 };
        static void Main(string[] args)
        {
            Console.Write("Ex 1The midle ellement(s) ");
            middleElements(ellements);
            Console.WriteLine("Ex 2The largest ellement is " +findLargestEllemnt(ellements));
            Console.ReadKey();
        }

        public static void middleElements(List<int> ellements)
        {
            int n = ellements.Count / 2;
            if (ellements.Count % 2 == 0)
            {
                Console.WriteLine(ellements[n - 1]);
                Console.WriteLine(ellements[n]);
            }
            else
                Console.WriteLine(ellements[n]);
        }
        public static int findLargestEllemnt(List<int> ellements)
        {
            int max = ellements[0];

            for(int i =0; i < ellements.Count; i++)
            {
                if (max < ellements[i])
                {
                    max = ellements[i];
                }
            }
            return max;
        }
    }
}
