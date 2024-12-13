#include<iostream>
#include<cmath>

bool isPrime(int num)
{
    if(num <= 1) return false;
    for(int i = 2; i <= sqrt(num); i++)
    {
        if(num % i == 0) return false;
    }
    return true;
}

int main()
{
    int num1 = 37;
    int num2 = 39;
    std::cout << "the number " << num1 << " is prime: " << isPrime(num1) << std::endl;
    std::cout << "the number " << num2 << " is prime: " << isPrime(num2) << std::endl;
    //system("pause");
}