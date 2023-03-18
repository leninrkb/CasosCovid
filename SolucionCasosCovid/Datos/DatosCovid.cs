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
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
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
                conexion.Close();
                return true;
            } catch {
                return false;
            }
        }
        public static List<EntidadRegistroCasos> ObtenerTodosLosRegistros() {

            try {
                List<EntidadRegistroCasos> registros = new List<EntidadRegistroCasos>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
                SqlCommand comando = new SqlCommand("SELECT * FROM RegistroCasos", conexion);
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read()) {
                    EntidadRegistroCasos registro = new EntidadRegistroCasos {
                        Id = int.Parse(reader["id"].ToString()),
                        Provincia = reader["provincia"].ToString(),
                        Casos = int.Parse(reader["casos"].ToString()),
                        Fallecidos = int.Parse(reader["fallecidos"].ToString()),
                        CentrosVacunacion = int.Parse(reader["centrosVacunacion"].ToString()),
                        Vacunados = int.Parse(reader["vacunados"].ToString()),
                        FechaRegistro = DateTime.Parse(reader["fechaRegistro"].ToString()),
                        Digitador = reader["digitador"].ToString()
                    };
                    registros.Add(registro);
                }
                reader.Close();
                conexion.Close();
                return registros;
            } catch {
                return null;
            }
        }

    }
}
