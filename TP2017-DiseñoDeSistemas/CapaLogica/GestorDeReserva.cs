using CapaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class GestorDeReserva
    {
        private GestorDeAula gestorAula;

        public GestorDeReserva()
        {
            this.gestorAula = new GestorDeAula();
        }

        public void registrarReserva(ReservaDTO reservaDTO)
        {
            HashSet<AulaDTO> disponibilidad = new HashSet<AulaDTO>();

            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservas)
            { //TODO: ver como concatenar al agregar aula DTO
                AulaDTO aulaDTO = new AulaDTO(reservaDTO.cantAlumnos,
                                      reservaDTO.idTipoAula,
                                      detalleReserva,
                                      reservaDTO.tipoReserva,
                                      detalleReserva.periodo);

                foreach (AulaDTO aulaDisponible in gestorAula.obtenerDisponibilidad(aulaDTO))
                {
                    disponibilidad.Add(aulaDisponible);
                }
            }
        } 
    }
}
