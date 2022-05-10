using System;
using System.Linq;

namespace Delegates_and_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // action ->does not return a value


            // func -> returns a value

            //Action<string> printGreeting = (n) => Console.WriteLine("Hi " + n);

            //Func<int, int, string> multiplier = (x, y) => {return "The product is " + (x * y).ToString();};

            //printGreeting("Bob");

            //Console.WriteLine(multiplier(5,7));

           // Action<string> printGreeting = (n) => {Console.WriteLine("Welcome friend " + n + "!");};
            //printGreeting("John");

            //Func<int, int, string> AddTwoNums = (x, y) => {return (x + y).ToString();};

           // Console.WriteLine(AddTwoNums(15,16));

            /* int[] TestData = new int[5];
            TestData[0] = 5;
            TestData[1] = 7;
            TestData[2] = 3;
            TestData[3] = 2;
            TestData[4] = 9;
            Func<int[], string> ArraySum = (int[] elements) => {return (elements.Sum()).ToString();};

            Console.WriteLine(ArraySum(TestData)); */

           /*  Console.WriteLine("Input base number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the exponent");
            int exp1 = Convert.ToInt32(Console.ReadLine());

            Func<int, int, string> Power = (int num, int exp) => {int rvalue = 1; int i; for (i=1;i<=exp;i++) rvalue=rvalue*num; return (rvalue).ToString();};
            Console.WriteLine(Power(n1,exp1)); */

           /*  Console.WriteLine("Please enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            Action<int> Fib = n =>
            {
                int n1 = 0, n2 = 1, Term = 0;
                if (n == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            for (int i = 2; i <= n; i++)
            {
                Term = n1 + n2;
                n1 = n2;
                n2 = Term;
            }
            Console.WriteLine(Term);
            };
            Fib(num); */
        }
    }
}
