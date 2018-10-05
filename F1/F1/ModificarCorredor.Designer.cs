namespace F1
{
    partial class ModificarCorredor
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
            this.tbxLugar = new System.Windows.Forms.TextBox();
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.LabFechaNac = new System.Windows.Forms.Label();
            this.LabApell = new System.Windows.Forms.Label();
            this.LabLugNac = new System.Windows.Forms.Label();
            this.LabPNCor = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.ButModificarCorr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.ButBuscarDatosID = new System.Windows.Forms.Button();
            this.tbxFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbxLugar
            // 
            this.tbxLugar.Location = new System.Drawing.Point(161, 157);
            this.tbxLugar.Name = "tbxLugar";
            this.tbxLugar.Size = new System.Drawing.Size(179, 20);
            this.tbxLugar.TabIndex = 25;
            this.tbxLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLugar_KeyPress);
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(161, 131);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(179, 20);
            this.tbxPais.TabIndex = 24;
            this.tbxPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPais_KeyPress);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(161, 105);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(179, 20);
            this.tbxApellido.TabIndex = 23;
            this.tbxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxApellido_KeyPress);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(161, 79);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(179, 20);
            this.tbxNombre.TabIndex = 22;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // LabFechaNac
            // 
            this.LabFechaNac.AutoSize = true;
            this.LabFechaNac.Location = new System.Drawing.Point(30, 186);
            this.LabFechaNac.Name = "LabFechaNac";
            this.LabFechaNac.Size = new System.Drawing.Size(111, 13);
            this.LabFechaNac.TabIndex = 21;
            this.LabFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LabApell
            // 
            this.LabApell.AutoSize = true;
            this.LabApell.Location = new System.Drawing.Point(30, 108);
            this.LabApell.Name = "LabApell";
            this.LabApell.Size = new System.Drawing.Size(106, 13);
            this.LabApell.TabIndex = 20;
            this.LabApell.Text = "Apellido del corredor:";
            // 
            // LabLugNac
            // 
            this.LabLugNac.AutoSize = true;
            this.LabLugNac.Location = new System.Drawing.Point(30, 160);
            this.LabLugNac.Name = "LabLugNac";
            this.LabLugNac.Size = new System.Drawing.Size(108, 13);
            this.LabLugNac.TabIndex = 19;
            this.LabLugNac.Text = "Lugar de Nacimiento:";
            // 
            // LabPNCor
            // 
            this.LabPNCor.AutoSize = true;
            this.LabPNCor.Location = new System.Drawing.Point(30, 134);
            this.LabPNCor.Name = "LabPNCor";
            this.LabPNCor.Size = new System.Drawing.Size(101, 13);
            this.LabPNCor.TabIndex = 18;
            this.LabPNCor.Text = "Pais de Nacimiento:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(30, 82);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(106, 13);
            this.labNom.TabIndex = 17;
            this.labNom.Text = "Nombre del corredor:";
            // 
            // ButModificarCorr
            // 
            this.ButModificarCorr.Location = new System.Drawing.Point(33, 229);
            this.ButModificarCorr.Name = "ButModificarCorr";
            this.ButModificarCorr.Size = new System.Drawing.Size(75, 23);
            this.ButModificarCorr.TabIndex = 16;
            this.ButModificarCorr.Text = "Modificar";
            this.ButModificarCorr.UseVisualStyleBackColor = true;
            this.ButModificarCorr.Click += new System.EventHandler(this.ButModificarCorr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ID del Corredor:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(161, 27);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(179, 20);
            this.tbxID.TabIndex = 33;
            this.tbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_KeyPress);
            // 
            // ButBuscarDatosID
            // 
            this.ButBuscarDatosID.Location = new System.Drawing.Point(33, 53);
            this.ButBuscarDatosID.Name = "ButBuscarDatosID";
            this.ButBuscarDatosID.Size = new System.Drawing.Size(147, 23);
            this.ButBuscarDatosID.TabIndex = 34;
            this.ButBuscarDatosID.Text = "Lenar con datos actuales";
            this.ButBuscarDatosID.UseVisualStyleBackColor = true;
            this.ButBuscarDatosID.Click += new System.EventHandler(this.ButBuscarDatosID_Click);
            // 
            // tbxFecha
            // 
            this.tbxFecha.Location = new System.Drawing.Point(161, 183);
            this.tbxFecha.Mask = "00/00/0000";
            this.tbxFecha.Name = "tbxFecha";
            this.tbxFecha.Size = new System.Drawing.Size(179, 20);
            this.tbxFecha.TabIndex = 35;
            this.tbxFecha.ValidatingType = typeof(System.DateTime);
            this.tbxFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFecha_KeyPress);
            // 
            // ModificarCorredor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.tbxFecha);
            this.Controls.Add(this.ButBuscarDatosID);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxLugar);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.LabFechaNac);
            this.Controls.Add(this.LabApell);
            this.Controls.Add(this.LabLugNac);
            this.Controls.Add(this.LabPNCor);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.ButModificarCorr);
            this.Name = "ModificarCorredor";
            this.Text = "ModificarCorredor";
            this.Load += new System.EventHandler(this.ModificarCorredor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxLugar;
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label LabFechaNac;
        private System.Windows.Forms.Label LabApell;
        private System.Windows.Forms.Label LabLugNac;
        private System.Windows.Forms.Label LabPNCor;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Button ButModificarCorr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button ButBuscarDatosID;
        private System.Windows.Forms.MaskedTextBox tbxFecha;
    }
}