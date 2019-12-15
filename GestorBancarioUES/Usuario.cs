using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestorBancarioUES
{
    /*
        Esta implementacion es probicional
        se tiene que cambier por una implementacion
        completa
    */

    public class Usuario
    {

        public string nombres;
        public string apellidos;
        public int edad;
        public string recidencia;
        public string telefono;
        public string email;
        public List<Tarjeta> tarjetas;
        public int usuario_id;

        public Usuario(string nombres, string apellidos,
                       int edad, string recidencia,
                       string telefono, string email, int usuario_id) {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.recidencia = recidencia;
            this.telefono = telefono;
            this.email = email;
            this.usuario_id = usuario_id;
        }

       

        public string nombreCompleto()
        {
            return string.Format("{0} {1}", nombres, apellidos);
        }

        public int registrarEnDB()
        {
            string sql_command = string.Format("INSERT INTO Usuarios (nombres, apellidos, edad, residencia, telefono, email) VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')",
                                               nombres, apellidos, edad, recidencia, telefono, email);
            return DataBase.IUDCommand(sql_command);
        }

        public void actualizarUsuario() {
            string sql_command = string.Format("UPDATE Usuarios SET nombres = '{1}', apellidos = '{2}', edad = {3}, residencia = '{4}', telefono = '{5}', email = '{6}' WHERE usuario_id = {0}",
                                              usuario_id, nombres, apellidos, edad, recidencia, telefono, email);

            DataBase.IUDCommand(sql_command);
        }

        static public Usuario buscarEnDBPorId(int id) {
            string sql_command = string.Format("SELECT * from Usuarios WHERE usuario_id = {0}", id);

            DataTable datos = DataBase.SelectCommand(sql_command);

            if (datos.Rows.Count < 1)
            {
                Console.WriteLine("Error no se encontro ningun registro en buscar usario por id");
                return null;
            }

            DataRow fistRow = datos.Rows[0];

            string nombres = fistRow["nombres"].ToString();
            string apellidos = fistRow["apellidos"].ToString();
            int edad = Convert.ToInt32(fistRow["edad"]);
            string recidencia = fistRow["residencia"].ToString();
            string telefono = fistRow["telefono"].ToString();
            string email = fistRow["email"].ToString();

            return new Usuario(nombres, apellidos,
                               edad, recidencia,
                               telefono, email, id);
        }

        static public DataTable buscarEnDBPorIdTable(int id)
        {
            string sql_command = string.Format("SELECT * from Usuarios WHERE usuario_id = {0}", id);

            return DataBase.SelectCommand(sql_command);
        }

        static public DataTable buscarEnDBPorNombre(string stringBusqueda) {

            string sql_command = string.Format("SELECT * FROM Usuarios WHERE nombres LIKE '%{0}%' OR apellidos LIKE '%{0}%'", stringBusqueda);

            return DataBase.SelectCommand(sql_command);
        }

        public int getPuntos() {
            return DataBase.getPuntosByUser(usuario_id);
        }

        


    }
}
