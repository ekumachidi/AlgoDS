## Problem: Contains Duplicate

Source: [#217](https://leetcode.com/problems/contains-duplicate/description/)

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109

## Solution:

1. We use a hash set `unique_set` to store unique elements encountered while iterating through the array.
2. For each element num in the array, we check if it already exists in the `unique_set`. If it does, it means we have found a duplicate, and we return true.
3. If the element is not in the set, we add it to the set.
4. If the loop completes without finding any duplicates, we return false.
