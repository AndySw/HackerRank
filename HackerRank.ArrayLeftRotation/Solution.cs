using System;
using System.Linq;
using System.Text;

namespace HackerRank.ArrayLeftRotation
{
    public class Solution
    {
        static void Main(String[] args)
        {
            //template solution code from HackerRank 
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            //solution
            var output = RotateLeft(a, k);
            var result = GetArrayAsDelimtedString(output, ' ');
            Console.WriteLine(result);
        }

        public static string GetArrayAsDelimtedString<T>(T[] array, char delimiter)
        {
            var result = new StringBuilder();
            foreach(T i in array)
            {
                result.Append(i);
                result.Append(delimiter);
            }
            return result.ToString().TrimEnd();
        }

        public static int[] RotateLeft(int[] input, int rotations)
        {
            if (rotations < 0) { throw new ArgumentOutOfRangeException(); }
            
            return input.Skip(rotations % input.Length)
                        .Concat(input.Take(rotations % input.Length))
                        .ToArray();
        }
    }
}
