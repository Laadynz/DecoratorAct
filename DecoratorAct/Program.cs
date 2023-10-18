using DecoratorAct;

class Program
{
    static void Main(string[] args)
    {
        IBebida bebida = new Cafe();
        Console.WriteLine($"Bebida: {bebida.Descripcion}, Costo: ${bebida.Costo()}");

        bebida = new Leche(bebida);
        Console.WriteLine($"Bebida: {bebida.Descripcion}, Costo: ${bebida.Costo()}");

        Console.ReadKey();
    }
}
