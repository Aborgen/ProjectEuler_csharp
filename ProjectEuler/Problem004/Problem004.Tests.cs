
using System;
using Xunit;

namespace ProjectEuler.Tests
{
    public class Problem004Tests
    {
        private Problem004 CreateProblem004()
        {
            return new Problem004();
        }

        [Fact]
        public void Given()
        {
            var unitUnderTest = CreateProblem004();
            int largestPalindrome = unitUnderTest.FindLargestPalindrome(digitLength:2);

            Assert.Equal(9009, largestPalindrome);
        }

        [Theory]
        [InlineData(9009, true)]
        [InlineData(101, true)]
        [InlineData(12, false)]
        [InlineData(944439, false)]
        [InlineData(549945, true)]
        public void Can_Tell_If_Number_Is_Palindrome(int value, bool correctResult)
        {
            var unitUnderTest = CreateProblem004();
            bool possiblePalindrome = unitUnderTest.IsPalindrome(value);
            Assert.Equal(correctResult, possiblePalindrome);
        }

        [Theory]
        [InlineData(3, 906609)]
        [InlineData(4, 99000099)]
        public void Solved(int digitLength, int correctAnswer)
        {
            var unitUnderTest = CreateProblem004();
            int palindrome = unitUnderTest.FindLargestPalindrome(digitLength);
            Assert.Equal(correctAnswer, palindrome);
        }
    }
}
