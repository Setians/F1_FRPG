namespace F1
{
    partial class EliminarEquipo
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
            this.ButEliminarEqui = new System.Windows.Forms.Button();
            this.tbxEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButEliminarEqui
            // 
            this.ButEliminarEqui.Location = new System.Drawing.Point(143, 137);
            this.ButEliminarEqui.Name = "ButEliminarEqui";
            this.ButEliminarEqui.Size = new System.Drawing.Size(75, 23);
            this.ButEliminarEqui.TabIndex = 5;
            this.ButEliminarEqui.Text = "Eliminar";
            this.ButEliminarEqui.UseVisualStyleBackColor = true;
            this.ButEliminarEqui.Click += new System.EventHandler(this.ButEliminarEqui_Click);
            this.ButEliminarEqui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButEliminarEqui_KeyPress);
            // 
            // tbxEliminar
            // 
            this.tbxEliminar.Location = new System.Drawing.Point(159, 42);
            this.tbxEliminar.Name = "tbxEliminar";
            this.tbxEliminar.Size = new System.Drawing.Size(100, 20);
            this.tbxEliminar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID del Equipo a eliminar:";
            // 
            // EliminarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButEliminarEqui);
            this.Controls.Add(this.tbxEliminar);
            this.Controls.Add(this.label1);
            this.Name = "EliminarEquipo";
            this.Text = "EliminarEquipo";
            this.Load += new System.EventHandler(this.EliminarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButEliminarEqui;
        private System.Windows.Forms.TextBox tbxEliminar;
        private System.Windows.Forms.Label label1;
    }
}