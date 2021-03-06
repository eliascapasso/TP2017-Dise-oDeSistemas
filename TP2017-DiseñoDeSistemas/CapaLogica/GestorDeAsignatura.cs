﻿
using CapaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class GestorDeAsignatura
    {
        private AsignaturaDAODB asigDAODB;

        public GestorDeAsignatura()
        {
            this.asigDAODB = new AsignaturaDAODB();
        }

        public ArrayList obtenerAsignaturas()
        {
            return asigDAODB.obtenerAsignaturas();
        }

        public ArrayList obtenerTiposAsignatura()
        {
            return asigDAODB.obtenerTiposAsignatura();
        }
    }
}
