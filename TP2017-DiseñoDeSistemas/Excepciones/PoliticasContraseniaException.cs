﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PoliticasContraseniaException : System.Exception
    {
        public PoliticasContraseniaException() : base("No se cumplen las politicas de contraseña")
        {

        }
    }
}
