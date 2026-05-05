namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Problema5 prob5 = new Problema5();

            // Creamos una venta minorista de $1000
            Sale ventaMinorista = new RetailSale(1000m);
            // Creamos una venta mayorista de $1000
            Sale ventaMayorista = new WholesaleSale(1000m);

            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 5 ---");
            Console.WriteLine($"Total Minorista (esperado 1000): {prob5.ObtenerImporteFinal(ventaMinorista)}");
            Console.WriteLine($"Total Mayorista (esperado 900): {prob5.ObtenerImporteFinal(ventaMayorista)}");
        }
    }
}
