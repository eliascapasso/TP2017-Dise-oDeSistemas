﻿using CapaDatos;
using CapaLogica;
using CapaPresentacion;
using Excepciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaClases;

namespace Autenticacion
{
    public partial class RegistrarReserva_1 : Form
    {
        private Form padre;
        private GestorDeUsuario gestorUsuario;
        private GestorDeAsignatura gestorAsignatura;
        private GestorDeAula gestorAula;
        private GestorDeDocente gestorDocente;
        public string nickBedel;
        private ArrayList docentes;
        private ArrayList asignaturas;

        public RegistrarReserva_1(Form papa, string nickBedel)
        {
            this.padre = papa;
            this.gestorUsuario = new GestorDeUsuario();
            this.gestorAsignatura = new GestorDeAsignatura();
            this.gestorAula = new GestorDeAula();
            this.gestorDocente = new GestorDeDocente();
            this.nickBedel = nickBedel;
            this.docentes = new ArrayList();
            this.asignaturas = new ArrayList();
            InitializeComponent();
        }

        public RegistrarReserva_1(Form papa)
        {
            this.padre = papa;
            this.gestorUsuario = new GestorDeUsuario();
            this.gestorAsignatura = new GestorDeAsignatura();
            this.gestorAula = new GestorDeAula();
            this.gestorDocente = new GestorDeDocente();
            this.docentes = new ArrayList();
            this.asignaturas = new ArrayList();
            InitializeComponent();
        }

        private void RegistrarReserva_1_Load(object sender, EventArgs e)
        {
            this.llenarHorasEnCombobox(cbHoraInicio, 7, 23,new DateTime());
            this.llenarTiposAulaEnComboBox();
            this.llenarAsignaturasEnComboBox();
            this.llenarSolicitantesEnDataGridView();

            cbHoraInicio.SelectedIndex = 0;
            cbTipoReserva.SelectedIndex = 0;
            cbNoEsporadico.SelectedIndex = 0;
            cbNombreCurso.SelectedIndex = 0;
            cbTipoAula.SelectedIndex = 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        { 
            string apellidoDocente = Convert.ToString(dgvSolicitantes.CurrentRow.Cells[0].Value); //obtengo el valor de la primer columna
            string nombreDocente = Convert.ToString(dgvSolicitantes.CurrentRow.Cells[1].Value); //obtengo el valor de la segunda columna
            string emailDocente = Convert.ToString(dgvSolicitantes.CurrentRow.Cells[2].Value); //obtengo el valor de la tercer columna
            
            int idDocente = this.obtenerIdDocente(apellidoDocente, nombreDocente, emailDocente);
            DataGridViewRowCollection fechas= dgvResultados.Rows;

            string nombreAsignatura = cbNombreCurso.SelectedItem.ToString();
            int idAsignatura = this.obtenerIdAsignatura(nombreAsignatura);

            ReservaDTO reservaDTO =new ReservaDTO(nickBedel, cbTipoReserva.Text, fechas, Convert.ToInt32(nudCantidadAlumnos.Value), idDocente, idAsignatura);

           
            this.Hide();
            new RegistrarReserva_2(this,reservaDTO).Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //No muestra el padre porque ya quedó abierto
        }

        private void cbHoraInicio_SelectedValueChanged(object sender, EventArgs e)
        {
            var aux = DateTime.Parse(cbHoraInicio.SelectedItem.ToString());
            cbHoraFin.Items.Clear();
            aux = aux.AddMinutes(30);
            llenarHorasEnCombobox(cbHoraFin, -1, 23, aux);
            cbHoraFin.SelectedIndex = 0;
        }

        private void cbTipoReserva_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoReserva.SelectedItem.ToString().Equals("Esporádica"))
            {
                cbNoEsporadico.Visible = false;
                calendarioEsporadico.Visible = true;
                calendarioEsporadico.MinDate = DateTime.Now;
                calendarioEsporadico.Value = DateTime.Now;
                
            }
            else
            {
                cbNoEsporadico.Visible = true;
                calendarioEsporadico.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           

            if (cbTipoReserva.SelectedItem.Equals("Esporádica"))
            {
                dgvResultados.Rows.Add(calendarioEsporadico.Value.ToShortDateString(),
                                       cbHoraInicio.Text,
                                       duracionTotal());
            }
            else
            {
                dgvResultados.Rows.Add(cbNoEsporadico.Text,
                                       cbHoraInicio.Text,
                                       duracionTotal());
            }
        }

        //METODOS PROPIOS

        private void llenarAsignaturasEnComboBox()
        {
            foreach (Asignatura asig in gestorAsignatura.obtenerAsignaturas())
            {
                cbNombreCurso.Items.Add(asig.nombre_asignatura);

                //Agrega la asignaturaDTO a la lista de asignaturas
                this.asignaturas.Add(new AsignaturaDTO(asig.id_asignatura, asig.nombre_asignatura));
            }
        }

        private void llenarSolicitantesEnDataGridView()
        {
            int i = 0;
            foreach (Docente docente in gestorDocente.obtenerDocentes())
            {
                dgvSolicitantes.Rows.Insert(i, docente.apellido_docente, docente.nombre_docente, docente.email_docente);

                //Agrega el docenteDTO a la lista de docentes
                this.docentes.Add(new DocenteDTO(docente.id_docente, docente.apellido_docente, docente.nombre_docente, docente.email_docente));
            }
        }

        private void llenarTiposAulaEnComboBox()
        {
            foreach (TipoAula tipoAula in gestorAula.obtenerTiposAula())
            {
                cbTipoAula.Items.Add(tipoAula.descripcion);
            }
        }

        private void llenarHorasEnCombobox(ComboBox cb, int firstHour, int lastHour, DateTime first)
        {
            DateTime time;

            if (firstHour != -1)
            {
                time = new DateTime(2000, 1, 1, firstHour, 0, 0);
            }
            else
            {
                time = first;
            }
            while (time.Hour < lastHour)
            {
                cb.Items.Add(time);
                time = time.AddMinutes(30);
            }
            cb.Items.Add(new DateTime(time.Year, time.Month, time.Day, lastHour, 0, 0));
            cb.FormatString = "HH:mm";
        }

        private int obtenerIdDocente(string apellido, string nombre, string email)
        {
            foreach (DocenteDTO docente in this.docentes)
            {
                if(docente.apellido.Equals(apellido) && docente.nombre.Equals(nombre) && docente.email.Equals(email))
                {
                    return docente.id_docente;
                }
            }
            return 0; //EN CASO DE QUE NO EXISTA ASIGNATURA CON LAS CONDICIONES ANTES PUESTAS
        }

        private int obtenerIdAsignatura(string nombre)
        {
            foreach (AsignaturaDTO asignatura in this.asignaturas)
            {
                if (asignatura.nombre.Equals(nombre))
                {
                    return asignatura.id_asignatura;
                }
            }
            return 0; //EN CASO DE QUE NO EXISTA DOCENTE CON LAS CONDICIONES ANTES PUESTAS
        }

        private string duracionTotal(){
            TimeSpan ts = DateTime.Parse(cbHoraFin.SelectedItem.ToString()) - DateTime.Parse(cbHoraInicio.SelectedItem.ToString());
            string aux =ts.TotalMinutes.ToString()+" Min";
            return aux;
       }
        
    }
    
}