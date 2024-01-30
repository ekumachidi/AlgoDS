def contains_duplicate(nums)
  # Create a hash set to store unique elements
  unique_set = Set.new

  # Iterate through the array
  nums.each do |num|
    # If the element is already in the set, it's a duplicate, return true
    return true if unique_set.include?(num)

    # Otherwise, add the element to the set
    unique_set.add(num)
  end

  # If the loop completes, no duplicates were found, return false
  false
end
