using LeetCode.Problems;

namespace LeetCode.Tests.ProblemsTests
{
    public class Tests
    {
        [Theory]
        [InlineData(false, new int[] { 1, 2, 3, 4 })]
        public void ContainsDuplicate_ShouldReturnTrueIfDupeOtherwiseFalse(bool expected, int[] nums)
        {
            //arrange

            //act
            bool actual = _217.ContainsDuplicate(nums);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, "anagram", "nagaram")]
        [InlineData(false, "rat", "car")]
        public void IsAnagram_ShouldReturnTrueIfAnagram(bool expected, string orginalString, string anagram)
        {
            //arrange

            //act
            bool actual = _242.IsAnagram(orginalString, anagram);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
