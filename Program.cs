namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Arbol arbolitox = new Arbol();

            arbolitox.insertar(60);
            arbolitox.insertar(70);
            arbolitox.insertar(10);
            arbolitox.insertar(49);
            arbolitox.insertar(23);
            arbolitox.insertar(3);

            Console.WriteLine($"Minimo: {arbolitox.ObtenerMinimo()}");
            Console.WriteLine($"Maximo: {arbolitox.ObtenerMaximo()}");
            Console.WriteLine($"El numero de nodos que hay es: {arbolitox.ObtenerCantidadNodos()}");
        }
    }
}