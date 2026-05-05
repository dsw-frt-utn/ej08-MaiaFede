using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Importe { get; protected set; }

        public Sale(decimal importe)
        {
            Importe = importe;
        }

        
        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }

    
    public class RetailSale : Sale
    {
        
        public RetailSale(decimal importe) : base(importe) { }

       
        public override decimal CalculateTotal()
        {
            return Importe; 
        }
    }

 
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe) { }

       
        public override decimal CalculateTotal()
        {
       
            return Importe - (Importe * 0.10m);
        }
    }
}
