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
            //this function does not support negative rotations
            if (rotations < 0) { throw new ArgumentOutOfRangeException(); }

            //figure out if you are going to be looping beyond the length of the array.
            rotations = rotations % input.Length;
            //if after all those loops you would end up producing the same value of the input, just return that
            //and be done with it.
            if (rotations == 0) { return input; }

            //to perform the left rotation, you will need to take the number of items from the left-hand side
            //of the array, as you will be adding them to the end of a new array in original order
            int[] temp = new int[input.Length];
            for (int i = 0; i < rotations; i++)
            {
                temp[i] = input[i];
            }

            //you will also need to know how much of the original array you need to preserve.
            //get the number of elements that need to be shifted to the left-hand side of the array.
            int remainder = input.Length - rotations;

            //add the rotated elements to the right-hand side of the array
            int[] result = new int[input.Length];
            int j = 0;
            for (int i = 0; i < rotations; i++)
            {
                result[i + remainder] = temp[j++];
            }

            //add the unrotated array elements to the left-hand side of the array
            j = input.Length - 1;
            for (int i = remainder - 1; i >= 0; i--)
            {
                result[i] = input[j--];
            }

            return result;
        }
    }
}
