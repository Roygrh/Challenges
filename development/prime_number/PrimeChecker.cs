using System;

/*class Program
{

    static bool IsPrime(int num)
    {
        if(num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        int num1 = 29;
        int num2 = 30;
        Console.WriteLine("The number: " + num1 + " is prime: " + IsPrime(num1));
        Console.WriteLine("The number: " + num2 + " is prime: " + IsPrime(num2));
    }
}*/


bool IsPrime(int num)
{
    if(num <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if(num % i == 0) return false;
    }
    return true;
}

int num1 = 29;
int num2 = 30;
Console.WriteLine("The number: " + num1 + " is prime: " + IsPrime(num1));
Console.WriteLine("The number: " + num2 + " is prime: " + IsPrime(num2));