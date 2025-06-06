namespace WorkExperienceProjectOne.UnitTests
{
    public class QuestionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { -4, 0, -10 }, new int[] { -10, -4, 0 })]
        [InlineData(new int[] { 1, 1, 0, 1, 0 }, new int[] { 0, 0, 1, 1, 1})]
        public void OrderNumbers_OrdersNumbers_FromSmallestToBiggest(int[] input, int[] expected)
        {
            // Act
            var actual = Questions.OrderNumbers(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { -4, 0, -10 }, new int[] { -10, -4, 0 })]
        [InlineData(new int[] { 1, 1, 0, 1, 0 }, new int[] { 0, 1 })]
        public void OrderNumbersAndRemoveDuplicates(int[] input, int[] expected)
        {
            // Act
            var actual = Questions.OrderNumbersAndRemoveDuplicates(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", 2)]
        [InlineData("sky", 0)]
        [InlineData("AEIOU", 5)]
        public void CountVowels_ReturnsNumberOfVowels(string input, int expected)
        {
            var actual = Questions.CountVowels(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("madam", true)]
        public void IsPalindrome_ReturnsTrueIfPalindrome(string input, bool expected)
        {
            var actual = Questions.IsPalindrome(input);
            Assert.Equal(expected, actual);
        }

        // warning: hard!
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, true)]      // 2 + 7 = 9
        [InlineData(new int[] { 1, 2, 3, 4 }, 8, false)]       // No two numbers sum to 8
        [InlineData(new int[] { -1, 0, 1 }, 0, true)]          // -1 + 1 = 0
        [InlineData(new int[] { 3, 3 }, 6, true)]              // 3 + 3 = 6 (duplicates allowed)
        [InlineData(new int[] { 5 }, 10, false)]               // Only one element, can't sum
        [InlineData(new int[] { }, 0, false)]                  // Empty array
        [InlineData(new int[] { 1, 2, 3, 4, 4 }, 7, true)]     // 3 + 4 = 7
        public void HasTwoSum_ReturnsExpectedResult(int[] input, int target, bool expected)
        {
            var actual = Questions.HasTwoSum(input, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("bbbbb", 1)]
        [InlineData("abcabcbb", 3)]
        [InlineData("pwwkew", 3)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", 26)]
        public void LengthOfLongestSubstringWithoutRepeatingCharacters(string s, int expected)
        {
            // Act
            var actual = Questions.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}