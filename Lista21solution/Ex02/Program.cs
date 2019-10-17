using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Retangulo x = new Retangulo();
                x.SetBase(double.Parse(Console.ReadLine()));
                x.SetAltura(double.Parse(Console.ReadLine()));
                Console.WriteLine(x.CalcArea());
            }

            catch(ArgumentOutOfRangeException c)
            {
                Console.WriteLine("Erro");
            }
            Console.ReadKey();
        }
    }
}
