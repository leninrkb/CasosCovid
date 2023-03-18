using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio {
    public class NegocioCovid {
        public static Boolean Guardar(EntidadRegistroCasos entidad) {
            return DatosCovid.Guardar(entidad);
        }

        public static List<EntidadRegistroCasos> ObtenerTodosLosRegistros() {
            return DatosCovid.ObtenerTodosLosRegistros();
        }
    }
}
