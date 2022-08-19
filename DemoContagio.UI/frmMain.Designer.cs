namespace DemoContagio.UI
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.btnFacultad = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnAula = new System.Windows.Forms.Button();
            this.btnCiclo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEstudiantes);
            this.panel1.Controls.Add(this.btnAsignatura);
            this.panel1.Controls.Add(this.btnFacultad);
            this.panel1.Controls.Add(this.btnCarreras);
            this.panel1.Controls.Add(this.btnAula);
            this.panel1.Controls.Add(this.btnCiclo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 561);
            this.panel1.TabIndex = 5;
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsignatura.FlatAppearance.BorderSize = 0;
            this.btnAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignatura.ForeColor = System.Drawing.Color.LightGray;
            this.btnAsignatura.Image = global::DemoContagio.UI.Properties.Resources._40pxçeducacion___copia;
            this.btnAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignatura.Location = new System.Drawing.Point(22, 113);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(200, 50);
            this.btnAsignatura.TabIndex = 2;
            this.btnAsignatura.Text = "Asignaturas";
            this.btnAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignatura.UseVisualStyleBackColor = false;
            this.btnAsignatura.Click += new System.EventHandler(this.btnAsignatura_Click);
            // 
            // btnFacultad
            // 
            this.btnFacultad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnFacultad.FlatAppearance.BorderSize = 0;
            this.btnFacultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacultad.ForeColor = System.Drawing.Color.LightGray;
            this.btnFacultad.Image = global::DemoContagio.UI.Properties.Resources._40PXsombrero_de_graduacion;
            this.btnFacultad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacultad.Location = new System.Drawing.Point(22, 385);
            this.btnFacultad.Name = "btnFacultad";
            this.btnFacultad.Size = new System.Drawing.Size(200, 50);
            this.btnFacultad.TabIndex = 4;
            this.btnFacultad.Text = "Facultades";
            this.btnFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacultad.UseVisualStyleBackColor = false;
            this.btnFacultad.Click += new System.EventHandler(this.btnFacultad_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnCarreras.FlatAppearance.BorderSize = 0;
            this.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.ForeColor = System.Drawing.Color.LightGray;
            this.btnCarreras.Image = global::DemoContagio.UI.Properties.Resources._40pxgraduado;
            this.btnCarreras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreras.Location = new System.Drawing.Point(22, 181);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(200, 50);
            this.btnCarreras.TabIndex = 1;
            this.btnCarreras.Text = "Carreras";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarreras.UseVisualStyleBackColor = false;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnAula
            // 
            this.btnAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnAula.FlatAppearance.BorderSize = 0;
            this.btnAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula.ForeColor = System.Drawing.Color.LightGray;
            this.btnAula.Image = global::DemoContagio.UI.Properties.Resources._40pxpizarra;
            this.btnAula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAula.Location = new System.Drawing.Point(22, 317);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(200, 50);
            this.btnAula.TabIndex = 3;
            this.btnAula.Text = "Aulas";
            this.btnAula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAula.UseVisualStyleBackColor = false;
            this.btnAula.Click += new System.EventHandler(this.btnAula_Click);
            // 
            // btnCiclo
            // 
            this.btnCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnCiclo.FlatAppearance.BorderSize = 0;
            this.btnCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiclo.ForeColor = System.Drawing.Color.LightGray;
            this.btnCiclo.Image = global::DemoContagio.UI.Properties.Resources._40PXcalendar_icon_129357;
            this.btnCiclo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiclo.Location = new System.Drawing.Point(22, 249);
            this.btnCiclo.Name = "btnCiclo";
            this.btnCiclo.Size = new System.Drawing.Size(200, 50);
            this.btnCiclo.TabIndex = 0;
            this.btnCiclo.Text = "Ciclo";
            this.btnCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCiclo.UseVisualStyleBackColor = false;
            this.btnCiclo.Click += new System.EventHandler(this.btnCiclo_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 32);
            this.panel2.TabIndex = 7;
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.LightGray;
            this.btnEstudiantes.Image = global::DemoContagio.UI.Properties.Resources._40pxgraduado;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(22, 452);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(200, 50);
            this.btnEstudiantes.TabIndex = 5;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCiclo;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnAsignatura;
        private System.Windows.Forms.Button btnAula;
        private System.Windows.Forms.Button btnFacultad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstudiantes;
    }
}