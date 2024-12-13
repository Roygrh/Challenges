object Main extends App {
    def isPrime(num: Int): Boolean = {
        if (num <= 1) false
        !(2 to math.sqrt(num).toInt).exists( i => num % i == 0)
    }

    val num1 = 29
    val num2 = 30
    println("the number: " + num1 + " is prime: " + isPrime(num1))
    println("the number: " + num2 + " is prime: " + isPrime(num2))
}