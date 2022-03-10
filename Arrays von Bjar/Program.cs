using System;

namespace Arrays_von_Bjar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo ihr Geringverdiener");

            int n = 20;

            int[] noten = new int[n];
            int summe = 0;
            for (int index = 0; index < n; index++)

            {

                Console.WriteLine($"Geben Sie bitte die {index+1} Note ein ");
                noten[index] = Convert.ToInt32(Console.ReadLine());
                summe = summe + noten[index];

            }

            Console.WriteLine("Ihr duchschnitt ist");
            Console.WriteLine(summe / n);



            
        }
    }
}
