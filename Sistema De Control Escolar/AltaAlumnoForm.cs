using System;
using System.Collections.Generic;
using System.Globalization;
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
    public partial class AltaAlumnoForm : Form
    {
        private ControlEscolar controlEscolar;
        private List<Alumno> alumnos = new List<Alumno>();
        public AltaAlumnoForm(ControlEscolar ControlEscolar)
        {
            InitializeComponent();
            controlEscolar = ControlEscolar;
            alumnos = controlEscolar.GetAlumnos();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text.Trim();
            string last_name = txtApellido.Text.Trim();
            int matricula;
            bool existe;
            
            name = name.ToLower();
            last_name = last_name.ToLower();
            
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            if (name != "" && last_name != "") {

                existe = alumnos.Exists(a => a.Nombre.ToLower().Equals(name)
                        && a.Apellido.ToLower().Equals(last_name));

                if (existe)
                {
                    MessageBox.Show("Este alumno ya ha sido dado de alta", "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    matricula = controlEscolar.GetNewMatricula();
                    controlEscolar.NewAlumno(matricula, myTI.ToTitleCase(name), myTI.ToTitleCase(last_name));
                    controlEscolar.NewKardex(matricula);
                    MessageBox.Show("Registro exitoso", "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellido.Clear();
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void AltaAlumnoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
