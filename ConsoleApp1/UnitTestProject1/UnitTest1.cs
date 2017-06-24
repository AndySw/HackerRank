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
            numbers.RotateLeft(numbers.Length);
            // assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, numbers);
        }

        [TestMethod]
        public void IfRotationsLessThanArrayLengthThenResultIsEqualToArrayRotatedLeftByNumberOfRotations()
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            numbers.RotateLeft(4);
            // assert
            CollectionAssert.AreEqual(new int[] { 5, 1, 2, 3, 4 }, numbers);
        }

        [TestMethod][Ignore]
        public void IfRotationsGreaterThanArrayLengthThenResultIsEqualToArrayRotatedByRemainderOfRotationsDividedByArrayLength()
        {
            // arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            // act
            numbers.RotateLeft(54);
            // assert
            CollectionAssert.AreEqual(new int[] { 5, 1, 2, 3, 4 }, numbers);
        }
    }
}