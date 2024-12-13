def is_prime(num)
    return false if num <= 1
    (2..Math.sqrt(num).to_i).each do |i|
        return false if num % i ==0
    end
    true
end

num1 = 47
num2 = 51
puts "the number: #{num1} +  is prime:  + #{is_prime(num1)}"
puts "the number: #{num2} +  is prime:  + #{is_prime(num2)}"