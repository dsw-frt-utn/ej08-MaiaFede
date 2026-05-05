namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("es-AR");


            Console.WriteLine("Hello, World!");

            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 1 ---");
            ProductHelper helper = new ProductHelper();
            Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Teclado Mecanico", 45000.50m));
            Console.WriteLine();


            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 2 ---");
            Problema2 prob2 = new Problema2();
            Console.WriteLine(prob2.CrearResumenVenta(55, "Mouse", 2, 1500m));
            Console.WriteLine(prob2.CrearResumenVenta(55, "Mouse", -1, 15000m));
            Console.WriteLine();


            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 3 ---");
            Problema3 prob3 = new Problema3();
            Product miProductoOriginal = new Product("Descripcion Intacta");
            Console.WriteLine(prob3.CompararCopias(10, miProductoOriginal));
            Console.WriteLine();


            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 4 ---");
            Problema4 prob4 = new Problema4();
            Console.WriteLine($"Promedio (8, null, 10): {prob4.CalcularPromedio(8, null, 10)}");
            Console.WriteLine($"Promedio (-5, 6, 8): {prob4.CalcularPromedio(-5, 6, 8)}");
            Console.WriteLine($"Promedio (null, null, null): {prob4.CalcularPromedio(null, null, null)}");
            Console.WriteLine();


            Console.WriteLine("--- DEMOSTRACIÓN PROBLEMA 5 ---");
            Problema5 prob5 = new Problema5();
            Sale ventaMinorista = new RetailSale(1000m);
            Sale ventaMayorista = new WholesaleSale(1000m);
            Console.WriteLine($"Total Minorista (esperado 1000): {prob5.ObtenerImporteFinal(ventaMinorista)}");
            Console.WriteLine($"Total Mayorista (esperado 900): {prob5.ObtenerImporteFinal(ventaMayorista)}");
            Console.WriteLine();

            Problema6 prob6 = new Problema6();

            Console.WriteLine("\n--- DEMOSTRACIÓN PROBLEMA 6 ---");

            string textoPrueba = "ab 123 x ";
            Console.WriteLine($"Prueba texto: '{textoPrueba}' -> {prob6.NormalizarCodigoProducto(textoPrueba)}");

            string textoNulo = null;
            Console.WriteLine($"Prueba null: -> {prob6.NormalizarCodigoProducto(textoNulo)}");

        }
    }
}
