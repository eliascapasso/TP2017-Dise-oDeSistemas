namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class HistContrasenia
    {
        public HistContrasenia()
        {

        }

        public HistContrasenia(string pass, Usuario usuario)
        {
            this.contrasenia = pass;
            this.Usuario = usuario;
            this.id_usuario = usuario.id_usuario;
            this.fecha_creacion = DateTime.Now;
        }
    }
}
