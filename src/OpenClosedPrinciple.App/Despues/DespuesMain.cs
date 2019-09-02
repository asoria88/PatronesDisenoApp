using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OpenClosedPrinciple.App.Despues
{
    public static class DespuesMain
    {
        #region " Métodos públicos "
        public static void DespuesPrincipal()
        {
            // Carga la lista de personas
            List<IDespuesPersonaSolicitante> vColDespuesPersona = new List<IDespuesPersonaSolicitante>()
            {
                new DespuesPersona { Apellido = "Arce", Nombre = "Juan Carlos"},
                new DespuesPersonaDoctor { Apellido = "Callejón", Nombre = "Juan Miguel"},
                new DespuesPersonaDoctor { Apellido = "Machado", Nombre = "Cristian"},
                new DespuesPersonaEnfermera { Apellido = "Flores", Nombre = "Pamela"}
            };

            // Crea las cuenta de servicio de las personas
            List<DespuesEquipo> vColDespuesEquipo = new List<DespuesEquipo>();
            vColDespuesPersona.ForEach(y =>
            {
                vColDespuesEquipo.Add(y.Proceso.CrearCuentaServicio(y));
            });

            WriteLine(" ");
            WriteLine(" Despues de implementar OCP ");
            // Imprime el resultado
            vColDespuesEquipo.ForEach(x =>
            {
                WriteLine(" ");
                WriteLine($"Bienvenido " +
                    $"{ x.Nombre } " +
                    $"{ x.Apellido } " +
                    $"{ x.CorreoElectronico }");
            });

        }
        #endregion
    }
}
