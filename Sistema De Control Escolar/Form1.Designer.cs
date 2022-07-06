namespace Sistema_De_Control_Escolar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenuSide = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.panelSubMenuReportes = new System.Windows.Forms.Panel();
            this.btnCerrarSubMenuReportes = new System.Windows.Forms.Button();
            this.btnExtraordinarios = new System.Windows.Forms.Button();
            this.btnAlumnosReprobados = new System.Windows.Forms.Button();
            this.btnPromParcial = new System.Windows.Forms.Button();
            this.btnPromTotal = new System.Windows.Forms.Button();
            this.btnSubMenuReportes = new System.Windows.Forms.Button();
            this.btnAsignarCalificaciones = new System.Windows.Forms.Button();
            this.btnAltaAlumnos = new System.Windows.Forms.Button();
            this.panelSubMenuMostrar = new System.Windows.Forms.Panel();
            this.btnCerrarSubMenuMostrar = new System.Windows.Forms.Button();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnSubMenuMostrar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMenuSide.SuspendLayout();
            this.panelSubMenuReportes.SuspendLayout();
            this.panelSubMenuMostrar.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuSide
            // 
            this.panelMenuSide.AutoScroll = true;
            this.panelMenuSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panelMenuSide.Controls.Add(this.btnSalir);
            this.panelMenuSide.Controls.Add(this.btnAcercaDe);
            this.panelMenuSide.Controls.Add(this.panelSubMenuReportes);
            this.panelMenuSide.Controls.Add(this.btnSubMenuReportes);
            this.panelMenuSide.Controls.Add(this.btnAsignarCalificaciones);
            this.panelMenuSide.Controls.Add(this.btnAltaAlumnos);
            this.panelMenuSide.Controls.Add(this.panelSubMenuMostrar);
            this.panelMenuSide.Controls.Add(this.btnSubMenuMostrar);
            this.panelMenuSide.Controls.Add(this.panelLogo);
            this.panelMenuSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSide.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSide.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenuSide.Name = "panelMenuSide";
            this.panelMenuSide.Size = new System.Drawing.Size(250, 561);
            this.panelMenuSide.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 683);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(233, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 638);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(233, 45);
            this.btnAcercaDe.TabIndex = 8;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // panelSubMenuReportes
            // 
            this.panelSubMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuReportes.Controls.Add(this.btnCerrarSubMenuReportes);
            this.panelSubMenuReportes.Controls.Add(this.btnExtraordinarios);
            this.panelSubMenuReportes.Controls.Add(this.btnAlumnosReprobados);
            this.panelSubMenuReportes.Controls.Add(this.btnPromParcial);
            this.panelSubMenuReportes.Controls.Add(this.btnPromTotal);
            this.panelSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuReportes.Location = new System.Drawing.Point(0, 413);
            this.panelSubMenuReportes.Name = "panelSubMenuReportes";
            this.panelSubMenuReportes.Size = new System.Drawing.Size(233, 225);
            this.panelSubMenuReportes.TabIndex = 7;
            // 
            // btnCerrarSubMenuReportes
            // 
            this.btnCerrarSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSubMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnCerrarSubMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSubMenuReportes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCerrarSubMenuReportes.Location = new System.Drawing.Point(0, 180);
            this.btnCerrarSubMenuReportes.Name = "btnCerrarSubMenuReportes";
            this.btnCerrarSubMenuReportes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCerrarSubMenuReportes.Size = new System.Drawing.Size(233, 40);
            this.btnCerrarSubMenuReportes.TabIndex = 7;
            this.btnCerrarSubMenuReportes.Text = "Volver";
            this.btnCerrarSubMenuReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSubMenuReportes.UseVisualStyleBackColor = true;
            this.btnCerrarSubMenuReportes.Click += new System.EventHandler(this.btnCerrarSubMenuReportes_Click);
            // 
            // btnExtraordinarios
            // 
            this.btnExtraordinarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtraordinarios.FlatAppearance.BorderSize = 0;
            this.btnExtraordinarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraordinarios.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnExtraordinarios.Location = new System.Drawing.Point(0, 140);
            this.btnExtraordinarios.Name = "btnExtraordinarios";
            this.btnExtraordinarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExtraordinarios.Size = new System.Drawing.Size(233, 40);
            this.btnExtraordinarios.TabIndex = 6;
            this.btnExtraordinarios.Text = "Extraordinarios";
            this.btnExtraordinarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtraordinarios.UseVisualStyleBackColor = true;
            this.btnExtraordinarios.Click += new System.EventHandler(this.btnExtraordinarios_Click);
            // 
            // btnAlumnosReprobados
            // 
            this.btnAlumnosReprobados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnosReprobados.FlatAppearance.BorderSize = 0;
            this.btnAlumnosReprobados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnosReprobados.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAlumnosReprobados.Location = new System.Drawing.Point(0, 80);
            this.btnAlumnosReprobados.Name = "btnAlumnosReprobados";
            this.btnAlumnosReprobados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlumnosReprobados.Size = new System.Drawing.Size(233, 60);
            this.btnAlumnosReprobados.TabIndex = 5;
            this.btnAlumnosReprobados.Text = "Alumnos con asignaturas reprobadas";
            this.btnAlumnosReprobados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnosReprobados.UseVisualStyleBackColor = true;
            this.btnAlumnosReprobados.Click += new System.EventHandler(this.btnAlumnosReprobados_Click);
            // 
            // btnPromParcial
            // 
            this.btnPromParcial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromParcial.FlatAppearance.BorderSize = 0;
            this.btnPromParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromParcial.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnPromParcial.Location = new System.Drawing.Point(0, 40);
            this.btnPromParcial.Name = "btnPromParcial";
            this.btnPromParcial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPromParcial.Size = new System.Drawing.Size(233, 40);
            this.btnPromParcial.TabIndex = 4;
            this.btnPromParcial.Text = "Promedio parcial";
            this.btnPromParcial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromParcial.UseVisualStyleBackColor = true;
            this.btnPromParcial.Click += new System.EventHandler(this.btnPromParcial_Click);
            // 
            // btnPromTotal
            // 
            this.btnPromTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromTotal.FlatAppearance.BorderSize = 0;
            this.btnPromTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromTotal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnPromTotal.Location = new System.Drawing.Point(0, 0);
            this.btnPromTotal.Name = "btnPromTotal";
            this.btnPromTotal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPromTotal.Size = new System.Drawing.Size(233, 40);
            this.btnPromTotal.TabIndex = 3;
            this.btnPromTotal.Text = "Promedio total";
            this.btnPromTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromTotal.UseVisualStyleBackColor = true;
            this.btnPromTotal.Click += new System.EventHandler(this.btnPromTotal_Click);
            // 
            // btnSubMenuReportes
            // 
            this.btnSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnSubMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuReportes.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSubMenuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuReportes.Location = new System.Drawing.Point(0, 368);
            this.btnSubMenuReportes.Name = "btnSubMenuReportes";
            this.btnSubMenuReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuReportes.Size = new System.Drawing.Size(233, 45);
            this.btnSubMenuReportes.TabIndex = 6;
            this.btnSubMenuReportes.Text = "Reportes";
            this.btnSubMenuReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuReportes.UseVisualStyleBackColor = true;
            this.btnSubMenuReportes.Click += new System.EventHandler(this.btnSubMenuReportes_Click);
            // 
            // btnAsignarCalificaciones
            // 
            this.btnAsignarCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignarCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarCalificaciones.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAsignarCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarCalificaciones.Location = new System.Drawing.Point(0, 323);
            this.btnAsignarCalificaciones.Name = "btnAsignarCalificaciones";
            this.btnAsignarCalificaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignarCalificaciones.Size = new System.Drawing.Size(233, 45);
            this.btnAsignarCalificaciones.TabIndex = 5;
            this.btnAsignarCalificaciones.Text = "Asignar calificaciones";
            this.btnAsignarCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarCalificaciones.UseVisualStyleBackColor = true;
            this.btnAsignarCalificaciones.Click += new System.EventHandler(this.btnAsignarCalificaciones_Click);
            // 
            // btnAltaAlumnos
            // 
            this.btnAltaAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAltaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAlumnos.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnAltaAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaAlumnos.Location = new System.Drawing.Point(0, 278);
            this.btnAltaAlumnos.Name = "btnAltaAlumnos";
            this.btnAltaAlumnos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAltaAlumnos.Size = new System.Drawing.Size(233, 45);
            this.btnAltaAlumnos.TabIndex = 4;
            this.btnAltaAlumnos.Text = "Alta de alumnos";
            this.btnAltaAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaAlumnos.UseVisualStyleBackColor = true;
            this.btnAltaAlumnos.Click += new System.EventHandler(this.btnAltaAlumnos_Click);
            // 
            // panelSubMenuMostrar
            // 
            this.panelSubMenuMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuMostrar.Controls.Add(this.btnCerrarSubMenuMostrar);
            this.panelSubMenuMostrar.Controls.Add(this.btnAsignaturas);
            this.panelSubMenuMostrar.Controls.Add(this.btnAlumnos);
            this.panelSubMenuMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMostrar.Location = new System.Drawing.Point(0, 153);
            this.panelSubMenuMostrar.Name = "panelSubMenuMostrar";
            this.panelSubMenuMostrar.Size = new System.Drawing.Size(233, 125);
            this.panelSubMenuMostrar.TabIndex = 3;
            // 
            // btnCerrarSubMenuMostrar
            // 
            this.btnCerrarSubMenuMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSubMenuMostrar.FlatAppearance.BorderSize = 0;
            this.btnCerrarSubMenuMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSubMenuMostrar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCerrarSubMenuMostrar.Location = new System.Drawing.Point(0, 80);
            this.btnCerrarSubMenuMostrar.Name = "btnCerrarSubMenuMostrar";
            this.btnCerrarSubMenuMostrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCerrarSubMenuMostrar.Size = new System.Drawing.Size(233, 40);
            this.btnCerrarSubMenuMostrar.TabIndex = 5;
            this.btnCerrarSubMenuMostrar.Text = "Volver";
            this.btnCerrarSubMenuMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSubMenuMostrar.UseVisualStyleBackColor = true;
            this.btnCerrarSubMenuMostrar.Click += new System.EventHandler(this.btnCerrarSubMenuMostrar_Click);
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignaturas.FlatAppearance.BorderSize = 0;
            this.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaturas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAsignaturas.Location = new System.Drawing.Point(0, 40);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAsignaturas.Size = new System.Drawing.Size(233, 40);
            this.btnAsignaturas.TabIndex = 4;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaturas.UseVisualStyleBackColor = true;
            this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(233, 40);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnSubMenuMostrar
            // 
            this.btnSubMenuMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuMostrar.FlatAppearance.BorderSize = 0;
            this.btnSubMenuMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuMostrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSubMenuMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMostrar.Location = new System.Drawing.Point(0, 108);
            this.btnSubMenuMostrar.Name = "btnSubMenuMostrar";
            this.btnSubMenuMostrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubMenuMostrar.Size = new System.Drawing.Size(233, 45);
            this.btnSubMenuMostrar.TabIndex = 2;
            this.btnSubMenuMostrar.Text = "Mostrar";
            this.btnSubMenuMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuMostrar.UseVisualStyleBackColor = true;
            this.btnSubMenuMostrar.Click += new System.EventHandler(this.btnSubMenuMostrar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 108);
            this.panelLogo.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panelContenedor.Controls.Add(this.pictureLogo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 561);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(139, 108);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(423, 241);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuSide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Sistema de Control Escolar";
            this.panelMenuSide.ResumeLayout(false);
            this.panelSubMenuReportes.ResumeLayout(false);
            this.panelSubMenuMostrar.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Panel panelSubMenuReportes;
        private System.Windows.Forms.Button btnCerrarSubMenuReportes;
        private System.Windows.Forms.Button btnExtraordinarios;
        private System.Windows.Forms.Button btnAlumnosReprobados;
        private System.Windows.Forms.Button btnPromParcial;
        private System.Windows.Forms.Button btnPromTotal;
        private System.Windows.Forms.Button btnSubMenuReportes;
        private System.Windows.Forms.Button btnAsignarCalificaciones;
        private System.Windows.Forms.Button btnAltaAlumnos;
        private System.Windows.Forms.Panel panelSubMenuMostrar;
        private System.Windows.Forms.Button btnCerrarSubMenuMostrar;
        private System.Windows.Forms.Button btnAsignaturas;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnSubMenuMostrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}

