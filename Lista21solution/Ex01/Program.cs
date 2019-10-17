using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Teste x = new Teste();
                x.SetTeste(int.Parse(Console.ReadLine()));
                Console.WriteLine(x.GetTeste());

            }
            catch (Erro)
            {
                Console.WriteLine("Erro");

            }
            Console.ReadKey();
        }
    }
}
