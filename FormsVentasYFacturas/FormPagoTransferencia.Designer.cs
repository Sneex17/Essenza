namespace Essenza.FormsVentasYFacturas
{
    partial class FormPagoTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoTransferencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProcesando = new System.Windows.Forms.ProgressBar();
            this.BuCancelar = new System.Windows.Forms.Button();
            this.BuPagarFinal = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printTransferencia = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 236);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pbProcesando);
            this.groupBox1.Controls.Add(this.BuCancelar);
            this.groupBox1.Controls.Add(this.BuPagarFinal);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Pago";
            // 
            // pbProcesando
            // 
            this.pbProcesando.Location = new System.Drawing.Point(33, 91);
            this.pbProcesando.Name = "pbProcesando";
            this.pbProcesando.Size = new System.Drawing.Size(270, 33);
            this.pbProcesando.TabIndex = 80;
            // 
            // BuCancelar
            // 
            this.BuCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BuCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuCancelar.FlatAppearance.BorderSize = 0;
            this.BuCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuCancelar.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuCancelar.ForeColor = System.Drawing.Color.White;
            this.BuCancelar.Image = global::Essenza.Properties.Resources.Delete;
            this.BuCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuCancelar.Location = new System.Drawing.Point(173, 139);
            this.BuCancelar.Name = "BuCancelar";
            this.BuCancelar.Size = new System.Drawing.Size(130, 29);
            this.BuCancelar.TabIndex = 79;
            this.BuCancelar.Text = "Cancelar";
            this.BuCancelar.UseVisualStyleBackColor = false;
            this.BuCancelar.Click += new System.EventHandler(this.BuCancelar_Click);
            // 
            // BuPagarFinal
            // 
            this.BuPagarFinal.BackColor = System.Drawing.Color.ForestGreen;
            this.BuPagarFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuPagarFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuPagarFinal.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuPagarFinal.ForeColor = System.Drawing.Color.White;
            this.BuPagarFinal.Image = global::Essenza.Properties.Resources.Cash;
            this.BuPagarFinal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuPagarFinal.Location = new System.Drawing.Point(33, 139);
            this.BuPagarFinal.Name = "BuPagarFinal";
            this.BuPagarFinal.Size = new System.Drawing.Size(130, 29);
            this.BuPagarFinal.TabIndex = 78;
            this.BuPagarFinal.Text = "Pagar";
            this.BuPagarFinal.UseVisualStyleBackColor = false;
            this.BuPagarFinal.Click += new System.EventHandler(this.BuPagarFinal_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(196, 41);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(50, 18);
            this.lbTotal.TabIndex = 74;
            this.lbTotal.Text = "$ 0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "Total a Pagar:";
            // 
            // printTransferencia
            // 
            this.printTransferencia.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirFactura);
            // 
            // FormPagoTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 236);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPagoTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago con Transferencia";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuCancelar;
        private System.Windows.Forms.Button BuPagarFinal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printTransferencia;
        private System.Windows.Forms.ProgressBar pbProcesando;
    }
}