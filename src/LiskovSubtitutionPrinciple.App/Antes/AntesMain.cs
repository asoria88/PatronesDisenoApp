using LiskovSubtitutionPrinciple.App.Enumerador;
using static System.Console;

namespace LiskovSubtitutionPrinciple.App.Antes
{
    public static class AntesMain
    {
        #region " Métodos públicos "
        public static void AntesPrincipal()
        {
            AntesJugador vObjAntesJugador = new AntesJugador();
            vObjAntesJugador.Nombre = "William";
            vObjAntesJugador.Apellido = "Ferreira";
            vObjAntesJugador.AsignarEquipo(new AntesEquipo { Nombre = "Bolivar" });
            vObjAntesJugador.AsignarCategoria(eCategoriaJugador.Profesional);

            ForegroundColor = System.ConsoleColor.Cyan;
            WriteLine($" Nombre: {vObjAntesJugador.Nombre} {vObjAntesJugador.Apellido} " +
                $"\n Equipo: {vObjAntesJugador.ObtenerEquipo()}" +
                $"\n Categoría: {vObjAntesJugador.Categoria}");
            WriteLine();
        }
        #endregion
    }
}
