using LeetCode.Problems;
using System.Runtime.CompilerServices;

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

        [Theory]
        [InlineData(new int[] { 0, 1 }, new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { 0, 1 }, new int[] { 3, 3 }, 6)]
        public void TwoSum_ReturnTwoIndiceValuesThatEqualTarget(int[] expected, int[] nums, int target)
        {
            //arrange

            //act
            int[] actual = _1.TwoSum(nums, target);

            //assert
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> GroupAnagramTestData =>
           new List<object[]>
           {
                new object[] { new List<IList<string>> { 
                    new List<string> {"eat", "tea", "ate"},
                    new List<string> {"tan", "nat"},
                    new List<string> {"bat"}
                } , new string[] { "eat", "tea", "tan", "ate", "nat", "bat" } }
           };

        [Theory]
        [MemberData(nameof(GroupAnagramTestData))]
        public void GroupAnagrams_ShouldReturnListOfAngagramsGroupedTogether(IList<IList<string>> expected, string[] strs)
        {
            //arrange
            List<string> test = new(){ "123", "123" };
            //act
            IList<IList<string>> actual = _49.GroupAnagrams(strs);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
