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
    public partial class ReporteExtraordinarioForm : Form
    {
        ControlEscolar controlEscolar;
        List<Asignatura> asignaturas = new List<Asignatura>();
        public ReporteExtraordinarioForm(ControlEscolar control_Escolar)
        {
            InitializeComponent();
            controlEscolar = control_Escolar;
            asignaturas = controlEscolar.GetAsignaturasPorAlumnos();
            FillAsignaturas(asignaturas);
        }

        public void FillAsignaturas(List<Asignatura> asignaturas)
        {
            for (int i = 0; i < asignaturas.Count; i++)
            {
                int idx = dataGridViewExtras.Rows.Add(); //Agregamos la fila
                dataGridViewExtras.Rows[idx].Cells[0].Value = asignaturas[i].Clave;
                dataGridViewExtras.Rows[idx].Cells[1].Value = asignaturas[i].Nombre;
                dataGridViewExtras.Rows[idx].Cells[2].Value = asignaturas[i].Creditos;
            }
        

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewExtras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
