using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class ArrayLeftRotationTest
    {
        [TestMethod]
        public void IfRotationsEqualsArrayLengthThenResultIsEqualToArray()
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            var actual = numbers.RotateLeft(numbers.Length);
            // assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IfRotationsIsLessThanZeroThenThrowArgumentOutOfRangeException()
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            var actual = numbers.RotateLeft(-6);
            // assert 
            // ArgumentOutOfRangeException is thrown
        }

        [DataTestMethod]
        [DataRow(0, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(1, new int[] { 2, 3, 4, 5, 1 })]
        [DataRow(2, new int[] { 3, 4, 5, 1, 2 })]
        [DataRow(3, new int[] { 4, 5, 1, 2, 3 })]
        [DataRow(4, new int[] { 5, 1, 2, 3, 4 })]
        [DataRow(5, new int[] { 1, 2, 3, 4, 5 })]
        public void IfRotationsLessThanArrayLengthThenResultIsEqualToArrayRotatedLeftByNumberOfRotations(int rotations, int[] expected)
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            var actual = numbers.RotateLeft(rotations);
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(10, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(21, new int[] { 2, 3, 4, 5, 1 })]
        [DataRow(32, new int[] { 3, 4, 5, 1, 2 })]
        [DataRow(43, new int[] { 4, 5, 1, 2, 3 })]
        [DataRow(54, new int[] { 5, 1, 2, 3, 4 })]
        [DataRow(65, new int[] { 1, 2, 3, 4, 5 })]
        public void IfRotationsGreaterThanArrayLengthThenResultIsEqualToArrayRotatedByRemainderOfRotationsDividedByArrayLength(int rotations, int[] expected)
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            var actual = numbers.RotateLeft(rotations);
            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}