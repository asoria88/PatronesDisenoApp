using OpenClosedPrinciple.App.Enumerador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.App.Antes
{
    public class AntesCuentaServicio
    {
        public AntesEquipo CrearCuentaServicio(AntesPersona pAntesPersona)
        {
            // Requerimiento original
            //AntesEquipo vObjAntesEquipo = new AntesEquipo()
            //{
            //    Nombre = pAntesPersona.Nombre,
            //    Apellido = pAntesPersona.Apellido,
            //    CorreoElectronico = $"{pAntesPersona.Nombre}.{pAntesPersona.Apellido}@equipo.com",
            //    Rol = pAntesPersona.Rol
            //};

            AntesEquipo vObjAntesEquipo = new AntesEquipo();
            vObjAntesEquipo.Nombre = pAntesPersona.Nombre;
            vObjAntesEquipo.Apellido = pAntesPersona.Apellido;
            vObjAntesEquipo.Rol = pAntesPersona.Rol;

            switch (pAntesPersona.Rol)
            {
                case eRol.Doctor:
                    vObjAntesEquipo.CorreoElectronico = $"{pAntesPersona.Nombre.ToLower()}.{pAntesPersona.Apellido.ToLower()}@doctor.com";
                    break;
                case eRol.Enfermera:
                    vObjAntesEquipo.CorreoElectronico = $"{pAntesPersona.Nombre.ToLower()}.{pAntesPersona.Apellido.ToLower()}@enfermera.com";
                    break;
            }

            return vObjAntesEquipo;
        }

    }
}
