namespace Essenza.Forms
{
    partial class RegistroInventarios
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
            this.plDock = new System.Windows.Forms.Panel();
            this.BuBuscarE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuRegister = new System.Windows.Forms.Button();
            this.BuUpdate = new System.Windows.Forms.Button();
            this.BuDeleteE = new System.Windows.Forms.Button();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtPventas = new System.Windows.Forms.TextBox();
            this.txtPcompras = new System.Windows.Forms.TextBox();
            this.cbxSuplidor = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtIdInv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.plDock.SuspendLayout();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.plDock.Controls.Add(this.cbxCategoria);
            this.plDock.Controls.Add(this.txtDescripcion);
            this.plDock.Controls.Add(this.BuBuscarE);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.BuRegister);
            this.plDock.Controls.Add(this.BuUpdate);
            this.plDock.Controls.Add(this.BuDeleteE);
            this.plDock.Controls.Add(this.dateIngreso);
            this.plDock.Controls.Add(this.txtPventas);
            this.plDock.Controls.Add(this.txtPcompras);
            this.plDock.Controls.Add(this.cbxSuplidor);
            this.plDock.Controls.Add(this.txtCantidad);
            this.plDock.Controls.Add(this.txtProducto);
            this.plDock.Controls.Add(this.txtIdInv);
            this.plDock.Controls.Add(this.label14);
            this.plDock.Controls.Add(this.label16);
            this.plDock.Controls.Add(this.label17);
            this.plDock.Controls.Add(this.label18);
            this.plDock.Controls.Add(this.label19);
            this.plDock.Controls.Add(this.label20);
            this.plDock.Controls.Add(this.label21);
            this.plDock.Controls.Add(this.label22);
            this.plDock.Controls.Add(this.label23);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 66);
            this.plDock.Margin = new System.Windows.Forms.Padding(4);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(1027, 577);
            this.plDock.TabIndex = 16;
            // 
            // BuBuscarE
            // 
            this.BuBuscarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuBuscarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuBuscarE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuBuscarE.FlatAppearance.BorderSize = 0;
            this.BuBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuBuscarE.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuBuscarE.ForeColor = System.Drawing.Color.White;
            this.BuBuscarE.Location = new System.Drawing.Point(72, 424);
            this.BuBuscarE.Margin = new System.Windows.Forms.Padding(4);
            this.BuBuscarE.Name = "BuBuscarE";
            this.BuBuscarE.Size = new System.Drawing.Size(140, 33);
            this.BuBuscarE.TabIndex = 70;
            this.BuBuscarE.Text = "Buscar";
            this.BuBuscarE.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 67;
            this.label1.Text = "Buscador";
            // 
            // BuRegister
            // 
            this.BuRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuRegister.FlatAppearance.BorderSize = 0;
            this.BuRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuRegister.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuRegister.ForeColor = System.Drawing.Color.White;
            this.BuRegister.Location = new System.Drawing.Point(834, 66);
            this.BuRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BuRegister.Name = "BuRegister";
            this.BuRegister.Size = new System.Drawing.Size(140, 33);
            this.BuRegister.TabIndex = 65;
            this.BuRegister.Text = "Register";
            this.BuRegister.UseVisualStyleBackColor = false;
            // 
            // BuUpdate
            // 
            this.BuUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuUpdate.FlatAppearance.BorderSize = 0;
            this.BuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuUpdate.ForeColor = System.Drawing.Color.White;
            this.BuUpdate.Location = new System.Drawing.Point(834, 161);
            this.BuUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BuUpdate.Name = "BuUpdate";
            this.BuUpdate.Size = new System.Drawing.Size(140, 33);
            this.BuUpdate.TabIndex = 64;
            this.BuUpdate.Text = "Update";
            this.BuUpdate.UseVisualStyleBackColor = false;
            // 
            // BuDeleteE
            // 
            this.BuDeleteE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuDeleteE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuDeleteE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuDeleteE.FlatAppearance.BorderSize = 0;
            this.BuDeleteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuDeleteE.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuDeleteE.ForeColor = System.Drawing.Color.White;
            this.BuDeleteE.Location = new System.Drawing.Point(834, 252);
            this.BuDeleteE.Margin = new System.Windows.Forms.Padding(4);
            this.BuDeleteE.Name = "BuDeleteE";
            this.BuDeleteE.Size = new System.Drawing.Size(140, 33);
            this.BuDeleteE.TabIndex = 63;
            this.BuDeleteE.Text = "Delete";
            this.BuDeleteE.UseVisualStyleBackColor = false;
            // 
            // dateIngreso
            // 
            this.dateIngreso.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIngreso.Location = new System.Drawing.Point(549, 190);
            this.dateIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(180, 26);
            this.dateIngreso.TabIndex = 60;
            // 
            // txtPventas
            // 
            this.txtPventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPventas.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPventas.Location = new System.Drawing.Point(549, 74);
            this.txtPventas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPventas.Name = "txtPventas";
            this.txtPventas.Size = new System.Drawing.Size(184, 24);
            this.txtPventas.TabIndex = 59;
            // 
            // txtPcompras
            // 
            this.txtPcompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPcompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPcompras.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcompras.Location = new System.Drawing.Point(309, 74);
            this.txtPcompras.Margin = new System.Windows.Forms.Padding(4);
            this.txtPcompras.Name = "txtPcompras";
            this.txtPcompras.Size = new System.Drawing.Size(184, 24);
            this.txtPcompras.TabIndex = 55;
            // 
            // cbxSuplidor
            // 
            this.cbxSuplidor.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuplidor.FormattingEnabled = true;
            this.cbxSuplidor.Location = new System.Drawing.Point(72, 192);
            this.cbxSuplidor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSuplidor.Name = "cbxSuplidor";
            this.cbxSuplidor.Size = new System.Drawing.Size(180, 29);
            this.cbxSuplidor.TabIndex = 54;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(549, 134);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(184, 24);
            this.txtCantidad.TabIndex = 53;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(72, 133);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(184, 24);
            this.txtProducto.TabIndex = 52;
            // 
            // txtIdInv
            // 
            this.txtIdInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdInv.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInv.Location = new System.Drawing.Point(72, 74);
            this.txtIdInv.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdInv.Name = "txtIdInv";
            this.txtIdInv.Size = new System.Drawing.Size(184, 24);
            this.txtIdInv.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Id Inventario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 110);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Producto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(545, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 21);
            this.label17.TabIndex = 48;
            this.label17.Text = "Precio de Venta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(545, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 21);
            this.label18.TabIndex = 41;
            this.label18.Text = "Cantidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(305, 165);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 21);
            this.label19.TabIndex = 47;
            this.label19.Text = "Categoria";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(68, 165);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 21);
            this.label20.TabIndex = 42;
            this.label20.Text = "Suplidor";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(305, 50);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 21);
            this.label21.TabIndex = 46;
            this.label21.Text = "Precio de Compra";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(305, 110);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 21);
            this.label22.TabIndex = 43;
            this.label22.Text = "Descripcion";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(545, 165);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 21);
            this.label23.TabIndex = 45;
            this.label23.Text = "Fecha de Ingreso";
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(30)))), ((int)(((byte)(91)))));
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Controls.Add(this.label2);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(4);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1027, 66);
            this.plTop.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Essenza.Properties.Resources.Checked_Identification_Documents;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Size = new System.Drawing.Size(261, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Registro de Inventarios";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(309, 133);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 24);
            this.txtDescripcion.TabIndex = 71;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(309, 192);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(180, 29);
            this.cbxCategoria.TabIndex = 72;
            // 
            // RegistroInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 643);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroInventarios";
            this.Text = "RegistroInventarios";
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.Button BuBuscarE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuRegister;
        private System.Windows.Forms.Button BuUpdate;
        private System.Windows.Forms.Button BuDeleteE;
        private System.Windows.Forms.DateTimePicker dateIngreso;
        private System.Windows.Forms.TextBox txtPventas;
        private System.Windows.Forms.TextBox txtPcompras;
        private System.Windows.Forms.ComboBox cbxSuplidor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtIdInv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}