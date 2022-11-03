class Hipergeometrica
{
    long comb1, comb2, comb3;
    double combfinal, c1, c2, c3;
    int N, r, n, x;
    int rx, Nr, nx, res, Nn;
    long factorialr, factorialx, factorialrx, factorialNr, factorialnx, factorialResta, factorialN, factorialn, factorialNn;
    public void Datos()
    {
        Console.WriteLine("Ingresar tamaño de la poblacion: ");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar tamaño de la muestra: ");
        r = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de exito de la poblacion: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de exitos en la muestra: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("");
    }
    public void Combinacion1()
    {
        //Factorial de r
        factorialr = 1;
        for(int i = 1; i <= r; i++)
        {
            factorialr = factorialr * i;
        }

        //Factorial de x
        factorialx = 1;
        rx = r - x;
        for(int i = 1; i <= x; i++)
        {
            factorialx = factorialx * i;
        }

        //Factorial de la resta de r - x
        factorialrx = 1;
        for(int i = 1; i <= rx; i++)
        {
            factorialrx = factorialrx * i;
        }

        //Combinacion de r C x
        comb1 = factorialr/(factorialx*factorialrx);
    }
    public void Combinacion2()
    {
        //Factorial de la resta de N - r
        factorialNr = 1;
        Nr = N - r;
        for(int i = 1; i <= Nr; i++)
        {
            factorialNr = factorialNr * i;
        }

        //Factorial de la resta de n - x
        factorialnx = 1;
        nx = n - x;
        for(int i = 1; i <= nx; i++)
        {
            factorialnx = factorialnx * i;
        }

        //Factorial de la resta de N - r por menos la resta de n - x
        res = ((N - r)-(n - x));
        factorialResta = 1;
        for(int i = 1; i <= res; i++)
        {
            factorialResta = factorialResta * i;
        }

        //Combinacion de N-r C n-x
        comb2 = factorialNr/(factorialnx*factorialResta);
    }
    public void Combinacion3()
    {
        //Factorial de N
        factorialN = 1;
        for(int i = 1; i <= N; i++)
        {
            factorialN = factorialN * i;
        }

        //Factorial de n
        factorialn = 1;
        for(int i = 1; i <= n; i++)
        {
            factorialn = factorialn * i;
        }

        //Factorial de N - n
        factorialNn = 1;
        Nn = N - n;
        for(int i = 1; i <= Nn; i++)
        {
            factorialNn = factorialNn * i;
        }

        //Combinacion de N C n
        comb3 = factorialN/(factorialn*factorialNn); 
    }
    public void CombinacionF()
    {
        c1 = comb1;
        c2 = comb2;
        c3 = comb3;
        combfinal = (c1 * c2)/c3;
        Console.WriteLine($"Resultado: {combfinal}");
    }

}
class Program
{
    static void Main()
    {
        Hipergeometrica C = new Hipergeometrica();
        C.Datos();
        C.Combinacion1();
        C.Combinacion2();
        C.Combinacion3();
        C.CombinacionF();
    }
}