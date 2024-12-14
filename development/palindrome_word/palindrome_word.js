function isPalindrome(word)
{
    let left = 0;
    let right = word.length - 1;

    while (left < right) {
        if (word[left] != word[right]) return false;

        left++;
        right--;
    }

    return true;
}

let word1 = "rotator"
let word2 =  "data"
console.log(`the word: ${word1} is palindrome: ${isPalindrome(word1)}`);
console.log(`the word: ${word2} is palindrome: ${isPalindrome(word2)}`);