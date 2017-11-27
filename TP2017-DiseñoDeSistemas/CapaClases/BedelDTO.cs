namespace CapaClases
{
    using System;
    using System.Collections.Generic;

    public partial class BedelDTO
    {
        public string nick;
        public string contrasenia;
        public string nombre;
        public string apellido;
        public string turno;
        public bool vacio;

        public BedelDTO()
        {
            this.vacio = true;
        }

        public BedelDTO(string nick, string pass, string nombre, string apellido, string turno)
        {
            this.nick = nick;
            this.contrasenia = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.turno = turno;

            this.vacio = false;
        }
    }
}