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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plDock = new System.Windows.Forms.Panel();
            this.BuGeneralReporte = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxFilroInventarios = new System.Windows.Forms.ComboBox();
            this.txtFilterInventarios = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxFechas = new System.Windows.Forms.ComboBox();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.BuBuscarFechas = new System.Windows.Forms.Button();
            this.BuExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataReportsInventarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuOrdenar = new System.Windows.Forms.Button();
            this.rBza = new System.Windows.Forms.RadioButton();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.rBaz = new System.Windows.Forms.RadioButton();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsInventarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.BuGeneralReporte);
            this.plDock.Controls.Add(this.groupBox3);
            this.plDock.Controls.Add(this.groupBox2);
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.dataReportsInventarios);
            this.plDock.Controls.Add(this.groupBox1);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 66);
            this.plDock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(1179, 624);
            this.plDock.TabIndex = 16;
            // 
            // BuGeneralReporte
            // 
            this.BuGeneralReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuGeneralReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuGeneralReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuGeneralReporte.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuGeneralReporte.ForeColor = System.Drawing.Color.White;
            this.BuGeneralReporte.Image = global::Essenza.Properties.Resources.Test_Results;
            this.BuGeneralReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuGeneralReporte.Location = new System.Drawing.Point(895, 543);
            this.BuGeneralReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuGeneralReporte.Name = "BuGeneralReporte";
            this.BuGeneralReporte.Size = new System.Drawing.Size(224, 46);
            this.BuGeneralReporte.TabIndex = 87;
            this.BuGeneralReporte.Text = "Gerenal Reporte";
            this.BuGeneralReporte.UseVisualStyleBackColor = false;
            this.BuGeneralReporte.Click += new System.EventHandler(this.BuGeneralReporte_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbxFilroInventarios);
            this.groupBox3.Controls.Add(this.txtFilterInventarios);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(65, 64);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(228, 116);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Columnas";
            // 
            // cbxFilroInventarios
            // 
            this.cbxFilroInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilroInventarios.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilroInventarios.FormattingEnabled = true;
            this.cbxFilroInventarios.Location = new System.Drawing.Point(27, 68);
            this.cbxFilroInventarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFilroInventarios.Name = "cbxFilroInventarios";
            this.cbxFilroInventarios.Size = new System.Drawing.Size(176, 28);
            this.cbxFilroInventarios.TabIndex = 70;
            // 
            // txtFilterInventarios
            // 
            this.txtFilterInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterInventarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInventarios.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterInventarios.Location = new System.Drawing.Point(27, 34);
            this.txtFilterInventarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterInventarios.Name = "txtFilterInventarios";
            this.txtFilterInventarios.Size = new System.Drawing.Size(178, 24);
            this.txtFilterInventarios.TabIndex = 67;
            this.txtFilterInventarios.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cbxFechas);
            this.groupBox2.Controls.Add(this.fechaFin);
            this.groupBox2.Controls.Add(this.fechaInicio);
            this.groupBox2.Controls.Add(this.BuBuscarFechas);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(301, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(524, 116);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
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
            this.cbxFechas.Location = new System.Drawing.Point(352, 64);
            this.cbxFechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFechas.Name = "cbxFechas";
            this.cbxFechas.Size = new System.Drawing.Size(151, 28);
            this.cbxFechas.TabIndex = 78;
            // 
            // fechaFin
            // 
            this.fechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFin.Location = new System.Drawing.Point(17, 65);
            this.fechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(325, 24);
            this.fechaFin.TabIndex = 77;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaInicio.Location = new System.Drawing.Point(17, 30);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(325, 24);
            this.fechaInicio.TabIndex = 76;
            // 
            // BuBuscarFechas
            // 
            this.BuBuscarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuBuscarFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuBuscarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuBuscarFechas.ForeColor = System.Drawing.Color.White;
            this.BuBuscarFechas.Location = new System.Drawing.Point(352, 28);
            this.BuBuscarFechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuBuscarFechas.Name = "BuBuscarFechas";
            this.BuBuscarFechas.Size = new System.Drawing.Size(152, 28);
            this.BuBuscarFechas.TabIndex = 73;
            this.BuBuscarFechas.Text = "Buscar";
            this.BuBuscarFechas.UseVisualStyleBackColor = false;
            this.BuBuscarFechas.Click += new System.EventHandler(this.BuBuscarFechas_Click);
            // 
            // BuExit
            // 
            this.BuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuExit.FlatAppearance.BorderSize = 0;
            this.BuExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuExit.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuExit.ForeColor = System.Drawing.Color.White;
            this.BuExit.Image = global::Essenza.Properties.Resources.Logout_Rounded_Left;
            this.BuExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuExit.Location = new System.Drawing.Point(37, 542);
            this.BuExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(171, 46);
            this.BuExit.TabIndex = 83;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "Filtrar datos por";
            // 
            // dataReportsInventarios
            // 
            this.dataReportsInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReportsInventarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataReportsInventarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataReportsInventarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReportsInventarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataReportsInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataReportsInventarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataReportsInventarios.EnableHeadersVisualStyles = false;
            this.dataReportsInventarios.Location = new System.Drawing.Point(37, 202);
            this.dataReportsInventarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataReportsInventarios.Name = "dataReportsInventarios";
            this.dataReportsInventarios.RowHeadersWidth = 51;
            this.dataReportsInventarios.Size = new System.Drawing.Size(1081, 332);
            this.dataReportsInventarios.TabIndex = 0;
            this.dataReportsInventarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReportsE_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BuOrdenar);
            this.groupBox1.Controls.Add(this.rBza);
            this.groupBox1.Controls.Add(this.cbxOrderBy);
            this.groupBox1.Controls.Add(this.rBaz);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(833, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(285, 116);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // BuOrdenar
            // 
            this.BuOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuOrdenar.ForeColor = System.Drawing.Color.White;
            this.BuOrdenar.Location = new System.Drawing.Point(19, 27);
            this.BuOrdenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuOrdenar.Name = "BuOrdenar";
            this.BuOrdenar.Size = new System.Drawing.Size(152, 28);
            this.BuOrdenar.TabIndex = 72;
            this.BuOrdenar.Text = "Ordenar";
            this.BuOrdenar.UseVisualStyleBackColor = false;
            this.BuOrdenar.Click += new System.EventHandler(this.BuOrdenar_Click);
            // 
            // rBza
            // 
            this.rBza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBza.AutoSize = true;
            this.rBza.Location = new System.Drawing.Point(193, 68);
            this.rBza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBza.Name = "rBza";
            this.rBza.Size = new System.Drawing.Size(54, 24);
            this.rBza.TabIndex = 82;
            this.rBza.TabStop = true;
            this.rBza.Text = "Z-A";
            this.rBza.UseVisualStyleBackColor = true;
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
            this.cbxOrderBy.Location = new System.Drawing.Point(19, 63);
            this.cbxOrderBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(151, 28);
            this.cbxOrderBy.TabIndex = 80;
            // 
            // rBaz
            // 
            this.rBaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBaz.AutoSize = true;
            this.rBaz.Location = new System.Drawing.Point(193, 32);
            this.rBaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBaz.Name = "rBaz";
            this.rBaz.Size = new System.Drawing.Size(54, 24);
            this.rBaz.TabIndex = 81;
            this.rBaz.TabStop = true;
            this.rBaz.Text = "A-Z";
            this.rBaz.UseVisualStyleBackColor = true;
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1179, 66);
            this.plTop.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Checked_Identification_Documents;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Reportes de Empleados";
            // 
            // EmployeeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReports";
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsInventarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button BuOrdenar;
        private System.Windows.Forms.Button BuBuscarFechas;
        private System.Windows.Forms.ComboBox cbxFechas;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.RadioButton rBaz;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.RadioButton rBza;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuGeneralReporte;
    }
}