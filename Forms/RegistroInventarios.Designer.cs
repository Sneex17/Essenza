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
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.BuBuscarE = new System.Windows.Forms.Button();
            this.BuRegistroInventario = new System.Windows.Forms.Button();
            this.BuUpdateInventario = new System.Windows.Forms.Button();
            this.BuDeleteInventario = new System.Windows.Forms.Button();
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
            this.plDock.Controls.Add(this.BuRegistroInventario);
            this.plDock.Controls.Add(this.BuUpdateInventario);
            this.plDock.Controls.Add(this.BuDeleteInventario);
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
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(770, 468);
            this.plDock.TabIndex = 16;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(232, 156);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(136, 24);
            this.cbxCategoria.TabIndex = 72;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(232, 108);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(138, 21);
            this.txtDescripcion.TabIndex = 71;
            // 
            // BuBuscarE
            // 
            this.BuBuscarE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuBuscarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(193)))));
            this.BuBuscarE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuBuscarE.FlatAppearance.BorderSize = 0;
            this.BuBuscarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuBuscarE.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuBuscarE.ForeColor = System.Drawing.Color.White;
            this.BuBuscarE.Image = global::Essenza.Properties.Resources.Search_in_List;
            this.BuBuscarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuBuscarE.Location = new System.Drawing.Point(588, 32);
            this.BuBuscarE.Name = "BuBuscarE";
            this.BuBuscarE.Size = new System.Drawing.Size(154, 40);
            this.BuBuscarE.TabIndex = 70;
            this.BuBuscarE.Text = "Buscador";
            this.BuBuscarE.UseVisualStyleBackColor = false;
            this.BuBuscarE.Click += new System.EventHandler(this.BuBuscarE_Click);
            // 
            // BuRegistroInventario
            // 
            this.BuRegistroInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuRegistroInventario.BackColor = System.Drawing.Color.ForestGreen;
            this.BuRegistroInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuRegistroInventario.FlatAppearance.BorderSize = 0;
            this.BuRegistroInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuRegistroInventario.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuRegistroInventario.ForeColor = System.Drawing.Color.White;
            this.BuRegistroInventario.Image = global::Essenza.Properties.Resources.Add_New;
            this.BuRegistroInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuRegistroInventario.Location = new System.Drawing.Point(341, 398);
            this.BuRegistroInventario.Name = "BuRegistroInventario";
            this.BuRegistroInventario.Size = new System.Drawing.Size(130, 40);
            this.BuRegistroInventario.TabIndex = 65;
            this.BuRegistroInventario.Text = "Register";
            this.BuRegistroInventario.UseVisualStyleBackColor = false;
            this.BuRegistroInventario.Click += new System.EventHandler(this.BuRegistroInventario_Click);
            // 
            // BuUpdateInventario
            // 
            this.BuUpdateInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuUpdateInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.BuUpdateInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuUpdateInventario.FlatAppearance.BorderSize = 0;
            this.BuUpdateInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuUpdateInventario.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuUpdateInventario.ForeColor = System.Drawing.Color.White;
            this.BuUpdateInventario.Image = global::Essenza.Properties.Resources.Edit_Property;
            this.BuUpdateInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuUpdateInventario.Location = new System.Drawing.Point(477, 398);
            this.BuUpdateInventario.Name = "BuUpdateInventario";
            this.BuUpdateInventario.Size = new System.Drawing.Size(130, 40);
            this.BuUpdateInventario.TabIndex = 64;
            this.BuUpdateInventario.Text = "Update";
            this.BuUpdateInventario.UseVisualStyleBackColor = false;
            this.BuUpdateInventario.Click += new System.EventHandler(this.BuUpdateInventario_Click);
            // 
            // BuDeleteInventario
            // 
            this.BuDeleteInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuDeleteInventario.BackColor = System.Drawing.Color.Firebrick;
            this.BuDeleteInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuDeleteInventario.FlatAppearance.BorderSize = 0;
            this.BuDeleteInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuDeleteInventario.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuDeleteInventario.ForeColor = System.Drawing.Color.White;
            this.BuDeleteInventario.Image = global::Essenza.Properties.Resources.Delete;
            this.BuDeleteInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuDeleteInventario.Location = new System.Drawing.Point(612, 398);
            this.BuDeleteInventario.Name = "BuDeleteInventario";
            this.BuDeleteInventario.Size = new System.Drawing.Size(130, 40);
            this.BuDeleteInventario.TabIndex = 63;
            this.BuDeleteInventario.Text = "Delete";
            this.BuDeleteInventario.UseVisualStyleBackColor = false;
            this.BuDeleteInventario.Click += new System.EventHandler(this.BuDeleteInventario_Click);
            // 
            // dateIngreso
            // 
            this.dateIngreso.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIngreso.Location = new System.Drawing.Point(412, 154);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(136, 22);
            this.dateIngreso.TabIndex = 60;
            // 
            // txtPventas
            // 
            this.txtPventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPventas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPventas.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPventas.Location = new System.Drawing.Point(412, 60);
            this.txtPventas.Name = "txtPventas";
            this.txtPventas.Size = new System.Drawing.Size(138, 21);
            this.txtPventas.TabIndex = 59;
            // 
            // txtPcompras
            // 
            this.txtPcompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPcompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPcompras.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcompras.Location = new System.Drawing.Point(232, 60);
            this.txtPcompras.Name = "txtPcompras";
            this.txtPcompras.Size = new System.Drawing.Size(138, 21);
            this.txtPcompras.TabIndex = 55;
            // 
            // cbxSuplidor
            // 
            this.cbxSuplidor.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuplidor.FormattingEnabled = true;
            this.cbxSuplidor.Location = new System.Drawing.Point(54, 156);
            this.cbxSuplidor.Name = "cbxSuplidor";
            this.cbxSuplidor.Size = new System.Drawing.Size(136, 24);
            this.cbxSuplidor.TabIndex = 54;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(412, 109);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 21);
            this.txtCantidad.TabIndex = 53;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(54, 108);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(138, 21);
            this.txtProducto.TabIndex = 52;
            // 
            // txtIdInv
            // 
            this.txtIdInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdInv.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInv.Location = new System.Drawing.Point(54, 60);
            this.txtIdInv.Name = "txtIdInv";
            this.txtIdInv.Size = new System.Drawing.Size(138, 21);
            this.txtIdInv.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Id Inventario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(51, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Producto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(409, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 16);
            this.label17.TabIndex = 48;
            this.label17.Text = "Precio de Venta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(409, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "Cantidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(229, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "Categoria";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(51, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 42;
            this.label20.Text = "Suplidor";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(229, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 16);
            this.label21.TabIndex = 46;
            this.label21.Text = "Precio de Compra";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(229, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 16);
            this.label22.TabIndex = 43;
            this.label22.Text = "Descripcion";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(409, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 16);
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
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(770, 54);
            this.plTop.TabIndex = 15;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Registro de Inventarios";
            // 
            // RegistroInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 522);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button BuRegistroInventario;
        private System.Windows.Forms.Button BuUpdateInventario;
        private System.Windows.Forms.Button BuDeleteInventario;
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