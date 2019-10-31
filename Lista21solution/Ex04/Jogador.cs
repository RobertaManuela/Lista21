using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogador : IComparable
    {
        private string nome, email;
        private int PontuacaoMax;
        private DateTime data;

        public Jogador(string n, string e)
        {
            n = nome;
            e = email;
        }

        //método compareto

        public void SetPontos(int p, DateTime d)
        {
            if (PontuacaoMax > 0) p = PontuacaoMax;
            else throw new ArgumentOutOfRangeException("Pontuacao Inválida");

            if (data < DateTime.Now) d = data;
            else throw new ArgumentOutOfRangeException("Data Inválida");
        }

        public override string ToString()
        {
            return $"{nome} - {email} - {PontuacaoMax} - {data}";
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
