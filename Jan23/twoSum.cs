public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store the indices of elements
        Dictionary<int, int> indexMap = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the complement (target - nums[i])
            int complement = target - nums[i];

            // Check if the complement is in the dictionary
            if (indexMap.ContainsKey(complement))
            {
                // Return the indices of the two numbers
                return new int[] { indexMap[complement], i };
            }

            // Store the current number and its index in the dictionary
            indexMap[nums[i]] = i;
        }

        // If no solution is found, return an empty array or handle appropriately
        return new int[] { };
    }
}
