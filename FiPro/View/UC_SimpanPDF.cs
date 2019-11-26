using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace FiPro
{
    public partial class UC_SimpanPDF : UserControl
    {
        private Entity.EntSiswa siswa;
        private Interface.intSiswa siswaDao;
        private DataTable tabel;



        SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

        public UC_SimpanPDF()
        {
            InitializeComponent();
            siswa = new Entity.EntSiswa();
            siswaDao = Factory.Factory.getSiswaDao();

            TampilDataSiswa();

            // Mengatur property savefiledialog
            SaveFileDialog1.FileName = "";
            SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";

            txt_lokasi.Text = "";


        }
        private void UC_SimpanPDF_Load(object sender, EventArgs e)
        {        
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult result = SaveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txt_lokasi.Text = SaveFileDialog1.FileName;
            }
        }

        private void btn_browse_Click_1(object sender, EventArgs e)
        {
            DialogResult result = SaveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txt_lokasi.Text = SaveFileDialog1.FileName;
            }
        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {
            if (txt_lokasi.Text == "")
            {
                View.Gagal GGL = new View.Gagal();
                GGL.Show();
            }
            else
            {
                Paragraph prg = new Paragraph();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10);
                PdfWriter write = PdfWriter.GetInstance(doc, new FileStream(txt_lokasi.Text, FileMode.Create));

                doc.Open();

                // Mempersiapkan font untuk judul dan table
                iTextSharp.text.Font fonttitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fonttable = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Membuat judul

                prg.Alignment = Element.ALIGN_CENTER;
                prg.SpacingAfter = 5.0F;
                // Menambahkan paragraph ke pdfdocument
                doc.Add(prg);

                // Membuat table
                PdfPTable pdftbl = new PdfPTable(dgv.Columns.Count);
                // Lebar table
                pdftbl.TotalWidth = 500.0F;
                pdftbl.LockedWidth = true;

                Single[] widths = new Single[dgv.Columns.Count];
                for (int i = 0; i <= dgv.Columns.Count - 1; i++)
                {
                    widths[i] = 1.0F;
                }
                pdftbl.SetWidths(widths);
                // Alignment table 0 = kiri 1 = tengah 2 = kanan
                pdftbl.HorizontalAlignment = 0;
                pdftbl.SpacingBefore = 5.0F;

                // Mendeklarasikan pdfcell
                PdfPCell pdfcell = new PdfPCell();

                // Membuat header table pdf
                for (int i = 0; i <= dgv.Columns.Count - 1; i++)
                {
                    pdfcell = new PdfPCell(new Phrase(new Chunk(dgv.Columns[i].HeaderText, fonttable)));
                    // Alignment header table  
                    pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                    // Menambahkan cell ke pdftable
                    pdftbl.AddCell(pdfcell);
                }

                for (int i = 0; i <= dgv.Rows.Count - 2; i++)
                {
                    for (int j = 0; j <= dgv.Columns.Count - 1; j++)
                    {
                        pdfcell = new PdfPCell(new Phrase(dgv[j, i].Value.ToString(), fonttable));
                        // Alignment data pada table
                        pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                        // Menambah cell ke pdftable    
                        pdftbl.AddCell(pdfcell);
                    }
                }

                // Menambahkan pdftable ke pdfdocument
                doc.Add(pdftbl);

                doc.Close();

                Sukses SK = new Sukses();
                SK.Show();
            }

            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_lokasi_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void TampilDataSiswa()
        {
            tabel = new DataTable();
            tabel = siswaDao.DisplaySiswa();
            dgv.DataSource = tabel;

        }

    }
}

