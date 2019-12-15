using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

       

        public string nombreCompleto()
        {
            return string.Format("{0} {1}", nombres, apellidos);
        }

        static void registrarEnDB()
        {
            //no hacer nada por el momento
            Console.WriteLine("Se registro el usuario con Id 0");
        }

        static public Usuario buscarEnDBPorId(int id) {
            return new Usuario("Qelin Porta","Mando loarez",
                               21, "Col Somewhere, Soyapango",
                               "0000-0000", "quelin@gmail.com", 0);
        }

        static public Usuario buscarEnDBPorNombre(string nombreText) {
            return null;
        }

        


    }
}
