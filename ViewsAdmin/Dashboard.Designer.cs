namespace Essenza.ViewsAdmin
{
    partial class Dashboard
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
            this.plDock = new System.Windows.Forms.Panel();
            this.BuExit = new System.Windows.Forms.Button();
            this.groupBoxUnderstock = new System.Windows.Forms.GroupBox();
            this.dataProductsUnderstock = new System.Windows.Forms.DataGridView();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.LbCountProd = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LbCountSupl = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LbCountClient = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LbCountEmpl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxVentas = new System.Windows.Forms.GroupBox();
            this.LbCantidadVentas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxIngresos = new System.Windows.Forms.GroupBox();
            this.LbTotalVentas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock.SuspendLayout();
            this.groupBoxUnderstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsUnderstock)).BeginInit();
            this.groupBoxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBoxVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBoxIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.groupBoxUnderstock);
            this.plDock.Controls.Add(this.groupBoxRegistros);
            this.plDock.Controls.Add(this.groupBoxVentas);
            this.plDock.Controls.Add(this.groupBoxIngresos);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(884, 507);
            this.plDock.TabIndex = 18;
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
            this.BuExit.TabIndex = 87;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // groupBoxUnderstock
            // 
            this.groupBoxUnderstock.BackColor = System.Drawing.Color.Snow;
            this.groupBoxUnderstock.Controls.Add(this.dataProductsUnderstock);
            this.groupBoxUnderstock.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnderstock.Location = new System.Drawing.Point(226, 140);
            this.groupBoxUnderstock.Name = "groupBoxUnderstock";
            this.groupBoxUnderstock.Size = new System.Drawing.Size(632, 288);
            this.groupBoxUnderstock.TabIndex = 80;
            this.groupBoxUnderstock.TabStop = false;
            this.groupBoxUnderstock.Text = "Productos de Stock Bajo";
            // 
            // dataProductsUnderstock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProductsUnderstock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProductsUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductsUnderstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataProductsUnderstock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductsUnderstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataProductsUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductsUnderstock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProductsUnderstock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataProductsUnderstock.EnableHeadersVisualStyles = false;
            this.dataProductsUnderstock.Location = new System.Drawing.Point(16, 27);
            this.dataProductsUnderstock.Name = "dataProductsUnderstock";
            this.dataProductsUnderstock.Size = new System.Drawing.Size(597, 249);
            this.dataProductsUnderstock.TabIndex = 0;
            // 
            // groupBoxRegistros
            // 
            this.groupBoxRegistros.BackColor = System.Drawing.Color.Snow;
            this.groupBoxRegistros.Controls.Add(this.LbCountProd);
            this.groupBoxRegistros.Controls.Add(this.pictureBox6);
            this.groupBoxRegistros.Controls.Add(this.label9);
            this.groupBoxRegistros.Controls.Add(this.LbCountSupl);
            this.groupBoxRegistros.Controls.Add(this.pictureBox7);
            this.groupBoxRegistros.Controls.Add(this.label11);
            this.groupBoxRegistros.Controls.Add(this.LbCountClient);
            this.groupBoxRegistros.Controls.Add(this.pictureBox5);
            this.groupBoxRegistros.Controls.Add(this.label7);
            this.groupBoxRegistros.Controls.Add(this.LbCountEmpl);
            this.groupBoxRegistros.Controls.Add(this.pictureBox4);
            this.groupBoxRegistros.Controls.Add(this.label5);
            this.groupBoxRegistros.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegistros.Location = new System.Drawing.Point(23, 140);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Size = new System.Drawing.Size(193, 288);
            this.groupBoxRegistros.TabIndex = 72;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "Total de Registros";
            // 
            // LbCountProd
            // 
            this.LbCountProd.AutoSize = true;
            this.LbCountProd.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountProd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbCountProd.Location = new System.Drawing.Point(86, 250);
            this.LbCountProd.Name = "LbCountProd";
            this.LbCountProd.Size = new System.Drawing.Size(51, 26);
            this.LbCountProd.TabIndex = 79;
            this.LbCountProd.Text = "000";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Essenza.Properties.Resources.Productos;
            this.pictureBox6.Location = new System.Drawing.Point(6, 223);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(62, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 78;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(87, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 77;
            this.label9.Text = "Productos";
            // 
            // LbCountSupl
            // 
            this.LbCountSupl.AutoSize = true;
            this.LbCountSupl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountSupl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbCountSupl.Location = new System.Drawing.Point(86, 184);
            this.LbCountSupl.Name = "LbCountSupl";
            this.LbCountSupl.Size = new System.Drawing.Size(51, 26);
            this.LbCountSupl.TabIndex = 76;
            this.LbCountSupl.Text = "000";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Essenza.Properties.Resources.Suplidores;
            this.pictureBox7.Location = new System.Drawing.Point(6, 157);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(62, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 75;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(87, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 74;
            this.label11.Text = "Suplidores";
            // 
            // LbCountClient
            // 
            this.LbCountClient.AutoSize = true;
            this.LbCountClient.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountClient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbCountClient.Location = new System.Drawing.Point(86, 117);
            this.LbCountClient.Name = "LbCountClient";
            this.LbCountClient.Size = new System.Drawing.Size(51, 26);
            this.LbCountClient.TabIndex = 73;
            this.LbCountClient.Text = "000";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Essenza.Properties.Resources.Clientes;
            this.pictureBox5.Location = new System.Drawing.Point(6, 90);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(87, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Clientes";
            // 
            // LbCountEmpl
            // 
            this.LbCountEmpl.AutoSize = true;
            this.LbCountEmpl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCountEmpl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbCountEmpl.Location = new System.Drawing.Point(86, 51);
            this.LbCountEmpl.Name = "LbCountEmpl";
            this.LbCountEmpl.Size = new System.Drawing.Size(51, 26);
            this.LbCountEmpl.TabIndex = 70;
            this.LbCountEmpl.Text = "000";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Essenza.Properties.Resources.Empleados;
            this.pictureBox4.Location = new System.Drawing.Point(6, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(87, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Empleados";
            // 
            // groupBoxVentas
            // 
            this.groupBoxVentas.BackColor = System.Drawing.Color.Snow;
            this.groupBoxVentas.Controls.Add(this.LbCantidadVentas);
            this.groupBoxVentas.Controls.Add(this.pictureBox3);
            this.groupBoxVentas.Controls.Add(this.label4);
            this.groupBoxVentas.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVentas.Location = new System.Drawing.Point(341, 19);
            this.groupBoxVentas.Name = "groupBoxVentas";
            this.groupBoxVentas.Size = new System.Drawing.Size(248, 86);
            this.groupBoxVentas.TabIndex = 71;
            this.groupBoxVentas.TabStop = false;
            this.groupBoxVentas.Text = "Cantidad de Ventas";
            // 
            // LbCantidadVentas
            // 
            this.LbCantidadVentas.AutoSize = true;
            this.LbCantidadVentas.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadVentas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbCantidadVentas.Location = new System.Drawing.Point(86, 51);
            this.LbCantidadVentas.Name = "LbCantidadVentas";
            this.LbCantidadVentas.Size = new System.Drawing.Size(51, 26);
            this.LbCantidadVentas.TabIndex = 70;
            this.LbCantidadVentas.Text = "000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Essenza.Properties.Resources.Total_Ventas;
            this.pictureBox3.Location = new System.Drawing.Point(6, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(87, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Total";
            // 
            // groupBoxIngresos
            // 
            this.groupBoxIngresos.BackColor = System.Drawing.Color.Snow;
            this.groupBoxIngresos.Controls.Add(this.LbTotalVentas);
            this.groupBoxIngresos.Controls.Add(this.pictureBox2);
            this.groupBoxIngresos.Controls.Add(this.label1);
            this.groupBoxIngresos.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIngresos.Location = new System.Drawing.Point(610, 19);
            this.groupBoxIngresos.Name = "groupBoxIngresos";
            this.groupBoxIngresos.Size = new System.Drawing.Size(248, 86);
            this.groupBoxIngresos.TabIndex = 51;
            this.groupBoxIngresos.TabStop = false;
            this.groupBoxIngresos.Text = "Ingresos por Ventas";
            // 
            // LbTotalVentas
            // 
            this.LbTotalVentas.AutoSize = true;
            this.LbTotalVentas.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalVentas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbTotalVentas.Location = new System.Drawing.Point(86, 51);
            this.LbTotalVentas.Name = "LbTotalVentas";
            this.LbTotalVentas.Size = new System.Drawing.Size(107, 26);
            this.LbTotalVentas.TabIndex = 70;
            this.LbTotalVentas.Text = "$0000.00\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Essenza.Properties.Resources.Total_Ingresos;
            this.pictureBox2.Location = new System.Drawing.Point(6, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Total";
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
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Combo_Chart;
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
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.plDock.ResumeLayout(false);
            this.groupBoxUnderstock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductsUnderstock)).EndInit();
            this.groupBoxRegistros.ResumeLayout(false);
            this.groupBoxRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBoxVentas.ResumeLayout(false);
            this.groupBoxVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBoxIngresos.ResumeLayout(false);
            this.groupBoxIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxIngresos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbTotalVentas;
        private System.Windows.Forms.GroupBox groupBoxVentas;
        private System.Windows.Forms.Label LbCantidadVentas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.Label LbCountEmpl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbCountProd;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbCountSupl;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbCountClient;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxUnderstock;
        private System.Windows.Forms.DataGridView dataProductsUnderstock;
        private System.Windows.Forms.Button BuExit;
    }
}