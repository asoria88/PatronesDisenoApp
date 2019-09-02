using OpenClosedPrinciple.App.Antes;
using OpenClosedPrinciple.App.Despues;
using System;
using static System.Console;

namespace OpenClosedPrinciple.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo
            AntesMain.AntesPrincipal();
            WriteLine("***************************************************************");
            DespuesMain.DespuesPrincipal();
            ReadKey();
        }
    }
}
