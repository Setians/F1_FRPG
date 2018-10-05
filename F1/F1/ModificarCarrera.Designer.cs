namespace F1
{
    partial class ModificarCarrera
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
            this.tbxDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNumeroVueltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIDCirc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butModificar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIdTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCarrera = new System.Windows.Forms.DataGridView();
            this.ButBuscarDatosID = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDistancia
            // 
            this.tbxDistancia.Location = new System.Drawing.Point(159, 174);
            this.tbxDistancia.Name = "tbxDistancia";
            this.tbxDistancia.Size = new System.Drawing.Size(100, 20);
            this.tbxDistancia.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Distancia de la Carrera:";
            // 
            // tbxNumeroVueltas
            // 
            this.tbxNumeroVueltas.Location = new System.Drawing.Point(159, 148);
            this.tbxNumeroVueltas.Name = "tbxNumeroVueltas";
            this.tbxNumeroVueltas.Size = new System.Drawing.Size(100, 20);
            this.tbxNumeroVueltas.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nro de vueltas de la Carrera:";
            // 
            // tbxIDCirc
            // 
            this.tbxIDCirc.Location = new System.Drawing.Point(159, 122);
            this.tbxIDCirc.Name = "tbxIDCirc";
            this.tbxIDCirc.Size = new System.Drawing.Size(100, 20);
            this.tbxIDCirc.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID del Circuito de la Carrera:";
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(282, 167);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 23;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(159, 70);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre de Carrera:";
            // 
            // tbxIdTempo
            // 
            this.tbxIdTempo.Location = new System.Drawing.Point(159, 96);
            this.tbxIdTempo.Name = "tbxIdTempo";
            this.tbxIdTempo.Size = new System.Drawing.Size(100, 20);
            this.tbxIdTempo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Año de Carrera:";
            // 
            // DGVCarrera
            // 
            this.DGVCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCarrera.Location = new System.Drawing.Point(17, 205);
            this.DGVCarrera.Name = "DGVCarrera";
            this.DGVCarrera.Size = new System.Drawing.Size(340, 66);
            this.DGVCarrera.TabIndex = 18;
            // 
            // ButBuscarDatosID
            // 
            this.ButBuscarDatosID.Location = new System.Drawing.Point(26, 38);
            this.ButBuscarDatosID.Name = "ButBuscarDatosID";
            this.ButBuscarDatosID.Size = new System.Drawing.Size(147, 23);
            this.ButBuscarDatosID.TabIndex = 65;
            this.ButBuscarDatosID.Text = "Lenar con datos actuales";
            this.ButBuscarDatosID.UseVisualStyleBackColor = true;
            this.ButBuscarDatosID.Click += new System.EventHandler(this.ButBuscarDatosID_Click);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(159, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "ID de Carrera:";
            // 
            // ModificarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.ButBuscarDatosID);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxDistancia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNumeroVueltas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxIDCirc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIdTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVCarrera);
            this.Name = "ModificarCarrera";
            this.Text = "ModificarCarrera";
            this.Load += new System.EventHandler(this.ModificarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNumeroVueltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIDCirc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIdTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVCarrera;
        private System.Windows.Forms.Button ButBuscarDatosID;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label6;
    }
}