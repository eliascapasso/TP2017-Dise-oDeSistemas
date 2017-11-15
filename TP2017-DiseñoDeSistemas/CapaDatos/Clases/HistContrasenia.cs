namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class HistContrasenia
    {
        
        public HistContrasenia(string pass, int idUsu)
        {
            this.contrasenia = pass;
            this.id_usuario = idUsu;
            this.fecha_creacion = DateTime.Now;
        }
    }
}
