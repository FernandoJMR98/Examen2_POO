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
    public partial class ReportePromedioTotalForm : Form
    {
        private ControlEscolar controlEscolar;
        private List<CalificaionPromedio> calificaciones = new List<CalificaionPromedio>();
        private List<Alumno> alumnos = new List<Alumno>();
        
        public ReportePromedioTotalForm(ControlEscolar control_Escolar)
        {
            InitializeComponent();
            controlEscolar = control_Escolar;
            calificaciones = controlEscolar.GetCalificacionesFinales();
            alumnos = controlEscolar.GetAlumnos();
            FillCalificaciones(calificaciones, alumnos);
        }

        public void FillCalificaciones(List<CalificaionPromedio> calificaciones, List<Alumno> alumnos)
        {
            for (int i = 0; i < calificaciones.Count; i++)
            {
                int idx = dataGridViewAlumnos.Rows.Add(); //Agregamos la fila
                dataGridViewAlumnos.Rows[idx].Cells[0].Value = calificaciones[i].Matricula;
                dataGridViewAlumnos.Rows[idx].Cells[1].Value = alumnos.Find(a => a.Matricula == calificaciones[i].Matricula).FullName;
                dataGridViewAlumnos.Rows[idx].Cells[2].Value = calificaciones[i].CalifacionObtenida;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
