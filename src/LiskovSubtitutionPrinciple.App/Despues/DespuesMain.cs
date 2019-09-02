using LiskovSubtitutionPrinciple.App.Despues;
using LiskovSubtitutionPrinciple.App.Enumerador;
using static System.Console;

namespace LiskovSubtitutionPrinciple.App.Antes
{
    public static class DespuesMain
    {
        #region " Métodos públicos "
        public static void DespuesPrincipal()
        {
            DespuesJugador vObjDespuesJugador = new DespuesJugadorTennis();
            vObjDespuesJugador.Nombre = "William";
            vObjDespuesJugador.Apellido = "Ferreira";
            //vObjAntesJugador.AsignarEquipo(new DespuesJugador { Nombre = "Bolivar" });
            vObjDespuesJugador.AsignarCategoria(eCategoriaJugador.Profesional);

            ForegroundColor = System.ConsoleColor.Cyan;
            WriteLine($" Nombre: {vObjDespuesJugador.Nombre} {vObjDespuesJugador.Apellido} " +
                $"\n Equipo: {vObjDespuesJugador.ObtenerEquipo()}" +
                $"\n Categoría: {vObjDespuesJugador.Categoria}");
            WriteLine();
        }
        #endregion
    }
}
