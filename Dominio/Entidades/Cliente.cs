using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeradores.Enumeradores;

namespace Dominio.Entidades
{
    public class Cliente : Pessoa
    {
        public decimal LimiteCredito;
        public int pontosFidelidade;
        public int NumeroCompras;
        public DateTime DataCadastro;
        public string Codigo;
        public string FormadePagamentoPreferida;
        public bool PossuiDescontoEspecial;
        public DateTime UltimaCompra;
        public Cliente() { }
    }
}
