namespace F1
{
    partial class AgregarCorredor
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
            this.ButAgregarCorr = new System.Windows.Forms.Button();
            this.labNom = new System.Windows.Forms.Label();
            this.LabPNCor = new System.Windows.Forms.Label();
            this.LabLugNac = new System.Windows.Forms.Label();
            this.LabApell = new System.Windows.Forms.Label();
            this.LabFechaNac = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.tbxLugar = new System.Windows.Forms.TextBox();
            this.tbxFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ButAgregarCorr
            // 
            this.ButAgregarCorr.Location = new System.Drawing.Point(32, 218);
            this.ButAgregarCorr.Name = "ButAgregarCorr";
            this.ButAgregarCorr.Size = new System.Drawing.Size(75, 23);
            this.ButAgregarCorr.TabIndex = 0;
            this.ButAgregarCorr.Text = "Agregar";
            this.ButAgregarCorr.UseVisualStyleBackColor = true;
            this.ButAgregarCorr.Click += new System.EventHandler(this.ButAgregarCorr_Click);
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(32, 41);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(106, 13);
            this.labNom.TabIndex = 1;
            this.labNom.Text = "Nombre del corredor:";
            // 
            // LabPNCor
            // 
            this.LabPNCor.AutoSize = true;
            this.LabPNCor.Location = new System.Drawing.Point(32, 93);
            this.LabPNCor.Name = "LabPNCor";
            this.LabPNCor.Size = new System.Drawing.Size(101, 13);
            this.LabPNCor.TabIndex = 2;
            this.LabPNCor.Text = "Pais de Nacimiento:";
            // 
            // LabLugNac
            // 
            this.LabLugNac.AutoSize = true;
            this.LabLugNac.Location = new System.Drawing.Point(32, 119);
            this.LabLugNac.Name = "LabLugNac";
            this.LabLugNac.Size = new System.Drawing.Size(108, 13);
            this.LabLugNac.TabIndex = 3;
            this.LabLugNac.Text = "Lugar de Nacimiento:";
            // 
            // LabApell
            // 
            this.LabApell.AutoSize = true;
            this.LabApell.Location = new System.Drawing.Point(32, 67);
            this.LabApell.Name = "LabApell";
            this.LabApell.Size = new System.Drawing.Size(106, 13);
            this.LabApell.TabIndex = 4;
            this.LabApell.Text = "Apellido del corredor:";
            // 
            // LabFechaNac
            // 
            this.LabFechaNac.AutoSize = true;
            this.LabFechaNac.Location = new System.Drawing.Point(32, 145);
            this.LabFechaNac.Name = "LabFechaNac";
            this.LabFechaNac.Size = new System.Drawing.Size(111, 13);
            this.LabFechaNac.TabIndex = 5;
            this.LabFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(163, 38);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(179, 20);
            this.tbxNombre.TabIndex = 6;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(163, 64);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(179, 20);
            this.tbxApellido.TabIndex = 7;
            this.tbxApellido.TextChanged += new System.EventHandler(this.tbxApellido_TextChanged);
            this.tbxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxApellido_KeyPress);
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(163, 90);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(179, 20);
            this.tbxPais.TabIndex = 8;
            this.tbxPais.TextChanged += new System.EventHandler(this.tbxPais_TextChanged);
            this.tbxPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPais_KeyPress);
            // 
            // tbxLugar
            // 
            this.tbxLugar.Location = new System.Drawing.Point(163, 116);
            this.tbxLugar.Name = "tbxLugar";
            this.tbxLugar.Size = new System.Drawing.Size(179, 20);
            this.tbxLugar.TabIndex = 9;
            this.tbxLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLugar_KeyPress);
            // 
            // tbxFecha
            // 
            this.tbxFecha.Location = new System.Drawing.Point(163, 142);
            this.tbxFecha.Mask = "00/00/0000";
            this.tbxFecha.Name = "tbxFecha";
            this.tbxFecha.Size = new System.Drawing.Size(179, 20);
            this.tbxFecha.TabIndex = 36;
            this.tbxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // AgregarCorredor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.tbxFecha);
            this.Controls.Add(this.tbxLugar);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.LabFechaNac);
            this.Controls.Add(this.LabApell);
            this.Controls.Add(this.LabLugNac);
            this.Controls.Add(this.LabPNCor);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.ButAgregarCorr);
            this.Name = "AgregarCorredor";
            this.Text = "AgregarCorredor";
            this.Load += new System.EventHandler(this.AgregarCorredor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButAgregarCorr;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label LabPNCor;
        private System.Windows.Forms.Label LabLugNac;
        private System.Windows.Forms.Label LabApell;
        private System.Windows.Forms.Label LabFechaNac;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.TextBox tbxLugar;
        private System.Windows.Forms.MaskedTextBox tbxFecha;
    }
}