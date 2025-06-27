// Gasolina.cs
public class Gasolina
{
    public double EcharGasolina(double litros)
    {
        double nivelDeposito = 20;
        return nivelDeposito * litros;
    }

    public void MostrarTotal(double total)
    {
        Console.WriteLine("Total de gasolina: " + total);
    }
}