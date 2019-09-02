using OpenClosedPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.App.Despues
{
    public class DespuesPersona : IDespuesPersonaSolicitante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public IDespuesCuentaServicio Proceso { get; set; } = new DespuesCuentaServicio();
    }
}
