object Main extends App {
    def isPalindrome(word: String): Boolean = {
        var left = 0
        var right = word.length - 1

        while (left < right) {
            if(word(left) != word(right)) {
                return false
            }

            left += 1
            right -= 1
        }

        true
    }

    var word1 = "noon"
    var word2 = "artificial"
    println("the word: " + word1 + " is palindrome: " + isPalindrome(word1))
    println("the word: " + word2 + " is palindrome: " + isPalindrome(word2))
}