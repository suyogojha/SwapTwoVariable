using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoVariable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 10,  j = 10;
            SwapValue(i, j);
            Console.WriteLine($"i={i},j={j}");
        }
        public static void SwapValue(int i, int j)
        {
            int temp = i;
            i = j;
            j = temp;
            Console.WriteLine($"i={i},j={j}");
        }
    }
}
