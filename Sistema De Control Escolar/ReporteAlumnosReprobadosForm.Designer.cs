namespace Sistema_De_Control_Escolar
{
    partial class ReporteAlumnosReprobadosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAlumExtra = new System.Windows.Forms.DataGridView();
            this.dataGridViewMateriaExtra = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(616, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alumnos con asignaturas reprobadas";
            // 
            // dataGridViewAlumExtra
            // 
            this.dataGridViewAlumExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlumExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGMatricula,
            this.Nombre});
            this.dataGridViewAlumExtra.Location = new System.Drawing.Point(18, 143);
            this.dataGridViewAlumExtra.Name = "dataGridViewAlumExtra";
            this.dataGridViewAlumExtra.RowHeadersWidth = 51;
            this.dataGridViewAlumExtra.Size = new System.Drawing.Size(638, 129);
            this.dataGridViewAlumExtra.TabIndex = 9;
            this.dataGridViewAlumExtra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumExtra_CellClick);
            // 
            // dataGridViewMateriaExtra
            // 
            this.dataGridViewMateriaExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMateriaExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriaExtra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Asignatura});
            this.dataGridViewMateriaExtra.Location = new System.Drawing.Point(18, 364);
            this.dataGridViewMateriaExtra.Name = "dataGridViewMateriaExtra";
            this.dataGridViewMateriaExtra.RowHeadersWidth = 51;
            this.dataGridViewMateriaExtra.Size = new System.Drawing.Size(638, 146);
            this.dataGridViewMateriaExtra.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alumnos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Materias Reprobadas";
            // 
            // DGMatricula
            // 
            this.DGMatricula.HeaderText = "Matrícula";
            this.DGMatricula.MaxInputLength = 256;
            this.DGMatricula.MinimumWidth = 6;
            this.DGMatricula.Name = "DGMatricula";
            this.DGMatricula.ReadOnly = true;
            this.DGMatricula.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 125;
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.MinimumWidth = 6;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            this.Asignatura.Width = 250;
            // 
            // ReporteAlumnosReprobadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMateriaExtra);
            this.Controls.Add(this.dataGridViewAlumExtra);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "ReporteAlumnosReprobadosForm";
            this.Text = "AlumnosReprobadosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAlumExtra;
        private System.Windows.Forms.DataGridView dataGridViewMateriaExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
    }
}