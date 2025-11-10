namespace Essenza.Forms
{
    partial class ReportesClientes
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
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock = new System.Windows.Forms.Panel();
            this.dataReportsC = new System.Windows.Forms.DataGridView();
            this.BuExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxFilroClientes = new System.Windows.Forms.ComboBox();
            this.txtFilterClientes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxFechas = new System.Windows.Forms.ComboBox();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.BuBuscarFechas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuOrdenar = new System.Windows.Forms.Button();
            this.rBza = new System.Windows.Forms.RadioButton();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.rBaz = new System.Windows.Forms.RadioButton();
            this.BuGeneralReporte = new System.Windows.Forms.Button();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(884, 54);
            this.plTop.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Manager;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Reportes de Clientes";
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.BuGeneralReporte);
            this.plDock.Controls.Add(this.dataReportsC);
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.groupBox3);
            this.plDock.Controls.Add(this.groupBox2);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.groupBox1);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(884, 507);
            this.plDock.TabIndex = 18;
            // 
            // dataReportsC
            // 
            this.dataReportsC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReportsC.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataReportsC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataReportsC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataReportsC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataReportsC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataReportsC.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataReportsC.EnableHeadersVisualStyles = false;
            this.dataReportsC.Location = new System.Drawing.Point(28, 164);
            this.dataReportsC.Name = "dataReportsC";
            this.dataReportsC.RowHeadersWidth = 51;
            this.dataReportsC.Size = new System.Drawing.Size(811, 270);
            this.dataReportsC.TabIndex = 92;
            this.dataReportsC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReportsC_CellDoubleClick);
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
            this.BuExit.Location = new System.Drawing.Point(28, 440);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(128, 37);
            this.BuExit.TabIndex = 91;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxFilroClientes);
            this.groupBox3.Controls.Add(this.txtFilterClientes);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(49, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 94);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Columnas";
            // 
            // cbxFilroClientes
            // 
            this.cbxFilroClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilroClientes.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilroClientes.FormattingEnabled = true;
            this.cbxFilroClientes.Location = new System.Drawing.Point(24, 55);
            this.cbxFilroClientes.Name = "cbxFilroClientes";
            this.cbxFilroClientes.Size = new System.Drawing.Size(129, 23);
            this.cbxFilroClientes.TabIndex = 70;
            // 
            // txtFilterClientes
            // 
            this.txtFilterClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterClientes.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterClientes.Location = new System.Drawing.Point(24, 28);
            this.txtFilterClientes.Name = "txtFilterClientes";
            this.txtFilterClientes.Size = new System.Drawing.Size(130, 21);
            this.txtFilterClientes.TabIndex = 67;
            this.txtFilterClientes.TextChanged += new System.EventHandler(this.txtFilterClientes_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxFechas);
            this.groupBox2.Controls.Add(this.fechaFin);
            this.groupBox2.Controls.Add(this.fechaInicio);
            this.groupBox2.Controls.Add(this.BuBuscarFechas);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(242, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 94);
            this.groupBox2.TabIndex = 89;
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
            this.cbxFechas.Location = new System.Drawing.Point(117, 50);
            this.cbxFechas.Name = "cbxFechas";
            this.cbxFechas.Size = new System.Drawing.Size(114, 23);
            this.cbxFechas.TabIndex = 78;
            // 
            // fechaFin
            // 
            this.fechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFin.Location = new System.Drawing.Point(11, 53);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(100, 21);
            this.fechaFin.TabIndex = 77;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaInicio.Location = new System.Drawing.Point(11, 24);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(100, 21);
            this.fechaInicio.TabIndex = 76;
            // 
            // BuBuscarFechas
            // 
            this.BuBuscarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuBuscarFechas.Location = new System.Drawing.Point(117, 21);
            this.BuBuscarFechas.Name = "BuBuscarFechas";
            this.BuBuscarFechas.Size = new System.Drawing.Size(114, 23);
            this.BuBuscarFechas.TabIndex = 73;
            this.BuBuscarFechas.Text = "Buscar";
            this.BuBuscarFechas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "Filtrar datos por";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuOrdenar);
            this.groupBox1.Controls.Add(this.rBza);
            this.groupBox1.Controls.Add(this.cbxOrderBy);
            this.groupBox1.Controls.Add(this.rBaz);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(509, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 94);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // BuOrdenar
            // 
            this.BuOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuOrdenar.Location = new System.Drawing.Point(21, 20);
            this.BuOrdenar.Name = "BuOrdenar";
            this.BuOrdenar.Size = new System.Drawing.Size(114, 23);
            this.BuOrdenar.TabIndex = 72;
            this.BuOrdenar.Text = "Ordenar";
            this.BuOrdenar.UseVisualStyleBackColor = true;
            this.BuOrdenar.Click += new System.EventHandler(this.BuOrdenar_Click);
            // 
            // rBza
            // 
            this.rBza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBza.AutoSize = true;
            this.rBza.Location = new System.Drawing.Point(155, 55);
            this.rBza.Name = "rBza";
            this.rBza.Size = new System.Drawing.Size(44, 19);
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
            this.cbxOrderBy.Location = new System.Drawing.Point(21, 49);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(114, 23);
            this.cbxOrderBy.TabIndex = 80;
            // 
            // rBaz
            // 
            this.rBaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBaz.AutoSize = true;
            this.rBaz.Location = new System.Drawing.Point(155, 26);
            this.rBaz.Name = "rBaz";
            this.rBaz.Size = new System.Drawing.Size(44, 19);
            this.rBaz.TabIndex = 81;
            this.rBaz.TabStop = true;
            this.rBaz.Text = "A-Z";
            this.rBaz.UseVisualStyleBackColor = true;
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
            this.BuGeneralReporte.Location = new System.Drawing.Point(671, 441);
            this.BuGeneralReporte.Name = "BuGeneralReporte";
            this.BuGeneralReporte.Size = new System.Drawing.Size(168, 37);
            this.BuGeneralReporte.TabIndex = 93;
            this.BuGeneralReporte.Text = "Gerenal Reporte";
            this.BuGeneralReporte.UseVisualStyleBackColor = false;
            this.BuGeneralReporte.Click += new System.EventHandler(this.BuGeneralReporte_Click);
            // 
            // ReportesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesClientes";
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportsC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFilroClientes;
        private System.Windows.Forms.TextBox txtFilterClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxFechas;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Button BuBuscarFechas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuOrdenar;
        private System.Windows.Forms.RadioButton rBza;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.RadioButton rBaz;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.DataGridView dataReportsC;
        private System.Windows.Forms.Button BuGeneralReporte;
    }
}