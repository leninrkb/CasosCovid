using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace SolucionCasosCovid {
    public partial class Form1 : Form {
        EntidadRegistroCasos registro_casos = new EntidadRegistroCasos();

        public Form1() {
            InitializeComponent();
            NotificacionSimple("Bienvenido al sistema");

        }

        private void Button_guardar_Click(object sender, EventArgs e) {
            LimpiarCampos();
        }

        
        private EntidadRegistroCasos CapturarCampos() {
            EntidadRegistroCasos entidad = new EntidadRegistroCasos {
                Provincia = textBox_provincia.Text,
                Casos = int.Parse(textBox_casos.Text),
                Fallecidos = int.Parse(textBox_fallecidos.Text),
                Vacunados = int.Parse(textBox_vacunados.Text),
                CentrosVacunacion = int.Parse(textBox_centros_vacunacion.Text),
                Digitador = textBox_digitador.Text,
                FechaRegistro = dateTimePicker_fechaRegistro.Value.Date
            };
            return entidad;
        }

        private void LimpiarCampos() {
            textBox_casos.Text = "";
            textBox_provincia.Text = "";
            textBox_vacunados.Text = "";
            textBox_fallecidos.Text = "";
            textBox_digitador.Text = "";
            textBox_centros_vacunacion.Text = "";
        }

        private void NotificacionSimple(String m) {
            notificacion.BackColor = Color.DarkGray;
            label_notificacion.Text = m;
        }
    }
}
