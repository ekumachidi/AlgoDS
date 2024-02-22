## Problem: Product of Array Except Self

### Complexity: Medium

Source: [#238](https://leetcode.com/problems/product-of-array-except-self/description/)

##### Tags: [LeetCode, Array, Product, Prefix Sum, Suffix Sum, Two Pointers, Time Complexity]

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

## Solution:

1. We initialize the `answer` array to store the final result.
2. We iterate through the array from left to right, calculating the products on the left of each element and storing them in the `answer` array.
3. We then iterate through the array from right to left, calculating the products on the right of each element and updating the corresponding element in the `answer` array.
4. The final `answer` array contains the product of all elements except the current element.

### Pseudo code

```
function productExceptSelf(nums):
// Initialize the answer array
answer = array of size length(nums)

    // Calculate the products on the left of each element and store in answer array
    left_product = 1
    for i from 0 to length(nums) - 1:
        answer[i] = left_product
        left_product *= nums[i]

    // Calculate the products on the right of each element and update answer array
    right_product = 1
    for i from length(nums) - 1 to 0:
        answer[i] *= right_product
        right_product *= nums[i]

    // Return the final answer
    return answer
```
