using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Veiculo
    {
        private int Id { get; set; }
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private int AnoFabricacao { get; set; }
        private string Placa { get; set; }
        private bool Disponivel { get; set; } = true;

        public Veiculo(int id, string modelo, string marca, int anoFabricacao, string placa)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            Placa = placa;
        }

        private void Adicionar()
        {

        }

        private void Editar()
        {
        }

        private void Delete()
        {
        }


    }
}
