using LiskovSubtitutionPrinciple.App.Enumerador;

namespace LiskovSubtitutionPrinciple.App.Antes
{
    public interface IDespuesJugador
    {
        #region " Propiedades "
        string Apellido { get; set; }
        eCategoriaJugador Categoria { get; set; }
        DespuesEquipo Equipo { get; set; }
        string Nombre { get; set; }
        #endregion

        #region " Métodos "
        void AsignarCategoria(eCategoriaJugador pCategoriaJugador);
        #endregion
    }
}