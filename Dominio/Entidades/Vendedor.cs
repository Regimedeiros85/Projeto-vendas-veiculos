using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeradores.Enumeradores;

namespace Dominio.Entidades
{
    public class Vendedor : Pessoa
    {
        public int Matricula;
        public decimal Comissao;
        public decimal MetaMensal;
        public int NumeroVendas;
        public bool MetaAtingida;
        public Vendedor() { }


    }
}
