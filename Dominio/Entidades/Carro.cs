using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Carro : Veiculo
    {
        public Carro(int id, string modelo, string marca, int anoFabricacao, string placa) : base(id, modelo, marca, anoFabricacao, placa)
        {
        }
    }
}
