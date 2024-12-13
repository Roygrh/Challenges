import math

def is_prime(num):
    if num <= 1:
        return False
    for i in range(2, int(math.sqrt(num)) + 1):
        if num % i == 0:
            return False
    return True

num1 = 43
num2 = 45

print("the number" + num1 + " is prime: " + is_prime(num1))
print("the number" + num2 + " is prime: " + is_prime(num2))