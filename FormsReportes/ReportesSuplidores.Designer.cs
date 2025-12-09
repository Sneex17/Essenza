namespace Essenza.FormsReportes
{
    partial class ReportesSuplidores
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
            this.cbxFilroSuplidores = new System.Windows.Forms.ComboBox();
            this.txtFilterSuplidores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuOrdenar = new System.Windows.Forms.Button();
            this.rBza = new System.Windows.Forms.RadioButton();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.rBaz = new System.Windows.Forms.RadioButton();
            this.BuExit = new System.Windows.Forms.Button();
            this.dataListSuplidores = new System.Windows.Forms.DataGridView();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListSuplidores)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.BuGeneralReporte);
            this.plDock.Controls.Add(this.groupBox3);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.groupBox1);
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.dataListSuplidores);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(884, 507);
            this.plDock.TabIndex = 18;
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
            this.BuGeneralReporte.TabIndex = 88;
            this.BuGeneralReporte.Text = "Gerenal Reporte";
            this.BuGeneralReporte.UseVisualStyleBackColor = false;
            this.BuGeneralReporte.Click += new System.EventHandler(this.BuGeneralReporte_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbxFilroSuplidores);
            this.groupBox3.Controls.Add(this.txtFilterSuplidores);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(49, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 94);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Columnas";
            // 
            // cbxFilroSuplidores
            // 
            this.cbxFilroSuplidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilroSuplidores.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilroSuplidores.FormattingEnabled = true;
            this.cbxFilroSuplidores.Location = new System.Drawing.Point(20, 55);
            this.cbxFilroSuplidores.Name = "cbxFilroSuplidores";
            this.cbxFilroSuplidores.Size = new System.Drawing.Size(133, 23);
            this.cbxFilroSuplidores.TabIndex = 70;
            // 
            // txtFilterSuplidores
            // 
            this.txtFilterSuplidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSuplidores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterSuplidores.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSuplidores.Location = new System.Drawing.Point(20, 28);
            this.txtFilterSuplidores.Name = "txtFilterSuplidores";
            this.txtFilterSuplidores.Size = new System.Drawing.Size(134, 21);
            this.txtFilterSuplidores.TabIndex = 67;
            this.txtFilterSuplidores.TextChanged += new System.EventHandler(this.txtFilterSuplidores_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Filtrar datos por";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BuOrdenar);
            this.groupBox1.Controls.Add(this.rBza);
            this.groupBox1.Controls.Add(this.cbxOrderBy);
            this.groupBox1.Controls.Add(this.rBaz);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(625, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 94);
            this.groupBox1.TabIndex = 94;
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
            this.BuOrdenar.Location = new System.Drawing.Point(14, 22);
            this.BuOrdenar.Name = "BuOrdenar";
            this.BuOrdenar.Size = new System.Drawing.Size(114, 23);
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
            this.rBza.Location = new System.Drawing.Point(145, 55);
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
            "Email"});
            this.cbxOrderBy.Location = new System.Drawing.Point(14, 51);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(114, 23);
            this.cbxOrderBy.TabIndex = 80;
            // 
            // rBaz
            // 
            this.rBaz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rBaz.AutoSize = true;
            this.rBaz.Location = new System.Drawing.Point(145, 26);
            this.rBaz.Name = "rBaz";
            this.rBaz.Size = new System.Drawing.Size(44, 19);
            this.rBaz.TabIndex = 81;
            this.rBaz.TabStop = true;
            this.rBaz.Text = "A-Z";
            this.rBaz.UseVisualStyleBackColor = true;
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
            this.BuExit.TabIndex = 92;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // dataListSuplidores
            // 
            this.dataListSuplidores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListSuplidores.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataListSuplidores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListSuplidores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListSuplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListSuplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListSuplidores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataListSuplidores.EnableHeadersVisualStyles = false;
            this.dataListSuplidores.Location = new System.Drawing.Point(28, 164);
            this.dataListSuplidores.Name = "dataListSuplidores";
            this.dataListSuplidores.RowHeadersWidth = 51;
            this.dataListSuplidores.Size = new System.Drawing.Size(811, 270);
            this.dataListSuplidores.TabIndex = 0;
            this.dataListSuplidores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListSuplidores_CellDoubleClick);
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
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Get_Cash;
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
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Reportes de Suplidores";
            // 
            // ReportesSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesSuplidores";
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListSuplidores)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.DataGridView dataListSuplidores;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFilroSuplidores;
        private System.Windows.Forms.TextBox txtFilterSuplidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuOrdenar;
        private System.Windows.Forms.RadioButton rBza;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.RadioButton rBaz;
        private System.Windows.Forms.Button BuGeneralReporte;
    }
}