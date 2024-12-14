package main

import "fmt"

func isPalindrome(word string) bool {
	left := 0
	right := len(word) - 1

	for left < right {
		if word[left] != word[right] {
			return false
		}

		left++
		right--
	}

	return true
}

func main() {
	word1 := "123404321"
	word2 := "machine learning"
	fmt.Println("the word: %s is a palindrome: %t", word1, isPalindrome(word1))
	fmt.Println("the word: %s is a palindrome: %t", word2, isPalindrome(word2))
}
