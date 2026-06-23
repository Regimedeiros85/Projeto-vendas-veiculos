using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Enumeradores
{
    public static class Enumeradores
    {
        public enum EnumTipoCombustivel
        {
            [Description("Gasolina")] Gasolina = 1,
            [Description("Álcool")] Alcool = 2,
            [Description("Diesel")] Diesel = 3,
            [Description("GNV")] GNV = 4,
            [Description("Elétrico")] Eletrico = 5
        }
        public enum EnumTipoDirecao
        {
            [Description("Hidráulica")] Hidraulica = 1,
            [Description("Elétrica")] Eletrica = 2,
            [Description("Mecânica")] Mecanica = 3
        }
        public enum EnumTipoVeiculo
        {
            [Description("Passeio")] Carro = 1,
            [Description("Esportivo")] Esportivo = 2,
            [Description("Utilitario")] Utilitario = 3,
            [Description("Carga")] Carga = 4,
        }
        public enum EnumStatusVeiculo
        {
            [Description("Disponível")] Disponivel = 1,
            [Description("Vendido")] Vendido =2
        }
        public enum EnumMarcaCarro
        {
            [Description("Toyota")] Toyota = 1,
            [Description("Honda")] Honda = 2,
            [Description("Ford")] Ford = 3,
            [Description("Chevrolet")] Chevrolet = 4,
            [Description("Volkswagen")] Volkswagen = 5,
            [Description("Renault")] Renault = 6,
            [Description("Fiat")] Fiat = 7,
            [Description("Nissan")] Nissan = 8,
            [Description("Hyundai")] Hyundai = 9,
            [Description("Kia")] Kia = 10
        }
        public enum EnumMarcaMoto
        {
            [Description("Honda")] Honda = 1,
            [Description("Yamaha")] Yamaha = 2,
            [Description("Suzuki")] Suzuki = 3,
            [Description("Kawasaki")] Kawasaki = 4,
            [Description("Ducati")] Ducati = 5,
            [Description("Harley-Davidson")] HarleyDavidson = 6,
            [Description("BMW")] BMW = 7,
            [Description("Triumph")] Triumph = 8,
            [Description("KTM")] KTM = 9,
            [Description("Royal Enfield")] RoyalEnfield = 10
        }
        public enum EnumMarcaCaminhao
        {
            [Description("Volvo")] Volvo = 1,
            [Description("Scania")] Scania = 2,
            [Description("Mercedes-Benz")] MercedesBenz = 3,
            [Description("MAN")] MAN = 4,
            [Description("Iveco")] Iveco = 5,
            [Description("DAF")] DAF = 6,
            [Description("Renault Trucks")] RenaultTrucks = 7,
            [Description("Ford Trucks")] FordTrucks = 8,
            [Description("GMC")] GMC = 9,
            [Description("Freightliner")] Freightliner = 10
        }
        public enum  EnumCores
        {
            [Description("Branco")] Branco = 1,
            [Description("Preto")] Preto = 2,
            [Description("Vermelho")] Vermelho = 3,
            [Description("Azul")] Azul = 4,
            [Description("Prata")] Prata = 5,
            [Description("Cinza")] Cinza = 6,
            [Description("Amarelo")] Amarelo = 7

        }
        public enum EnumTipoFreio
        {
            [Description("ABS")] ABS = 1,
            [Description("Disco")] Disco = 2,
            [Description("Tambor")] Tambor = 3,
            [Description("Eletromagnético")] Eletromagnetico = 4,
            [Description("Regenerativo")] Regenerativo = 5
        }
        public enum EnumTipoCarroceria
        {
            [Description("Baú")] Bau = 1,
            [Description("Sider")] Sider = 2,
            [Description("Graneleiro")] Graneleiro = 3,
            [Description("Tanque")] Tanque = 4,
            [Description("Frigorífico")] Frigorifico = 5,
            [Description("Plataforma")] Plataforma = 6
        }
        public enum Genero
        {
            [Description("Masculino")] Masculino = 1,
            [Description("Feminino")] Feminino = 2,
            [Description("Outro")] Outro = 3
        }
        public enum EstadoCivil
        {
            [Description("Solteiro(a)")] Solteiro = 1,
            [Description("Casado(a)")] Casado = 2,
            [Description("Divorciado(a)")] Divorciado = 3,
            [Description("Viúvo(a)")] Viuvo = 4
        }
        public enum EnumTipoPagamento
        {
            [Description("Dinheiro")] Dinheiro = 1,
            [Description("Cartão de Crédito")] CartaoCredito = 2,
            [Description("Cartão de Débito")] CartaoDebito = 3,
            [Description("Transferência Bancária")] TransferenciaBancaria = 4,
            [Description("Pix")] Pix = 5
        }
        public enum Escolaridade
        {
            [Description("Ensino Fundamental")] EnsinoFundamental = 1,
            [Description("Ensino Médio")] EnsinoMedio = 2,
            [Description("Ensino Superior")] EnsinoSuperior = 3,
            [Description("Pós-Graduação")] PosGraduacao = 4,
            [Description("Mestrado")] Mestrado = 5,
            [Description("Doutorado")] Doutorado = 6
        }
     
        
        

    }
}
