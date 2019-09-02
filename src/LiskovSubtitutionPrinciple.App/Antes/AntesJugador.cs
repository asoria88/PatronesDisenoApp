using LiskovSubtitutionPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.App.Antes
{
    public class AntesJugador
    {
        #region " Propiedades"
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public eCategoriaJugador Categoria { get; set; }
        public AntesEquipo Equipo { get; set; }
        #endregion

        #region " Métodos públicos "
        public string ObtenerEquipo() => Equipo.Nombre;
        #endregion

        #region " Override "
        public virtual void AsignarCategoria(eCategoriaJugador pCategoriaJugador)
        {
            Categoria = pCategoriaJugador;
        }
        public virtual void AsignarEquipo(AntesEquipo pAntesEquipo)
        {
            Equipo = pAntesEquipo;
        }
        #endregion
    }
}
