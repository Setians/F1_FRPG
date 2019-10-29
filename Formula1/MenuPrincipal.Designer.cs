namespace Formula1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BtnCorredores = new System.Windows.Forms.Button();
            this.btnEscuderias = new System.Windows.Forms.Button();
            this.BtnTorneos = new System.Windows.Forms.Button();
            this.BtnCircuitos = new System.Windows.Forms.Button();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipal.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelPrincipal.Controls.Add(this.PanelContenedor);
            this.PanelPrincipal.Controls.Add(this.BarraTitulo);
            this.PanelPrincipal.Controls.Add(this.MenuVertical);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1284, 650);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1034, 600);
            this.PanelContenedor.TabIndex = 4;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.BtnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Controls.Add(this.BtnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1034, 50);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(966, 12);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 5;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(935, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(966, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(997, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlide.Image")));
            this.BtnSlide.Location = new System.Drawing.Point(6, 9);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(35, 35);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 1;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.White;
            this.MenuVertical.Controls.Add(this.BtnCorredores);
            this.MenuVertical.Controls.Add(this.btnEscuderias);
            this.MenuVertical.Controls.Add(this.BtnTorneos);
            this.MenuVertical.Controls.Add(this.BtnCircuitos);
            this.MenuVertical.Controls.Add(this.PBLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 1;
            // 
            // BtnCorredores
            // 
            this.BtnCorredores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCorredores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCorredores.FlatAppearance.BorderSize = 0;
            this.BtnCorredores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCorredores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCorredores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorredores.Font = new System.Drawing.Font("Formula1 Display Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorredores.Image = ((System.Drawing.Image)(resources.GetObject("BtnCorredores.Image")));
            this.BtnCorredores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorredores.Location = new System.Drawing.Point(0, 83);
            this.BtnCorredores.Name = "BtnCorredores";
            this.BtnCorredores.Size = new System.Drawing.Size(250, 55);
            this.BtnCorredores.TabIndex = 1;
            this.BtnCorredores.Text = "Corredores";
            this.BtnCorredores.UseVisualStyleBackColor = true;
            this.BtnCorredores.Click += new System.EventHandler(this.BtnCorredores_Click);
            // 
            // btnEscuderias
            // 
            this.btnEscuderias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEscuderias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscuderias.FlatAppearance.BorderSize = 0;
            this.btnEscuderias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEscuderias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEscuderias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscuderias.Font = new System.Drawing.Font("Formula1 Display Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuderias.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuderias.Image")));
            this.btnEscuderias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscuderias.Location = new System.Drawing.Point(0, 266);
            this.btnEscuderias.Name = "btnEscuderias";
            this.btnEscuderias.Size = new System.Drawing.Size(250, 55);
            this.btnEscuderias.TabIndex = 4;
            this.btnEscuderias.Text = "Escuderias";
            this.btnEscuderias.UseVisualStyleBackColor = true;
            // 
            // BtnTorneos
            // 
            this.BtnTorneos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnTorneos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTorneos.FlatAppearance.BorderSize = 0;
            this.BtnTorneos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTorneos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnTorneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTorneos.Font = new System.Drawing.Font("Formula1 Display Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTorneos.Image = ((System.Drawing.Image)(resources.GetObject("BtnTorneos.Image")));
            this.BtnTorneos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTorneos.Location = new System.Drawing.Point(0, 205);
            this.BtnTorneos.Name = "BtnTorneos";
            this.BtnTorneos.Size = new System.Drawing.Size(250, 55);
            this.BtnTorneos.TabIndex = 3;
            this.BtnTorneos.Text = "Torneos";
            this.BtnTorneos.UseVisualStyleBackColor = true;
            // 
            // BtnCircuitos
            // 
            this.BtnCircuitos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCircuitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCircuitos.FlatAppearance.BorderSize = 0;
            this.BtnCircuitos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnCircuitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCircuitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircuitos.Font = new System.Drawing.Font("Formula1 Display Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCircuitos.Image = ((System.Drawing.Image)(resources.GetObject("BtnCircuitos.Image")));
            this.BtnCircuitos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCircuitos.Location = new System.Drawing.Point(0, 144);
            this.BtnCircuitos.Name = "BtnCircuitos";
            this.BtnCircuitos.Size = new System.Drawing.Size(250, 55);
            this.BtnCircuitos.TabIndex = 2;
            this.BtnCircuitos.Text = "Circuitos";
            this.BtnCircuitos.UseVisualStyleBackColor = true;
            // 
            // PBLogo
            // 
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(0, 3);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(250, 47);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 0;
            this.PBLogo.TabStop = false;
            // 
            // tmOcultarMenu
            // 
            this.tmOcultarMenu.Tick += new System.EventHandler(this.tmOcultarMenu_Tick);
            // 
            // tmMostrarMenu
            // 
            this.tmMostrarMenu.Tick += new System.EventHandler(this.tmMostrarMenu_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 650);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrinicpal_Load);
            this.PanelPrincipal.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button BtnCorredores;
        private System.Windows.Forms.Button btnEscuderias;
        private System.Windows.Forms.Button BtnTorneos;
        private System.Windows.Forms.Button BtnCircuitos;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.Timer tmOcultarMenu;
        private System.Windows.Forms.Timer tmMostrarMenu;
    }
}

