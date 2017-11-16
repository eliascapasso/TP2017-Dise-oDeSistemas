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
            this.nombre = nombre;
            this.apellido = apellido;
            this.turno = turno;
            this.activo = true;

            this.HistContrasenias = new HashSet<HistContrasenia>();
            this.Reservas = new HashSet<Reserva>();
        }

        //Agrega un historial a la lista de historiales del bedel creado
        public void agregarHistorial(HistContrasenia historial)
        {
            this.HistContrasenias.Add(historial);
        }
    }
}
