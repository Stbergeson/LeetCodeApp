namespace LeetCode.Problems;

internal static class _1
{
    /*
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

     * You may assume that each input would have exactly one solution, and you may not use the same element twice.

     * You can return the answer in any order.
     */
    internal static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { -1, -1 };
    }
}

internal static class _49
{
    /*
     * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
     * typically using all the original letters exactly once.
     */
    internal static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        List <string> stringsArray = new List<string>(strs);
        List<string> tempArray;
        List<string> list;
        while (stringsArray.Count > 0)
        {
            tempArray = new();
            list = new()
            {
                stringsArray[0]
            };
            for (int i = 1; i < stringsArray.Count; i++)
            {
                if (IsAnagram(stringsArray[0], stringsArray[i]))
                {
                    list.Add(stringsArray[i]);
                }
                else
                {
                    tempArray.Add(stringsArray[i]);
                }
            }
            result.Add(list);
            stringsArray = tempArray;
        }

        return result;

    }

    internal static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet.Add(c, 0);
        }

        for (int i = 0; i < s.Length; i++)
        {
            alphabet[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            alphabet[t[i]]--;
        }

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (alphabet[c] != 0)
                return false;
        }

        return true;
    }
}

internal static class _217
{
    internal static bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    return true;
            }
        }

        return false;
    }
}

internal static class _242
{
    internal static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();

        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet.Add(c, 0);
        }

        for (int i = 0; i < s.Length; i++)
        {
            alphabet[s[i]]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            alphabet[t[i]]--;
        }

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (alphabet[c] != 0)
                return false;
        }

        return true;
    }
}