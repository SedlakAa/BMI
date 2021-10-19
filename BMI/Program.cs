using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet BMI!");

            Console.ReadLine();

            double hmotnost;
            double výška;
            double count;
            Console.Clear();
            Console.WriteLine("Výpočet BMI");
            Console.ReadLine();

            Console.Write("zadej váhu");
            double.TryParse(Console.ReadLine(), out hmotnost);
            Console.ReadLine();

            Console.Write("zadej svou výšku");
            double.TryParse(Console.ReadLine(), out výška);
            Console.ReadLine();

            count = (hmotnost) / (výška/100*výška/100);
            Console.WriteLine();
            Console.WriteLine($"Tvoje BMI je {count} ");
            Console.ReadLine();
        }   
    }
}
