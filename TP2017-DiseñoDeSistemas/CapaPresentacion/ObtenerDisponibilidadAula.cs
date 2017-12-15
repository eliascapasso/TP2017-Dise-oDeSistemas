using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaClases;

namespace CapaPresentacion
{
    public partial class ObtenerDisponibilidadAula : Form
    {
        private Form padre;
        private GestorDeAula gestorAula;
        private HashSet<CuatrimestreDTO> todosLosPeriodos;

        public ObtenerDisponibilidadAula(Form papa, HashSet<CuatrimestreDTO> todosLosPeriodos)
        {
            this.todosLosPeriodos = todosLosPeriodos;
            this.padre = papa;
            this.gestorAula = new GestorDeAula();
            InitializeComponent();
        }

        public HashSet<AulaDTO> obtenerDisponibilidad(ReservaDTO reservaDTO)
        {
            HashSet<AulaDTO> disponibilidad = new HashSet<AulaDTO>();

            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservas)
            { 
                AulaDTO aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                              reservaDTO.idTipoAula,
                                              detalleReserva,
                                              reservaDTO.tipoReserva,
                                              gestorAula.calcularPeriodo(detalleReserva, reservaDTO.tipoReserva));
                
                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    disponibilidad.Add(aulaDisponible);
                }
            }
            
            return disponibilidad;
        }

        
    }
}
