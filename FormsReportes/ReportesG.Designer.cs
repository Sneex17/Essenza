namespace Essenza.FormsReportes
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewerGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.BuExit = new System.Windows.Forms.Button();
            this.panelReport.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(834, 69);
            this.panelTop.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewerGeneral);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 69);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(834, 542);
            this.panelReport.TabIndex = 1;
            // 
            // reportViewerGeneral
            // 
            this.reportViewerGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerGeneral.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGeneral.Name = "reportViewerGeneral";
            this.reportViewerGeneral.ServerReport.BearerToken = null;
            this.reportViewerGeneral.Size = new System.Drawing.Size(834, 542);
            this.reportViewerGeneral.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.BuExit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 542);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(834, 69);
            this.panelButtons.TabIndex = 1;
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
            this.BuExit.Location = new System.Drawing.Point(13, 16);
            this.BuExit.Name = "BuExit";
            this.BuExit.Size = new System.Drawing.Size(128, 37);
            this.BuExit.TabIndex = 84;
            this.BuExit.Text = "Volver";
            this.BuExit.UseVisualStyleBackColor = false;
            this.BuExit.Click += new System.EventHandler(this.BuExit_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panelReport.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelButtons;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGeneral;
        private System.Windows.Forms.Button BuExit;
    }
}