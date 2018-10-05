namespace F1
{
    partial class ModificarCircuito
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
            this.tbxLong = new System.Windows.Forms.TextBox();
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.tbxPGP = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.LabApell = new System.Windows.Forms.Label();
            this.LabLugNac = new System.Windows.Forms.Label();
            this.LabPNCor = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.ButModificarCirc = new System.Windows.Forms.Button();
            this.ButBuscarDatosID = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxLong
            // 
            this.tbxLong.Location = new System.Drawing.Point(218, 164);
            this.tbxLong.Name = "tbxLong";
            this.tbxLong.Size = new System.Drawing.Size(118, 20);
            this.tbxLong.TabIndex = 55;
            this.tbxLong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLong_KeyPress);
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(218, 138);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(118, 20);
            this.tbxPais.TabIndex = 54;
            this.tbxPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPais_KeyPress);
            // 
            // tbxPGP
            // 
            this.tbxPGP.Location = new System.Drawing.Point(218, 112);
            this.tbxPGP.Name = "tbxPGP";
            this.tbxPGP.Size = new System.Drawing.Size(118, 20);
            this.tbxPGP.TabIndex = 53;
            this.tbxPGP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPGP_KeyPress);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(218, 86);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(118, 20);
            this.tbxNombre.TabIndex = 52;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // LabApell
            // 
            this.LabApell.AutoSize = true;
            this.LabApell.Location = new System.Drawing.Point(26, 115);
            this.LabApell.Name = "LabApell";
            this.LabApell.Size = new System.Drawing.Size(160, 13);
            this.LabApell.TabIndex = 51;
            this.LabApell.Text = "Año del Primer GP que participo:";
            // 
            // LabLugNac
            // 
            this.LabLugNac.AutoSize = true;
            this.LabLugNac.Location = new System.Drawing.Point(26, 167);
            this.LabLugNac.Name = "LabLugNac";
            this.LabLugNac.Size = new System.Drawing.Size(121, 13);
            this.LabLugNac.TabIndex = 50;
            this.LabLugNac.Text = "Longitud del mismo(Km):";
            // 
            // LabPNCor
            // 
            this.LabPNCor.AutoSize = true;
            this.LabPNCor.Location = new System.Drawing.Point(26, 141);
            this.LabPNCor.Name = "LabPNCor";
            this.LabPNCor.Size = new System.Drawing.Size(128, 13);
            this.LabPNCor.TabIndex = 49;
            this.LabPNCor.Text = "Pais donde se encuentra:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(26, 89);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(102, 13);
            this.labNom.TabIndex = 48;
            this.labNom.Text = "Nombre del Circuito:";
            // 
            // ButModificarCirc
            // 
            this.ButModificarCirc.Location = new System.Drawing.Point(29, 219);
            this.ButModificarCirc.Name = "ButModificarCirc";
            this.ButModificarCirc.Size = new System.Drawing.Size(75, 23);
            this.ButModificarCirc.TabIndex = 47;
            this.ButModificarCirc.Text = "Modificar";
            this.ButModificarCirc.UseVisualStyleBackColor = true;
            this.ButModificarCirc.Click += new System.EventHandler(this.ButModificarCirc_Click);
            // 
            // ButBuscarDatosID
            // 
            this.ButBuscarDatosID.Location = new System.Drawing.Point(29, 47);
            this.ButBuscarDatosID.Name = "ButBuscarDatosID";
            this.ButBuscarDatosID.Size = new System.Drawing.Size(147, 23);
            this.ButBuscarDatosID.TabIndex = 58;
            this.ButBuscarDatosID.Text = "Lenar con datos actuales";
            this.ButBuscarDatosID.UseVisualStyleBackColor = true;
            this.ButBuscarDatosID.Click += new System.EventHandler(this.ButBuscarDatosID_Click);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(157, 21);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(179, 20);
            this.tbxID.TabIndex = 57;
            this.tbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID del Circuito:";
            // 
            // ModificarCircuito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButBuscarDatosID);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxLong);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.tbxPGP);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.LabApell);
            this.Controls.Add(this.LabLugNac);
            this.Controls.Add(this.LabPNCor);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.ButModificarCirc);
            this.Name = "ModificarCircuito";
            this.Text = "ModificarCircuito";
            this.Load += new System.EventHandler(this.ModificarCircuito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLong;
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.TextBox tbxPGP;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label LabApell;
        private System.Windows.Forms.Label LabLugNac;
        private System.Windows.Forms.Label LabPNCor;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Button ButModificarCirc;
        private System.Windows.Forms.Button ButBuscarDatosID;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label4;
    }
}