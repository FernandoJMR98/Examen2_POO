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
    public partial class AsignarCalificacionesForm : Form
    {
        private ControlEscolar controlEscolar;
        private List<Alumno> alumnos = new List<Alumno>();
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<Calificacion> calificaciones = new List<Calificacion>(); 
        public AsignarCalificacionesForm(ControlEscolar ControlEscolar)
        {
            InitializeComponent();
            controlEscolar = ControlEscolar;
            alumnos = controlEscolar.GetAlumnos();
            asignaturas = controlEscolar.GetAsignaturas();
            calificaciones = controlEscolar.GetCalificaciones();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtMateriaId.Clear();
            txtCalificacion.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            int clave = Convert.ToInt32(txtMateriaId.Text);
            int calificacion = Convert.ToInt32(txtCalificacion.Text);

            //Condiciones que determinan que los datos introducidos fueron correctos
            bool condicion_1 = alumnos.Exists(a => a.Matricula == matricula); //Existe el alumno
            bool condicion_2 = asignaturas.Exists(a => a.Clave == clave); //Existe la materia
            bool condicion_3 = (calificacion >= 0 && calificacion <= 100) ? true : false; //Calificaión entre 0 y 100
            bool condicion_4 = calificaciones.Exists(a => a.Matricula == matricula && a.Clave == clave && a.CalifacionObtenida == -1); //Calificación no asignada

            if (condicion_1 && condicion_2 && condicion_3 && condicion_4)
            {
                controlEscolar.NewCalificacion(matricula, clave, calificacion);
                MessageBox.Show("Registro exitoso", "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                txtMatricula.Clear();
                txtMateriaId.Clear();
                txtCalificacion.Clear();
            }
            else {
                MessageBox.Show("Alguno de los datos fueron incorrecto, prueba:\nRevisar la matrícula\nRevisar la clave de la materia\n" +
                    "Que la calificación esté entre 0 y 100\nQue la materia no haya sido cursada con anterioridad", "Aviso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }


        }
    }
}
