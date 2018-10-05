namespace F1
{
    partial class Equipos
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
            this.DGVEquipos = new System.Windows.Forms.DataGridView();
            this.butRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // ButRef
            // 
            this.ButRef.Location = new System.Drawing.Point(21, 243);
            this.ButRef.Name = "ButRef";
            this.ButRef.Size = new System.Drawing.Size(75, 23);
            this.ButRef.TabIndex = 14;
            this.ButRef.Text = "Refrescar";
            this.ButRef.UseVisualStyleBackColor = true;
            this.ButRef.Click += new System.EventHandler(this.ButRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Black", 15.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equipos(Constructores)";
            // 
            // ButModificar
            // 
            this.ButModificar.Location = new System.Drawing.Point(21, 117);
            this.ButModificar.Name = "ButModificar";
            this.ButModificar.Size = new System.Drawing.Size(75, 23);
            this.ButModificar.TabIndex = 12;
            this.ButModificar.Text = "Modificar";
            this.ButModificar.UseVisualStyleBackColor = true;
            this.ButModificar.Click += new System.EventHandler(this.ButModificar_Click);
            // 
            // ButEliminar
            // 
            this.ButEliminar.Location = new System.Drawing.Point(21, 87);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(75, 23);
            this.ButEliminar.TabIndex = 11;
            this.ButEliminar.Text = "Eliminar";
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // ButAgregar
            // 
            this.ButAgregar.Location = new System.Drawing.Point(21, 57);
            this.ButAgregar.Name = "ButAgregar";
            this.ButAgregar.Size = new System.Drawing.Size(75, 23);
            this.ButAgregar.TabIndex = 10;
            this.ButAgregar.Text = "Agregar";
            this.ButAgregar.UseVisualStyleBackColor = true;
            this.ButAgregar.Click += new System.EventHandler(this.ButAgregar_Click);
            // 
            // DGVEquipos
            // 
            this.DGVEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEquipos.Location = new System.Drawing.Point(128, 57);
            this.DGVEquipos.Name = "DGVEquipos";
            this.DGVEquipos.ReadOnly = true;
            this.DGVEquipos.Size = new System.Drawing.Size(383, 221);
            this.DGVEquipos.TabIndex = 9;
            // 
            // butRegresar
            // 
            this.butRegresar.Location = new System.Drawing.Point(21, 272);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(75, 23);
            this.butRegresar.TabIndex = 8;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = true;
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.ButRef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButModificar);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.ButAgregar);
            this.Controls.Add(this.DGVEquipos);
            this.Controls.Add(this.butRegresar);
            this.Name = "Equipos";
            this.Text = "F1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Equipos_FormClosing);
            this.Load += new System.EventHandler(this.Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButModificar;
        private System.Windows.Forms.Button ButEliminar;
        private System.Windows.Forms.Button ButAgregar;
        public System.Windows.Forms.DataGridView DGVEquipos;
        private System.Windows.Forms.Button butRegresar;
    }
}