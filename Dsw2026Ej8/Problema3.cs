using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {

        public String CompararCopias(int originalValue,Product product)
        { 
        int copyValue = originalValue;

            copyValue++;

            Product copyProduct = product;

            copyProduct.ModificarDescripcion("Copia Modificada");

         
            return $"{originalValue}-{copyValue}-{copyProduct.Description}";
        }
    }
}
