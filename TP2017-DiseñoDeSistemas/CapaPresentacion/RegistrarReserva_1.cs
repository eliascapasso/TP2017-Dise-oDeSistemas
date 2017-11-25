﻿using CapaDatos;
using CapaLogica;
using CapaPresentacion;
using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autenticacion
{
    public partial class RegistrarReserva_1 : Form
    {
        private Form padre;
        private GestorDeUsuario gestorUsuario;
        private GestorDeAsignatura gestorAsignatura;
        private GestorDeAula gestorAula;
        private GestorDeDocente gestorDocente;
        
        public RegistrarReserva_1(Form papa)
        {
            this.padre = papa;
            this.gestorUsuario = new GestorDeUsuario();
            this.gestorAsignatura = new GestorDeAsignatura();
            this.gestorAula = new GestorDeAula();
            this.gestorDocente = new GestorDeDocente();
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
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                dgvResultados.Rows.Add(calendarioEsporadico.Value.ToShortDateString(), cbHoraInicio.Text, calcularDuracion(cbHoraInicio.Text, cbHoraFin.Text));
            }
            else
            {
                dgvResultados.Rows.Add(cbNoEsporadico.Text, cbHoraInicio.Text, calcularDuracion(cbHoraInicio.Text, cbHoraFin.Text));
            }
        }


        private void dgvResultados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Falta implementar
        }

        private void dgvSolicitante_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Falta implementar
        }

        //METODOS PROPIOS

        private void llenarAsignaturasEnComboBox()
        {
            foreach (Asignatura asig in gestorAsignatura.obtenerAsignaturas())
            {
                cbNombreCurso.Items.Add(asig.nombre_asignatura);
            }
        }

        private void llenarSolicitantesEnDataGridView()
        {
            int i = 0;
            foreach (Docente docente in gestorDocente.obtenerDocentes())
            {
                dgvSolicitantes.Rows.Insert(i, docente.apellido_docente, docente.nombre_docente, docente.email_docente);
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
        
        private string calcularDuracion(string inicio, string fin)
        {
            double inicioNum = this.toNumero(inicio);
            double finNum = this.toNumero(fin);

            long horas = (long)(finNum - inicioNum);
            double minutos = (finNum - inicioNum) - (double)horas;

            string horasCadena = "";
            string minutosCadena = "";

            if (horas != 0) { horasCadena = horas.ToString() + "hs"; }
            if (minutos == 0.5) { minutosCadena = "30min"; }

            return horasCadena + minutosCadena;
        }
        
        private double toNumero(string cadena)
        {
            switch (cadena)
            {
                case "07:00":
                    return 7.0;
                case "07:30":
                    return 7.5;
                case "08:00":
                    return 8.0;
                case "08:30":
                    return 8.5;
                case "09:00":
                    return 9.0;
                case "09:30":
                    return 9.5;
                case "10:00":
                    return 10.0;
                case "10:30":
                    return 10.5;
                case "11:00":
                    return 11.0;
                case "11:30":
                    return 11.5;
                case "12:00":
                    return 12.0;
                case "12:30":
                    return 12.5;
                case "13:00":
                    return 13.0;
                case "13:30":
                    return 13.5;
                case "14:00":
                    return 14.0;
                case "14:30":
                    return 14.5;
                case "15:00":
                    return 15.0;
                case "15:30":
                    return 15.5;
                case "16:00":
                    return 16.0;
                case "16:30":
                    return 16.5;
                case "17:00":
                    return 17.0;
                case "17:30":
                    return 17.5;
                case "18:00":
                    return 18.0;
                case "18:30":
                    return 18.5;
                case "19:00":
                    return 19.0;
                case "19:30":
                    return 19.5;
                case "20:00":
                    return 20.0;
                case "20:30":
                    return 20.5;
                case "21:00":
                    return 21.0;
                case "21:30":
                    return 21.5;
                case "22:00":
                    return 22.0;
                case "22:30":
                    return 22.5;
                case "23:00":
                    return 23.0;
                case "23:30":
                    return 23.5;
                case "00:00":
                    return 24.0;

                default: return 0.0;
            }
        }
    }
}