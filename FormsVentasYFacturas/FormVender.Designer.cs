namespace Essenza.FormsVentasYFacturas
{
    partial class FormVender
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
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtTotalFact = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BuExit = new System.Windows.Forms.Button();
            this.BuPagar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataCarrito = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.BuBuscarDatos = new System.Windows.Forms.Button();
            this.radioButtonProducto = new System.Windows.Forms.RadioButton();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpleado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoneClientFact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaClientFact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameClientFact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdClientFact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.txtSubTotalFact = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BuAddCarrito = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPventaProductFact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNameProductFact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdProductFact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CantidadPorProducto = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEmpleado = new System.Windows.Forms.GroupBox();
            this.txtEmailEmpFact = new System.Windows.Forms.TextBox();
            this.txtNameEmpFact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCargoEmpFact = new System.Windows.Forms.TextBox();
            this.txtIdEmpFact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTransferencia = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarrito)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPorProducto)).BeginInit();
            this.groupBoxEmpleado.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.plTop.Size = new System.Drawing.Size(768, 54);
            this.plTop.TabIndex = 18;
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
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ventas y Facturacion";
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.panelDatos.Controls.Add(this.BuExit);
            this.panelDatos.Controls.Add(this.label15);
            this.panelDatos.Controls.Add(this.dataCarrito);
            this.panelDatos.Controls.Add(this.groupBoxBuscar);
            this.panelDatos.Controls.Add(this.groupBox1);
            this.panelDatos.Controls.Add(this.groupBoxVenta);
            this.panelDatos.Controls.Add(this.groupBoxEmpleado);
            this.panelDatos.Controls.Add(this.groupBox2);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(0, 54);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(768, 468);
            this.panelDatos.TabIndex = 19;
            // 
            // txtTotalFact
            // 
            this.txtTotalFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFact.Location = new System.Drawing.Point(203, 18);
            this.txtTotalFact.Name = "txtTotalFact";
            this.txtTotalFact.Size = new System.Drawing.Size(110, 21);
            this.txtTotalFact.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(147, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "Total:";
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
            this.BuExit.TabIndex = 86;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // BuPagar
            // 
            this.BuPagar.BackColor = System.Drawing.Color.ForestGreen;
            this.BuPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuPagar.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuPagar.ForeColor = System.Drawing.Color.White;
            this.BuPagar.Image = global::Essenza.Properties.Resources.Cash;
            this.BuPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuPagar.Location = new System.Drawing.Point(183, 45);
            this.BuPagar.Name = "BuPagar";
            this.BuPagar.Size = new System.Drawing.Size(130, 29);
            this.BuPagar.TabIndex = 77;
            this.BuPagar.Text = "Pagar";
            this.BuPagar.UseVisualStyleBackColor = false;
            this.BuPagar.Click += new System.EventHandler(this.BuPagar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 18);
            this.label15.TabIndex = 77;
            this.label15.Text = "Detalles del Carrito";
            // 
            // dataCarrito
            // 
            this.dataCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.id_empleado,
            this.id_inventario,
            this.cantidad,
            this.precio_unitario,
            this.precio_cantidad,
            this.itbis,
            this.subtotal,
            this.opcion});
            this.dataCarrito.Location = new System.Drawing.Point(41, 260);
            this.dataCarrito.Name = "dataCarrito";
            this.dataCarrito.Size = new System.Drawing.Size(685, 104);
            this.dataCarrito.TabIndex = 3;
            this.dataCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCarrito_CellClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // id_empleado
            // 
            this.id_empleado.HeaderText = "id_empleado";
            this.id_empleado.Name = "id_empleado";
            // 
            // id_inventario
            // 
            this.id_inventario.HeaderText = "id_inventario";
            this.id_inventario.Name = "id_inventario";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "precio_unitario";
            this.precio_unitario.Name = "precio_unitario";
            // 
            // precio_cantidad
            // 
            this.precio_cantidad.HeaderText = "precio_cantidad";
            this.precio_cantidad.Name = "precio_cantidad";
            // 
            // itbis
            // 
            this.itbis.HeaderText = "itbis";
            this.itbis.Name = "itbis";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // opcion
            // 
            this.opcion.HeaderText = "opcion";
            this.opcion.Name = "opcion";
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxBuscar.Controls.Add(this.BuBuscarDatos);
            this.groupBoxBuscar.Controls.Add(this.radioButtonProducto);
            this.groupBoxBuscar.Controls.Add(this.radioButtonCliente);
            this.groupBoxBuscar.Controls.Add(this.radioButtonEmpleado);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(613, 18);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(113, 128);
            this.groupBoxBuscar.TabIndex = 2;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar";
            // 
            // BuBuscarDatos
            // 
            this.BuBuscarDatos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuBuscarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuBuscarDatos.Image = global::Essenza.Properties.Resources.Search_in_List;
            this.BuBuscarDatos.Location = new System.Drawing.Point(8, 22);
            this.BuBuscarDatos.Name = "BuBuscarDatos";
            this.BuBuscarDatos.Size = new System.Drawing.Size(95, 29);
            this.BuBuscarDatos.TabIndex = 3;
            this.BuBuscarDatos.UseVisualStyleBackColor = false;
            this.BuBuscarDatos.Click += new System.EventHandler(this.BuBuscarDatos_Click);
            // 
            // radioButtonProducto
            // 
            this.radioButtonProducto.AutoSize = true;
            this.radioButtonProducto.Location = new System.Drawing.Point(6, 100);
            this.radioButtonProducto.Name = "radioButtonProducto";
            this.radioButtonProducto.Size = new System.Drawing.Size(88, 22);
            this.radioButtonProducto.TabIndex = 2;
            this.radioButtonProducto.TabStop = true;
            this.radioButtonProducto.Text = "Producto";
            this.radioButtonProducto.UseVisualStyleBackColor = true;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Location = new System.Drawing.Point(6, 78);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(74, 22);
            this.radioButtonCliente.TabIndex = 1;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmpleado
            // 
            this.radioButtonEmpleado.AutoSize = true;
            this.radioButtonEmpleado.Location = new System.Drawing.Point(6, 57);
            this.radioButtonEmpleado.Name = "radioButtonEmpleado";
            this.radioButtonEmpleado.Size = new System.Drawing.Size(95, 22);
            this.radioButtonEmpleado.TabIndex = 0;
            this.radioButtonEmpleado.TabStop = true;
            this.radioButtonEmpleado.Text = "Empleado";
            this.radioButtonEmpleado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.txtPhoneClientFact);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCedulaClientFact);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNameClientFact);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdClientFact);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Cliente";
            // 
            // txtPhoneClientFact
            // 
            this.txtPhoneClientFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneClientFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneClientFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneClientFact.Location = new System.Drawing.Point(138, 88);
            this.txtPhoneClientFact.Name = "txtPhoneClientFact";
            this.txtPhoneClientFact.Size = new System.Drawing.Size(125, 21);
            this.txtPhoneClientFact.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Telefono:";
            // 
            // txtCedulaClientFact
            // 
            this.txtCedulaClientFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedulaClientFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaClientFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaClientFact.Location = new System.Drawing.Point(15, 88);
            this.txtCedulaClientFact.Name = "txtCedulaClientFact";
            this.txtCedulaClientFact.Size = new System.Drawing.Size(100, 21);
            this.txtCedulaClientFact.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Cedula:";
            // 
            // txtNameClientFact
            // 
            this.txtNameClientFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameClientFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameClientFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameClientFact.Location = new System.Drawing.Point(138, 46);
            this.txtNameClientFact.Name = "txtNameClientFact";
            this.txtNameClientFact.Size = new System.Drawing.Size(125, 21);
            this.txtNameClientFact.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre:";
            // 
            // txtIdClientFact
            // 
            this.txtIdClientFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdClientFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdClientFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClientFact.Location = new System.Drawing.Point(15, 46);
            this.txtIdClientFact.Name = "txtIdClientFact";
            this.txtIdClientFact.Size = new System.Drawing.Size(100, 21);
            this.txtIdClientFact.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Id Cliente:";
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxVenta.Controls.Add(this.txtSubTotalFact);
            this.groupBoxVenta.Controls.Add(this.label13);
            this.groupBoxVenta.Controls.Add(this.BuAddCarrito);
            this.groupBoxVenta.Controls.Add(this.label12);
            this.groupBoxVenta.Controls.Add(this.txtPventaProductFact);
            this.groupBoxVenta.Controls.Add(this.label11);
            this.groupBoxVenta.Controls.Add(this.txtNameProductFact);
            this.groupBoxVenta.Controls.Add(this.label10);
            this.groupBoxVenta.Controls.Add(this.txtIdProductFact);
            this.groupBoxVenta.Controls.Add(this.label9);
            this.groupBoxVenta.Controls.Add(this.CantidadPorProducto);
            this.groupBoxVenta.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVenta.Location = new System.Drawing.Point(41, 155);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(685, 82);
            this.groupBoxVenta.TabIndex = 1;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Detalles del Producto";
            // 
            // txtSubTotalFact
            // 
            this.txtSubTotalFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotalFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalFact.Location = new System.Drawing.Point(489, 50);
            this.txtSubTotalFact.Name = "txtSubTotalFact";
            this.txtSubTotalFact.Size = new System.Drawing.Size(110, 21);
            this.txtSubTotalFact.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(486, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "SubTotal:";
            // 
            // BuAddCarrito
            // 
            this.BuAddCarrito.BackColor = System.Drawing.Color.ForestGreen;
            this.BuAddCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuAddCarrito.Image = global::Essenza.Properties.Resources.Add_Shopping_Cart;
            this.BuAddCarrito.Location = new System.Drawing.Point(615, 29);
            this.BuAddCarrito.Name = "BuAddCarrito";
            this.BuAddCarrito.Size = new System.Drawing.Size(53, 29);
            this.BuAddCarrito.TabIndex = 4;
            this.BuAddCarrito.UseVisualStyleBackColor = false;
            this.BuAddCarrito.Click += new System.EventHandler(this.BuAddCarrito_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(396, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Cantidad:";
            // 
            // txtPventaProductFact
            // 
            this.txtPventaProductFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPventaProductFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPventaProductFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPventaProductFact.Location = new System.Drawing.Point(270, 48);
            this.txtPventaProductFact.Name = "txtPventaProductFact";
            this.txtPventaProductFact.Size = new System.Drawing.Size(110, 21);
            this.txtPventaProductFact.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Precio de Venta:";
            // 
            // txtNameProductFact
            // 
            this.txtNameProductFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameProductFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameProductFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProductFact.Location = new System.Drawing.Point(133, 48);
            this.txtNameProductFact.Name = "txtNameProductFact";
            this.txtNameProductFact.Size = new System.Drawing.Size(120, 21);
            this.txtNameProductFact.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Producto:";
            // 
            // txtIdProductFact
            // 
            this.txtIdProductFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProductFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProductFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductFact.Location = new System.Drawing.Point(16, 48);
            this.txtIdProductFact.Name = "txtIdProductFact";
            this.txtIdProductFact.Size = new System.Drawing.Size(100, 21);
            this.txtIdProductFact.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Id Producto:";
            // 
            // CantidadPorProducto
            // 
            this.CantidadPorProducto.Location = new System.Drawing.Point(399, 48);
            this.CantidadPorProducto.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CantidadPorProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadPorProducto.Name = "CantidadPorProducto";
            this.CantidadPorProducto.Size = new System.Drawing.Size(74, 23);
            this.CantidadPorProducto.TabIndex = 0;
            this.CantidadPorProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadPorProducto.ValueChanged += new System.EventHandler(this.CantidadPorProducto_ValueChanged);
            // 
            // groupBoxEmpleado
            // 
            this.groupBoxEmpleado.BackColor = System.Drawing.Color.SeaShell;
            this.groupBoxEmpleado.Controls.Add(this.txtEmailEmpFact);
            this.groupBoxEmpleado.Controls.Add(this.txtNameEmpFact);
            this.groupBoxEmpleado.Controls.Add(this.label5);
            this.groupBoxEmpleado.Controls.Add(this.label8);
            this.groupBoxEmpleado.Controls.Add(this.txtCargoEmpFact);
            this.groupBoxEmpleado.Controls.Add(this.txtIdEmpFact);
            this.groupBoxEmpleado.Controls.Add(this.label6);
            this.groupBoxEmpleado.Controls.Add(this.label7);
            this.groupBoxEmpleado.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmpleado.Location = new System.Drawing.Point(41, 18);
            this.groupBoxEmpleado.Name = "groupBoxEmpleado";
            this.groupBoxEmpleado.Size = new System.Drawing.Size(280, 128);
            this.groupBoxEmpleado.TabIndex = 0;
            this.groupBoxEmpleado.TabStop = false;
            this.groupBoxEmpleado.Text = "Detalles del Empleado";
            // 
            // txtEmailEmpFact
            // 
            this.txtEmailEmpFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailEmpFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailEmpFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmpFact.Location = new System.Drawing.Point(139, 88);
            this.txtEmailEmpFact.Name = "txtEmailEmpFact";
            this.txtEmailEmpFact.Size = new System.Drawing.Size(125, 21);
            this.txtEmailEmpFact.TabIndex = 67;
            // 
            // txtNameEmpFact
            // 
            this.txtNameEmpFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameEmpFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameEmpFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEmpFact.Location = new System.Drawing.Point(139, 46);
            this.txtNameEmpFact.Name = "txtNameEmpFact";
            this.txtNameEmpFact.Size = new System.Drawing.Size(125, 21);
            this.txtNameEmpFact.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Id Empleado:";
            // 
            // txtCargoEmpFact
            // 
            this.txtCargoEmpFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargoEmpFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargoEmpFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoEmpFact.Location = new System.Drawing.Point(16, 88);
            this.txtCargoEmpFact.Name = "txtCargoEmpFact";
            this.txtCargoEmpFact.Size = new System.Drawing.Size(100, 21);
            this.txtCargoEmpFact.TabIndex = 65;
            // 
            // txtIdEmpFact
            // 
            this.txtIdEmpFact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdEmpFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmpFact.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpFact.Location = new System.Drawing.Point(16, 46);
            this.txtIdEmpFact.Name = "txtIdEmpFact";
            this.txtIdEmpFact.Size = new System.Drawing.Size(100, 21);
            this.txtIdEmpFact.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Id Cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.txtTotalFact);
            this.groupBox2.Controls.Add(this.BuPagar);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.radioButtonTransferencia);
            this.groupBox2.Controls.Add(this.radioButtonEfectivo);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(401, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodos de Pago";
            // 
            // radioButtonTransferencia
            // 
            this.radioButtonTransferencia.AutoSize = true;
            this.radioButtonTransferencia.Location = new System.Drawing.Point(6, 48);
            this.radioButtonTransferencia.Name = "radioButtonTransferencia";
            this.radioButtonTransferencia.Size = new System.Drawing.Size(118, 22);
            this.radioButtonTransferencia.TabIndex = 2;
            this.radioButtonTransferencia.TabStop = true;
            this.radioButtonTransferencia.Text = "Transferencia";
            this.radioButtonTransferencia.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(6, 26);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(82, 22);
            this.radioButtonEfectivo.TabIndex = 1;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVender";
            this.Text = "FormVender";
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarrito)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadPorProducto)).EndInit();
            this.groupBoxEmpleado.ResumeLayout(false);
            this.groupBoxEmpleado.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.GroupBox groupBoxVenta;
        private System.Windows.Forms.GroupBox groupBoxEmpleado;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuBuscarDatos;
        private System.Windows.Forms.RadioButton radioButtonProducto;
        private System.Windows.Forms.RadioButton radioButtonCliente;
        private System.Windows.Forms.RadioButton radioButtonEmpleado;
        private System.Windows.Forms.TextBox txtPhoneClientFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaClientFact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameClientFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdClientFact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmailEmpFact;
        private System.Windows.Forms.TextBox txtNameEmpFact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCargoEmpFact;
        private System.Windows.Forms.TextBox txtIdEmpFact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProductFact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CantidadPorProducto;
        private System.Windows.Forms.Button BuAddCarrito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPventaProductFact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameProductFact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubTotalFact;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BuPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataCarrito;
        private System.Windows.Forms.Button BuExit;
        private System.Windows.Forms.TextBox txtTotalFact;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn opcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonTransferencia;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
    }
}