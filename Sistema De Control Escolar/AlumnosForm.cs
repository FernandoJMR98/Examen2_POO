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
    public partial class AlumnosForm : Form
    {
        private ControlEscolar controlEscolar;
        private List<Alumno> alumnos = new List<Alumno>();
        public AlumnosForm(ControlEscolar control_Escolar)
        {
            InitializeComponent();
            controlEscolar = control_Escolar;
            alumnos = controlEscolar.GetAlumnos();
            FillAlumnos(alumnos);
        }

        public void FillAlumnos(List<Alumno> alumnos) {
            for (int i = 0; i < alumnos.Count; i++) {
                int idx = dataGridViewAlumnos.Rows.Add(); //Agregamos la fila
                dataGridViewAlumnos.Rows[idx].Cells[0].Value = alumnos[i].Apellido;
                dataGridViewAlumnos.Rows[idx].Cells[1].Value = alumnos[i].Nombre;
                dataGridViewAlumnos.Rows[idx].Cells[2].Value = alumnos[i].Matricula;
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
