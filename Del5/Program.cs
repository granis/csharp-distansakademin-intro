using System;

namespace Del5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create random generator
            Random rnd = new Random();

            //iterate 20 times
            for (int i = 0; i < 20; i++)
            {
                //get and print a random number
                int myRandomNumber = rnd.Next(1, 10+1); //add 1 so max-value is included
                Console.WriteLine(myRandomNumber);
            }
        }
    }
}
