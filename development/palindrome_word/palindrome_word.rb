def is_palindrome(word)
    left = 0
    right = word.length - 1

    while left < right
        return false if word[left] != word[right]

        left += 1
        right -= 1
    end

    true
end

word1 = "deified"
word2 = "neural"
puts "the word: #{word1} is a palindrome: #{is_palindrome(word1)}"
puts "the word: #{word2} is a palindrome: #{is_palindrome(word2)}"