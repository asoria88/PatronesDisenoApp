using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.App.Despues
{
    public class DespuesPersonaDoctor : IDespuesPersonaSolicitante
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public IDespuesCuentaServicio Proceso { get; set; } = new DespuesDoctorCuentaServicio();
    }
}
