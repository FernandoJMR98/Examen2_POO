using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculty;

namespace Sistema_De_Control_Escolar
{
    public partial class ReportePromedioParcialForm : Form
    {
        ControlEscolar controlEscolar;
        List<CalificacionConCreditos> calificaciones = new List<CalificacionConCreditos>();
        List<Alumno> alumnos = new List<Alumno>();

        public ReportePromedioParcialForm(ControlEscolar control_Escolar)
        {
            InitializeComponent();
            controlEscolar = control_Escolar;
            calificaciones = controlEscolar.GetCalificacionesParciales();
            alumnos = controlEscolar.GetAlumnos();
            FillCalificaciones(calificaciones, alumnos);
        }

        public void FillCalificaciones(List<CalificacionConCreditos> calificaciones, List<Alumno> alumnos)
        {
            for (int i = 0; i < calificaciones.Count; i++)
            {
                int idx = dataGridViewPromParcial.Rows.Add(); //Agregamos la fila
                dataGridViewPromParcial.Rows[idx].Cells[0].Value = calificaciones[i].Matricula;
                dataGridViewPromParcial.Rows[idx].Cells[1].Value = alumnos.Find(a => a.Id == calificaciones[i].Matricula).FullName;
                dataGridViewPromParcial.Rows[idx].Cells[2].Value = calificaciones[i].Promedio;
                dataGridViewPromParcial.Rows[idx].Cells[3].Value = calificaciones[i].Creditos;
                dataGridViewPromParcial.Rows[idx].Cells[4].Value = calificaciones[i].Porcentaje;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
