class Fisher
{
    double ln, ld, f, numerador, denominador, numcua, dencua, resultado;
    public void Datos()
    {
        Console.WriteLine("Ingresar valor de F");
        f = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar grados de libertad del numerador");
        ln = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar grados de libertad del denominador");
        ld = double.Parse(Console.ReadLine());
    }
    public void Cuadrada()
    {
        //Chi-Cuadrada de numerador
        numerador = Math.Pow(ln - f, 2);
        numcua = numerador / f;

        //Chi-Cuadrada de denominador
        denominador = Math.Pow(ld - f, 2);
        dencua = denominador / f; 

        //Resultado
        resultado = Math.Pow(dencua, 2) / Math.Pow(numcua, 2);
        Console.WriteLine($"Resultado: {resultado}");
    }
}
class Program
{
    static void Main()
    {
        Fisher c = new Fisher();
        c.Datos();
        c.Cuadrada();
    }
}
