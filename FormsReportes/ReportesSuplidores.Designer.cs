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
            this.button1 = new System.Windows.Forms.Button();
            this.BuExcelRI = new System.Windows.Forms.Button();
            this.cbxFilroInventarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterInventarios = new System.Windows.Forms.TextBox();
            this.dataListSuplidores = new System.Windows.Forms.DataGridView();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListSuplidores)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDock
            // 
            this.plDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.plDock.Controls.Add(this.button1);
            this.plDock.Controls.Add(this.BuExcelRI);
            this.plDock.Controls.Add(this.cbxFilroInventarios);
            this.plDock.Controls.Add(this.label1);
            this.plDock.Controls.Add(this.txtFilterInventarios);
            this.plDock.Controls.Add(this.dataListSuplidores);
            this.plDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDock.Location = new System.Drawing.Point(0, 54);
            this.plDock.Name = "plDock";
            this.plDock.Size = new System.Drawing.Size(768, 468);
            this.plDock.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "A-Z";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuExcelRI
            // 
            this.BuExcelRI.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuExcelRI.Location = new System.Drawing.Point(49, 418);
            this.BuExcelRI.Name = "BuExcelRI";
            this.BuExcelRI.Size = new System.Drawing.Size(131, 28);
            this.BuExcelRI.TabIndex = 71;
            this.BuExcelRI.Text = "Exportar en Excel";
            this.BuExcelRI.UseVisualStyleBackColor = true;
            // 
            // cbxFilroInventarios
            // 
            this.cbxFilroInventarios.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilroInventarios.FormattingEnabled = true;
            this.cbxFilroInventarios.Location = new System.Drawing.Point(127, 29);
            this.cbxFilroInventarios.Name = "cbxFilroInventarios";
            this.cbxFilroInventarios.Size = new System.Drawing.Size(170, 23);
            this.cbxFilroInventarios.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Buscar por";
            // 
            // txtFilterInventarios
            // 
            this.txtFilterInventarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterInventarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInventarios.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterInventarios.Location = new System.Drawing.Point(303, 31);
            this.txtFilterInventarios.Name = "txtFilterInventarios";
            this.txtFilterInventarios.Size = new System.Drawing.Size(420, 21);
            this.txtFilterInventarios.TabIndex = 67;
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
            this.dataListSuplidores.Location = new System.Drawing.Point(49, 78);
            this.dataListSuplidores.MaximumSize = new System.Drawing.Size(674, 325);
            this.dataListSuplidores.MinimumSize = new System.Drawing.Size(674, 325);
            this.dataListSuplidores.Name = "dataListSuplidores";
            this.dataListSuplidores.RowHeadersWidth = 51;
            this.dataListSuplidores.Size = new System.Drawing.Size(674, 325);
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
            this.plTop.Size = new System.Drawing.Size(768, 54);
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
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.plDock);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesSuplidores";
            this.Text = "ReportesSuplidores";
            this.plDock.ResumeLayout(false);
            this.plDock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListSuplidores)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BuExcelRI;
        private System.Windows.Forms.ComboBox cbxFilroInventarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterInventarios;
        private System.Windows.Forms.DataGridView dataListSuplidores;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}