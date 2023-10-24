namespace FinalProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazılanReçetelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastanınKullandığıİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(389, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen sağ üst menüden işlem seçiniz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muayeneKaydıToolStripMenuItem,
            this.yazılanReçetelerToolStripMenuItem,
            this.hastanınKullandığıİlaçlarToolStripMenuItem,
            this.muayeneListeleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // muayeneKaydıToolStripMenuItem
            // 
            this.muayeneKaydıToolStripMenuItem.Name = "muayeneKaydıToolStripMenuItem";
            this.muayeneKaydıToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.muayeneKaydıToolStripMenuItem.Text = "Muayene Kaydı";
            this.muayeneKaydıToolStripMenuItem.Click += new System.EventHandler(this.muayeneKaydıToolStripMenuItem_Click);
            // 
            // yazılanReçetelerToolStripMenuItem
            // 
            this.yazılanReçetelerToolStripMenuItem.Name = "yazılanReçetelerToolStripMenuItem";
            this.yazılanReçetelerToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.yazılanReçetelerToolStripMenuItem.Text = "Yazılan Reçeteler";
            this.yazılanReçetelerToolStripMenuItem.Click += new System.EventHandler(this.yazılanReçetelerToolStripMenuItem_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.saglik_bakanligi_logo_3;
            this.ClientSize = new System.Drawing.Size(1193, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazılanReçetelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastanınKullandığıİlaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneListeleToolStripMenuItem;
    }
}

