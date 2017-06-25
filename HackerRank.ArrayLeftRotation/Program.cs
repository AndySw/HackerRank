﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ArrayLeftRotation
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int[] RotateLeft(int[] array, int rotations)
        {
            //this function does not support negative rotations
            if (rotations < 0) { throw new ArgumentOutOfRangeException(); }

            //figure out if you are going to be looping beyond the length of the array.
            rotations = rotations % array.Length;
            //if after all those loops you would end up producing the same value of the input, just return that
            //and be done with it.
            if (rotations == 0) { return array; }

            //to perform the left rotation, you will need to take the number of items from the left-hand side
            //of the array, as you will be adding them to the end of a new array in original order
            int[] temp = new int[array.Length];
            for (int i = 0; i < rotations; i++)
            {
                temp[i] = array[i];
            }

            //you will also need to know how much of the original array you need to preserve.
            //get the number of elements that need to be shifted to the left-hand side of the array.
            int remainder = array.Length - rotations;

            //add the rotated elements to the right-hand side of the array
            int[] result = new int[array.Length];
            int j = 0;
            for (int i = 0; i < rotations; i++)
            {
                result[i + remainder] = temp[j++];
            }

            //add the unrotated array elements to the left-hand side of the array
            j = array.Length - 1;
            for (int i = remainder - 1; i >= 0; i--)
            {
                result[i] = array[j--];
            }

            return result;
        }
    }
}