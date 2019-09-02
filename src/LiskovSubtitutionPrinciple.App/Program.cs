using LiskovSubtitutionPrinciple.App.Antes;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AntesMain.AntesPrincipal();
            WriteLine("***************************************************************");
            DespuesMain.DespuesPrincipal();
            ReadKey();
        }
    }
}
