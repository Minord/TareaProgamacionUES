using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBancarioUES
{
    public sealed class DataBase
    {
        private static string conection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Orellana\\source\\repos\\GestorBancarioUES\\GestorBancarioUES\\data\\ProyectoBancario.accdb;Persist Security Info=True";

        private static DataBase instance = null;

        private DataBase() {

        }

        public DataBase GetInstance() {
            if (instance == null) {
                instance = new DataBase();
            }
            return instance;
        }

        public void InsertCommand() {

        }

        public void DeleteCommand() {


        }

        public void UpdateCommand() {

        }

        public void SelectCommand() {

        }

    }
}
