using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            if (nota1 < 0 || nota1 > 10) nota1 = null;
            if (nota2 < 0 || nota2 > 10) nota2 = null;
            if (nota3 < 0 || nota3 > 10) nota3 = null;

            
            if (nota1 == null && nota2 == null && nota3 == null)
            {
                return 0;
            }

           
            double suma = 0;
            int cantidadNotas = 0;

            if (nota1 != null)
            {
                suma += nota1.Value;  
                cantidadNotas++;
            }
            if (nota2 != null)
            {
                suma += nota2.Value;
                cantidadNotas++;
            }
            if (nota3 != null)
            {
                suma += nota3.Value;
                cantidadNotas++;
            }

            
            return suma / cantidadNotas;


        }

    }
}
