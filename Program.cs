using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlanoSaude> planos = new List<PlanoSaude>();
            List<Pessoa> pessoas = new List<Pessoa>();
            Menu.Carregar(pessoas, planos);
        }
    }
}
