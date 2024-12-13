function isPrime(num){
    if(num <= 1) return false;
    for(let i = 2; i <= Math.sqrt(num); i++){
        if(num % i == 0) return false;
    }
    return true;
}

let num1 = 47;
let num2 = 49;

console.log("the number: " + num1 + " is prime: " + isPrime(num1));
console.log("the number: " + num2 + " is prime: " + isPrime(num2));