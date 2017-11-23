namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class Bedel : Usuario
    {
        public Bedel() {
            this.HistContrasenias = new HashSet<HistContrasenia>();
        }

        public Bedel(string nick, string pass, string nombre, string apellido, string turno)
        {
            this.nick = nick;
            this.contrasenia = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.turno = turno;
            this.activo = true;
            this.id_tipo_usuario = 1;

            this.HistContrasenias = new HashSet<HistContrasenia>();
        }
        public void setValores(string nombre, string apellido, string turno, string pass)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.contrasenia = pass;
            this.turno = turno;
        }
    }
}
