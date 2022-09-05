namespace Teatros
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbDescuentos = new System.Windows.Forms.GroupBox();
            this.rbt20 = new System.Windows.Forms.RadioButton();
            this.rbt3x2 = new System.Windows.Forms.RadioButton();
            this.rbt2x1 = new System.Windows.Forms.RadioButton();
            this.gbTickets = new System.Windows.Forms.GroupBox();
            this.nudNiños = new System.Windows.Forms.NumericUpDown();
            this.nudAdultosMayores = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblNiño = new System.Windows.Forms.Label();
            this.lblAdultoMayor = new System.Windows.Forms.Label();
            this.lblAdulto = new System.Windows.Forms.Label();
            this.gbCartelera = new System.Windows.Forms.GroupBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.lblCartelera = new System.Windows.Forms.Label();
            this.gbTeatros = new System.Windows.Forms.GroupBox();
            this.rbtLucho = new System.Windows.Forms.RadioButton();
            this.rbtVariedades = new System.Windows.Forms.RadioButton();
            this.rbtMelico = new System.Windows.Forms.RadioButton();
            this.btnComprar = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbDescuentos.SuspendLayout();
            this.gbTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultosMayores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            this.gbCartelera.SuspendLayout();
            this.gbTeatros.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gbDescuentos);
            this.splitContainer.Panel1.Controls.Add(this.gbTickets);
            this.splitContainer.Panel1.Controls.Add(this.gbCartelera);
            this.splitContainer.Panel1.Controls.Add(this.gbTeatros);
            this.splitContainer.Panel1.Controls.Add(this.btnComprar);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel1_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer.Size = new System.Drawing.Size(781, 432);
            this.splitContainer.SplitterDistance = 428;
            this.splitContainer.TabIndex = 5;
            // 
            // gbDescuentos
            // 
            this.gbDescuentos.Controls.Add(this.rbt20);
            this.gbDescuentos.Controls.Add(this.rbt3x2);
            this.gbDescuentos.Controls.Add(this.rbt2x1);
            this.gbDescuentos.Location = new System.Drawing.Point(276, 231);
            this.gbDescuentos.Name = "gbDescuentos";
            this.gbDescuentos.Size = new System.Drawing.Size(140, 130);
            this.gbDescuentos.TabIndex = 9;
            this.gbDescuentos.TabStop = false;
            this.gbDescuentos.Text = "Descuentos";
            // 
            // rbt20
            // 
            this.rbt20.AutoSize = true;
            this.rbt20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt20.Location = new System.Drawing.Point(41, 88);
            this.rbt20.Name = "rbt20";
            this.rbt20.Size = new System.Drawing.Size(59, 22);
            this.rbt20.TabIndex = 2;
            this.rbt20.Text = "20 %";
            this.rbt20.UseVisualStyleBackColor = true;
            // 
            // rbt3x2
            // 
            this.rbt3x2.AutoSize = true;
            this.rbt3x2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt3x2.Location = new System.Drawing.Point(41, 59);
            this.rbt3x2.Name = "rbt3x2";
            this.rbt3x2.Size = new System.Drawing.Size(58, 22);
            this.rbt3x2.TabIndex = 1;
            this.rbt3x2.Text = "3 x 2";
            this.rbt3x2.UseVisualStyleBackColor = true;
            // 
            // rbt2x1
            // 
            this.rbt2x1.AutoSize = true;
            this.rbt2x1.Checked = true;
            this.rbt2x1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt2x1.Location = new System.Drawing.Point(41, 30);
            this.rbt2x1.Name = "rbt2x1";
            this.rbt2x1.Size = new System.Drawing.Size(58, 22);
            this.rbt2x1.TabIndex = 0;
            this.rbt2x1.TabStop = true;
            this.rbt2x1.Text = "2 x 1";
            this.rbt2x1.UseVisualStyleBackColor = true;
            // 
            // gbTickets
            // 
            this.gbTickets.Controls.Add(this.nudNiños);
            this.gbTickets.Controls.Add(this.nudAdultosMayores);
            this.gbTickets.Controls.Add(this.nudAdultos);
            this.gbTickets.Controls.Add(this.lblNiño);
            this.gbTickets.Controls.Add(this.lblAdultoMayor);
            this.gbTickets.Controls.Add(this.lblAdulto);
            this.gbTickets.Location = new System.Drawing.Point(12, 231);
            this.gbTickets.Name = "gbTickets";
            this.gbTickets.Size = new System.Drawing.Size(258, 130);
            this.gbTickets.TabIndex = 8;
            this.gbTickets.TabStop = false;
            this.gbTickets.Text = "Tickets";
            // 
            // nudNiños
            // 
            this.nudNiños.Location = new System.Drawing.Point(130, 94);
            this.nudNiños.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNiños.Name = "nudNiños";
            this.nudNiños.Size = new System.Drawing.Size(85, 23);
            this.nudNiños.TabIndex = 6;
            // 
            // nudAdultosMayores
            // 
            this.nudAdultosMayores.Location = new System.Drawing.Point(130, 60);
            this.nudAdultosMayores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAdultosMayores.Name = "nudAdultosMayores";
            this.nudAdultosMayores.Size = new System.Drawing.Size(85, 23);
            this.nudAdultosMayores.TabIndex = 5;
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(130, 26);
            this.nudAdultos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(85, 23);
            this.nudAdultos.TabIndex = 4;
            // 
            // lblNiño
            // 
            this.lblNiño.AutoSize = true;
            this.lblNiño.Location = new System.Drawing.Point(11, 96);
            this.lblNiño.Name = "lblNiño";
            this.lblNiño.Size = new System.Drawing.Size(43, 17);
            this.lblNiño.TabIndex = 3;
            this.lblNiño.Text = "Niños";
            // 
            // lblAdultoMayor
            // 
            this.lblAdultoMayor.AutoSize = true;
            this.lblAdultoMayor.Location = new System.Drawing.Point(10, 62);
            this.lblAdultoMayor.Name = "lblAdultoMayor";
            this.lblAdultoMayor.Size = new System.Drawing.Size(114, 17);
            this.lblAdultoMayor.TabIndex = 2;
            this.lblAdultoMayor.Text = "Adultos mayores";
            // 
            // lblAdulto
            // 
            this.lblAdulto.AutoSize = true;
            this.lblAdulto.Location = new System.Drawing.Point(11, 28);
            this.lblAdulto.Name = "lblAdulto";
            this.lblAdulto.Size = new System.Drawing.Size(56, 17);
            this.lblAdulto.TabIndex = 1;
            this.lblAdulto.Text = "Adultos";
            // 
            // gbCartelera
            // 
            this.gbCartelera.Controls.Add(this.cmbHorario);
            this.gbCartelera.Controls.Add(this.lblHorario);
            this.gbCartelera.Controls.Add(this.cmbObra);
            this.gbCartelera.Controls.Add(this.lblCartelera);
            this.gbCartelera.Location = new System.Drawing.Point(12, 106);
            this.gbCartelera.Name = "gbCartelera";
            this.gbCartelera.Size = new System.Drawing.Size(404, 119);
            this.gbCartelera.TabIndex = 7;
            this.gbCartelera.TabStop = false;
            this.gbCartelera.Text = "Cartelera";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(106, 73);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(198, 25);
            this.cmbHorario.TabIndex = 3;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(28, 76);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 17);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario";
            // 
            // cmbObra
            // 
            this.cmbObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObra.FormattingEnabled = true;
            this.cmbObra.Location = new System.Drawing.Point(106, 33);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(198, 25);
            this.cmbObra.TabIndex = 1;
            this.cmbObra.SelectedIndexChanged += new System.EventHandler(this.cmbCartelera_SelectedIndexChanged);
            // 
            // lblCartelera
            // 
            this.lblCartelera.AutoSize = true;
            this.lblCartelera.Location = new System.Drawing.Point(27, 36);
            this.lblCartelera.Name = "lblCartelera";
            this.lblCartelera.Size = new System.Drawing.Size(41, 17);
            this.lblCartelera.TabIndex = 0;
            this.lblCartelera.Text = "Obra";
            // 
            // gbTeatros
            // 
            this.gbTeatros.Controls.Add(this.rbtLucho);
            this.gbTeatros.Controls.Add(this.rbtVariedades);
            this.gbTeatros.Controls.Add(this.rbtMelico);
            this.gbTeatros.Location = new System.Drawing.Point(12, 12);
            this.gbTeatros.Name = "gbTeatros";
            this.gbTeatros.Size = new System.Drawing.Size(404, 88);
            this.gbTeatros.TabIndex = 6;
            this.gbTeatros.TabStop = false;
            this.gbTeatros.Text = "Teatros";
            // 
            // rbtLucho
            // 
            this.rbtLucho.BackgroundImage = global::Teatros.Properties.Resources.teatro_lucho;
            this.rbtLucho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtLucho.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtLucho.Location = new System.Drawing.Point(280, 22);
            this.rbtLucho.Name = "rbtLucho";
            this.rbtLucho.Size = new System.Drawing.Size(112, 63);
            this.rbtLucho.TabIndex = 3;
            this.rbtLucho.UseVisualStyleBackColor = true;
            // 
            // rbtVariedades
            // 
            this.rbtVariedades.BackgroundImage = global::Teatros.Properties.Resources.variedades;
            this.rbtVariedades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtVariedades.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtVariedades.Location = new System.Drawing.Point(146, 22);
            this.rbtVariedades.Name = "rbtVariedades";
            this.rbtVariedades.Size = new System.Drawing.Size(112, 63);
            this.rbtVariedades.TabIndex = 2;
            this.rbtVariedades.UseVisualStyleBackColor = true;
            // 
            // rbtMelico
            // 
            this.rbtMelico.BackgroundImage = global::Teatros.Properties.Resources.melico1;
            this.rbtMelico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtMelico.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtMelico.Checked = true;
            this.rbtMelico.Location = new System.Drawing.Point(12, 22);
            this.rbtMelico.Name = "rbtMelico";
            this.rbtMelico.Size = new System.Drawing.Size(112, 63);
            this.rbtMelico.TabIndex = 1;
            this.rbtMelico.TabStop = true;
            this.rbtMelico.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(167, 374);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(95, 40);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(349, 432);
            this.webBrowser.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 432);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teatro - Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbDescuentos.ResumeLayout(false);
            this.gbDescuentos.PerformLayout();
            this.gbTickets.ResumeLayout(false);
            this.gbTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultosMayores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            this.gbCartelera.ResumeLayout(false);
            this.gbCartelera.PerformLayout();
            this.gbTeatros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox gbDescuentos;
        private System.Windows.Forms.RadioButton rbt20;
        private System.Windows.Forms.RadioButton rbt3x2;
        private System.Windows.Forms.RadioButton rbt2x1;
        private System.Windows.Forms.GroupBox gbTickets;
        private System.Windows.Forms.NumericUpDown nudNiños;
        private System.Windows.Forms.NumericUpDown nudAdultosMayores;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.Label lblNiño;
        private System.Windows.Forms.Label lblAdultoMayor;
        private System.Windows.Forms.Label lblAdulto;
        private System.Windows.Forms.GroupBox gbCartelera;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbObra;
        private System.Windows.Forms.Label lblCartelera;
        private System.Windows.Forms.GroupBox gbTeatros;
        private System.Windows.Forms.RadioButton rbtLucho;
        private System.Windows.Forms.RadioButton rbtVariedades;
        private System.Windows.Forms.RadioButton rbtMelico;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

