class Tstudent
{
    int x, u, n, xu; //x Media de la muestra, u Media de la poblacion, n Numero de datos de la muestra
    double s, raiz, div1, div2; //s Desviacion estandar
    public void Datos()
    {
        Console.WriteLine("Introducir la media de la muestra");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducir la media de la poblacion");
        u = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducir la desviacion estandar");
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("Introducir numero de datos de la muestra");
        n = int.Parse(Console.ReadLine());
    }
    public void T()
    {
        xu = x - u;
        raiz = Math.Sqrt(n); 
        div1 = s/raiz;
        div2 = xu/div1;
        Console.WriteLine($"Resultado: {div2}");
    }
}
class Program
{
    static void Main()
    {    
        Tstudent c = new Tstudent();
        c.Datos();
        c.T();    
    }
}
