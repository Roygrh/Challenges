#include<iostream>
#include<string>

bool isPalindrome(std::string word)
{
    int left = 0;
    int right = word.length() - 1;

    while(left < right)
    {
        if(word[left] != word[right]) return false;

        left++;
        right--;
    }

    return true;
}

int main()
{
    std::string word1 = "11011";
    std::string word2 = "code";
    std::cout << "the word: " << word1 << " is palindrome: " << isPalindrome(word1) << std::endl;
    std::cout << "the word: " << word2 << " is palindrome: " << isPalindrome(word2) << std::endl;
    return 0;
}