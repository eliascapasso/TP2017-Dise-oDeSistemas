namespace CapaDatos
{
    using System;
    using System.Collections.Generic;

    public partial class Usuario
    {
        public Usuario(string nick, string pass, string nombre, string apellido, string turno)
        {
            this.nick = nick;
            this.contrasenia = pass;
            this.activo = true;

            this.HistContrasenias = new HashSet<HistContrasenia>();

        }

        //Agrega un historial a la lista de historiales del bedel creado
        public void agregarHistorial(HistContrasenia historial)
        {
            this.HistContrasenias.Add(historial);
        }
    }
}
