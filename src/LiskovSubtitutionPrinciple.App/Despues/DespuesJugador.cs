using LiskovSubtitutionPrinciple.App.Enumerador;

namespace LiskovSubtitutionPrinciple.App.Antes
{
    public class DespuesJugador : IDespuesJugador
    {
        #region " Propiedades"
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public eCategoriaJugador Categoria { get; set; }
        public DespuesEquipo Equipo { get; set; }
        #endregion

        #region " Métodos públicos "
        /*public string ObtenerEquipo() => Equipo.Nombre;*/
        public string ObtenerEquipo()
        {
            if (Equipo != null)
                return Equipo.Nombre;
            else
                return "Sin Equipo";
        }
        #endregion

        #region " Override "
        public virtual void AsignarCategoria(eCategoriaJugador pCategoriaJugador)
        {
            Categoria = pCategoriaJugador;
        }
        public virtual void AsignarEquipo(DespuesEquipo pDespuesEquipo)
        {
            Equipo = pDespuesEquipo;
        }
        #endregion
    }
}
