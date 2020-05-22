using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        { 
            int milhas;
            double km;
            Console.WriteLine("Entre com a medida em milhas:");
            milhas = Convert.ToInt16(Console.ReadLine());
            
            km = (milhas / 0.62137);
            Console.WriteLine("a medida em km é:" + km);

        }
    }
}
