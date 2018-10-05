namespace F1
{
    partial class AgregarCircuito
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
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.tbxPGP = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.LabApell = new System.Windows.Forms.Label();
            this.LabLugNac = new System.Windows.Forms.Label();
            this.LabPNCor = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.ButAgregarCirc = new System.Windows.Forms.Button();
            this.tbxLong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(221, 91);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(118, 20);
            this.tbxPais.TabIndex = 45;
            this.tbxPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPais_KeyPress);
            // 
            // tbxPGP
            // 
            this.tbxPGP.Location = new System.Drawing.Point(221, 65);
            this.tbxPGP.Name = "tbxPGP";
            this.tbxPGP.Size = new System.Drawing.Size(118, 20);
            this.tbxPGP.TabIndex = 44;
            this.tbxPGP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPGP_KeyPress);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(221, 39);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(118, 20);
            this.tbxNombre.TabIndex = 43;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // LabApell
            // 
            this.LabApell.AutoSize = true;
            this.LabApell.Location = new System.Drawing.Point(29, 68);
            this.LabApell.Name = "LabApell";
            this.LabApell.Size = new System.Drawing.Size(160, 13);
            this.LabApell.TabIndex = 41;
            this.LabApell.Text = "Año del Primer GP que participo:";
            // 
            // LabLugNac
            // 
            this.LabLugNac.AutoSize = true;
            this.LabLugNac.Location = new System.Drawing.Point(29, 120);
            this.LabLugNac.Name = "LabLugNac";
            this.LabLugNac.Size = new System.Drawing.Size(121, 13);
            this.LabLugNac.TabIndex = 40;
            this.LabLugNac.Text = "Longitud del mismo(Km):";
            // 
            // LabPNCor
            // 
            this.LabPNCor.AutoSize = true;
            this.LabPNCor.Location = new System.Drawing.Point(29, 94);
            this.LabPNCor.Name = "LabPNCor";
            this.LabPNCor.Size = new System.Drawing.Size(128, 13);
            this.LabPNCor.TabIndex = 39;
            this.LabPNCor.Text = "Pais donde se encuentra:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(29, 42);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(102, 13);
            this.labNom.TabIndex = 38;
            this.labNom.Text = "Nombre del Circuito:";
            // 
            // ButAgregarCirc
            // 
            this.ButAgregarCirc.Location = new System.Drawing.Point(29, 219);
            this.ButAgregarCirc.Name = "ButAgregarCirc";
            this.ButAgregarCirc.Size = new System.Drawing.Size(75, 23);
            this.ButAgregarCirc.TabIndex = 37;
            this.ButAgregarCirc.Text = "Agregar";
            this.ButAgregarCirc.UseVisualStyleBackColor = true;
            this.ButAgregarCirc.Click += new System.EventHandler(this.ButAgregarCirc_Click);
            // 
            // tbxLong
            // 
            this.tbxLong.Location = new System.Drawing.Point(221, 117);
            this.tbxLong.Name = "tbxLong";
            this.tbxLong.Size = new System.Drawing.Size(118, 20);
            this.tbxLong.TabIndex = 46;
            this.tbxLong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLong_KeyPress);
            // 
            // AgregarCircuito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.tbxLong);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.tbxPGP);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.LabApell);
            this.Controls.Add(this.LabLugNac);
            this.Controls.Add(this.LabPNCor);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.ButAgregarCirc);
            this.Name = "AgregarCircuito";
            this.Text = "AgregarCircuito";
            this.Load += new System.EventHandler(this.AgregarCircuito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.TextBox tbxPGP;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label LabApell;
        private System.Windows.Forms.Label LabLugNac;
        private System.Windows.Forms.Label LabPNCor;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Button ButAgregarCirc;
        private System.Windows.Forms.TextBox tbxLong;
    }
}