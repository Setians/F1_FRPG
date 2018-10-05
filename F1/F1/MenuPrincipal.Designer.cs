namespace F1
{
    partial class MenuPrincipal
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
            this.ButTemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButCorredores = new System.Windows.Forms.Button();
            this.ButEquipos = new System.Windows.Forms.Button();
            this.ButCircuitos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButTemp
            // 
            this.ButTemp.Location = new System.Drawing.Point(37, 58);
            this.ButTemp.Name = "ButTemp";
            this.ButTemp.Size = new System.Drawing.Size(118, 38);
            this.ButTemp.TabIndex = 0;
            this.ButTemp.Text = "Temporadas";
            this.ButTemp.UseVisualStyleBackColor = true;
            this.ButTemp.Click += new System.EventHandler(this.ButTemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Black", 15.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "F1 Competicion 2018";
            // 
            // ButCorredores
            // 
            this.ButCorredores.Location = new System.Drawing.Point(37, 102);
            this.ButCorredores.Name = "ButCorredores";
            this.ButCorredores.Size = new System.Drawing.Size(118, 38);
            this.ButCorredores.TabIndex = 2;
            this.ButCorredores.Text = "Corredores";
            this.ButCorredores.UseVisualStyleBackColor = true;
            this.ButCorredores.Click += new System.EventHandler(this.ButCorredores_Click);
            // 
            // ButEquipos
            // 
            this.ButEquipos.Location = new System.Drawing.Point(37, 146);
            this.ButEquipos.Name = "ButEquipos";
            this.ButEquipos.Size = new System.Drawing.Size(118, 38);
            this.ButEquipos.TabIndex = 3;
            this.ButEquipos.Text = "Equipos";
            this.ButEquipos.UseVisualStyleBackColor = true;
            this.ButEquipos.Click += new System.EventHandler(this.ButEquipos_Click);
            // 
            // ButCircuitos
            // 
            this.ButCircuitos.Location = new System.Drawing.Point(37, 190);
            this.ButCircuitos.Name = "ButCircuitos";
            this.ButCircuitos.Size = new System.Drawing.Size(118, 38);
            this.ButCircuitos.TabIndex = 4;
            this.ButCircuitos.Text = "Circuitos";
            this.ButCircuitos.UseVisualStyleBackColor = true;
            this.ButCircuitos.Click += new System.EventHandler(this.ButCircuitos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.ButCircuitos);
            this.Controls.Add(this.ButEquipos);
            this.Controls.Add(this.ButCorredores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButTemp);
            this.Name = "MenuPrincipal";
            this.Text = "F1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButCorredores;
        private System.Windows.Forms.Button ButEquipos;
        private System.Windows.Forms.Button ButCircuitos;
    }
}

