namespace CapaPresentacion
{
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

        private void RegistrarReserva_2_Load(object sender, EventArgs e)
        {
            this.llenarTabControl();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indicePestaniaSeleccionada = tcPestañasDias.SelectedIndex;
            DataGridView dataGridActual = this.listaAulasDisponibles[indicePestaniaSeleccionada];

            DataGridViewRow aulaDisponibleSeleccionada = dataGridActual.CurrentRow; // Obtengo la fila actualmente seleccionada en el dataGrid de las aulas disponibles

            string columnaDia = tcPestañasDias.SelectedTab.Name;
            string columnaAula = Convert.ToString(aulaDisponibleSeleccionada.Cells[0].Value);
            string columnaDuracion = Convert.ToString(aulaDisponibleSeleccionada.Cells[1].Value);
            string columnaCapacidad = Convert.ToString(aulaDisponibleSeleccionada.Cells[2].Value);

            AddToDatagrid(columnaDia, columnaAula, columnaDuracion, columnaCapacidad);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow aulaSeleccionada = this.dgvAulasSeleccionadas.CurrentRow; // Obtengo la fila actualmente seleccionada en el dataGrid de las aulas seleccionadas

            this.dgvAulasSeleccionadas.Rows.Remove(aulaSeleccionada);
            this.dgvAulasSeleccionadas.Refresh();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvAulasSeleccionadas.Rows.Count == 0) //No se selecciona ningun aula
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("No seleccionó ningún aula", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    this.gestorReserva.registrarReserva(reservaDTO);

                    System.Media.SystemSounds.Hand.Play();
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea guardar la reserva?", 
                                                             "Reserva", 
                                                             MessageBoxButtons.YesNo, 
                                                             MessageBoxIcon.Question);

                    if (respuesta.Equals(DialogResult.Yes))
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Reserva almacenada con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private HashSet<CuatrimestreDTO> obtenerTodosLosPeriodos()
        {
            return gestorAnio.obtenerTodosLosPeriodos();
        }

        private void llenarTabControl()
        {
            obtenerDisponibilidad = new ObtenerDisponibilidadAula(this, this.obtenerTodosLosPeriodos());

            HashSet<AulaDTO> disponibilidad = obtenerDisponibilidad.obtenerDisponibilidad(reservaDTO); /*Obtiene una lista con las aulas que 
                                                                                                      estan disponibles para todos los dias 
                                                                                                      (CU ObtenerDisponibilidad)*/
            foreach (DetalleReservaDTO detalleReserva in reservaDTO.detallesReservas)
            {
                string dia = Convert.ToString(detalleReserva.diaReserva); //Obtengo el valor de la primer columna (dia)
                DataGridView dgvAulasDisponibles = new DataGridView();

                //Propiedades del dataGrid
                dgvAulasDisponibles.Size = tcPestañasDias.Size;
                dgvAulasDisponibles.AllowUserToAddRows = false;
                dgvAulasDisponibles.AllowUserToDeleteRows = false;

                //Se asignan los nombres de cada columna
                dgvAulasDisponibles.Columns.Add("Aula", "Aula");
                dgvAulasDisponibles.Columns.Add("Capacidad", "Capacidad");
                dgvAulasDisponibles.Columns.Add("Caracteristicas", "Caracteristicas");

                //Se agregan las filas
                foreach (AulaDTO aulaDisponible in disponibilidad)
                {
                    if (aulaDisponible.detalleReserva.diaReserva.Equals(dia)) //Compara que el dia del aula sea igual al dia de la pestaña
                    {
                        dgvAulasDisponibles.Rows.Add(aulaDisponible.idAula, aulaDisponible.capacidad, "");
                    }
                } 

                //TODO: obtener idAula del datagrid de aulas seleccionadas y setear en reservadto parecido a idDocente en reserva 1 (Buscar)
                
                TabPage pestania = new TabPage(dia);
                pestania.Name = dia;
                pestania.Controls.Add(dgvAulasDisponibles);

                tcPestañasDias.TabPages.Add(pestania); //Agrego una pestaña nueva con su respectivo dataGrid

                this.listaAulasDisponibles.Add(dgvAulasDisponibles);
            }
        }

        private void timerReserva_Tick(object sender, EventArgs e)
        {
            //Cada vez que se abre reserva 2 se contara con 10 min antes de que se cierre, por disponibilidad.
            this.Close();
            padre.Show();
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
                foreach (DetalleReservaDTO detalle in reservaDTO.detallesReservas)
                {
                    if (detalle.diaReserva.Equals(fecha))
                    {
                        detalle.idAula = Convert.ToInt32(aula); 
                        //Console.Write(detalle.idAula + "\n");
                    }
                }
                dgvAulasSeleccionadas.Rows.Add(fecha, aula, duracion, capacidad);
            }
        }
    }
}
