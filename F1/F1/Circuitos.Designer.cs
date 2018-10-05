namespace F1
{
    partial class Circuitos
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
            this.ButRef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButModificar = new System.Windows.Forms.Button();
            this.ButEliminar = new System.Windows.Forms.Button();
            this.ButAgregar = new System.Windows.Forms.Button();
            this.DGVCircuitos = new System.Windows.Forms.DataGridView();
            this.butRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCircuitos)).BeginInit();
            this.SuspendLayout();
            // 
            // ButRef
            // 
            this.ButRef.Location = new System.Drawing.Point(21, 247);
            this.ButRef.Name = "ButRef";
            this.ButRef.Size = new System.Drawing.Size(75, 23);
            this.ButRef.TabIndex = 21;
            this.ButRef.Text = "Refrescar";
            this.ButRef.UseVisualStyleBackColor = true;
            this.ButRef.Click += new System.EventHandler(this.ButRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Black", 15.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Circuitos";
            // 
            // ButModificar
            // 
            this.ButModificar.Location = new System.Drawing.Point(21, 121);
            this.ButModificar.Name = "ButModificar";
            this.ButModificar.Size = new System.Drawing.Size(75, 23);
            this.ButModificar.TabIndex = 19;
            this.ButModificar.Text = "Modificar";
            this.ButModificar.UseVisualStyleBackColor = true;
            this.ButModificar.Click += new System.EventHandler(this.ButModificar_Click);
            // 
            // ButEliminar
            // 
            this.ButEliminar.Location = new System.Drawing.Point(21, 91);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(75, 23);
            this.ButEliminar.TabIndex = 18;
            this.ButEliminar.Text = "Eliminar";
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // ButAgregar
            // 
            this.ButAgregar.Location = new System.Drawing.Point(21, 61);
            this.ButAgregar.Name = "ButAgregar";
            this.ButAgregar.Size = new System.Drawing.Size(75, 23);
            this.ButAgregar.TabIndex = 17;
            this.ButAgregar.Text = "Agregar";
            this.ButAgregar.UseVisualStyleBackColor = true;
            this.ButAgregar.Click += new System.EventHandler(this.ButAgregar_Click);
            // 
            // DGVCircuitos
            // 
            this.DGVCircuitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCircuitos.Location = new System.Drawing.Point(128, 61);
            this.DGVCircuitos.Name = "DGVCircuitos";
            this.DGVCircuitos.ReadOnly = true;
            this.DGVCircuitos.Size = new System.Drawing.Size(383, 221);
            this.DGVCircuitos.TabIndex = 16;
            // 
            // butRegresar
            // 
            this.butRegresar.Location = new System.Drawing.Point(21, 276);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(75, 23);
            this.butRegresar.TabIndex = 15;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = true;
            // 
            // Circuitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.ButRef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButModificar);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.ButAgregar);
            this.Controls.Add(this.DGVCircuitos);
            this.Controls.Add(this.butRegresar);
            this.Name = "Circuitos";
            this.Text = "Circuitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Circuitos_FormClosing);
            this.Load += new System.EventHandler(this.Circuitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCircuitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButModificar;
        private System.Windows.Forms.Button ButEliminar;
        private System.Windows.Forms.Button ButAgregar;
        public System.Windows.Forms.DataGridView DGVCircuitos;
        private System.Windows.Forms.Button butRegresar;
    }
}