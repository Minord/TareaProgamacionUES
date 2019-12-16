using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestorBancarioUES
{
    public class Transaccion
    {
        protected int tarjeta_id;
        protected float monto;

        public Transaccion(int tarjeta_id, float monto) {
            this.tarjeta_id = tarjeta_id;
            this.monto = monto;
        }

        //obtener tabla de tanssac
        public static DataTable getTransaccionesTablePorUsuarioID(int usuario_id) {
            string command_string = string.Format("SELECT t.tarjeta_id, t.cantidad, t.tipo, t.fecha_hora FROM (SELECT ta.tarjeta_id FROM Tarjetas  AS ta WHERE ta.usuario_id = {0}) AS tid, Transacciones AS t WHERE t.tarjeta_id IN (tid.tarjeta_id)", usuario_id);
            return DataBase.SelectCommand(command_string);
        }


        //obetener balance total por usuario id
        public static float getBanlancePorUsuarioID(int usuario_id) {
            float result = 0;
            string command_string_abonos = string.Format("SELECT SUM (t.cantidad) FROM (SELECT ta.tarjeta_id FROM Tarjetas  AS ta WHERE ta.usuario_id = {0}) AS tid, Transacciones AS t WHERE t.tarjeta_id IN (tid.tarjeta_id) AND t.tipo = 'abono' ", usuario_id);
            string command_string_retiros = string.Format("SELECT SUM (t.cantidad) FROM (SELECT ta.tarjeta_id FROM Tarjetas  AS ta WHERE ta.usuario_id = {0}) AS tid, Transacciones AS t WHERE t.tarjeta_id IN (tid.tarjeta_id) AND t.tipo = 'retiro' ", usuario_id);
            result = DataBase.numericResultSelect(command_string_abonos) - DataBase.numericResultSelect(command_string_retiros);
            return result;
        }
    }
}
