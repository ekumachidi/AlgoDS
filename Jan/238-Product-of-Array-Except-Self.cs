using System;
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // Initialize the answer array
        int[] answer = new int[nums.Length];

        // Calculate the products on the left of each element and store in answer array
        int leftProduct = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = leftProduct;
            leftProduct *= nums[i];
        }

        // Calculate the products on the right of each element and update answer array
        int rightProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        // Return the final answer
        return answer;

    }
    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };
        PrintResult(nums1);

        int[] nums2 = { -1, 1, 0, -3, 3 };
        PrintResult(nums1);
    }

    static void PrintResult(int[] nums)
    {
        int[] result = ProductExceptSelf(nums);

        Console.Write("Result: [");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
            if (i < result.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}