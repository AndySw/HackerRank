using System;

namespace ClassLibrary1
{
    public static class ArrayExtensions
    {
        public static int[] RotateLeft(this int[] array, int rotations)
        {
            if(rotations < 0) { throw new ArgumentOutOfRangeException(); }

            int[] result = new int[array.Length];
            int[] temp = new int[array.Length];

            //figure out if you are going to be looping around the length of the array.
            rotations = rotations % array.Length;
            //if after all those loops you would end up producing the same value of the input, just return that
            //and be done with it.
            if(rotations == 0) { return array; }

            //to perform the left rotation, you will need to take the number of items from the left-hand side
            //of the array, as you will be adding them to the end of a new array in reverse order
            for(int i = 0; i < rotations; i++)
            {
                temp[i] = array[i];
            }

            //you will also need to know how much of the original array you need to preserve.
            //get the number of elements that need to be shifted to the left-hand side of the array.
            int remainder = array.Length - rotations;

            //reverse the order of the temp array
            int j = 0;
            for(int i = 0; i < result.Length - 1; i++)
            {
                result[i + remainder] = temp[j++];
            }

            //add the unrotated array elements to the left-hand side of the array
            j = (array.Length - 1) - (remainder - 1);
            for (int i = 0; i < remainder; i++)
            {
                result[i] = array[j--];
            }

            return result;
        }
    }
}
