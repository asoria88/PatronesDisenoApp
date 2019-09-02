using OpenClosedPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.App.Despues
{
    class DespuesEnfermeraCuentaServicio : IDespuesCuentaServicio
    {
        public DespuesEquipo CrearCuentaServicio(IDespuesPersonaSolicitante pAntesPersona)
        {
            DespuesEquipo vObjAntesEquipo = new DespuesEquipo();
            vObjAntesEquipo.Nombre = pAntesPersona.Nombre;
            vObjAntesEquipo.Apellido = pAntesPersona.Apellido;
            vObjAntesEquipo.CorreoElectronico = $"{pAntesPersona.Nombre}.{pAntesPersona.Apellido}@enfermera.com";

            return vObjAntesEquipo;
        }
    }
}
