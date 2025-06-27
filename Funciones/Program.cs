// See https://aka.ms/new-console-template for more information
// Program.cs
using System;

        Gasolina g = new Gasolina();  // Esto funciona si Gasolina es en el mismo namespace o en uno global
        double total = g.EcharGasolina(15);
        g.MostrarTotal(total);