#!/bin/python3.8

# Solving greatest common divisor problem using recursive function in Python
# we are entering 2 numbers, than function DEF counts the GCD
num1=int(input("Please enter first number to count GCD: "))
num2=int(input("Please enter second number to count GCD: "))

def GCD (a, b):
    if b == 0:
        return a
    else:
# function calls itself until b==0 >>> than GCD returns value "a"
        return GCD (b, a % b)

print("The greatest common divisor for numbers",num1,"and",num2,"is >>>>",GCD(num1, num2))
