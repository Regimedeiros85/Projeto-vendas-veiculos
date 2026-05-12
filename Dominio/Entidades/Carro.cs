using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Carro : Veiculo
    {
        public int NumeroPortas;
        public bool ArCondicionado;
        public bool DirecaoHidraulica;
        public bool VidrosEletricos;
        public bool TravasEletricas;
        public bool Alarme;
        public bool Airbag;
        public bool Abs;
        public bool SensorEstacionamento;
        public bool CameraRe;
        public bool TetoSolar;
        public bool BancosCouro;
        public bool Multimidia;
        public bool Bluetooth;
        public double Kilometragem;
        public bool MotorFlex;
        public bool CambioAutomatico;
        public bool RodasLigaLeve;
        public bool FarolDeNeblina;
        public bool RetrovisoresEletricos;
        public bool VolanteMultifuncional;
        public bool BancosRegulaveis;

        public Carro(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {
        }
    } 

}
