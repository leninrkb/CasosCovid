using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class EntidadRegistroCasos {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public int Casos { get; set; }
        public int Fallecidos { get; set; }
        public int Vacunados { get; set; }
        public int CentrosVacunacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Digitador { get; set; }

        public EntidadRegistroCasos() {

        }

        public EntidadRegistroCasos(int id, string provincia, int casos, int fallecidos, int vacunados, int centrosVacunacion,DateTime fechaRegistro, string digitador) {
            Id = id;
            Provincia = provincia;
            Casos = casos;
            Fallecidos = fallecidos;
            Vacunados = vacunados;
            CentrosVacunacion = centrosVacunacion;
            FechaRegistro = fechaRegistro;
            Digitador = digitador;
        }
    }
}
