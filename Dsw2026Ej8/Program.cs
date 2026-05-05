namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Problema6 prob6 = new Problema6();

            Console.WriteLine("\n--- DEMOSTRACIÓN PROBLEMA 6 ---");

            string textoPrueba = "ab 123 x ";
            Console.WriteLine($"Prueba texto: '{textoPrueba}' -> {prob6.NormalizarCodigoProducto(textoPrueba)}");

            string textoNulo = null;
            Console.WriteLine($"Prueba null: -> {prob6.NormalizarCodigoProducto(textoNulo)}");

        }
    }
}
