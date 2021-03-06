﻿
using Autenticacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaClases;
using CapaLogica;
using System.Collections;
using Excepciones;

namespace CapaPresentacion
{
    public partial class RegistrarReserva_2 : Form
    {
        private Form padre;
        private ReservaDTO reservaDTO; /*reservaDTO.fechas -> Columna 1: Dia, Columna 2: horaInicio, Columna 3: duracion*/
        private ObtenerDisponibilidadAula obtenerDisponibilidad;
        private GestorAnioLectivo gestorAnio = new GestorAnioLectivo();
        private List<DataGridView> listaAulasDisponibles = new List<DataGridView>();
        private GestorDeAula gestorAula = new GestorDeAula();
        GestorDeReserva gestorReserva = new GestorDeReserva();

        public RegistrarReserva_2(Form papa, ReservaDTO reservaDTO)
        {
            this.reservaDTO = reservaDTO;
            padre = papa;
            InitializeComponent();
        }

        public void RegistrarReserva_2_Load(object sender, EventArgs e)
        {
            this.llenarDgvPestanias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indicePestaniaSeleccionada = tcPestañasDias.SelectedIndex;
            DataGridView dataGridActual = this.listaAulasDisponibles[indicePestaniaSeleccionada];

            // Obtengo la fila actualmente seleccionada en el dataGrid de las aulas disponibles
            DataGridViewRow aulaDisponibleSeleccionada = dataGridActual.CurrentRow; 

            string columnaDia = tcPestañasDias.SelectedTab.Name;
            string columnaAula = Convert.ToString(aulaDisponibleSeleccionada.Cells[0].Value);
            string columnaDuracion = Convert.ToString(aulaDisponibleSeleccionada.Cells[1].Value);
            string columnaCapacidad = Convert.ToString(aulaDisponibleSeleccionada.Cells[2].Value);

            AddToDatagrid(columnaDia, columnaAula, columnaDuracion, columnaCapacidad);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Obtengo la fila actualmente seleccionada en el dataGrid de las aulas seleccionadas
            DataGridViewRow aulaSeleccionada = this.dgvAulasSeleccionadas.CurrentRow; 
            try
            {
                this.dgvAulasSeleccionadas.Rows.Remove(aulaSeleccionada);
                this.dgvAulasSeleccionadas.Refresh();
            }
            catch (ArgumentNullException n)
            {
                Console.WriteLine("No existen aulas seleccionadas por quitar. " + n.Message);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            padre.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            padre.Close();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAulasSeleccionadas.Rows.Count == 0) //No se selecciona ningun aula
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No seleccionó ningún aula", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(dgvAulasSeleccionadas.Rows.Count!=tcPestañasDias.TabCount)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Seleccione un aula para cada día", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    System.Media.SystemSounds.Hand.Play();
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea guardar la reserva?", 
                                                             "Reserva", 
                                                             MessageBoxButtons.YesNo, 
                                                             MessageBoxIcon.Question);

                    if (respuesta.Equals(DialogResult.Yes))
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Reserva almacenada con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.gestorReserva.registrarReserva(reservaDTO);
                        this.Close();
                    }
                }
                catch(DisponibilidadException d)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    MessageBox.Show(d.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        
        //METODOS PROPIOS

        private List<CuatrimestreDTO> obtenerTodosLosPeriodos()
        {
            return gestorAnio.obtenerTodosLosPeriodos();
        }

        private void configurarDgvAulasDisponibles(DataGridView dgvAulasDisponibles)
        {
            //Propiedades del dataGrid
            dgvAulasDisponibles.Size = tcPestañasDias.Size;
            dgvAulasDisponibles.AllowUserToAddRows = false;
            dgvAulasDisponibles.AllowUserToDeleteRows = false;
            dgvAulasDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAulasDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAulasDisponibles.ReadOnly = true;

            //Se asignan los nombres de cada columna
            dgvAulasDisponibles.Columns.Add("Aula", "Aula");
            dgvAulasDisponibles.Columns.Add("Capacidad", "Capacidad");
            dgvAulasDisponibles.Columns.Add("Caracteristicas", "Caracteristicas");
        }

        private void llenarDgvPestanias()
        {
            HashSet<AulaDTO> disponibilidad = this.obtenerAulasDisponibles();

            //Recorro todas las filas seleccionadas en la tabla de la primer pantalla de la reserva
            foreach (DetalleReservaDTO detalleReservaDTO in reservaDTO.detallesReservasDTOs)
            {
                string nombreDiaoFecha = Convert.ToString(detalleReservaDTO.diaOFecha); //Obtengo el valor de la primer columna (dia)
                DataGridView dgvAulasDisponibles = new DataGridView();

                this.configurarDgvAulasDisponibles(dgvAulasDisponibles);

                this.agregarFilasDgvAulasDisponibles(dgvAulasDisponibles, disponibilidad, nombreDiaoFecha);
                
                //En caso de que en alguno o en todos los dias no existan aulas disponibles
                if (dgvAulasDisponibles.Rows.Count == 0)
                {
                    MessageBox.Show("No existen aulas disponibles para completar la reserva", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    padre.Show();
                }

                this.configurarPestania(nombreDiaoFecha, dgvAulasDisponibles);                
                
                //Para poder posteriormente agregar aulas a la tabla de aulas seleccionadas
                this.listaAulasDisponibles.Add(dgvAulasDisponibles);
            }
        }

        private void configurarPestania(string nombreDiaoFecha, DataGridView dgvAulasDisponibles)
        {
            TabPage pestania = new TabPage(nombreDiaoFecha);
            pestania.Name = nombreDiaoFecha;
            pestania.Controls.Add(dgvAulasDisponibles);

            tcPestañasDias.TabPages.Add(pestania); //Agrego una pestaña nueva con su respectivo dataGrid
        }

        private void agregarFilasDgvAulasDisponibles(DataGridView dgvAulasDisponibles, HashSet<AulaDTO> disponibilidad, string nombreDiaoFecha)
        {
            //Se agregan las filas a la tabla de aulas disponibles
            foreach (AulaDTO aulaDisponible in disponibilidad)
            {
                if (aulaDisponible.detalleReserva.diaOFecha.Equals(nombreDiaoFecha)) //Compara que el dia del aula sea igual al dia de la pestaña
                {
                    dgvAulasDisponibles.Rows.Add(aulaDisponible.idAula, aulaDisponible.capacidad, "");
                }
            }
        }

        private HashSet<AulaDTO> obtenerAulasDisponibles()
        {
            obtenerDisponibilidad = new ObtenerDisponibilidadAula(this, this.obtenerTodosLosPeriodos());

            return obtenerDisponibilidad.obtenerDisponibilidad(reservaDTO); /*Obtiene una lista con las aulas que 
                                                                              estan disponibles para todos los dias 
                                                                              (CU ObtenerDisponibilidad)*/
        }
        
        private void AddToDatagrid(string fecha, string aula, string duracion, string capacidad)
        {
            List<DataGridViewRow> listaDeFilas = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvAulasSeleccionadas.Rows) listaDeFilas.Add(row);

            bool existe = listaDeFilas.Any(x => x.Cells[0].Value.Equals(fecha));

            if (existe)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No se puede agregar una fila igual a otra existente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DetalleReservaDTO detalle in reservaDTO.detallesReservasDTOs)
                {
                    if (detalle.diaOFecha.Equals(fecha))
                    {
                        detalle.idAula = Convert.ToInt32(aula); 
                       
                    }
                }
                dgvAulasSeleccionadas.Rows.Add(fecha, aula, duracion, capacidad);
            }
        }
    }
}
