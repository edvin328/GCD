using System;
using System.Diagnostics;

// in this programm we are solving the greatest common divisor problem using recursive function in C#

namespace GCD_in_Csharp
{
    class Program
    {
        public static void Main()
        {
            long num1, num2;
            Console.WriteLine("\n Find the GCD of two numbers using recursive function in C# ->>>>");   

        // we are entering num1 and num2      
            Console.Write("\n Please enter the first number : "); 
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write(" Please enter the second number : "); 
            num2 = Convert.ToInt64(Console.ReadLine());

        // the programm counts GCD using recursive function gcd below, and we could print using (console.writeline) the result
            Console.WriteLine("\n The GCD of {0} and {1} is ->>> {2} \n", num1, num2, gcd(num1, num2));
        }
 
       static long gcd(long a, long b)
       {
           if (b == 0)
           {
               return a;
           }
           else
           {
               // function calls itself until b==0 >>> than GCD returns value "a"
               return gcd(b, a % b);
        
           }   
       }
    }
}    
