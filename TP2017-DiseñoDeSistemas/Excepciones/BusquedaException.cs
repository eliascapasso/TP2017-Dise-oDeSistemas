﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BusquedaException : System.Exception
    {
        public BusquedaException() : base("Error: El nick ingresado ya existe")
        {

        }
    }
}
