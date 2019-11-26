namespace FiPro
{
    partial class Pastikan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pastikan));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_OKE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(268, 23);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Maaf NIP/Password Anda Salah";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OKE
            // 
            this.btn_OKE.ActiveBorderThickness = 1;
            this.btn_OKE.ActiveCornerRadius = 20;
            this.btn_OKE.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.ActiveForecolor = System.Drawing.Color.White;
            this.btn_OKE.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OKE.BackgroundImage")));
            this.btn_OKE.ButtonText = "OKE";
            this.btn_OKE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKE.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.IdleBorderThickness = 1;
            this.btn_OKE.IdleCornerRadius = 20;
            this.btn_OKE.IdleFillColor = System.Drawing.Color.White;
            this.btn_OKE.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OKE.Location = new System.Drawing.Point(103, 65);
            this.btn_OKE.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OKE.Name = "btn_OKE";
            this.btn_OKE.Size = new System.Drawing.Size(98, 41);
            this.btn_OKE.TabIndex = 4;
            this.btn_OKE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OKE.Click += new System.EventHandler(this.btn_OKE_Click);
            // 
            // Pastikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(305, 130);
            this.Controls.Add(this.btn_OKE);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pastikan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastikan";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_OKE;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}