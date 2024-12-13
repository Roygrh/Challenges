public class PrimeChecker {
    public static boolean isPrime(int num){
        if (num <= 1) return false;
        for (int i = 2; i <= Math.sqrt(num); i++){
            if (num % i == 0) return false;
        }
        return true;
    }

    public static void main(String[] args) {
        int num1 = 47;
        int num2 = 48;

        System.out.println("the number: " + num1 + " is prime: " + isPrime(num1));
        System.out.println("the number: " + num2 + " is prime: " + isPrime(num2));
    }
}
