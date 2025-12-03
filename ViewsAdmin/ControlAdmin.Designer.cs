namespace Essenza.ViewsAdmin
{
    partial class ControlAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plDock = new System.Windows.Forms.Panel();
            this.BuNuevo = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbCategorias = new System.Windows.Forms.RadioButton();
            this.rbCargos = new System.Windows.Forms.RadioButton();
            this.rbRoles = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataRoles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataCargos = new System.Windows.Forms.DataGridView();
            this.BuRegister = new System.Windows.Forms.Button();
            this.BuUpdate = new System.Windows.Forms.Button();
            this.BuDeleteE = new System.Windows.Forms.Button();
            this.BuExit = new System.Windows.Forms.Button();
            this.groupBoxUnderstock = new System.Windows.Forms.GroupBox();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCargos)).BeginInit();
            this.groupBoxUnderstock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.plDock.Controls.Add(this.BuNuevo);
            this.plDock.Controls.Add(this.groupBoxBuscar);
            this.plDock.Controls.Add(this.groupBox3);
            this.plDock.Controls.Add(this.groupBox2);
            this.plDock.Controls.Add(this.groupBox1);
            this.plDock.Controls.Add(this.BuRegister);
            this.plDock.Controls.Add(this.BuUpdate);
            this.plDock.Controls.Add(this.BuDeleteE);
            this.plDock.Controls.Add(this.BuExit);
            this.plDock.Controls.Add(this.groupBoxUnderstock);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(884, 507);
            this.plDock.TabIndex = 20;
            // 
            // BuNuevo
            // 
            this.BuNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.BuNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuNuevo.FlatAppearance.BorderSize = 0;
            this.BuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuNuevo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuNuevo.ForeColor = System.Drawing.Color.White;
            this.BuNuevo.Image = global::Essenza.Properties.Resources.Add_New;
            this.BuNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuNuevo.Location = new System.Drawing.Point(457, 437);
            this.BuNuevo.Name = "BuNuevo";
            this.BuNuevo.Size = new System.Drawing.Size(130, 40);
            this.BuNuevo.TabIndex = 92;
            this.BuNuevo.Text = "Nuevo";
            this.BuNuevo.UseVisualStyleBackColor = false;
            this.BuNuevo.Click += new System.EventHandler(this.BuNuevo_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.BackColor = System.Drawing.Color.White;
            this.groupBoxBuscar.Controls.Add(this.rbUsuarios);
            this.groupBoxBuscar.Controls.Add(this.rbCategorias);
            this.groupBoxBuscar.Controls.Add(this.rbCargos);
            this.groupBoxBuscar.Controls.Add(this.rbRoles);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(739, 262);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(119, 128);
            this.groupBoxBuscar.TabIndex = 91;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Gestionar por";
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.Location = new System.Drawing.Point(6, 36);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(84, 22);
            this.rbUsuarios.TabIndex = 3;
            this.rbUsuarios.TabStop = true;
            this.rbUsuarios.Text = "Usuarios";
            this.rbUsuarios.UseVisualStyleBackColor = true;
            // 
            // rbCategorias
            // 
            this.rbCategorias.AutoSize = true;
            this.rbCategorias.Location = new System.Drawing.Point(6, 100);
            this.rbCategorias.Name = "rbCategorias";
            this.rbCategorias.Size = new System.Drawing.Size(98, 22);
            this.rbCategorias.TabIndex = 2;
            this.rbCategorias.TabStop = true;
            this.rbCategorias.Text = "Categorias";
            this.rbCategorias.UseVisualStyleBackColor = true;
            // 
            // rbCargos
            // 
            this.rbCargos.AutoSize = true;
            this.rbCargos.Location = new System.Drawing.Point(6, 78);
            this.rbCargos.Name = "rbCargos";
            this.rbCargos.Size = new System.Drawing.Size(72, 22);
            this.rbCargos.TabIndex = 1;
            this.rbCargos.TabStop = true;
            this.rbCargos.Text = "Cargos";
            this.rbCargos.UseVisualStyleBackColor = true;
            // 
            // rbRoles
            // 
            this.rbRoles.AutoSize = true;
            this.rbRoles.Location = new System.Drawing.Point(6, 57);
            this.rbRoles.Name = "rbRoles";
            this.rbRoles.Size = new System.Drawing.Size(63, 22);
            this.rbRoles.TabIndex = 0;
            this.rbRoles.TabStop = true;
            this.rbRoles.Text = "Roles";
            this.rbRoles.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dataCategorias);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(535, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 236);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categorias";
            // 
            // dataCategorias
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dataCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCategorias.EnableHeadersVisualStyles = false;
            this.dataCategorias.Location = new System.Drawing.Point(16, 27);
            this.dataCategorias.Name = "dataCategorias";
            this.dataCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataCategorias.Size = new System.Drawing.Size(288, 197);
            this.dataCategorias.TabIndex = 0;
            this.dataCategorias.SelectionChanged += new System.EventHandler(this.dataCategorias_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dataRoles);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 112);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // dataRoles
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataRoles.BackgroundColor = System.Drawing.Color.White;
            this.dataRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRoles.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataRoles.EnableHeadersVisualStyles = false;
            this.dataRoles.Location = new System.Drawing.Point(16, 27);
            this.dataRoles.Name = "dataRoles";
            this.dataRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataRoles.Size = new System.Drawing.Size(454, 73);
            this.dataRoles.TabIndex = 0;
            this.dataRoles.SelectionChanged += new System.EventHandler(this.dataRoles_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataCargos);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 112);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargos";
            // 
            // dataCargos
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataCargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCargos.BackgroundColor = System.Drawing.Color.White;
            this.dataCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCargos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataCargos.EnableHeadersVisualStyles = false;
            this.dataCargos.Location = new System.Drawing.Point(16, 27);
            this.dataCargos.Name = "dataCargos";
            this.dataCargos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataCargos.Size = new System.Drawing.Size(454, 73);
            this.dataCargos.TabIndex = 0;
            this.dataCargos.SelectionChanged += new System.EventHandler(this.dataCargos_SelectionChanged);
            // 
            // BuRegister
            // 
            this.BuRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.BuRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuRegister.FlatAppearance.BorderSize = 0;
            this.BuRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuRegister.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuRegister.ForeColor = System.Drawing.Color.White;
            this.BuRegister.Image = global::Essenza.Properties.Resources.Add_New;
            this.BuRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuRegister.Location = new System.Drawing.Point(457, 437);
            this.BuRegister.Name = "BuRegister";
            this.BuRegister.Size = new System.Drawing.Size(130, 40);
            this.BuRegister.TabIndex = 90;
            this.BuRegister.Text = "Register";
            this.BuRegister.UseVisualStyleBackColor = false;
            this.BuRegister.Click += new System.EventHandler(this.BuRegister_Click);
            // 
            // BuUpdate
            // 
            this.BuUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuUpdate.FlatAppearance.BorderSize = 0;
            this.BuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuUpdate.ForeColor = System.Drawing.Color.White;
            this.BuUpdate.Image = global::Essenza.Properties.Resources.Edit_Property;
            this.BuUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuUpdate.Location = new System.Drawing.Point(593, 437);
            this.BuUpdate.Name = "BuUpdate";
            this.BuUpdate.Size = new System.Drawing.Size(130, 40);
            this.BuUpdate.TabIndex = 89;
            this.BuUpdate.Text = "Update";
            this.BuUpdate.UseVisualStyleBackColor = false;
            this.BuUpdate.Click += new System.EventHandler(this.BuUpdate_Click);
            // 
            // BuDeleteE
            // 
            this.BuDeleteE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuDeleteE.BackColor = System.Drawing.Color.Firebrick;
            this.BuDeleteE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuDeleteE.FlatAppearance.BorderSize = 0;
            this.BuDeleteE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuDeleteE.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuDeleteE.ForeColor = System.Drawing.Color.White;
            this.BuDeleteE.Image = global::Essenza.Properties.Resources.Delete;
            this.BuDeleteE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuDeleteE.Location = new System.Drawing.Point(728, 437);
            this.BuDeleteE.Name = "BuDeleteE";
            this.BuDeleteE.Size = new System.Drawing.Size(130, 40);
            this.BuDeleteE.TabIndex = 88;
            this.BuDeleteE.Text = "Delete";
            this.BuDeleteE.UseVisualStyleBackColor = false;
            this.BuDeleteE.Click += new System.EventHandler(this.BuDeleteE_Click);
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
            this.groupBoxUnderstock.BackColor = System.Drawing.Color.White;
            this.groupBoxUnderstock.Controls.Add(this.dataUsuarios);
            this.groupBoxUnderstock.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnderstock.Location = new System.Drawing.Point(28, 262);
            this.groupBoxUnderstock.Name = "groupBoxUnderstock";
            this.groupBoxUnderstock.Size = new System.Drawing.Size(695, 163);
            this.groupBoxUnderstock.TabIndex = 80;
            this.groupBoxUnderstock.TabStop = false;
            this.groupBoxUnderstock.Text = "Usuarios";
            // 
            // dataUsuarios
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(73)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.id_empleado,
            this.usuario,
            this.pass,
            this.id_rol,
            this.id_estado,
            this.fecha_creacion,
            this.ultimo_acceso});
            this.dataUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUsuarios.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataUsuarios.EnableHeadersVisualStyles = false;
            this.dataUsuarios.Location = new System.Drawing.Point(16, 27);
            this.dataUsuarios.MultiSelect = false;
            this.dataUsuarios.Name = "dataUsuarios";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataUsuarios.Size = new System.Drawing.Size(660, 124);
            this.dataUsuarios.TabIndex = 0;
            this.dataUsuarios.SelectionChanged += new System.EventHandler(this.dataUsuarios_SelectionChanged);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Width = 94;
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "id_empleado";
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 112;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.Width = 76;
            // 
            // pass
            // 
            this.pass.HeaderText = "pass";
            this.pass.Name = "pass";
            this.pass.Width = 57;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "id_rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.Width = 65;
            // 
            // id_estado
            // 
            this.id_estado.HeaderText = "id_estado";
            this.id_estado.Name = "id_estado";
            this.id_estado.Width = 90;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.HeaderText = "fecha_creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.Width = 125;
            // 
            // ultimo_acceso
            // 
            this.ultimo_acceso.HeaderText = "ultimo_acceso";
            this.ultimo_acceso.Name = "ultimo_acceso";
            this.ultimo_acceso.Width = 121;
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
            this.plTop.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Administrative_Tools;
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
            this.label2.Size = new System.Drawing.Size(209, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Administracion General";
            // 
            // ControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(884, 561);
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "ControlAdmin";
            this.Text = "ControlAdmin";
            this.plDock.ResumeLayout(false);
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCargos)).EndInit();
            this.groupBoxUnderstock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.GroupBox groupBoxUnderstock;
        private System.Windows.Forms.DataGridView dataUsuarios;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuRegister;
        private System.Windows.Forms.Button BuUpdate;
        private System.Windows.Forms.Button BuDeleteE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataCategorias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataCargos;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.RadioButton rbUsuarios;
        private System.Windows.Forms.RadioButton rbCategorias;
        private System.Windows.Forms.RadioButton rbCargos;
        private System.Windows.Forms.RadioButton rbRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo_acceso;
        private System.Windows.Forms.Button BuNuevo;
    }
}