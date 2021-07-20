using System;

namespace Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din ålder");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine("Din ålder är " + age);

            int birthYear = 2021 - age;
            Console.WriteLine("Du föddes år " + birthYear);
        }
    }
}
