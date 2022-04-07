
using System;

namespace Methoden_HoteCheckIn
{
    class Program
    {
        static void Main()
        {

            bool wiederholen = false;
            do
            {

                short[] zimmernummer = { 45, 23, 3, 32 };
                string[] vorname = { "John", "Paul", "George", "Ringo" };
                string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
                short[] übernachtung = { 1, 4, 12, 3 };
                double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

                Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);

                if (flag == false)
                {
                    var data = GetData(eingabe_str, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);

                    if (data.Item1 == true)
                    {
                        Console.WriteLine($"{data.Item2},{data.Item3},{data.Item4},{data.Item5},{data.Item6}");
                    }
                    else
                    {
                        Console.WriteLine("Ihre Nachname wurde nicht gewunden");
                    }
                }
                else
                {
                    var data = GetData(eingabe_short, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);

                    if (data.Item1 == true)
                    {
                        Console.WriteLine($"{data.Item1},{data.Item2},{data.Item3},{data.Item4},{data.Item5},{data.Item6}");
                    }
                    else
                    {
                        Console.WriteLine("Ihre Zimmernummer wurde nicht gewunden");
                    }

                }

                Console.WriteLine("Möchten Sie wierderholen");

                wiederholen = Convert.ToBoolean(Console.ReadLine());

            } while (wiederholen);


        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool EI = false;
            int index = 0;

            for (int i = 0; i < zn.Length; i++)

                if (diff == zn[i])
                {
                    EI = true;
                    index = i;
                }


            return (EI, zn[index], vn[index], nn[index], ue[index], rb[index]);
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool EI = false;
            int index = 0;

            for (int i = 0; i < nn.Length; i++)

                if (diff == nn[i])
                {
                    EI = true;
                    index = i;
                }

            return (EI, zn[index], vn[index], nn[index], ue[index], rb[index]);

        }
    }

}