using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public /*abstract*/ class Usuario
    {
        private string nombreUsuario;
        private string contrasenia;
        private string nombre;
        private int tipoDeUsuario;

        

        public Usuario(string nombreUsuario, string contrasenia, string nombre)
        {
            this.NombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.nombre = nombre;
        }
        public Usuario(string nombreUsuario, string contrasenia, string nombre, int tipoDeUsuario)
        : this (nombreUsuario,contrasenia ,nombre)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.nombre = nombre;
            this.tipoDeUsuario = tipoDeUsuario; 
        }



        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
    }
}
