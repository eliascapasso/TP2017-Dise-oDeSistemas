namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class Bedel : Usuario
    {
        public Bedel() { }

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
    }
}
