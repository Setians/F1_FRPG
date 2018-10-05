namespace F1
{
    partial class ModificarTemporada
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVTemporada = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButBuscarDatosID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTemporada)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(148, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Año de Temporada:";
            // 
            // DGVTemporada
            // 
            this.DGVTemporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTemporada.Location = new System.Drawing.Point(12, 99);
            this.DGVTemporada.Name = "DGVTemporada";
            this.DGVTemporada.Size = new System.Drawing.Size(332, 157);
            this.DGVTemporada.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre de Temporada:";
            // 
            // ButBuscarDatosID
            // 
            this.ButBuscarDatosID.Location = new System.Drawing.Point(32, 44);
            this.ButBuscarDatosID.Name = "ButBuscarDatosID";
            this.ButBuscarDatosID.Size = new System.Drawing.Size(147, 23);
            this.ButBuscarDatosID.TabIndex = 62;
            this.ButBuscarDatosID.Text = "Lenar con datos actuales";
            this.ButBuscarDatosID.UseVisualStyleBackColor = true;
            this.ButBuscarDatosID.Click += new System.EventHandler(this.ButBuscarDatosID_Click);
            // 
            // ModificarTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButBuscarDatosID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVTemporada);
            this.Name = "ModificarTemporada";
            this.Text = "ModificarTemporada";
            this.Load += new System.EventHandler(this.ModificarTemporada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTemporada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVTemporada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButBuscarDatosID;
    }
}