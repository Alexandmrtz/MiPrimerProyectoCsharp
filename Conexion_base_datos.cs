using System;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace GestionDocentes
{
    public class Conexion_base_datos
    {
        public DataSet ds = new DataSet();
        public DataTable usuariosTable;
        private readonly string jsonPath;
        private int nextId = 1;

        public Conexion_base_datos()
        {
            // Archivo JSON en la carpeta de la aplicación
            jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.json");
            crearDs();
        }

        // Representación simple para serializar/deserializar
        private class UsuarioJson
        {
            public int idUsuario { get; set; }
            public string usuario { get; set; }
            public string clave { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
        }

        public void crearDs()
        {
            // Si ya existe la tabla en ds, salir
            if (ds.Tables.Contains("usuarios"))
            {
                usuariosTable = ds.Tables["usuarios"];
                // recalcular nextId
                if (usuariosTable.Rows.Count > 0)
                {
                    int max = 0;
                    foreach (DataRow r in usuariosTable.Rows)
                        max = Math.Max(max, Convert.ToInt32(r["idUsuario"]));
                    nextId = max + 1;
                }
                return;
            }

            usuariosTable = new DataTable("usuarios");
            usuariosTable.Columns.Add("idUsuario", typeof(int));
            usuariosTable.Columns["idUsuario"].AutoIncrement = false; // manejamos manualmente
            usuariosTable.Columns.Add("usuario", typeof(string));
            usuariosTable.Columns.Add("clave", typeof(string));
            usuariosTable.Columns.Add("nombre", typeof(string));
            usuariosTable.Columns.Add("direccion", typeof(string));
            usuariosTable.Columns.Add("telefono", typeof(string));

            // Cargar desde JSON si existe
            if (File.Exists(jsonPath))
            {
                try
                {
                    string json = File.ReadAllText(jsonPath);
                    var list = JsonSerializer.Deserialize<List<UsuarioJson>>(json);
                    if (list != null)
                    {
                        foreach (var u in list)
                        {
                            usuariosTable.Rows.Add(u.idUsuario, u.usuario, u.clave, u.nombre, u.direccion, u.telefono);
                            if (u.idUsuario >= nextId) nextId = u.idUsuario + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si falla la lectura, caer a los usuarios de ejemplo
                    Console.WriteLine("Error leyendo usuarios.json: " + ex.Message);
                    AgregarEjemplos();
                }
            }
            else
            {
                AgregarEjemplos();
            }

            ds.Tables.Add(usuariosTable);
        }

        private void AgregarEjemplos()
        {
            usuariosTable.Rows.Add(nextId++, "alumno01", "Pass123", "Juan Perez", "123456789");
            usuariosTable.Rows.Add(nextId++, "profesor1", "Abc12345", "María López", "987654321");
            usuariosTable.Rows.Add(nextId++, "adminuser", "Adm1n2025", "Administrador", "555123456");
        }

        // 'procesar' ahora serializa la tabla a JSON
        public void procesar()
        {
            try
            {
                var list = new List<UsuarioJson>();
                foreach (DataRow r in usuariosTable.Rows)
                {
                    // Si la fila está marcada para borrar, saltarla
                    if (r.RowState == DataRowState.Deleted) continue;

                    int id = r.Field<int>("idUsuario");
                    string usuario = r.Field<string>("usuario") ?? "";
                    string clave = r.Field<string>("clave") ?? "";
                    string nombre = r.Field<string>("nombre") ?? "";
                    string direccion = r.Field<string>("direccion") ?? "";
                    string telefono = r.Field<string>("telefono") ?? "";

                    list.Add(new UsuarioJson
                    {
                        idUsuario = id,
                        usuario = usuario,
                        clave = clave,
                        nombre = nombre,
                        direccion = direccion,
                        telefono = telefono
                    });
                }

                // También tenemos que procesar filas nuevas que no tengan id asignado (si existe)
                // Para simplicidad asumimos que filas nuevas se crearon con idUsuario = 0 -> asignarlas aquí
                foreach (DataRow r in usuariosTable.Rows)
                {
                    if (r.RowState == DataRowState.Added)
                    {
                        // Si idUsuario está vacío o 0, asignar nextId
                        object o = r["idUsuario"];
                        int idVal = 0;
                        if (o != DBNull.Value)
                        {
                            int.TryParse(o.ToString(), out idVal);
                        }
                        if (idVal == 0)
                        {
                            r["idUsuario"] = nextId++;
                        }
                    }
                }

                // Rebuild list after assigning ids
                list.Clear();
                foreach (DataRow r in usuariosTable.Rows)
                {
                    if (r.RowState == DataRowState.Deleted) continue;
                    list.Add(new UsuarioJson
                    {
                        idUsuario = Convert.ToInt32(r["idUsuario"]),
                        usuario = r["usuario"]?.ToString() ?? "",
                        clave = r["clave"]?.ToString() ?? "",
                        nombre = r["nombre"]?.ToString() ?? "",
                        direccion = r["direccion"]?.ToString() ?? "",
                        telefono = r["telefono"]?.ToString() ?? ""
                    });
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(list, options);
                File.WriteAllText(jsonPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error guardando usuarios.json: " + ex.Message);
                // En app real, mostrar mensaje o log
            }
        }

        // mantenimiento_usuarios llama a procesar (persistencia)
        public void mantenimiento_usuarios()
        {
            procesar();
        }

        // Validar usuario/clave contra la tabla
        public bool validarUsuario(string usuario, string clave, out string nombre)
        {
            nombre = string.Empty;
            if (usuariosTable == null) crearDs();

            foreach (DataRow r in usuariosTable.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                var u = r.Field<string>("usuario") ?? "";
                var c = r.Field<string>("clave") ?? "";
                if (u.Equals(usuario, StringComparison.OrdinalIgnoreCase) && c == clave)
                {
                    nombre = r.Field<string>("nombre") ?? usuario;
                    return true;
                }
            }
            return false;
        }

        // Validación simple de contraseña
        public bool claveValida(string clave)
        {
            if (string.IsNullOrEmpty(clave)) return false;
            bool tieneLetra = Regex.IsMatch(clave, "[A-Za-z]");
            bool tieneNumero = Regex.IsMatch(clave, "[0-9]");
            return tieneLetra && tieneNumero;
        }
    }
}
