package main

import "math"

func isPrime(num int) bool {
	if num <= 1 {
		return false
	}
	for i := 2; i <= int(math.Sqrt(float64(num))); i++ {
		if num%i == 0 {
			return false
		}
	}

	return true
}

func main() {
	num1 := 41
	num2 := 44
	println("the number: ", num1, " is prime: ", isPrime(num1))
	println("the number: ", num2, " is prime: ", isPrime(num2))
}
