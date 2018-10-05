namespace F1
{
    partial class AgregarEquipo
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
            this.tbxJefTecEqui = new System.Windows.Forms.TextBox();
            this.tbxJefEqui = new System.Windows.Forms.TextBox();
            this.tbxCentEqui = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.LabFechaNac = new System.Windows.Forms.Label();
            this.LabCenEqui = new System.Windows.Forms.Label();
            this.LabJefTeEqui = new System.Windows.Forms.Label();
            this.LabJEqui = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.ButAgregarEqui = new System.Windows.Forms.Button();
            this.tbxAñoEqui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxJefTecEqui
            // 
            this.tbxJefTecEqui.Location = new System.Drawing.Point(222, 117);
            this.tbxJefTecEqui.Name = "tbxJefTecEqui";
            this.tbxJefTecEqui.Size = new System.Drawing.Size(97, 20);
            this.tbxJefTecEqui.TabIndex = 46;
            this.tbxJefTecEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxJefTecEqui_KeyPress);
            // 
            // tbxJefEqui
            // 
            this.tbxJefEqui.Location = new System.Drawing.Point(222, 91);
            this.tbxJefEqui.Name = "tbxJefEqui";
            this.tbxJefEqui.Size = new System.Drawing.Size(97, 20);
            this.tbxJefEqui.TabIndex = 45;
            this.tbxJefEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxJefEqui_KeyPress);
            // 
            // tbxCentEqui
            // 
            this.tbxCentEqui.Location = new System.Drawing.Point(222, 65);
            this.tbxCentEqui.Name = "tbxCentEqui";
            this.tbxCentEqui.Size = new System.Drawing.Size(97, 20);
            this.tbxCentEqui.TabIndex = 44;
            this.tbxCentEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCentEqui_KeyPress);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(222, 39);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(97, 20);
            this.tbxNombre.TabIndex = 43;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // LabFechaNac
            // 
            this.LabFechaNac.AutoSize = true;
            this.LabFechaNac.Location = new System.Drawing.Point(29, 146);
            this.LabFechaNac.Name = "LabFechaNac";
            this.LabFechaNac.Size = new System.Drawing.Size(149, 13);
            this.LabFechaNac.TabIndex = 42;
            this.LabFechaNac.Text = "Año de Fundacion del equipo:";
            // 
            // LabCenEqui
            // 
            this.LabCenEqui.AutoSize = true;
            this.LabCenEqui.Location = new System.Drawing.Point(29, 68);
            this.LabCenEqui.Name = "LabCenEqui";
            this.LabCenEqui.Size = new System.Drawing.Size(171, 13);
            this.LabCenEqui.TabIndex = 41;
            this.LabCenEqui.Text = "Ubicacion de la central del equipo:";
            // 
            // LabJefTeEqui
            // 
            this.LabJefTeEqui.AutoSize = true;
            this.LabJefTeEqui.Location = new System.Drawing.Point(29, 120);
            this.LabJefTeEqui.Name = "LabJefTeEqui";
            this.LabJefTeEqui.Size = new System.Drawing.Size(124, 13);
            this.LabJefTeEqui.TabIndex = 40;
            this.LabJefTeEqui.Text = "Jefe Tecnico del equipo:";
            // 
            // LabJEqui
            // 
            this.LabJEqui.AutoSize = true;
            this.LabJEqui.Location = new System.Drawing.Point(29, 94);
            this.LabJEqui.Name = "LabJEqui";
            this.LabJEqui.Size = new System.Drawing.Size(82, 13);
            this.LabJEqui.TabIndex = 39;
            this.LabJEqui.Text = "Jefe del equipo:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(29, 42);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(100, 13);
            this.labNom.TabIndex = 38;
            this.labNom.Text = "Nombre del Equipo:";
            // 
            // ButAgregarEqui
            // 
            this.ButAgregarEqui.Location = new System.Drawing.Point(29, 219);
            this.ButAgregarEqui.Name = "ButAgregarEqui";
            this.ButAgregarEqui.Size = new System.Drawing.Size(75, 23);
            this.ButAgregarEqui.TabIndex = 37;
            this.ButAgregarEqui.Text = "Agregar";
            this.ButAgregarEqui.UseVisualStyleBackColor = true;
            this.ButAgregarEqui.Click += new System.EventHandler(this.ButAgregarEqui_Click);
            // 
            // tbxAñoEqui
            // 
            this.tbxAñoEqui.Location = new System.Drawing.Point(222, 146);
            this.tbxAñoEqui.Name = "tbxAñoEqui";
            this.tbxAñoEqui.Size = new System.Drawing.Size(97, 20);
            this.tbxAñoEqui.TabIndex = 47;
            this.tbxAñoEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAñoEqui_KeyPress);
            // 
            // AgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.tbxAñoEqui);
            this.Controls.Add(this.tbxJefTecEqui);
            this.Controls.Add(this.tbxJefEqui);
            this.Controls.Add(this.tbxCentEqui);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.LabFechaNac);
            this.Controls.Add(this.LabCenEqui);
            this.Controls.Add(this.LabJefTeEqui);
            this.Controls.Add(this.LabJEqui);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.ButAgregarEqui);
            this.Name = "AgregarEquipo";
            this.Text = "AgregarEquipo";
            this.Load += new System.EventHandler(this.AgregarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxJefTecEqui;
        private System.Windows.Forms.TextBox tbxJefEqui;
        private System.Windows.Forms.TextBox tbxCentEqui;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label LabFechaNac;
        private System.Windows.Forms.Label LabCenEqui;
        private System.Windows.Forms.Label LabJefTeEqui;
        private System.Windows.Forms.Label LabJEqui;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Button ButAgregarEqui;
        private System.Windows.Forms.TextBox tbxAñoEqui;
    }
}