using System;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            if(PrimeNumber(7))
            {
                Console.WriteLine("This a prime number");
            }
            else
            {
                Console.WriteLine("This is a not prime number");
            }
        }
        private static bool PrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if(number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
