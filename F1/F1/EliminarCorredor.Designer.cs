namespace F1
{
    partial class EliminarCorredor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEliminar = new System.Windows.Forms.TextBox();
            this.ButEliminarCorr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del corredor a eliminar:";
            // 
            // tbxEliminar
            // 
            this.tbxEliminar.Location = new System.Drawing.Point(145, 50);
            this.tbxEliminar.Name = "tbxEliminar";
            this.tbxEliminar.Size = new System.Drawing.Size(100, 20);
            this.tbxEliminar.TabIndex = 1;
            this.tbxEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEliminar_KeyPress);
            // 
            // ButEliminarCorr
            // 
            this.ButEliminarCorr.Location = new System.Drawing.Point(129, 145);
            this.ButEliminarCorr.Name = "ButEliminarCorr";
            this.ButEliminarCorr.Size = new System.Drawing.Size(75, 23);
            this.ButEliminarCorr.TabIndex = 2;
            this.ButEliminarCorr.Text = "Eliminar";
            this.ButEliminarCorr.UseVisualStyleBackColor = true;
            this.ButEliminarCorr.Click += new System.EventHandler(this.ButEliminarCorr_Click);
            // 
            // EliminarCorredor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButEliminarCorr);
            this.Controls.Add(this.tbxEliminar);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCorredor";
            this.Text = "EliminarCorredor";
            this.Load += new System.EventHandler(this.EliminarCorredor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEliminar;
        private System.Windows.Forms.Button ButEliminarCorr;
    }
}