def two_sum(nums, target)
  # Create a hash to store the indices of elements
  index_map = {}

  # Iterate through the array
  (0...nums.length).each do |i|
    # Calculate the complement (target - nums[i])
    complement = target - nums[i]

    # Check if the complement is in the hash table
    if index_map.key?(complement)
      # Return the indices of the two numbers
      return [index_map[complement], i]
    end

    # Store the current number and its index in the hash table
    index_map[nums[i]] = i
  end

  # If no solution is found, return an empty array or handle appropriately
  return []
end
