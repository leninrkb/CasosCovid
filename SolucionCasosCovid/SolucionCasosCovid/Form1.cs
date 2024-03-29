﻿using System;
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
            CargarDataGrid();

        }
        private void Button_guardar_Click(object sender, EventArgs e) {
            Guardar();
        }

        private void Guardar() {
            var e = CapturarCampos();
            if (e == null) {
                return;
            }
            if (NegocioCovid.Guardar(e)) {
                LimpiarCampos();
                NotificacionBien("se guardo con exito!");
                CargarDataGrid();
            } else {
                NotificacionError("ocurrio un error y no se guardo!");
            }
        }
        private void CargarDataGrid() {
            try {
                dataGridView_datos.DataSource = NegocioCovid.ObtenerTodosLosRegistros();
            } catch {
                MessageBox.Show("ocurrio un error al cargar los datos!");
                DeshabilitarBotones();
            }
        }
        private EntidadRegistroCasos CapturarCampos() {
            try {
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
            } catch (FormatException){
                NotificacionError("Error - Revise los campos!");
                return null;
            }
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
        private async void NotificacionError(String m) {
            notificacion.BackColor = Color.DarkRed;
            label_notificacion.Text = m;
            await Task.Delay(3000);
            NotificacionSimple("Bienvenido al sistema");
        }
        private async void NotificacionBien(String m) {
            notificacion.BackColor = Color.DarkGreen;
            label_notificacion.Text = m;
            await Task.Delay(3000);
            NotificacionSimple("Bienvenido al sistema");
        }
        private void DeshabilitarBotones() {
            button_actualizar.Enabled = false;
            button_guardar.Enabled = false;
            button_nuevo.Enabled = false;
            button_eliminar.Enabled = false;
        }
        private void HabilitarBotones() {
            button_actualizar.Enabled = true;
            button_guardar.Enabled = true;
            button_nuevo.Enabled = true;
            button_eliminar.Enabled = true;
        }
    }
}
