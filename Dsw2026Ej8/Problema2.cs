using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {

        public String CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice) {

            decimal total = quantity * unitPrice;

            if (quantity <= 0)
            {
                total = 0;
            }


            var resumen = new { Code = productCode, Description = productDescription, Quanty = quantity, Total = total};


             return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
