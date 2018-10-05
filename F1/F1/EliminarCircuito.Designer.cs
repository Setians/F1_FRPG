namespace F1
{
    partial class EliminarCircuito
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
            this.ButEliminarCirc = new System.Windows.Forms.Button();
            this.tbxEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButEliminarCirc
            // 
            this.ButEliminarCirc.Location = new System.Drawing.Point(171, 168);
            this.ButEliminarCirc.Name = "ButEliminarCirc";
            this.ButEliminarCirc.Size = new System.Drawing.Size(75, 23);
            this.ButEliminarCirc.TabIndex = 5;
            this.ButEliminarCirc.Text = "Eliminar";
            this.ButEliminarCirc.UseVisualStyleBackColor = true;
            this.ButEliminarCirc.Click += new System.EventHandler(this.ButEliminarCirc_Click);
            this.ButEliminarCirc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButEliminarCirc_KeyPress);
            // 
            // tbxEliminar
            // 
            this.tbxEliminar.Location = new System.Drawing.Point(187, 73);
            this.tbxEliminar.Name = "tbxEliminar";
            this.tbxEliminar.Size = new System.Drawing.Size(100, 20);
            this.tbxEliminar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID del circuito a eliminar:";
            // 
            // EliminarCircuito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButEliminarCirc);
            this.Controls.Add(this.tbxEliminar);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCircuito";
            this.Text = "EliminarCircuito";
            this.Load += new System.EventHandler(this.EliminarCircuito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButEliminarCirc;
        private System.Windows.Forms.TextBox tbxEliminar;
        private System.Windows.Forms.Label label1;
    }
}