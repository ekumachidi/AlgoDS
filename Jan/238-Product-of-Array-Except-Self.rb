def product_except_self(nums)
  # Initialize the answer array
  answer = []

  # Calculate the products on the left of each element and store in answer array
  left_product = 1
  (0...nums.length).each do |i|
    answer[i] = left_product
    left_product *= nums[i]
  end

  # Calculate the products on the right of each element and update answer array
  right_product = 1
  (nums.length - 1).downto(0).each do |i|
    answer[i] *= right_product
    right_product *= nums[i]
  end

  # Return the final answer
  answer
end

# Test
nums = [1, 2, 3, 4]
result = product_except_self(nums)
puts "Result: #{result.inspect}"

nums = [-1,1,0,-3,3]
result = product_except_self(nums)
puts "Result: #{result.inspect}"