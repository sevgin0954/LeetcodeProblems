using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var strs = new string[] { "rod","dye" };
        var groups = GroupAnagrams(strs);

        Print.PrintLine(groups);
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new List<IList<string>>();

        foreach (var currentStr in strs)
        {
            var groupIndex = FindAnargamGroup(groups, currentStr);
            if (groupIndex >= 0)
            {
                groups[groupIndex].Add(currentStr);
            }
            else
            {
                var newGroup = new List<string>();
                newGroup.Add(currentStr);
                groups.Add(newGroup);
            }
        }

        return groups;
    }

    private static int FindAnargamGroup(List<IList<string>> groups, string anagram)
    {
        var groupIndex = -1;

        for (int i = 0; i < groups.Count; i++)
        {
            var firstAnagram = groups[i][0];
            if (firstAnagram.Length != anagram.Length)
            {
                continue;
            }
            if (AreAnagrams(anagram, firstAnagram) && AreAnagrams(firstAnagram, anagram))
            {
                groupIndex = i;
                break;
            }
        }

        return groupIndex;
    }

    private static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var lettersCount = new int[26];
        for (int i = 0; i < str1.Length; i++)
        {
            var str1LetterIndex = str1[i] - 'a';
            var str2LetterIndex = str2[i] - 'a';
            lettersCount[str1LetterIndex]++;
            lettersCount[str2LetterIndex]--;
        }

        var isLettersCountsZero = true;
        foreach (var letterCount in lettersCount)
        {
            if (letterCount != 0)
            {
                isLettersCountsZero = false;
                break;
            }
        }

        if (isLettersCountsZero)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}