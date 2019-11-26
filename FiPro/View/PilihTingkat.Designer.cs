namespace FiPro
{
    partial class PilihTingkat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihTingkat));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pelanggaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mohon Pilih Kategori ";
            // 
            // btn_OK
            // 
            this.btn_OK.ActiveBorderThickness = 1;
            this.btn_OK.ActiveCornerRadius = 20;
            this.btn_OK.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.ActiveForecolor = System.Drawing.Color.White;
            this.btn_OK.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OK.BackgroundImage")));
            this.btn_OK.ButtonText = "OKE";
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.IdleBorderThickness = 1;
            this.btn_OK.IdleCornerRadius = 20;
            this.btn_OK.IdleFillColor = System.Drawing.Color.White;
            this.btn_OK.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_OK.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_OK.Location = new System.Drawing.Point(117, 121);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(109, 41);
            this.btn_OK.TabIndex = 25;
            this.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // PilihTingkat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(354, 189);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PilihTingkat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PilihTingkat";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}