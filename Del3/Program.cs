using System;

namespace Del3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din ålder");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine("Din ålder är " + input);

            if (age >= 18)
            {
                Console.WriteLine("Du får ta körkort");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Du får övningsköra bil");
            }
            else
            {
                Console.WriteLine("Du får köra sparkcykel");
            }
        }
    }
}
