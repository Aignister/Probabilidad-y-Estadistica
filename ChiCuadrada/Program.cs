class ChiCuadrada
{
    double o, e, cuadrada, resultado;
    public void Datos()
    {
        Console.WriteLine("Ingresar el numero de eventos observados");
        o = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar el numero de eventos esperados");
        e = double.Parse(Console.ReadLine());
    }
    public void Cuadrada()
    {
        cuadrada = Math.Pow(o - e, 2);
        resultado = cuadrada / e;
        Console.WriteLine($"Resultado: {resultado}");
    }
}
class Program
{
    static void Main()
    {
        ChiCuadrada C = new ChiCuadrada();
        C.Datos();
        C.Cuadrada();
    }
}