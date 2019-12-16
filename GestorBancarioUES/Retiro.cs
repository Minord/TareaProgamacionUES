using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBancarioUES
{
    public class Retiro : Transaccion
    {
        public Retiro(int tarjeta_id, float monto) : base(tarjeta_id, monto) {

        }

        public int registrarRetiro() {
            string command_string = string.Format("INSERT INTO Transacciones (tarjeta_id, cantidad, tipo, fecha_hora) VALUES ({0}, {1}, '{2}', #{3}#)",
                                                  tarjeta_id, monto, "retiro", DateTime.Now.ToString());
            return DataBase.IUDCommand(command_string);
        }
    }
}
