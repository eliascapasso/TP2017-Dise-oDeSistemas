using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class GestorDePoliticaDeContrasenia
    {
        public GestorDePoliticaDeContrasenia()
        {

        }

        public Boolean comprobarPoliticas(String pass)
        {
            return (pass.Length >= 8) && 
                (poseeCaracterEspecial(pass)) && 
                (pass.Any(c => char.IsUpper(c))) && 
                (pass.Any(c => char.IsDigit(c)));
        }

        private Boolean poseeCaracterEspecial(String texto)
        {
            var lista = new[] { "@", "#", "$", "%", "&", "*" };
            return lista.Any(texto.Contains);
        }
    }
}
