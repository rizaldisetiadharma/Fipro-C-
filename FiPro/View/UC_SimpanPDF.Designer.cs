namespace FiPro
{
    partial class UC_SimpanPDF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_lokasi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_export = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_browse.BorderRadius = 0;
            this.btn_browse.ButtonText = "Pilih Lokasi";
            this.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse.DisabledColor = System.Drawing.Color.Gray;
            this.btn_browse.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_browse.Iconimage = null;
            this.btn_browse.Iconimage_right = null;
            this.btn_browse.Iconimage_right_Selected = null;
            this.btn_browse.Iconimage_Selected = null;
            this.btn_browse.IconMarginLeft = 0;
            this.btn_browse.IconMarginRight = 0;
            this.btn_browse.IconRightVisible = true;
            this.btn_browse.IconRightZoom = 0D;
            this.btn_browse.IconVisible = true;
            this.btn_browse.IconZoom = 90D;
            this.btn_browse.IsTab = false;
            this.btn_browse.Location = new System.Drawing.Point(33, 479);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_browse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.btn_browse.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_browse.selected = false;
            this.btn_browse.Size = new System.Drawing.Size(126, 48);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Pilih Lokasi";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_browse.Textcolor = System.Drawing.Color.White;
            this.btn_browse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click_1);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(23, 71);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.Size = new System.Drawing.Size(661, 393);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txt_lokasi
            // 
            this.txt_lokasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_lokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lokasi.HintForeColor = System.Drawing.Color.Empty;
            this.txt_lokasi.HintText = "";
            this.txt_lokasi.isPassword = false;
            this.txt_lokasi.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_lokasi.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_lokasi.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_lokasi.LineThickness = 3;
            this.txt_lokasi.Location = new System.Drawing.Point(171, 494);
            this.txt_lokasi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lokasi.Name = "txt_lokasi";
            this.txt_lokasi.Size = new System.Drawing.Size(346, 33);
            this.txt_lokasi.TabIndex = 10;
            this.txt_lokasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_lokasi.OnValueChanged += new System.EventHandler(this.txt_lokasi_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(14)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(219, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(273, 36);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Simpan Data Ke PDF";
            // 
            // btn_export
            // 
            this.btn_export.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export.BorderRadius = 0;
            this.btn_export.ButtonText = "Simpan Data";
            this.btn_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export.DisabledColor = System.Drawing.Color.Gray;
            this.btn_export.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_export.Iconimage = global::FiPro.Properties.Resources.save1;
            this.btn_export.Iconimage_right = null;
            this.btn_export.Iconimage_right_Selected = null;
            this.btn_export.Iconimage_Selected = null;
            this.btn_export.IconMarginLeft = 0;
            this.btn_export.IconMarginRight = 0;
            this.btn_export.IconRightVisible = true;
            this.btn_export.IconRightZoom = 0D;
            this.btn_export.IconVisible = true;
            this.btn_export.IconZoom = 90D;
            this.btn_export.IsTab = false;
            this.btn_export.Location = new System.Drawing.Point(524, 482);
            this.btn_export.Name = "btn_export";
            this.btn_export.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_export.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.btn_export.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_export.selected = false;
            this.btn_export.Size = new System.Drawing.Size(142, 48);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "Simpan Data";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Textcolor = System.Drawing.Color.White;
            this.btn_export.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click_1);
            // 
            // UC_SimpanPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_lokasi);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_browse);
            this.Name = "UC_SimpanPDF";
            this.Size = new System.Drawing.Size(710, 560);
            this.Load += new System.EventHandler(this.UC_SimpanPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_browse;
        private Bunifu.Framework.UI.BunifuFlatButton btn_export;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_lokasi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
