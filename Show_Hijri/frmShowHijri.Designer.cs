namespace Show_Hijri
{
    partial class frmShowHijri
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
            this.lblHijriDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHijriDate
            // 
            this.lblHijriDate.AutoSize = true;
            this.lblHijriDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHijriDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijriDate.ForeColor = System.Drawing.Color.White;
            this.lblHijriDate.Location = new System.Drawing.Point(0, 0);
            this.lblHijriDate.Name = "lblHijriDate";
            this.lblHijriDate.Size = new System.Drawing.Size(48, 17);
            this.lblHijriDate.TabIndex = 0;
            this.lblHijriDate.Text = "label1";
            this.lblHijriDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseDown);
            this.lblHijriDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseMove);
            this.lblHijriDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(297, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowHijri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(316, 17);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHijriDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowHijri";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmShowHijri_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmShowHijri_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHijriDate;
        private System.Windows.Forms.Button btnClose;

    }
}

