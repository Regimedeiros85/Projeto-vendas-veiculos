using static Dominio.Enumeradores.Enumeradores;

namespace Dominio.Entidades
{
    public class Caminhao : Veiculo
    {
        public int QuantidadeEixos;
        public double CapacidadeCarga;
        public bool Tacografo;
        public double PesoBrutoTotal;
        public double Comprimento;
        public double Largura;
        public double Altura;
        public bool ArCondicionado;
        public EnumTipoCombustivel TipoCombustivel;
        public string TipoCarroceria;
        public string TipoFreio;
        public bool PossuiReboque;
        public bool PossuiCama;
        

        public Caminhao(int id, string modelo, string marca, int anoFabricacao, string placa)
            : base(id, modelo, marca, anoFabricacao, placa)
        {


        }

        protected override void Adicionar()
        {
            // Implementação específica para adicionar um caminhão
        }

        protected override void Editar()
        {
            // Implementação específica para editar um caminhão
        }

        protected override void Delete()
        {
            // Implementação específica para deletar um caminhão
        }
    }
}
