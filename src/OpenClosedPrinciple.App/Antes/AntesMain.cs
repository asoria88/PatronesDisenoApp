using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.App.Enumerador;

namespace OpenClosedPrinciple.App.Antes
{
    public static class AntesMain
    {
        #region " ctor "
        static AntesMain()
        {

        }
        #endregion

        #region " Métodos públicos "
        public static void AntesPrincipal()
        {
            // Carga la lista de personas
            List<AntesPersona> vColAntesPersona = new List<AntesPersona>()
            {
                new AntesPersona { Apellido = "Arce", Nombre = "Juan Carlos", Rol = eRol.Doctor},
                new AntesPersona { Apellido = "Callejón", Nombre = "Juan Miguel", Rol = eRol.Doctor},
                new AntesPersona { Apellido = "Machado", Nombre = "Cristian", Rol = eRol.Doctor },
                new AntesPersona { Apellido = "Flores", Nombre = "Pamela", Rol = eRol.Enfermera }
            };

            // Crea las cuenta de servicio de las personas
            List<AntesEquipo> vColAntesEquipo = new List<AntesEquipo>();
            vColAntesPersona.ForEach(y => 
            {
                vColAntesEquipo.Add(new AntesCuentaServicio().CrearCuentaServicio(y));
            });


            // Imprime el resultado
            vColAntesEquipo.ForEach(x =>
            {
                WriteLine(" ");
                WriteLine($"Bienvenido " +
                    $"{ x.Nombre } " +
                    $"{ x.Apellido } " +
                    $"{ x.CorreoElectronico } " +
                    $"Es doctor: {(x.Rol == eRol.Doctor ? "SI" : "NO")} " +
                    $"Es enfermera: {(x.Rol == eRol.Enfermera ? "SI" : "NO")} ");
            });

        }
        #endregion
    }
}
