namespace Essenza.FormsReportes
{
    partial class ReportesVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plDock = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuEsteA = new System.Windows.Forms.Button();
            this.BuEsteM = new System.Windows.Forms.Button();
            this.BuHoy = new System.Windows.Forms.Button();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.BuGeneralReporte = new System.Windows.Forms.Button();
            this.groupBoxDetallesFacturas = new System.Windows.Forms.GroupBox();
            this.dataDetallesFacturas = new System.Windows.Forms.DataGridView();
            this.groupBoxFacturas = new System.Windows.Forms.GroupBox();
            this.dataFacturas = new System.Windows.Forms.DataGridView();
            this.BuExit = new System.Windows.Forms.Button();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.BuFechaCustom = new System.Windows.Forms.Button();
            this.plDock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDetallesFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetallesFacturas)).BeginInit();
            this.groupBoxFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.groupBox1);
            this.plDock.Controls.Add(this.BuGeneralReporte);
            this.plDock.Controls.Add(this.groupBoxDetallesFacturas);
            this.plDock.Controls.Add(this.groupBoxFacturas);
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(884, 507);
            this.plDock.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.BuFechaCustom);
            this.groupBox1.Controls.Add(this.dateFechaHasta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateFechaDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BuEsteA);
            this.groupBox1.Controls.Add(this.BuEsteM);
            this.groupBox1.Controls.Add(this.BuHoy);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(514, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 185);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes por";
            // 
            // BuEsteA
            // 
            this.BuEsteA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuEsteA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuEsteA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuEsteA.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuEsteA.ForeColor = System.Drawing.Color.White;
            this.BuEsteA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuEsteA.Location = new System.Drawing.Point(220, 133);
            this.BuEsteA.Name = "BuEsteA";
            this.BuEsteA.Size = new System.Drawing.Size(97, 37);
            this.BuEsteA.TabIndex = 94;
            this.BuEsteA.Text = "Este Año";
            this.BuEsteA.UseVisualStyleBackColor = false;
            this.BuEsteA.Click += new System.EventHandler(this.BuEsteA_Click);
            // 
            // BuEsteM
            // 
            this.BuEsteM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuEsteM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuEsteM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuEsteM.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuEsteM.ForeColor = System.Drawing.Color.White;
            this.BuEsteM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuEsteM.Location = new System.Drawing.Point(117, 133);
            this.BuEsteM.Name = "BuEsteM";
            this.BuEsteM.Size = new System.Drawing.Size(97, 37);
            this.BuEsteM.TabIndex = 93;
            this.BuEsteM.Text = "Este Mes";
            this.BuEsteM.UseVisualStyleBackColor = false;
            this.BuEsteM.Click += new System.EventHandler(this.BuEsteM_Click);
            // 
            // BuHoy
            // 
            this.BuHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuHoy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuHoy.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuHoy.ForeColor = System.Drawing.Color.White;
            this.BuHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuHoy.Location = new System.Drawing.Point(14, 133);
            this.BuHoy.Name = "BuHoy";
            this.BuHoy.Size = new System.Drawing.Size(97, 37);
            this.BuHoy.TabIndex = 92;
            this.BuHoy.Text = "Hoy";
            this.BuHoy.UseVisualStyleBackColor = false;
            this.BuHoy.Click += new System.EventHandler(this.BuHoy_Click);
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.Location = new System.Drawing.Point(74, 34);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.Size = new System.Drawing.Size(243, 23);
            this.dateFechaDesde.TabIndex = 89;
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
            this.BuGeneralReporte.Location = new System.Drawing.Point(674, 445);
            this.BuGeneralReporte.Name = "BuGeneralReporte";
            this.BuGeneralReporte.Size = new System.Drawing.Size(168, 37);
            this.BuGeneralReporte.TabIndex = 88;
            this.BuGeneralReporte.Text = "Gerenal Reporte";
            this.BuGeneralReporte.UseVisualStyleBackColor = false;
            this.BuGeneralReporte.Click += new System.EventHandler(this.BuGeneralReporte_Click);
            // 
            // groupBoxDetallesFacturas
            // 
            this.groupBoxDetallesFacturas.BackColor = System.Drawing.Color.Snow;
            this.groupBoxDetallesFacturas.Controls.Add(this.dataDetallesFacturas);
            this.groupBoxDetallesFacturas.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetallesFacturas.Location = new System.Drawing.Point(28, 214);
            this.groupBoxDetallesFacturas.Name = "groupBoxDetallesFacturas";
            this.groupBoxDetallesFacturas.Size = new System.Drawing.Size(814, 220);
            this.groupBoxDetallesFacturas.TabIndex = 85;
            this.groupBoxDetallesFacturas.TabStop = false;
            this.groupBoxDetallesFacturas.Text = "Detalles de la Factura";
            // 
            // dataDetallesFacturas
            // 
            this.dataDetallesFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDetallesFacturas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataDetallesFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDetallesFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetallesFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDetallesFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetallesFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDetallesFacturas.EnableHeadersVisualStyles = false;
            this.dataDetallesFacturas.Location = new System.Drawing.Point(9, 25);
            this.dataDetallesFacturas.Name = "dataDetallesFacturas";
            this.dataDetallesFacturas.RowHeadersWidth = 51;
            this.dataDetallesFacturas.Size = new System.Drawing.Size(794, 181);
            this.dataDetallesFacturas.TabIndex = 1;
            // 
            // groupBoxFacturas
            // 
            this.groupBoxFacturas.BackColor = System.Drawing.Color.Snow;
            this.groupBoxFacturas.Controls.Add(this.dataFacturas);
            this.groupBoxFacturas.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFacturas.Location = new System.Drawing.Point(28, 23);
            this.groupBoxFacturas.Name = "groupBoxFacturas";
            this.groupBoxFacturas.Size = new System.Drawing.Size(480, 185);
            this.groupBoxFacturas.TabIndex = 84;
            this.groupBoxFacturas.TabStop = false;
            this.groupBoxFacturas.Text = "Facturas";
            // 
            // dataFacturas
            // 
            this.dataFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFacturas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFacturas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataFacturas.EnableHeadersVisualStyles = false;
            this.dataFacturas.Location = new System.Drawing.Point(9, 25);
            this.dataFacturas.Name = "dataFacturas";
            this.dataFacturas.RowHeadersWidth = 51;
            this.dataFacturas.Size = new System.Drawing.Size(460, 145);
            this.dataFacturas.TabIndex = 1;
            this.dataFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFacturas_CellDoubleClick);
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
            this.BuExit.TabIndex = 83;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
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
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Sell_Stock;
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
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Reportes de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Hasta";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Location = new System.Drawing.Point(74, 66);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.Size = new System.Drawing.Size(243, 23);
            this.dateFechaHasta.TabIndex = 97;
            // 
            // BuFechaCustom
            // 
            this.BuFechaCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuFechaCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            this.BuFechaCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuFechaCustom.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuFechaCustom.ForeColor = System.Drawing.Color.White;
            this.BuFechaCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuFechaCustom.Location = new System.Drawing.Point(74, 97);
            this.BuFechaCustom.Name = "BuFechaCustom";
            this.BuFechaCustom.Size = new System.Drawing.Size(243, 29);
            this.BuFechaCustom.TabIndex = 98;
            this.BuFechaCustom.Text = "Aplicar";
            this.BuFechaCustom.UseVisualStyleBackColor = false;
            this.BuFechaCustom.Click += new System.EventHandler(this.BuFechaCustom_Click);
            // 
            // ReportesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "ReportesVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesVentas";
            this.plDock.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDetallesFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDetallesFacturas)).EndInit();
            this.groupBoxFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDetallesFacturas;
        private System.Windows.Forms.DataGridView dataDetallesFacturas;
        private System.Windows.Forms.GroupBox groupBoxFacturas;
        private System.Windows.Forms.DataGridView dataFacturas;
        private System.Windows.Forms.Button BuGeneralReporte;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuEsteA;
        private System.Windows.Forms.Button BuEsteM;
        private System.Windows.Forms.Button BuHoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuFechaCustom;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
    }
}