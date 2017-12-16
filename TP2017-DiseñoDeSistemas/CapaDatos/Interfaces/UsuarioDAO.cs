using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public interface UsuarioDAO
    {
        ArrayList obtenerBedeles(string apellido, string turno);
        Bedel obtenerBedel(string nickActual);
        bool existeUsuario(string nickActual, string pass);
        void guardarBedelModificado(Bedel bedel);
        bool comprobarNickRepetido(string nick);
        void guardarBedel(Bedel bedel);
        void eliminarBedel(string nick);
    }
}
