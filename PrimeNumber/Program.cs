using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeNumber {
    class Program {
        static void Main(string[] args) {
            IsPrime(5);
            Console.ReadLine();
            
        }
        Prime prime1 = new Prime();
        public static bool IsPrime(int n) {
            bool prime;
            int root = (int)Math.Sqrt((double)n);
            if (n < 2) {
                prime = false;
                Prime.PrintPrimeOrNot(prime);
            }
            if (n % 2 == 0) return (n == 2);

            for (int i = 3; i <= root; i += 2) {
                if (n % i == 0) {
                    prime = true;
                    Prime.PrintPrimeOrNot(prime);

                }
            }
            return true;
            


        }

        class Prime {
            
            
            // This method checks to see if a number is prime by taking the square root of n and checking it against 3 (continuing up by
            // intervals of 2 until the correct value is reached)
            // 
            
            public static void PrintPrimeOrNot(bool prime) {
                if (prime == true) {
                    Console.WriteLine("The number is prime.");
                }
                else {
                    Console.WriteLine("The number is not prime");
                }
            }

        }

    }
}
