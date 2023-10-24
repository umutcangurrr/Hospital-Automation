namespace FinalProject
{
    partial class MuayeneListele
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
            this.muayeneListeleDgw = new System.Windows.Forms.DataGridView();
            this.muayeneListeleBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayneKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazılanReçetelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastanınKullandığıİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.muayeneListeleDgw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // muayeneListeleDgw
            // 
            this.muayeneListeleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muayeneListeleDgw.Location = new System.Drawing.Point(12, 44);
            this.muayeneListeleDgw.Name = "muayeneListeleDgw";
            this.muayeneListeleDgw.RowHeadersWidth = 51;
            this.muayeneListeleDgw.RowTemplate.Height = 24;
            this.muayeneListeleDgw.Size = new System.Drawing.Size(1444, 494);
            this.muayeneListeleDgw.TabIndex = 0;
            // 
            // muayeneListeleBtn
            // 
            this.muayeneListeleBtn.Location = new System.Drawing.Point(630, 544);
            this.muayeneListeleBtn.Name = "muayeneListeleBtn";
            this.muayeneListeleBtn.Size = new System.Drawing.Size(234, 79);
            this.muayeneListeleBtn.TabIndex = 1;
            this.muayeneListeleBtn.Text = "Listele";
            this.muayeneListeleBtn.UseVisualStyleBackColor = true;
            this.muayeneListeleBtn.Click += new System.EventHandler(this.muayeneListeleBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muayneKaydıToolStripMenuItem,
            this.yazılanReçetelerToolStripMenuItem,
            this.hastanınKullandığıİlaçlarToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // muayneKaydıToolStripMenuItem
            // 
            this.muayneKaydıToolStripMenuItem.Name = "muayneKaydıToolStripMenuItem";
            this.muayneKaydıToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.muayneKaydıToolStripMenuItem.Text = "Muayne Kaydı";
            this.muayneKaydıToolStripMenuItem.Click += new System.EventHandler(this.muayneKaydıToolStripMenuItem_Click);
            // 
            // yazılanReçetelerToolStripMenuItem
            // 
            this.yazılanReçetelerToolStripMenuItem.Name = "yazılanReçetelerToolStripMenuItem";
            this.yazılanReçetelerToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.yazılanReçetelerToolStripMenuItem.Text = "Yazılan Reçeteler";
            this.yazılanReçetelerToolStripMenuItem.Click += new System.EventHandler(this.yazılanReçetelerToolStripMenuItem_Click);
            // 
            // hastanınKullandığıİlaçlarToolStripMenuItem
            // 
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Name = "hastanınKullandığıİlaçlarToolStripMenuItem";
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Text = "Hastanın Kullandığı İlaçlar";
            this.hastanınKullandığıİlaçlarToolStripMenuItem.Click += new System.EventHandler(this.hastanınKullandığıİlaçlarToolStripMenuItem_Click);
            // 
            // MuayeneListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.feather_2947022_960_720;
            this.ClientSize = new System.Drawing.Size(1468, 635);
            this.Controls.Add(this.muayeneListeleBtn);
            this.Controls.Add(this.muayeneListeleDgw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MuayeneListele";
            this.Text = "MuayeneListele";
            ((System.ComponentModel.ISupportInitialize)(this.muayeneListeleDgw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView muayeneListeleDgw;
        private System.Windows.Forms.Button muayeneListeleBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayneKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazılanReçetelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastanınKullandığıİlaçlarToolStripMenuItem;
    }
}