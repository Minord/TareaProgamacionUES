using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace GestorBancarioUES
{
    public sealed class DataBase
    {
        private static string conectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Orellana\\source\\repos\\GestorBancarioUES\\GestorBancarioUES\\data\\ProyectoBancario.accdb;Persist Security Info=True";

        public static int IUDCommand(string sql_command) {
            int affected_id = -1;
            using (OleDbConnection conexion = new OleDbConnection(conectionString))
            {
                OleDbCommand comando = new OleDbCommand(sql_command);
                OleDbCommand comando_last_id = new OleDbCommand("SELECT @@Identity");

                comando.Connection = conexion;
                comando_last_id.Connection = conexion;

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    affected_id = Convert.ToInt32(comando_last_id.ExecuteScalar());

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // la conexion se cierra automaticamente por usar el bloque using
            }
            return affected_id;
        }
        public static DataTable SelectCommand(string sql_command) {
            DataTable result = new DataTable();
            using (OleDbConnection conexion = new OleDbConnection(conectionString)) {
                OleDbCommand comando = new OleDbCommand(sql_command);
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    result.Load(comando.ExecuteReader());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // la conexion se cierra automaticamente por usar el bloque using
            }
            return result;
        }

        public static int getPuntosByUser(int id) {
            int result = 0;

            using (OleDbConnection conexion = new OleDbConnection(conectionString))
            {
                OleDbCommand comando = new OleDbCommand(string.Format("SELECT SUM(cantidad) FROM Puntos WHERE usuario_id = {0}", id));
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    result = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // la conexion se cierra automaticamente por usar el bloque using
            }

            return result;
        }

    }
}
