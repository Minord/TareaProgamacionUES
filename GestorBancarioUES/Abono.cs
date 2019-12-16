using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBancarioUES
{
    public class Abono : Transaccion
    {
        public Abono(int tarjeta_id, float monto) : base(tarjeta_id, monto) {

        }

        public int registrarAbono() {
            string command_string = string.Format("INSERT INTO Transacciones (tarjeta_id, cantidad, tipo, fecha_hora) VALUES ({0}, {1}, '{2}', #{3}#)",
                                                  tarjeta_id, monto, "abono", DateTime.Now.ToString());
            return DataBase.IUDCommand(command_string);
        }
    }
}
