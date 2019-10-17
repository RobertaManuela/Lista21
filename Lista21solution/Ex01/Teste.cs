using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Teste : ITeste
    {
        private int x;

        public void SetTeste(int valor)
        {
            if (valor < 0) throw new Erro();
            else x = valor;
        }

        public int GetTeste()
        {
            return x;
        }
    }
}
