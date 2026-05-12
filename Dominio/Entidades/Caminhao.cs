using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Caminhao : Veiculo
    {
        public string TipoCarga;
        public int QuantidadeEixos;
        public double CapacidadeCarga;
        public bool Tacografo;
        public double PesoBrutoTotal;
        public string TipoCarroceria;
        public double Dimensoes;
        public string CategoriaHabilitacao;
        public double Kilometragem;
        public bool CambioAutomatico;
        public bool ArCondicionado;
        public bool CambioManual;
        public string TipoCombustivel;
        public string TipoFreio;
        public bool PossuiReboque;
        public bool PossuiCama;
        public double Altura;
        

        public Caminhao(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {










        }

       
    }
}
