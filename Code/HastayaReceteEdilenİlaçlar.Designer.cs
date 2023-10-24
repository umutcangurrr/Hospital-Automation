namespace FinalProject
{
    partial class HastayaReceteEdilenİlaçlar
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
            this.tutucuDgw = new System.Windows.Forms.DataGridView();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.hastaTcTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receteliİlaclarDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tutucuDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteliİlaclarDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // tutucuDgw
            // 
            this.tutucuDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tutucuDgw.Location = new System.Drawing.Point(363, 161);
            this.tutucuDgw.Name = "tutucuDgw";
            this.tutucuDgw.RowHeadersWidth = 51;
            this.tutucuDgw.RowTemplate.Height = 24;
            this.tutucuDgw.Size = new System.Drawing.Size(10, 10);
            this.tutucuDgw.TabIndex = 0;
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.Location = new System.Drawing.Point(462, 518);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(231, 63);
            this.ListeleBtn.TabIndex = 1;
            this.ListeleBtn.Text = "Listele";
            this.ListeleBtn.UseVisualStyleBackColor = true;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // hastaTcTxt
            // 
            this.hastaTcTxt.Location = new System.Drawing.Point(244, 536);
            this.hastaTcTxt.Name = "hastaTcTxt";
            this.hastaTcTxt.Size = new System.Drawing.Size(146, 22);
            this.hastaTcTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastanın T.C\'sini giriniz:";
            // 
            // receteliİlaclarDgw
            // 
            this.receteliİlaclarDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteliİlaclarDgw.Location = new System.Drawing.Point(12, 21);
            this.receteliİlaclarDgw.Name = "receteliİlaclarDgw";
            this.receteliİlaclarDgw.RowHeadersWidth = 51;
            this.receteliİlaclarDgw.RowTemplate.Height = 24;
            this.receteliİlaclarDgw.Size = new System.Drawing.Size(1079, 425);
            this.receteliİlaclarDgw.TabIndex = 4;
            // 
            // HastayaReceteEdilenİlaçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.feather_2947022_960_720;
            this.ClientSize = new System.Drawing.Size(1126, 625);
            this.Controls.Add(this.receteliİlaclarDgw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastaTcTxt);
            this.Controls.Add(this.ListeleBtn);
            this.Controls.Add(this.tutucuDgw);
            this.Name = "HastayaReceteEdilenİlaçlar";
            this.Text = "HastayaReceteEdilenİlaçlar";
            ((System.ComponentModel.ISupportInitialize)(this.tutucuDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteliİlaclarDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tutucuDgw;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.TextBox hastaTcTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView receteliİlaclarDgw;
    }
}