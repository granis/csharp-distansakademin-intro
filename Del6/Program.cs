using System;

namespace Del6
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            int roll = RollDice();
            Console.WriteLine("Tärningskast: " + roll);

            for (int i = 0; i < 10; i++)
            {
                int product = Multiply(2, i);
                Console.WriteLine("Produkt: " + product);
            }
        }

        /// <summary>
        /// Prints "Hello" to the console
        /// </summary>
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        /// <summary>
        /// Generate a number between 0 and 7 ;)
        /// </summary>
        /// <returns>Randomly generated value</returns>
        static int RollDice()
        {
            Random rnd = new();
            int roll = rnd.Next(1, 7);
            return roll;
        }

        /// <summary>
        /// Multiplies two numbers
        /// </summary>
        /// <param name="a">First term to multiply</param>
        /// <param name="b">Second term to multiply</param>
        /// <returns>Calculated product of a*b</returns>
        static int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }
    }
}
