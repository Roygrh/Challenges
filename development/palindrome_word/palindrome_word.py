def is_palindrome(word):
    left = 0
    right = len(word) -1

    while left < right:
        if word[left] != word[right]:
            return False
        
        left += 1
        right -= 1

    return True

word1 = "9875789"
word2 = "deep learning"
print("the word: %s is palindrome %t", word1, is_palindrome(word1))
print("the word: %s is palindrome %t", word2, is_palindrome(word2))