# @param {String} s
# @param {String} t
# @return {Boolean}
def is_anagram(s, t)
    return false if s.length != t.length

  char_count = Hash.new(0)

  # Update character counts for s
  s.each_char do |char|
    char_count[char.ord] += 1
  end

  # Decrement character counts for t
  t.each_char do |char|
    char_count[char.ord] -= 1
  end

  # Check if all character counts are zero
  char_count.values.all? { |count| count.zero? }
end