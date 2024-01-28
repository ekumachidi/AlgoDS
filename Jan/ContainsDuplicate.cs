using System;
using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Create a hash set to store unique elements
        HashSet<int> uniqueSet = new HashSet<int>();

        // Iterate through the array
        foreach (int num in nums)
        {
            // If the element is already in the set, it's a duplicate, return true
            if (uniqueSet.Contains(num))
            {
                return true;
            }

            // Otherwise, add the element to the set
            uniqueSet.Add(num);
        }

        // If the loop completes, no duplicates were found, return false
        return false;
    }

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        bool hasDuplicate = ContainsDuplicate(nums);

        if (hasDuplicate)
            Console.WriteLine("The array contains duplicates.");
        else
            Console.WriteLine("No duplicates found in the array.");
    }
}