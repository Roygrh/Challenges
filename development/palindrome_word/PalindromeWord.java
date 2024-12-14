public class PalindromeWord {
    public static boolean IsPalindrome(String word) {
        int left = 0;
        int right = word.length() - 1;

        while (left < right) {
            if(word.charAt(left) != word.charAt(right)) return false;

            left++;
            right--;
        }

        return true;
    }

    public static void main(String[] args) {
        String word1 = "repaper";
        String word2 = "intelligence";

        System.out.printf("the word: %s is a palindrome: %b%n", word1, IsPalindrome(word1));
        System.out.printf("the word: %s is a palindrome: %b%n", word2, IsPalindrome(word2));
    }
}