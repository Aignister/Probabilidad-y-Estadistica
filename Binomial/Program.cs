class Binomial
{
    long factn, factx, factnx, comb; //Factorial de n, x, n-x
    int n, x, nx; //n Numero de pruebas, x Numero de exitos, nx n - x
    double p , q, potp, potq, resultado; //p Probabilidad de exito, q Probabilidad de fracaso "q = 1 - p"
    public void Datos()
    {
        Console.WriteLine("Ingresar numero de pruebas");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar el numero de exitos");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar la probabilidad de obtener exito");
        p = double.Parse(Console.ReadLine());

    }
    public void Combinacion()
    {
        //Factorial de n
        factn = 1;
        for(int i = 1; i <= n; i++)
        {
            factn = factn * i;
        }

        //Factorial de x
        factx = 1;
        for(int i = 1; i <= x; i++)
        {
            factx = factx * i;
        }

        //Factorial de n - x
        factnx = 1;
        nx = n - x;
        for(int i = 1; i <= nx; i++)
        {
            factnx = factnx * i;
        }

        //Combinacion    
        comb = factn / (factx * factnx);
        Console.WriteLine($"Resultado: {comb}");
    }
    public void Potencia()
    {
        q = 1 - p;
        //Potencia de p
        potp = Math.Pow(p, x);
        Console.WriteLine($"Resultado: {potp}");
        //Potencia de q
        potq = Math.Pow(q, nx);
        Console.WriteLine($"Resultado: {potq}");
    }
    public void Resultado()
    {
        double combinacion = comb;
        resultado = combinacion * potp * potq;
        Console.WriteLine($"Resultado: {resultado}");
    }
}
class Program
{
    static void Main()
    {
        Binomial C = new Binomial();
        C.Datos();
        C.Combinacion();
        C.Potencia();
        C.Resultado();
    }
}