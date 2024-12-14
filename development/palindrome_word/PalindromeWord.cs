using System;

bool IsPalindrome(string word)
{
    int left = 0;
    int right = word.Length - 1;

    while(left < right)
    {
        if(word[left] != word[right]) return false;

        left++;
        right--;
    }

    return true;
}

string word1 = "madam";
string word2 = "palindrome";
Console.WriteLine("the word: " + word1 + " is a palindrome: " + IsPalindrome(word1));
Console.WriteLine("the word: " + word2 + " is a palindrome: " + IsPalindrome(word2));