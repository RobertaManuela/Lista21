using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogo
    {
        private string nome;
        List<Jogador> jogs = new List<Jogador>();

        public Jogo(string n)
        {
            n = nome;
        }

        public void Inserir(Jogador j)
        {

            foreach (Jogador m in jogs)
            {
                if (m.GetEmail == j.GetEmail) throw new EmailExistenteException("Email já existente");
            }

            jogs.Add(j);
        }

        public List<Jogador> Listar()
        {
            return jogs;
        }
    }

    class EmailExistenteException : Exception
    {
        //a fazer
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
