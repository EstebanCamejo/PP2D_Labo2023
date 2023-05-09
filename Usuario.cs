using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPLabo2_2D
{
    public abstract class Usuario
    {
        private string nombreUsuario;
        private string contrasenia;
        private string nombre;

        public Usuario(string nombreUsuario, string contraseña, string nombre)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contraseña;
            this.nombre = nombre;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
