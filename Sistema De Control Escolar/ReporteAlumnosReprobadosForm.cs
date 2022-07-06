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
    public partial class ReporteAlumnosReprobadosForm : Form
    {
        List<Alumno> alumnos;
        List<Asignatura> asignaturas;
        ControlEscolar controlEscolar;
        public ReporteAlumnosReprobadosForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            alumnos = controlEscolar.GetAlumnosReprobados();
            FillAlumnos(alumnos);

        }

        public void FillAlumnos(List<Alumno> alumnos)
        {
            for (int i = 0; i < alumnos.Count; i++)
            {
                int idx = dataGridViewAlumExtra.Rows.Add(); //Agregamos la fila
                dataGridViewAlumExtra.Rows[idx].Cells[0].Value = alumnos[i].Id;
                dataGridViewAlumExtra.Rows[idx].Cells[1].Value = alumnos[i].FullName;
            }


        }

        public void FillAsignaturas(List<Asignatura> asignaturas)
        {
            for (int i = 0; i < asignaturas.Count; i++)
            {
                int idx = dataGridViewMateriaExtra.Rows.Add(); //Agregamos la fila
                dataGridViewMateriaExtra.Rows[idx].Cells[0].Value = asignaturas[i].Id;
                dataGridViewMateriaExtra.Rows[idx].Cells[1].Value = asignaturas[i].Name;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridViewAlumExtra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewAlumExtra.CurrentCell.RowIndex;
            asignaturas = controlEscolar.GetAsignaturasReprobadas(int.Parse(dataGridViewAlumExtra.Rows[rowindex].Cells[0].Value.ToString()));
            dataGridViewMateriaExtra.Rows.Clear();
            FillAsignaturas(asignaturas);
          
        }
    }
}
