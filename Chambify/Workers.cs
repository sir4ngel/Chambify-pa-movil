using System;
using System.Collections.Generic;
using System.Text;

namespace Chambify
{
    class Workers
    {
        private int id;
        private string usuario;
        private string nombre;
        private string oficio;
        private int edad;
        private string correo;
        private int id_tipo;
        private string fecha;
        private string hora;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Oficio { get => oficio; set => oficio = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
