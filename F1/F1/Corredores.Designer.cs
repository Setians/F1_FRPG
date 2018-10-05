namespace F1
{
    partial class Corredores
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
            this.butRegresar = new System.Windows.Forms.Button();
            this.DGVCorredor = new System.Windows.Forms.DataGridView();
            this.ButAgregar = new System.Windows.Forms.Button();
            this.ButEliminar = new System.Windows.Forms.Button();
            this.ButModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCorredor)).BeginInit();
            this.SuspendLayout();
            // 
            // butRegresar
            // 
            this.butRegresar.Location = new System.Drawing.Point(31, 263);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(75, 23);
            this.butRegresar.TabIndex = 1;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = true;
            this.butRegresar.Click += new System.EventHandler(this.butRegresar_Click);
            // 
            // DGVCorredor
            // 
            this.DGVCorredor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCorredor.Location = new System.Drawing.Point(138, 48);
            this.DGVCorredor.Name = "DGVCorredor";
            this.DGVCorredor.ReadOnly = true;
            this.DGVCorredor.Size = new System.Drawing.Size(383, 221);
            this.DGVCorredor.TabIndex = 2;
            // 
            // ButAgregar
            // 
            this.ButAgregar.Location = new System.Drawing.Point(31, 48);
            this.ButAgregar.Name = "ButAgregar";
            this.ButAgregar.Size = new System.Drawing.Size(75, 23);
            this.ButAgregar.TabIndex = 3;
            this.ButAgregar.Text = "Agregar";
            this.ButAgregar.UseVisualStyleBackColor = true;
            this.ButAgregar.Click += new System.EventHandler(this.ButAgregar_Click);
            // 
            // ButEliminar
            // 
            this.ButEliminar.Location = new System.Drawing.Point(31, 78);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(75, 23);
            this.ButEliminar.TabIndex = 4;
            this.ButEliminar.Text = "Eliminar";
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // ButModificar
            // 
            this.ButModificar.Location = new System.Drawing.Point(31, 108);
            this.ButModificar.Name = "ButModificar";
            this.ButModificar.Size = new System.Drawing.Size(75, 23);
            this.ButModificar.TabIndex = 5;
            this.ButModificar.Text = "Modificar";
            this.ButModificar.UseVisualStyleBackColor = true;
            this.ButModificar.Click += new System.EventHandler(this.ButModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Black", 15.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Corredores";
            // 
            // ButRef
            // 
            this.ButRef.Location = new System.Drawing.Point(31, 234);
            this.ButRef.Name = "ButRef";
            this.ButRef.Size = new System.Drawing.Size(75, 23);
            this.ButRef.TabIndex = 7;
            this.ButRef.Text = "Refrescar";
            this.ButRef.UseVisualStyleBackColor = true;
            this.ButRef.Click += new System.EventHandler(this.ButRef_Click);
            // 
            // Corredores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 313);
            this.Controls.Add(this.ButRef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButModificar);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.ButAgregar);
            this.Controls.Add(this.DGVCorredor);
            this.Controls.Add(this.butRegresar);
            this.Name = "Corredores";
            this.Text = "F1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Corredores_FormClosing);
            this.Load += new System.EventHandler(this.Corredores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCorredor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRegresar;
        public System.Windows.Forms.DataGridView DGVCorredor;
        private System.Windows.Forms.Button ButAgregar;
        private System.Windows.Forms.Button ButEliminar;
        private System.Windows.Forms.Button ButModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButRef;
    }
}