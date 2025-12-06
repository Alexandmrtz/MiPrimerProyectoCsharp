using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria para usar comando para trabajar con BD
using System.Data.SqlClient; //Esta libreria permite trabajar con SQL Server
namespace miPrimerProyectoCsharp
{
    internal class Conexion
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Puente entre la BD y la App
        DataSet objDs = new DataSet(); //Representacion de la arquitectura de la BD en memoria
        public Conexion() //Constructor //Inicializador de los atributos
        {
            String cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_maestros.mdf;Integrated Security=True"; 
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD    
        }
        public DataSet obtenerDatosAlumno()
        {
            objDs.Clear(); //Limpia el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar comandos

            objAdaptador.SelectCommand = objComando; //Establece el comando de seleccion
            objComando.CommandText = "SELECT * FROM alumnos"; //Seleccionar todo de una tabla
            objAdaptador.Fill(objDs, "alumnos"); //Tomando los datos de la BD y llenando DataSet

            return objDs;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo = @codigo, nombre = @nombre, direccion = @direccion, telefono = @telefono WHERE idAlumno = @idAlumno";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno = @idAlumno";
            }
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idAlumno", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataSet obtenerDatosDocente()
        {
            objDs.Clear(); //Limpia el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar comandos

            objAdaptador.SelectCommand = objComando; //Establece el comando de seleccion
            objComando.CommandText = "SELECT * FROM docentes"; //Seleccionar todo de una tabla
            objAdaptador.Fill(objDs, "docentes"); //Tomando los datos de la BD y llenando DataSet

            return objDs;
        }
        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO docentes (codigo, nombre, asignatura, direccion, telefono) VALUES (@codigo, @nombre, @asignatura, @direccion, @telefono)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET codigo = @codigo, nombre = @nombre, asignatura = @asignatura, direccion = @direccion, telefono = @telefono WHERE idDocente = @idDocente";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente = @idDocente";
            }
            return ejecutarSQLDocente(sql, datos);
        }
        private String ejecutarSQLDocente(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idDocente", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@asignatura", datos[3]);
                objComando.Parameters.AddWithValue("@direccion", datos[4]);
                objComando.Parameters.AddWithValue("@telefono", datos[5]);

                return objComando.ExecuteNonQuery().ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
