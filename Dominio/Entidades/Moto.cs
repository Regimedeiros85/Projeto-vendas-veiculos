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
        public bool PartidaEletrica;
        public bool TravaGuidao;
        public bool ProtetorDeMao;
        public bool ProtetorDePernas;
        public bool SensorDeDescanso;

        public Moto(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {
        }

        protected override void Adicionar()
        {
            throw new NotImplementedException();
        }

        protected override void Delete()
        {
            throw new NotImplementedException();
        }

        protected override void Editar()
        {
            throw new NotImplementedException();
        }
    }
}
