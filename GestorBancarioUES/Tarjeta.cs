using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestorBancarioUES
{
    public class Tarjeta
    {

        int usuario_id;
        int numero_de_cuenta;
        string tipo;
        int tarjeta_id = -1;
        public Tarjeta(int usuario_id, int numero_de_cuenta, string tipo, int tarjeta_id ) {
            this.usuario_id = usuario_id;
            this.numero_de_cuenta = numero_de_cuenta;
            this.tipo = tipo;
            this.tarjeta_id = tarjeta_id;
        }

        public int registarTarjeta() {
            string sql_command = string.Format("INSERT INTO Tarjetas (usuario_id, numero_de_cuenta, tipo, fecha_hora) VALUES ({0},{1},'{2}',#{3}#)",
                                 usuario_id, numero_de_cuenta, tipo, DateTime.Now.ToString());
            return DataBase.IUDCommand(sql_command);
        }

        public static int borrarTarjetaPorID(int tarjeta_id) {
            string sql_commanf = string.Format("DELETE FROM Tarjetas WHERE tarjeta_id = {0}", tarjeta_id);
            return DataBase.IUDCommand(sql_commanf);
        }

        public static Tarjeta getTargetaEnDBporID(int tarjeta_id) {
            string sql_command = string.Format("SELECT * from Tarjetas WHERE tarjeta_id = {0}", tarjeta_id);

            DataTable datos = DataBase.SelectCommand(sql_command);

            if (datos.Rows.Count < 1)
            {
                Console.WriteLine("Error no se encontro ningun registro en buscar tarjetas por id");
                return null;
            }

            DataRow fistRow = datos.Rows[0];

            int usuario_id = Convert.ToInt32(fistRow["usuario_id"]);
            int numero_de_cuenta = Convert.ToInt32(fistRow["numero_de_cuenta"]);
            string tipo = fistRow["tipo"].ToString();

            return new Tarjeta(usuario_id, numero_de_cuenta, tipo, tarjeta_id);
        }

        public static DataTable getTargetasTablePorUsuarioID(int usuario_id) {
            string command_string = string.Format("SELECT tarjeta_id, numero_de_cuenta, tipo, fecha_hora  FROM Tarjetas WHERE usuario_id = {0}", usuario_id);

            return DataBase.SelectCommand(command_string);
        }

    }
}
