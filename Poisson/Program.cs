class Poisson
{
    long factx = 0; //Factorial de x
    double resultado = 0; //Resultado
    double pote = 0; //Potencia de e
    double potlam = 0; //Potencia de lambda
    double e = 2.718281828; //Valor de e
    double lambda = 0; //Lamda = n * P
    double p = 0; //Probabilidad
    int n = 0; //Muestra
    int x = 0; //Exitos
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
        pote = Math.Pow(e, -lambda);
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