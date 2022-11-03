class Poisson
{
    long factx;//Factorial de x
    double resultado, pote, potlam, lambda, p; //p probabilidad
    double e = 2.718281828; //Valor de e
    int n, x; //n Muestra, x Exitos
    public void Datos()
    {
        Console.WriteLine("Ingresar el tamaño de la muestra");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar la probabilidad");
        p = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar la cantidad de exitos");
        x = int.Parse(Console.ReadLine());
    }
    public void Potencia()
    {
        lambda = n * p;
        //Potencia de e
        pote = Math.Pow(e, -lambda);
        //Potencia de lambda
        potlam = Math.Pow(lambda, x);
    }
    public void Factorial()
    {
        factx = 1;
        for(int i = 1; i <= x; i++)
        {
            factx = factx * i;
        }
    }
    public void Resultado()
    {
        resultado = pote * potlam / factx;
        Console.WriteLine($"Resultado: {resultado}");
    }
}
class Program
{
    static void Main()
    {
        Poisson c = new Poisson();
        c.Datos();
        c.Potencia();
        c.Factorial();
        c.Resultado();
    }
}