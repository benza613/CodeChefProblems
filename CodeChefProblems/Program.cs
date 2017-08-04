using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            for (int i = 0; i < n; i++)
            {
                int numToRemove = a[i].Length-1;
                int numIndex = Array.IndexOf(a[i], numToRemove);
                a[i] = a[i].Where((val, idx) => idx != numIndex).ToArray();

                Console.WriteLine(a[i].Max());
            }
        }
    }
}
