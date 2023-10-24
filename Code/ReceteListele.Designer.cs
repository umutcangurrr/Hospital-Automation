namespace FinalProject
{
    partial class ReceteListele
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
            this.receteListeleDgw = new System.Windows.Forms.DataGridView();
            this.receteListeleBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayneKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastanınKullandığıİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDgw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receteListeleDgw
            // 
            this.receteListeleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteListeleDgw.Location = new System.Drawing.Point(12, 50);
            this.receteListeleDgw.Name = "receteListeleDgw";
            this.receteListeleDgw.RowHeadersWidth = 51;
            this.receteListeleDgw.RowTemplate.Height = 24;
            this.receteListeleDgw.Size = new System.Drawing.Size(1017, 457);
            this.receteListeleDgw.TabIndex = 0;
            // 
            // receteListeleBtn
            // 
            this.receteListeleBtn.Location = new System.Drawing.Point(399, 527);
            this.receteListeleBtn.Name = "receteListeleBtn";
            this.receteListeleBtn.Size = new System.Drawing.Size(237, 62);
            this.receteListeleBtn.TabIndex = 1;
            this.receteListeleBtn.Text = "Listele";
            this.receteListeleBtn.UseVisualStyleBackColor = true;
            this.receteListeleBtn.Click += new System.EventHandler(this.receteListeleBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muayneKaydıToolStripMenuItem,
            this.hastanınKullandığıİlaçlarToolStripMenuItem,
            this.muayeneListeleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // muayneKaydıToolStripMenuItem
            // 
            this.muayneKaydıToolStripMenuItem.Name = "muayneKaydıToolStripMenuItem";
            this.muayneKaydıToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.muayneKaydıToolStripMenuItem.Text = "Muayne Kaydı";
            this.muayneKaydıToolStripMenuItem.Click += new System.EventHandler(this.muayneKaydıToolStripMenuItem_Click);
            // 
            // hastanınKullandığıİlaçlarToolStripMenuItem
            // 
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Name = "hastanınKullandığıİlaçlarToolStripMenuItem";
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Text = "Hastanın kullandığı ilaçlar";
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Click += new System.EventHandler(this.hastanınKullandığıİlaçlarToolStripMenuItem_Click);
            // 
            // muayeneListeleToolStripMenuItem
            // 
            this.muayeneListeleToolStripMenuItem.Name = "muayeneListeleToolStripMenuItem";
            this.muayeneListeleToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.muayeneListeleToolStripMenuItem.Text = "Muayene Listele";
            this.muayeneListeleToolStripMenuItem.Click += new System.EventHandler(this.muayeneListeleToolStripMenuItem_Click);
            // 
            // ReceteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.feather_2947022_960_720;
            this.ClientSize = new System.Drawing.Size(1041, 601);
            this.Controls.Add(this.receteListeleBtn);
            this.Controls.Add(this.receteListeleDgw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReceteListele";
            this.Text = "ReceteListele";
            ((System.ComponentModel.ISupportInitialize)(this.receteListeleDgw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView receteListeleDgw;
        private System.Windows.Forms.Button receteListeleBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayneKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastanınKullandığıİlaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneListeleToolStripMenuItem;
    }
}