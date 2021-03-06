﻿using CapaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AnioLectivoDAODB : AnioLectivoDAO
    {
        public AnioLectivoDAODB() { }

        public List<CuatrimestreDTO> obtenerTodosLosPeriodos()
        {
            List<CuatrimestreDTO> periodos = new List<CuatrimestreDTO>();

            using (TP2017Entities bd = new TP2017Entities())
            {
                foreach(Cuatrimestre cuat in bd.Cuatrimestres)
                {
                    periodos.Add(new CuatrimestreDTO(cuat.fecha_inicio, 
                                                     cuat.fecha_fin, 
                                                     cuat.AnioLectivo_id_anio_lectivo, 
                                                     cuat.id_cuatrimestre));
                }
            }
            periodos.Sort();
            return periodos;
        }
    }
}
