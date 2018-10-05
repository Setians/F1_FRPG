namespace F1
{
    partial class Temporadas
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
            this.butAgregarTemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVTemp = new System.Windows.Forms.DataGridView();
            this.CBXTemp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GBXTemp = new System.Windows.Forms.GroupBox();
            this.ButModificarTemp = new System.Windows.Forms.Button();
            this.butEliminarTemp = new System.Windows.Forms.Button();
            this.GBXCarrera = new System.Windows.Forms.GroupBox();
            this.butModificarCarrera = new System.Windows.Forms.Button();
            this.butEliminarCarrera = new System.Windows.Forms.Button();
            this.butAgregarCarrera = new System.Windows.Forms.Button();
            this.RButXCorredor = new System.Windows.Forms.RadioButton();
            this.RbutXEquipo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTemp2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTemp)).BeginInit();
            this.GBXTemp.SuspendLayout();
            this.GBXCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp2)).BeginInit();
            this.SuspendLayout();
            // 
            // butRegresar
            // 
            this.butRegresar.Location = new System.Drawing.Point(52, 339);
            this.butRegresar.Name = "butRegresar";
            this.butRegresar.Size = new System.Drawing.Size(75, 23);
            this.butRegresar.TabIndex = 0;
            this.butRegresar.Text = "Regresar";
            this.butRegresar.UseVisualStyleBackColor = true;
            // 
            // butAgregarTemp
            // 
            this.butAgregarTemp.Location = new System.Drawing.Point(31, 19);
            this.butAgregarTemp.Name = "butAgregarTemp";
            this.butAgregarTemp.Size = new System.Drawing.Size(95, 23);
            this.butAgregarTemp.TabIndex = 1;
            this.butAgregarTemp.Text = "Agregar";
            this.butAgregarTemp.UseVisualStyleBackColor = true;
            this.butAgregarTemp.Click += new System.EventHandler(this.butAgregarTemp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica LT Std Black", 15.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temporadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVTemp
            // 
            this.DGVTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTemp.Location = new System.Drawing.Point(200, 143);
            this.DGVTemp.Name = "DGVTemp";
            this.DGVTemp.Size = new System.Drawing.Size(393, 237);
            this.DGVTemp.TabIndex = 3;
            // 
            // CBXTemp
            // 
            this.CBXTemp.FormattingEnabled = true;
            this.CBXTemp.Location = new System.Drawing.Point(279, 49);
            this.CBXTemp.Name = "CBXTemp";
            this.CBXTemp.Size = new System.Drawing.Size(121, 21);
            this.CBXTemp.TabIndex = 4;
            this.CBXTemp.SelectedIndexChanged += new System.EventHandler(this.CBXTemp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temporada:";
            // 
            // GBXTemp
            // 
            this.GBXTemp.Controls.Add(this.ButModificarTemp);
            this.GBXTemp.Controls.Add(this.butEliminarTemp);
            this.GBXTemp.Controls.Add(this.butAgregarTemp);
            this.GBXTemp.Location = new System.Drawing.Point(12, 24);
            this.GBXTemp.Name = "GBXTemp";
            this.GBXTemp.Size = new System.Drawing.Size(159, 113);
            this.GBXTemp.TabIndex = 6;
            this.GBXTemp.TabStop = false;
            this.GBXTemp.Text = "Temporada";
            // 
            // ButModificarTemp
            // 
            this.ButModificarTemp.Location = new System.Drawing.Point(31, 77);
            this.ButModificarTemp.Name = "ButModificarTemp";
            this.ButModificarTemp.Size = new System.Drawing.Size(95, 23);
            this.ButModificarTemp.TabIndex = 7;
            this.ButModificarTemp.Text = "Modificar";
            this.ButModificarTemp.UseVisualStyleBackColor = true;
            this.ButModificarTemp.Click += new System.EventHandler(this.ButModificarTemp_Click);
            // 
            // butEliminarTemp
            // 
            this.butEliminarTemp.Location = new System.Drawing.Point(31, 48);
            this.butEliminarTemp.Name = "butEliminarTemp";
            this.butEliminarTemp.Size = new System.Drawing.Size(95, 23);
            this.butEliminarTemp.TabIndex = 8;
            this.butEliminarTemp.Text = "Eliminar";
            this.butEliminarTemp.UseVisualStyleBackColor = true;
            this.butEliminarTemp.Click += new System.EventHandler(this.butEliminarTemp_Click);
            // 
            // GBXCarrera
            // 
            this.GBXCarrera.Controls.Add(this.butModificarCarrera);
            this.GBXCarrera.Controls.Add(this.butEliminarCarrera);
            this.GBXCarrera.Controls.Add(this.butAgregarCarrera);
            this.GBXCarrera.Location = new System.Drawing.Point(12, 143);
            this.GBXCarrera.Name = "GBXCarrera";
            this.GBXCarrera.Size = new System.Drawing.Size(159, 113);
            this.GBXCarrera.TabIndex = 7;
            this.GBXCarrera.TabStop = false;
            this.GBXCarrera.Text = "Carrera";
            // 
            // butModificarCarrera
            // 
            this.butModificarCarrera.Location = new System.Drawing.Point(31, 77);
            this.butModificarCarrera.Name = "butModificarCarrera";
            this.butModificarCarrera.Size = new System.Drawing.Size(95, 23);
            this.butModificarCarrera.TabIndex = 7;
            this.butModificarCarrera.Text = "Modificar";
            this.butModificarCarrera.UseVisualStyleBackColor = true;
            this.butModificarCarrera.Click += new System.EventHandler(this.butModificarCarrera_Click);
            // 
            // butEliminarCarrera
            // 
            this.butEliminarCarrera.Location = new System.Drawing.Point(31, 48);
            this.butEliminarCarrera.Name = "butEliminarCarrera";
            this.butEliminarCarrera.Size = new System.Drawing.Size(95, 23);
            this.butEliminarCarrera.TabIndex = 8;
            this.butEliminarCarrera.Text = "Eliminar";
            this.butEliminarCarrera.UseVisualStyleBackColor = true;
            this.butEliminarCarrera.Click += new System.EventHandler(this.butEliminarCarrera_Click);
            // 
            // butAgregarCarrera
            // 
            this.butAgregarCarrera.Location = new System.Drawing.Point(31, 19);
            this.butAgregarCarrera.Name = "butAgregarCarrera";
            this.butAgregarCarrera.Size = new System.Drawing.Size(95, 23);
            this.butAgregarCarrera.TabIndex = 1;
            this.butAgregarCarrera.Text = "Agregar";
            this.butAgregarCarrera.UseVisualStyleBackColor = true;
            this.butAgregarCarrera.Click += new System.EventHandler(this.butAgregarCarrera_Click);
            // 
            // RButXCorredor
            // 
            this.RButXCorredor.AutoSize = true;
            this.RButXCorredor.Location = new System.Drawing.Point(200, 107);
            this.RButXCorredor.Name = "RButXCorredor";
            this.RButXCorredor.Size = new System.Drawing.Size(134, 17);
            this.RButXCorredor.TabIndex = 8;
            this.RButXCorredor.TabStop = true;
            this.RButXCorredor.Text = "Resultado por Corredor";
            this.RButXCorredor.UseVisualStyleBackColor = true;
            this.RButXCorredor.CheckedChanged += new System.EventHandler(this.RButXCorredor_CheckedChanged);
            // 
            // RbutXEquipo
            // 
            this.RbutXEquipo.AutoSize = true;
            this.RbutXEquipo.Location = new System.Drawing.Point(354, 107);
            this.RbutXEquipo.Name = "RbutXEquipo";
            this.RbutXEquipo.Size = new System.Drawing.Size(127, 17);
            this.RbutXEquipo.TabIndex = 9;
            this.RbutXEquipo.TabStop = true;
            this.RbutXEquipo.Text = "Resultado por Equipo";
            this.RbutXEquipo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Carrera:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Filtrar por Carrera";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Resultado por Carrera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTemp2
            // 
            this.dgvTemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp2.Location = new System.Drawing.Point(205, 43);
            this.dgvTemp2.Name = "dgvTemp2";
            this.dgvTemp2.Size = new System.Drawing.Size(393, 237);
            this.dgvTemp2.TabIndex = 14;
            // 
            // Temporadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 392);
            this.Controls.Add(this.dgvTemp2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RbutXEquipo);
            this.Controls.Add(this.RButXCorredor);
            this.Controls.Add(this.GBXCarrera);
            this.Controls.Add(this.GBXTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBXTemp);
            this.Controls.Add(this.DGVTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRegresar);
            this.Name = "Temporadas";
            this.Text = "F1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Temporadas_FormClosing);
            this.Load += new System.EventHandler(this.Temporadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTemp)).EndInit();
            this.GBXTemp.ResumeLayout(false);
            this.GBXCarrera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butRegresar;
        private System.Windows.Forms.Button butAgregarTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVTemp;
        private System.Windows.Forms.ComboBox CBXTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBXTemp;
        private System.Windows.Forms.Button ButModificarTemp;
        private System.Windows.Forms.Button butEliminarTemp;
        private System.Windows.Forms.GroupBox GBXCarrera;
        private System.Windows.Forms.Button butModificarCarrera;
        private System.Windows.Forms.Button butEliminarCarrera;
        private System.Windows.Forms.Button butAgregarCarrera;
        private System.Windows.Forms.RadioButton RButXCorredor;
        private System.Windows.Forms.RadioButton RbutXEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTemp2;
    }
}