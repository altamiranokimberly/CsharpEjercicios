using System;

namespace appGas
{
class Gasolina
{
    // Método para calcular el total de gasolina
    public double EcharGasolina(double litros)
    {
        double nivelDeposito = 20;
        return nivelDeposito * litros;
    }

    // Método que no devuelve valor
    public void MostrarTotal(double total)
    {
        Console.WriteLine("Total de gasolina: " + total);
    }
}

}



