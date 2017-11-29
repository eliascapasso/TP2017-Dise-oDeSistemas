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


    public partial class RegistrarReserva_2 : Form
    {
        private Form padre;
        private ReservaDTO reservaDTO; /*reservaDTO.fechas -> Columna 1: Dia, Columna 2: horaInicio, Columna 3: duracion*/
 
        private List<DataGridView> listaAulasDisponibles = new List<DataGridView>();
        private GestorDeAula gestorAula = new GestorDeAula();


        public RegistrarReserva_2(Form papa,ReservaDTO reservaDTO)
        {

            this.reservaDTO = reservaDTO;
            padre = papa;
            InitializeComponent();
        }
        public RegistrarReserva_2(Form papa)
        {
            padre = papa;
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            padre.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            padre.Close();
            this.Close();
        }

        private void RegistrarReserva_2_Load(object sender, EventArgs e)
        {
            //EJECUTAR OBTENER DISPONIBILIDAD EN EL METODO llenarTabControl()??

            this.llenarTabControl();
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

            if (this.existeDia(columnaDia)) //Valida que en el dataGrid de aulas seleccionadas no exista el dia seleccionado
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Ya agregó un aula en este día", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dgvAulasSeleccionadas.Rows.Add(columnaDia, columnaAula, columnaDuracion, columnaCapacidad);
            }
        }
        
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow aulaSeleccionada = this.dgvAulasSeleccionadas.CurrentRow; // Obtengo la fila actualmente seleccionada en el dataGrid de las aulas seleccionadas

            this.dgvAulasSeleccionadas.Rows.Remove(aulaSeleccionada);
            this.dgvAulasSeleccionadas.Refresh();
        }

        //METODOS PROPIOS

        private void llenarTabControl()
        {

            foreach (DataGridViewRow fila in reservaDTO.fechas)
            {
                string dia = Convert.ToString(fila.Cells[0].Value); //Obtengo el valor de la primer columna (dia)
                HashSet<DataGridViewRow> disponibilidad = gestorAula.obtenerDisponibilidad(reservaDTO); //Obtiene una lista con las aulas que estan disponibles (CU ObtenerDisponibilidad)

                DataGridView dgvAulasDisponibles = new DataGridView();

                //Propiedades del dataGrid
                dgvAulasDisponibles.Size = tcPestañasDias.Size;
                dgvAulasDisponibles.AllowUserToAddRows = false;
                dgvAulasDisponibles.AllowUserToDeleteRows = false;

                //Se asignan los nombres de cada columna
                dgvAulasDisponibles.Columns.Add("Aula", "Aula");
                dgvAulasDisponibles.Columns.Add("Ubicación", "Ubicación");
                dgvAulasDisponibles.Columns.Add("Capacidad", "Capacidad");

                //Se agregan las filas
                foreach (DataGridViewRow aulaDisponible in disponibilidad)
                {
                    dgvAulasDisponibles.Rows.Add(aulaDisponible);
                }
                //TODO: Mariano: validar datagrid reserva 1 para no poder agregar dos veces lo mismo, validar en reserva 1 que no se pueda agregar dos tipos de reserva, obtener idAula del datagrid de aulas seleccionadas y setear en reservadto parecido a idDocente en reserva 1 (Buscar)
                ////PRUEBAS
                //dgvAulasDisponibles.Rows.Add("hola", "k ace", "asd");
                //dgvAulasDisponibles.Rows.Add("chau", "nada", "blabla");
                //dgvAulasDisponibles.Rows.Add("asda", "elco", "pato");

                TabPage pestania = new TabPage(dia);
                pestania.Name = dia;
                pestania.Controls.Add(dgvAulasDisponibles);

                tcPestañasDias.TabPages.Add(pestania); //Agrego una pestaña nueva con su respectivo dataGrid

                this.listaAulasDisponibles.Add(dgvAulasDisponibles);
            }
        }

        private bool existeDia(string dia)
        {
            foreach (DataGridViewRow fila in this.dgvAulasSeleccionadas.Rows)
            {
                string diaFila = Convert.ToString(fila.Cells[0].Value);
                if (diaFila.Equals(dia))
                {
                    return true;
                }
            }
            return false;
        }

        private void timerReserva_Tick(object sender, EventArgs e)
        {
            //Cada vez que se abre reserva 2 se contara con 10 min antes de que se cierre, por disponibilidad.
            this.Close();
            padre.Show();
        }
    }
}
