using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Console.WriteLine(p.Fib(50));
            int input = Int32.Parse(Console.ReadLine());
            p.FizzBuzz(input);
            //Thread.Sleep(5000);

            Console.Read();
        }

        public int Fib(int f)
        {
            //Console.WriteLine(f);
            if (f == 1)
            {
                return 1;
            }
            else if (f == 2)
            {

                return 1;
            }
            else
            {
                return Fib(f - 1) + Fib(f - 2);
            }
        }

        public void FizzBuzz(int max)
        {
            for (int i = 0; i < max; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output.Equals(""))
                {
                    output += i;
                }
                Console.WriteLine(output);
            }
        }
    }
}
