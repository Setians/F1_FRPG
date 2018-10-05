namespace F1
{
    partial class AgregarCarrera
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
            this.butAgregar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIdTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCarrera = new System.Windows.Forms.DataGridView();
            this.tbxIDCirc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNumeroVueltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(282, 33);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 11;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(157, 9);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 10;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de Carrera:";
            // 
            // tbxIdTempo
            // 
            this.tbxIdTempo.Location = new System.Drawing.Point(157, 35);
            this.tbxIdTempo.Name = "tbxIdTempo";
            this.tbxIdTempo.Size = new System.Drawing.Size(100, 20);
            this.tbxIdTempo.TabIndex = 8;
            this.tbxIdTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIdTempo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Año de Carrera:";
            // 
            // DGVCarrera
            // 
            this.DGVCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCarrera.Location = new System.Drawing.Point(15, 148);
            this.DGVCarrera.Name = "DGVCarrera";
            this.DGVCarrera.Size = new System.Drawing.Size(342, 120);
            this.DGVCarrera.TabIndex = 6;
            // 
            // tbxIDCirc
            // 
            this.tbxIDCirc.Location = new System.Drawing.Point(157, 61);
            this.tbxIDCirc.Name = "tbxIDCirc";
            this.tbxIDCirc.Size = new System.Drawing.Size(100, 20);
            this.tbxIDCirc.TabIndex = 13;
            this.tbxIDCirc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIDCirc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID del Circuito de la Carrera:";
            // 
            // tbxNumeroVueltas
            // 
            this.tbxNumeroVueltas.Location = new System.Drawing.Point(157, 87);
            this.tbxNumeroVueltas.Name = "tbxNumeroVueltas";
            this.tbxNumeroVueltas.Size = new System.Drawing.Size(100, 20);
            this.tbxNumeroVueltas.TabIndex = 15;
            this.tbxNumeroVueltas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumeroVueltas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nro de vueltas de la Carrera:";
            // 
            // tbxDistancia
            // 
            this.tbxDistancia.Location = new System.Drawing.Point(157, 113);
            this.tbxDistancia.Name = "tbxDistancia";
            this.tbxDistancia.Size = new System.Drawing.Size(100, 20);
            this.tbxDistancia.TabIndex = 17;
            this.tbxDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDistancia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Distancia de la Carrera:";
            // 
            // AgregarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 280);
            this.Controls.Add(this.tbxDistancia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNumeroVueltas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxIDCirc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIdTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVCarrera);
            this.Name = "AgregarCarrera";
            this.Text = "AgregarCarrera";
            this.Load += new System.EventHandler(this.AgregarCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIdTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVCarrera;
        private System.Windows.Forms.TextBox tbxIDCirc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNumeroVueltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDistancia;
        private System.Windows.Forms.Label label5;
    }
}