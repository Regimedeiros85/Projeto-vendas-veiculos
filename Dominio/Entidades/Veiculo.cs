using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Veiculo
    {
        private int Id { get; set; }
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private int AnoFabricacao { get; set; }
        private string Placa { get; set; }
        private bool Disponivel { get; set; } = true;
        private double Kilometragem { get; set; }
        private bool FreioABS { get; set; }
        private bool InjeçaoEletronica { get; set; }
        private bool Alarme { get; set; }
        private bool PainelDigital { get; set; }
        private bool FarolDeLED { get; set; }
        private bool RodaLigaLeve { get; set; }
        private bool MotorFlex { get; set; }
        private bool CambioAutomatico { get; set; }

        public Veiculo(int id, string modelo, string marca, int anoFabricacao, string placa)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            Placa = placa;
        }

        protected abstract void Adicionar();
        protected abstract void Editar();
        protected abstract void Delete();
    }
}
