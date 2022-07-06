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
    public partial class Form1 : Form
    {
        private ControlEscolar controlEscolar;
        public Form1()
        {
            InitializeComponent();
            CustomDesign();
            controlEscolar = new ControlEscolar();
        }


        public void CustomDesign() { 
            
            panelSubMenuMostrar.Visible = false;
            panelSubMenuReportes.Visible = false;
        
        }

        public void HideSubMenus() {
        
            if (panelSubMenuMostrar.Visible == true)
                panelSubMenuMostrar.Visible = false;
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
        
        }

        public void ShowSubMenu(Panel SubMenu) {

            if (SubMenu.Visible == false)
            {
                HideSubMenus();
                SubMenu.Visible = true;
            }
            else { 
                SubMenu.Visible = false;
            }

        }

        private void btnSubMenuMostrar_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuMostrar);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            openForm(new AlumnosForm(controlEscolar));
            HideSubMenus();
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            openForm(new AsignaturasForm(controlEscolar));
            HideSubMenus();
        }

        private void btnCerrarSubMenuMostrar_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
                currentForm.Close();
            HideSubMenus();
        }

        private void btnAltaAlumnos_Click(object sender, EventArgs e)
        {
            openForm(new AltaAlumnoForm(controlEscolar));
            HideSubMenus();
        }

        private void btnAsignarCalificaciones_Click(object sender, EventArgs e)
        {
            openForm(new AsignarCalificacionesForm(controlEscolar));
            HideSubMenus();
        }

        private void btnSubMenuReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuReportes);
        }

        private void btnPromTotal_Click(object sender, EventArgs e)
        {
            openForm(new ReportePromedioTotalForm(controlEscolar));
            HideSubMenus();
        }

        private void btnPromParcial_Click(object sender, EventArgs e)
        {
            openForm(new ReportePromedioParcialForm(controlEscolar));
            HideSubMenus();
        }

        private void btnAlumnosReprobados_Click(object sender, EventArgs e)
        {
            openForm(new ReporteAlumnosReprobadosForm(controlEscolar));
            HideSubMenus();
        }

        private void btnExtraordinarios_Click(object sender, EventArgs e)
        {
            openForm(new ReporteExtraordinarioForm(controlEscolar));
            HideSubMenus();
        }

        private void btnCerrarSubMenuReportes_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
                currentForm.Close();
            HideSubMenus();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            openForm(new AcercaDeForm());
            HideSubMenus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //Salimos de la aplicación
        }

        private Form currentForm = null;

        private void openForm(Form newForm) {
            if (currentForm != null)
                currentForm.Close();
            
            currentForm = newForm;
            //Configuraciones
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None; //Quitamos el borde
            currentForm.Dock = DockStyle.Fill; //Rellenamos
            panelContenedor.Controls.Add(currentForm);  //Agregamos al panel
            panelContenedor.Tag = currentForm; //Asociamos al panel
            currentForm.BringToFront(); //Traemos al frente
            currentForm.Show(); // Mostramos
        }

    }
}
