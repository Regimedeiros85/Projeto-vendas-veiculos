using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Moto : Veiculo
    {
        public int Cilindradas;
        public double Kilometragem;
        public bool PartidaEletrica;
        public bool FreioABS;
        public bool InjeçaoEletronica;
        public bool Alarme;
        public bool TravaGuidao;
        public bool ProtetorDeMao;
        public bool ProtetorDePernas;
        public bool PainelDigital;
        public bool FarolDeLED;
        public bool RodaLigaLeve;
        public bool MotorFlex;
        public bool SensorDeDescanso;

        public Moto(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {
        }
    }
}
