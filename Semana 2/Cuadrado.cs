
// Cuadrado.cs
public class Cuadrado
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    public double CalcularArea()
    {
        return Lado * Lado;
    } 

    public double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}
