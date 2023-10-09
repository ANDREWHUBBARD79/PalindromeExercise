using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false) ]
        [InlineData("RaceCar", false)]


        public void MyTest(string word, bool expected)
        {
            //arange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPaindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
