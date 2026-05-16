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
        public bool DirecaoHidraulica;// TODO: CRIAR ENUMERADOR PARA TIPOS DE DIREÇÃO
        public bool VidrosEletricos;
        public bool TravasEletricas;
        public bool Airbag;
        public bool SensorEstacionamento;
        public bool CameraRe;
        public bool TetoSolar;
        public bool BancosCouro;
        public bool Multimidia;
        public bool FarolDeNeblina;
        public bool RetrovisoresEletricos;
        public bool VolanteMultifuncional;
        public bool BancosRegulaveis;

        public Carro(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {
        }

        protected override void Adicionar()
        {
            // Implementação específica para adicionar um carro
        }

        protected override void Editar()
        {
            // Implementação específica para editar um carro
        }

        protected override void Delete()
        {
            // Implementação específica para deletar um carro
        }
    } 

}
