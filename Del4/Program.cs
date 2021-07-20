using System;

namespace Del4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
            {
                Console.WriteLine("Skriv in ditt namn eller exit för att avsluta");
                string name = Console.ReadLine();

                if(name.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("Längden på ditt namn är " + name.Length);
            }*/

            for (int counter=0; counter < 10; counter++)
            {
                Console.WriteLine(counter+1);
            }
        }
    }
}
