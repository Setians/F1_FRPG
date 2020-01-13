namespace Formula1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circuitos));
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.DGVCircuitos = new System.Windows.Forms.DataGridView();
            this.PanelCorredores = new System.Windows.Forms.Panel();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.pbx_Circuito_Carga = new System.Windows.Forms.PictureBox();
            this.lblPGP_D = new System.Windows.Forms.Label();
            this.lblPrimerGP = new System.Windows.Forms.Label();
            this.lblLongitud_D = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblPais_D = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.PanelFiltros = new System.Windows.Forms.Panel();
            this.btnAgregarCircuito = new System.Windows.Forms.Button();
            this.PBXCircuito = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPrimerGP = new System.Windows.Forms.TextBox();
            this.TxtLongitud = new System.Windows.Forms.TextBox();
            this.TxtLugar = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_A_Circuito = new System.Windows.Forms.Label();
            this.CbxFiltroTemporada = new System.Windows.Forms.ComboBox();
            this.cbxOrdenadosPrimerGP = new System.Windows.Forms.CheckBox();
            this.ChxMayorLongitud = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMPrimerGP = new System.Windows.Forms.TextBox();
            this.txtMNombre = new System.Windows.Forms.TextBox();
            this.txtMLongitud = new System.Windows.Forms.TextBox();
            this.txtMPais = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCircuitos)).BeginInit();
            this.PanelCorredores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Circuito_Carga)).BeginInit();
            this.PanelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXCircuito)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(11, 14);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVCircuitos
            // 
            this.DGVCircuitos.AllowUserToAddRows = false;
            this.DGVCircuitos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.DGVCircuitos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCircuitos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVCircuitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCircuitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCircuitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCircuitos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCircuitos.EnableHeadersVisualStyles = false;
            this.DGVCircuitos.Location = new System.Drawing.Point(12, 25);
            this.DGVCircuitos.Name = "DGVCircuitos";
            this.DGVCircuitos.ReadOnly = true;
            this.DGVCircuitos.RowHeadersVisible = false;
            this.DGVCircuitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCircuitos.ShowEditingIcon = false;
            this.DGVCircuitos.Size = new System.Drawing.Size(335, 505);
            this.DGVCircuitos.TabIndex = 1;
            this.DGVCircuitos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGVCircuitos_RowStateChanged);
            // 
            // PanelCorredores
            // 
            this.PanelCorredores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCorredores.BackColor = System.Drawing.Color.White;
            this.PanelCorredores.Controls.Add(this.btnModificar);
            this.PanelCorredores.Controls.Add(this.txtMPais);
            this.PanelCorredores.Controls.Add(this.txtMLongitud);
            this.PanelCorredores.Controls.Add(this.txtMNombre);
            this.PanelCorredores.Controls.Add(this.txtMPrimerGP);
            this.PanelCorredores.Controls.Add(this.btnFiltros);
            this.PanelCorredores.Controls.Add(this.pbx_Circuito_Carga);
            this.PanelCorredores.Controls.Add(this.lblPGP_D);
            this.PanelCorredores.Controls.Add(this.lblPrimerGP);
            this.PanelCorredores.Controls.Add(this.lblLongitud_D);
            this.PanelCorredores.Controls.Add(this.lblLongitud);
            this.PanelCorredores.Controls.Add(this.lblPais_D);
            this.PanelCorredores.Controls.Add(this.lblPais);
            this.PanelCorredores.Controls.Add(this.lblNombre);
            this.PanelCorredores.Controls.Add(this.btn_Cerrar);
            this.PanelCorredores.Location = new System.Drawing.Point(353, 25);
            this.PanelCorredores.Name = "PanelCorredores";
            this.PanelCorredores.Size = new System.Drawing.Size(653, 505);
            this.PanelCorredores.TabIndex = 2;
            this.PanelCorredores.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Location = new System.Drawing.Point(11, 55);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(117, 23);
            this.btnFiltros.TabIndex = 21;
            this.btnFiltros.Text = "Filtrar/Buscar";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.BtnFiltros_Click);
            // 
            // pbx_Circuito_Carga
            // 
            this.pbx_Circuito_Carga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_Circuito_Carga.Location = new System.Drawing.Point(6, 270);
            this.pbx_Circuito_Carga.Name = "pbx_Circuito_Carga";
            this.pbx_Circuito_Carga.Size = new System.Drawing.Size(636, 219);
            this.pbx_Circuito_Carga.TabIndex = 18;
            this.pbx_Circuito_Carga.TabStop = false;
            // 
            // lblPGP_D
            // 
            this.lblPGP_D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPGP_D.AutoSize = true;
            this.lblPGP_D.Location = new System.Drawing.Point(373, 210);
            this.lblPGP_D.Name = "lblPGP_D";
            this.lblPGP_D.Size = new System.Drawing.Size(35, 13);
            this.lblPGP_D.TabIndex = 7;
            this.lblPGP_D.Text = "label8";
            // 
            // lblPrimerGP
            // 
            this.lblPrimerGP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrimerGP.AutoSize = true;
            this.lblPrimerGP.Location = new System.Drawing.Point(135, 210);
            this.lblPrimerGP.Name = "lblPrimerGP";
            this.lblPrimerGP.Size = new System.Drawing.Size(88, 13);
            this.lblPrimerGP.TabIndex = 6;
            this.lblPrimerGP.Text = "Primer Grand Prix";
            // 
            // lblLongitud_D
            // 
            this.lblLongitud_D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLongitud_D.AutoSize = true;
            this.lblLongitud_D.Location = new System.Drawing.Point(373, 185);
            this.lblLongitud_D.Name = "lblLongitud_D";
            this.lblLongitud_D.Size = new System.Drawing.Size(35, 13);
            this.lblLongitud_D.TabIndex = 5;
            this.lblLongitud_D.Text = "label6";
            // 
            // lblLongitud
            // 
            this.lblLongitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(135, 185);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(48, 13);
            this.lblLongitud.TabIndex = 4;
            this.lblLongitud.Text = "Longitud";
            // 
            // lblPais_D
            // 
            this.lblPais_D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPais_D.AutoSize = true;
            this.lblPais_D.Location = new System.Drawing.Point(373, 163);
            this.lblPais_D.Name = "lblPais_D";
            this.lblPais_D.Size = new System.Drawing.Size(35, 13);
            this.lblPais_D.TabIndex = 3;
            this.lblPais_D.Text = "label4";
            // 
            // lblPais
            // 
            this.lblPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(135, 163);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(223, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // PanelFiltros
            // 
            this.PanelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFiltros.BackColor = System.Drawing.Color.White;
            this.PanelFiltros.Controls.Add(this.btnAgregarCircuito);
            this.PanelFiltros.Controls.Add(this.PBXCircuito);
            this.PanelFiltros.Controls.Add(this.panel1);
            this.PanelFiltros.Controls.Add(this.TxtPrimerGP);
            this.PanelFiltros.Controls.Add(this.TxtLongitud);
            this.PanelFiltros.Controls.Add(this.TxtLugar);
            this.PanelFiltros.Controls.Add(this.TxtNombre);
            this.PanelFiltros.Controls.Add(this.label11);
            this.PanelFiltros.Controls.Add(this.label9);
            this.PanelFiltros.Controls.Add(this.label7);
            this.PanelFiltros.Controls.Add(this.label5);
            this.PanelFiltros.Controls.Add(this.lbl_A_Circuito);
            this.PanelFiltros.Controls.Add(this.CbxFiltroTemporada);
            this.PanelFiltros.Controls.Add(this.cbxOrdenadosPrimerGP);
            this.PanelFiltros.Controls.Add(this.ChxMayorLongitud);
            this.PanelFiltros.Controls.Add(this.label22);
            this.PanelFiltros.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelFiltros.Location = new System.Drawing.Point(353, 25);
            this.PanelFiltros.Name = "PanelFiltros";
            this.PanelFiltros.Size = new System.Drawing.Size(653, 505);
            this.PanelFiltros.TabIndex = 3;
            // 
            // btnAgregarCircuito
            // 
            this.btnAgregarCircuito.Location = new System.Drawing.Point(16, 279);
            this.btnAgregarCircuito.Name = "btnAgregarCircuito";
            this.btnAgregarCircuito.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCircuito.TabIndex = 42;
            this.btnAgregarCircuito.Text = "Agregar";
            this.btnAgregarCircuito.UseVisualStyleBackColor = true;
            this.btnAgregarCircuito.Click += new System.EventHandler(this.btnAgregarCircuito_Click);
            // 
            // PBXCircuito
            // 
            this.PBXCircuito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBXCircuito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBXCircuito.Image = ((System.Drawing.Image)(resources.GetObject("PBXCircuito.Image")));
            this.PBXCircuito.Location = new System.Drawing.Point(248, 226);
            this.PBXCircuito.Name = "PBXCircuito";
            this.PBXCircuito.Size = new System.Drawing.Size(394, 258);
            this.PBXCircuito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXCircuito.TabIndex = 41;
            this.PBXCircuito.TabStop = false;
            this.PBXCircuito.Click += new System.EventHandler(this.PBXCircuito_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 10);
            this.panel1.TabIndex = 29;
            // 
            // TxtPrimerGP
            // 
            this.TxtPrimerGP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrimerGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtPrimerGP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrimerGP.Location = new System.Drawing.Point(16, 469);
            this.TxtPrimerGP.Name = "TxtPrimerGP";
            this.TxtPrimerGP.Size = new System.Drawing.Size(226, 13);
            this.TxtPrimerGP.TabIndex = 39;
            // 
            // TxtLongitud
            // 
            this.TxtLongitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLongitud.Location = new System.Drawing.Point(16, 430);
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.Size = new System.Drawing.Size(226, 13);
            this.TxtLongitud.TabIndex = 38;
            // 
            // TxtLugar
            // 
            this.TxtLugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLugar.Location = new System.Drawing.Point(16, 391);
            this.TxtLugar.Name = "TxtLugar";
            this.TxtLugar.Size = new System.Drawing.Size(226, 13);
            this.TxtLugar.TabIndex = 37;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Location = new System.Drawing.Point(16, 352);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(226, 13);
            this.TxtNombre.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Primer Gran Prix";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Pais/ Lugar";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Longitud";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre";
            // 
            // lbl_A_Circuito
            // 
            this.lbl_A_Circuito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_A_Circuito.AutoSize = true;
            this.lbl_A_Circuito.Location = new System.Drawing.Point(13, 241);
            this.lbl_A_Circuito.Name = "lbl_A_Circuito";
            this.lbl_A_Circuito.Size = new System.Drawing.Size(82, 13);
            this.lbl_A_Circuito.TabIndex = 30;
            this.lbl_A_Circuito.Text = "Agregar Circuito";
            // 
            // CbxFiltroTemporada
            // 
            this.CbxFiltroTemporada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxFiltroTemporada.FormattingEnabled = true;
            this.CbxFiltroTemporada.Location = new System.Drawing.Point(190, 38);
            this.CbxFiltroTemporada.Name = "CbxFiltroTemporada";
            this.CbxFiltroTemporada.Size = new System.Drawing.Size(121, 21);
            this.CbxFiltroTemporada.TabIndex = 26;
            this.CbxFiltroTemporada.SelectedIndexChanged += new System.EventHandler(this.ddlFiltroTemporadas_SelectedIndexChanged);
            // 
            // cbxOrdenadosPrimerGP
            // 
            this.cbxOrdenadosPrimerGP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrdenadosPrimerGP.AutoSize = true;
            this.cbxOrdenadosPrimerGP.Location = new System.Drawing.Point(57, 115);
            this.cbxOrdenadosPrimerGP.Name = "cbxOrdenadosPrimerGP";
            this.cbxOrdenadosPrimerGP.Size = new System.Drawing.Size(146, 17);
            this.cbxOrdenadosPrimerGP.TabIndex = 24;
            this.cbxOrdenadosPrimerGP.Text = "Ordenados por Primer GP";
            this.cbxOrdenadosPrimerGP.UseVisualStyleBackColor = true;
            this.cbxOrdenadosPrimerGP.CheckedChanged += new System.EventHandler(this.cbxOrdenadosPrimerGP_CheckedChanged);
            // 
            // ChxMayorLongitud
            // 
            this.ChxMayorLongitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChxMayorLongitud.AutoSize = true;
            this.ChxMayorLongitud.Location = new System.Drawing.Point(57, 79);
            this.ChxMayorLongitud.Name = "ChxMayorLongitud";
            this.ChxMayorLongitud.Size = new System.Drawing.Size(140, 17);
            this.ChxMayorLongitud.TabIndex = 23;
            this.ChxMayorLongitud.Text = "Ordenados por Longitud";
            this.ChxMayorLongitud.UseVisualStyleBackColor = true;
            this.ChxMayorLongitud.CheckedChanged += new System.EventHandler(this.ChxMayorLongitud_CheckedChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(54, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Temporada";
            // 
            // txtMPrimerGP
            // 
            this.txtMPrimerGP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMPrimerGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMPrimerGP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPrimerGP.Location = new System.Drawing.Point(376, 84);
            this.txtMPrimerGP.Name = "txtMPrimerGP";
            this.txtMPrimerGP.Size = new System.Drawing.Size(123, 13);
            this.txtMPrimerGP.TabIndex = 37;
            // 
            // txtMNombre
            // 
            this.txtMNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMNombre.Location = new System.Drawing.Point(376, 24);
            this.txtMNombre.Name = "txtMNombre";
            this.txtMNombre.Size = new System.Drawing.Size(123, 13);
            this.txtMNombre.TabIndex = 38;
            // 
            // txtMLongitud
            // 
            this.txtMLongitud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMLongitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMLongitud.Location = new System.Drawing.Point(376, 65);
            this.txtMLongitud.Name = "txtMLongitud";
            this.txtMLongitud.Size = new System.Drawing.Size(123, 13);
            this.txtMLongitud.TabIndex = 39;
            // 
            // txtMPais
            // 
            this.txtMPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPais.Location = new System.Drawing.Point(376, 46);
            this.txtMPais.Name = "txtMPais";
            this.txtMPais.Size = new System.Drawing.Size(123, 13);
            this.txtMPais.TabIndex = 40;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 41;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Circuitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1018, 559);
            this.Controls.Add(this.DGVCircuitos);
            this.Controls.Add(this.PanelCorredores);
            this.Controls.Add(this.PanelFiltros);
            this.Name = "Circuitos";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Circuitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCircuitos)).EndInit();
            this.PanelCorredores.ResumeLayout(false);
            this.PanelCorredores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Circuito_Carga)).EndInit();
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXCircuito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView DGVCircuitos;
        private System.Windows.Forms.Panel PanelCorredores;
        private System.Windows.Forms.PictureBox pbx_Circuito_Carga;
        private System.Windows.Forms.Label lblPGP_D;
        private System.Windows.Forms.Label lblPrimerGP;
        private System.Windows.Forms.Label lblLongitud_D;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblPais_D;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Panel PanelFiltros;
        private System.Windows.Forms.ComboBox CbxFiltroTemporada;
        private System.Windows.Forms.CheckBox cbxOrdenadosPrimerGP;
        private System.Windows.Forms.CheckBox ChxMayorLongitud;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_A_Circuito;
        private System.Windows.Forms.TextBox TxtPrimerGP;
        private System.Windows.Forms.TextBox TxtLongitud;
        private System.Windows.Forms.TextBox TxtLugar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.PictureBox PBXCircuito;
        private System.Windows.Forms.Button btnAgregarCircuito;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtMPais;
        private System.Windows.Forms.TextBox txtMLongitud;
        private System.Windows.Forms.TextBox txtMNombre;
        private System.Windows.Forms.TextBox txtMPrimerGP;
        private System.Windows.Forms.Button btnModificar;
    }
}