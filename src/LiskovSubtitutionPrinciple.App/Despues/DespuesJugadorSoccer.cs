using LiskovSubtitutionPrinciple.App.Antes;
using LiskovSubtitutionPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.App.Despues
{
    public class DespuesJugadorSoccer : DespuesJugador
    {
        #region " Métodos públicos "
        public string ObtenerValorMercado(eCategoriaJugador pCategoriaJugador)
        {
            switch (pCategoriaJugador)
            {
                case eCategoriaJugador.Aficionado:
                    return "100";
                case eCategoriaJugador.Profesional:
                    return "1000";
                default:
                    return "-";
            }
        }
        #endregion
    }
}
