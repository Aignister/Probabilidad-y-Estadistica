class Normal
{
    double x, u, o, z;
    public void Datos()
    {
        Console.WriteLine("Ingresar X");
        x=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar u");
        u=double.Parse(Console.ReadLine());      
        Console.WriteLine("Ingresar o");
        o=double.Parse(Console.ReadLine());   
    }

    public void Formula()
    {
        z = (x - u) / o;
        Console.WriteLine($"Resultado: {z}");
    }
}
class Program
{
    static void Main()
    {
        Normal c = new Normal();
        c.Datos();
        c.Formula();
    }
}
