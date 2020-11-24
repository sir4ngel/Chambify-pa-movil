using System;
using System.Collections.Generic;
using System.Text;

namespace Chambify
{
    class Users
    {
        private int id;
        private string usuario;
        private string contrasena;
        private string nombre;
        private string correo;
        private int id_tipo;
        private string fecha;
        private string hora;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
