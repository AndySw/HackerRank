using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]{ 1, 2, 3, 4, 5 };
            
        }
    }

    class ReverseSortComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
