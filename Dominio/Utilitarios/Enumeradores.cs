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

    }
}
