using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("wow",true)]
        [InlineData("mom",true)]
        [InlineData("radar",true)]
        [InlineData("dad",true)]
        [InlineData("gary",false)]
        [InlineData("yellow",false)]
        [InlineData("",false)]
        [InlineData("Racecar",true)]// ← you will need to put some test data and expected result here.  
        // For example [InlineData(“racecar”, true)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
             
            // Arrange
            var ws = new WordSmith();
            // Act
            var actual = ws.IsAPalindrome(word);
            // Assert 
            Assert.Equal(expected, actual);
        }

    }
}
