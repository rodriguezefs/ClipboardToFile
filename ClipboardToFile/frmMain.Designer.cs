namespace ClipboardToFile
{
    partial class frmMain
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
            this.cmdPro = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbr = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSal = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRslt = new System.Windows.Forms.TextBox();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPro
            // 
            this.cmdPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPro.Location = new System.Drawing.Point(390, 419);
            this.cmdPro.Name = "cmdPro";
            this.cmdPro.Size = new System.Drawing.Size(110, 28);
            this.cmdPro.TabIndex = 4;
            this.cmdPro.Text = "&Procesar";
            this.cmdPro.UseVisualStyleBackColor = true;
            this.cmdPro.Click += new System.EventHandler(this.CmdPro_Click);
            // 
            // txtBase
            // 
            this.txtBase.AcceptsReturn = true;
            this.txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase.Location = new System.Drawing.Point(12, 27);
            this.txtBase.Multiline = true;
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(488, 196);
            this.txtBase.TabIndex = 3;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArch});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(512, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // mnuArch
            // 
            this.mnuArch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbr,
            this.ToolStripSeparator1,
            this.mnuSal});
            this.mnuArch.Name = "mnuArch";
            this.mnuArch.Size = new System.Drawing.Size(60, 20);
            this.mnuArch.Text = "&Archivo";
            // 
            // mnuAbr
            // 
            this.mnuAbr.Name = "mnuAbr";
            this.mnuAbr.Size = new System.Drawing.Size(180, 22);
            this.mnuAbr.Text = "&Abrir...";
            this.mnuAbr.Click += new System.EventHandler(this.MnuAbr_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSal
            // 
            this.mnuSal.Name = "mnuSal";
            this.mnuSal.Size = new System.Drawing.Size(180, 22);
            this.mnuSal.Text = "&Salir";
            // 
            // txtRslt
            // 
            this.txtRslt.AcceptsReturn = true;
            this.txtRslt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRslt.Location = new System.Drawing.Point(12, 229);
            this.txtRslt.Multiline = true;
            this.txtRslt.Name = "txtRslt";
            this.txtRslt.Size = new System.Drawing.Size(488, 184);
            this.txtRslt.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 459);
            this.Controls.Add(this.txtRslt);
            this.Controls.Add(this.cmdPro);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmMain";
            this.Text = "Clipboard To File";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdPro;
        internal System.Windows.Forms.TextBox txtBase;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem mnuArch;
        internal System.Windows.Forms.ToolStripMenuItem mnuAbr;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem mnuSal;
        internal System.Windows.Forms.TextBox txtRslt;
    }
}