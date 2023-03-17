using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos {
    public class DatosCovid {
        public static Boolean Guardar(EntidadRegistroCasos entidad) {
            try {
                SqlConnection c = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                c.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = c;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO RegistroCasos
                                   (provincia
                                   ,casos
                                   ,fallecidos
                                   ,vacunados
                                   ,centrosVacunacion
                                   ,fechaRegistro
                                   ,digitador)
                                    VALUES
                                   (@provincia, @casos, @fallecidos, @vacunados,
                                    @centrosVacunacion, @fechaRegistro,
                                    @digitador);
                                    select scope_identity();";
                cmd.Parameters.AddWithValue("@provincia", entidad.Provincia);
                cmd.Parameters.AddWithValue("@casos", entidad.Casos);
                cmd.Parameters.AddWithValue("@fallecidos", entidad.Fallecidos);
                cmd.Parameters.AddWithValue("@vacunados", entidad.Vacunados);
                cmd.Parameters.AddWithValue("@centrosVacunacion", entidad.CentrosVacunacion);
                cmd.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);
                cmd.Parameters.AddWithValue("@digitador", entidad.Digitador);
                cmd.ExecuteNonQuery();
                c.Close();
                return true;
            } catch (Exception e) {
                Console.WriteLine("error -------: " + e);
                return false;
            }
        }
    }
}
