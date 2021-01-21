using System;

namespace Oef1_Slide
{
    public delegate int MijnDelegate(int g1, int g2);
    class Program
    {
        static int Max(int getal1, int getal2)
        {
            //Math.Max bestaat ook
            return getal1 > getal2 ? getal1 : getal2; //conditional operator
        }
        static int Min(int getal1, int getal2)
        {
            //Math.Min
            return getal1 < getal2 ? getal1 : getal2; 
        }
        static void Main(string[] args)
        {
            //variabele aanmaken van MijnDegate:
            MijnDelegate del_Max = new MijnDelegate(Max);
            int maxWaarde = del_Max(5, 6);
            Console.WriteLine($"Mijn Delegate gebruikt voor Max(5,6) resultaat = {maxWaarde}");
            MijnDelegate del_Min = new MijnDelegate(Min);
            int minWaarde = del_Min(5, 6);
            Console.WriteLine($"Mijn Delegate gebruikt voor Min(5,6) resultaat = {minWaarde}");
            Console.ReadKey();

        }
    }
}
