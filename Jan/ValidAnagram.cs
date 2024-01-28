using System;
using System.Collections.Generic;

class Solution
{
    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<int, int> charCount = new Dictionary<int, int>();

        // Update character counts for s
        foreach (char c in s)
        {
            int charCode = (int)c;
            if (charCount.ContainsKey(charCode))
                charCount[charCode]++;
            else
                charCount[charCode] = 1;
        }

        // Decrement character counts for t
        foreach (char c in t)
        {
            int charCode = (int)c;
            if (charCount.ContainsKey(charCode))
                charCount[charCode]--;
            else
                return false; // Character not present in s
        }

        // Check if all character counts are zero
        foreach (int count in charCount.Values)
        {
            if (count != 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        string s = "listen";
        string t = "silent";

        if (AreAnagrams(s, t))
            Console.WriteLine($"{s} and {t} are anagrams.");
        else
            Console.WriteLine($"{s} and {t} are not anagrams.");
    }
}
