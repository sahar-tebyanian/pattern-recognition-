using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }

    static bool IsPrime(int num)  // method  definition  a static method returns a booliean value and takes an integer parametre
    {
        if (num <= 1)   // conditional nstatemnet  , chekc if the number is les than or equal 
            return false;   // return is condition i s true 

        for (int i = 2; i <= Math.Sqrt(num); i++)    // for loop interates to the square root of the number 
        {
            if (num % i == 0)   // conditional statemnt , check if the number 
                return false;   // return statemnt if the nuber divisible by i 
        }
        return true;
    }
}
