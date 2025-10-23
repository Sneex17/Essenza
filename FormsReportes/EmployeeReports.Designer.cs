namespace Essenza.Forms
{
    partial class EmployeeReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plDock = new System.Windows.Forms.Panel();
            this.rBza = new System.Windows.Forms.RadioButton();
            this.rBaz = new System.Windows.Forms.RadioButton();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxFechas = new System.Windows.Forms.ComboBox();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuBuscarFechas = new System.Windows.Forms.Button();
            this.BuOrdenar = new System.Windows.Forms.Button();
            this.BuExcelRI = new System.Windows.Forms.Button();
            this.cbxFilroInventarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterInventarios = new System.Windows.Forms.TextBox();
            this.dataReportsInventarios = new System.Windows.Forms.DataGridView();
            this.plTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BuExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsInventarios)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.rBza);
            this.plDock.Controls.Add(this.rBaz);
            this.plDock.Controls.Add(this.cbxOrderBy);
            this.plDock.Controls.Add(this.label5);
            this.plDock.Controls.Add(this.cbxFechas);
            this.plDock.Controls.Add(this.fechaFin);
            this.plDock.Controls.Add(this.fechaInicio);
            this.plDock.Controls.Add(this.label4);
            this.plDock.Controls.Add(this.label3);
            this.plDock.Controls.Add(this.BuBuscarFechas);
            this.plDock.Controls.Add(this.BuOrdenar);
            this.plDock.Controls.Add(this.BuExcelRI);
            this.plDock.Controls.Add(this.cbxFilroInventarios);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.txtFilterInventarios);
            this.plDock.Controls.Add(this.dataReportsInventarios);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(768, 468);
            this.plDock.TabIndex = 16;
            // 
            // rBza
            // 
            this.rBza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBza.AutoSize = true;
            this.rBza.Location = new System.Drawing.Point(595, 112);
            this.rBza.Name = "rBza";
            this.rBza.Size = new System.Drawing.Size(42, 17);
            this.rBza.TabIndex = 82;
            this.rBza.TabStop = true;
            this.rBza.Text = "Z-A";
            this.rBza.UseVisualStyleBackColor = true;
            // 
            // rBaz
            // 
            this.rBaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBaz.AutoSize = true;
            this.rBaz.Location = new System.Drawing.Point(595, 80);
            this.rBaz.Name = "rBaz";
            this.rBaz.Size = new System.Drawing.Size(42, 17);
            this.rBaz.TabIndex = 81;
            this.rBaz.TabStop = true;
            this.rBaz.Text = "A-Z";
            this.rBaz.UseVisualStyleBackColor = true;
            // 
            // cbxOrderBy
            // 
            this.cbxOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrderBy.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderBy.FormattingEnabled = true;
            this.cbxOrderBy.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos"});
            this.cbxOrderBy.Location = new System.Drawing.Point(461, 106);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(114, 23);
            this.cbxOrderBy.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 79;
            this.label5.Text = "Orden";
            // 
            // cbxFechas
            // 
            this.cbxFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFechas.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFechas.FormattingEnabled = true;
            this.cbxFechas.Items.AddRange(new object[] {
            "Contrato",
            "Nacimiento"});
            this.cbxFechas.Location = new System.Drawing.Point(320, 106);
            this.cbxFechas.Name = "cbxFechas";
            this.cbxFechas.Size = new System.Drawing.Size(114, 23);
            this.cbxFechas.TabIndex = 78;
            // 
            // fechaFin
            // 
            this.fechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFin.Location = new System.Drawing.Point(214, 109);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(100, 20);
            this.fechaFin.TabIndex = 77;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaInicio.Location = new System.Drawing.Point(214, 80);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(100, 20);
            this.fechaInicio.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Fechas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Columnas";
            // 
            // BuBuscarFechas
            // 
            this.BuBuscarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuBuscarFechas.Location = new System.Drawing.Point(320, 77);
            this.BuBuscarFechas.Name = "BuBuscarFechas";
            this.BuBuscarFechas.Size = new System.Drawing.Size(114, 23);
            this.BuBuscarFechas.TabIndex = 73;
            this.BuBuscarFechas.Text = "Buscar";
            this.BuBuscarFechas.UseVisualStyleBackColor = true;
            this.BuBuscarFechas.Click += new System.EventHandler(this.BuBuscarFechas_Click);
            // 
            // BuOrdenar
            // 
            this.BuOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuOrdenar.Location = new System.Drawing.Point(461, 77);
            this.BuOrdenar.Name = "BuOrdenar";
            this.BuOrdenar.Size = new System.Drawing.Size(114, 23);
            this.BuOrdenar.TabIndex = 72;
            this.BuOrdenar.Text = "Ordenar";
            this.BuOrdenar.UseVisualStyleBackColor = true;
            this.BuOrdenar.Click += new System.EventHandler(this.BuOrdenar_Click);
            // 
            // BuExcelRI
            // 
            this.BuExcelRI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuExcelRI.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuExcelRI.Location = new System.Drawing.Point(595, 409);
            this.BuExcelRI.Name = "BuExcelRI";
            this.BuExcelRI.Size = new System.Drawing.Size(131, 28);
            this.BuExcelRI.TabIndex = 71;
            this.BuExcelRI.Text = "Exportar en Excel";
            this.BuExcelRI.UseVisualStyleBackColor = true;
            this.BuExcelRI.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxFilroInventarios
            // 
            this.cbxFilroInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilroInventarios.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilroInventarios.FormattingEnabled = true;
            this.cbxFilroInventarios.Location = new System.Drawing.Point(49, 106);
            this.cbxFilroInventarios.Name = "cbxFilroInventarios";
            this.cbxFilroInventarios.Size = new System.Drawing.Size(129, 23);
            this.cbxFilroInventarios.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Filtrar datos por";
            // 
            // txtFilterInventarios
            // 
            this.txtFilterInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterInventarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInventarios.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterInventarios.Location = new System.Drawing.Point(49, 79);
            this.txtFilterInventarios.Name = "txtFilterInventarios";
            this.txtFilterInventarios.Size = new System.Drawing.Size(130, 21);
            this.txtFilterInventarios.TabIndex = 67;
            this.txtFilterInventarios.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dataReportsInventarios
            // 
            this.dataReportsInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReportsInventarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataReportsInventarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataReportsInventarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReportsInventarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataReportsInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataReportsInventarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataReportsInventarios.EnableHeadersVisualStyles = false;
            this.dataReportsInventarios.Location = new System.Drawing.Point(49, 164);
            this.dataReportsInventarios.Name = "dataReportsInventarios";
            this.dataReportsInventarios.RowHeadersWidth = 51;
            this.dataReportsInventarios.Size = new System.Drawing.Size(674, 231);
            this.dataReportsInventarios.TabIndex = 0;
            this.dataReportsInventarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReportsE_CellDoubleClick);
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(768, 54);
            this.plTop.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Reportes de Empleados";
            // 
            // BuExit
            // 
            this.BuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuExit.FlatAppearance.BorderSize = 0;
            this.BuExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuExit.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuExit.ForeColor = System.Drawing.Color.White;
            this.BuExit.Image = global::Essenza.Properties.Resources.Logout_Rounded_Left;
            this.BuExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuExit.Location = new System.Drawing.Point(28, 401);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(128, 37);
            this.BuExit.TabIndex = 83;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Checked_Identification_Documents;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReports";
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsInventarios)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataReportsInventarios;
        private System.Windows.Forms.TextBox txtFilterInventarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxFilroInventarios;
        private System.Windows.Forms.Button BuExcelRI;
        private System.Windows.Forms.Button BuOrdenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuBuscarFechas;
        private System.Windows.Forms.ComboBox cbxFechas;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBaz;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBza;
        private System.Windows.Forms.Button BuExit;
    }
}