using OpenClosedPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.App.Antes
{
    public class AntesPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }

        #region " Modificación"
        public eRol Rol { get; set; }
        #endregion

    }
}
