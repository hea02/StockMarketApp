using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace WindowsFormsApp1
{
    public partial class UserGestures : Form
    {
        int userId;
        public UserGestures( int id)
        {
            userId = id;
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");

        private void btnHareket_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand data = new SqlCommand("select Tarih,UrunAd,UrunMiktar,UrunTutar from tblHareketler where UserId=@userId ", baglanti);
            data.Parameters.AddWithValue("@userId", userId);
            SqlDataAdapter da = new SqlDataAdapter(data);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            dataGridHareket.DataSource = ds;
            baglanti.Close();
           

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SaticiEkrani bakiyeVeUrun = new SaticiEkrani(userId);
            bakiyeVeUrun.Show();
            this.Hide();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridHareket.Columns.Count; i++)
            {
                Range myRange = (Range)sayfa.Cells[i + 1][1];
                myRange.Value2 = dataGridHareket.Columns[i].HeaderText;

            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < dataGridHareket.Rows.Count-3; j++)
                {
                    Range myRange = (Range)sayfa.Cells[i + 1][j + 2]; // satır colon
                    myRange.Value2 = dataGridHareket[i, j].Value.ToString(); //colon ve satır
                    //MessageBox.Show("deger" + myRange);
                }
            }
            for (int i = 0; i < dataGridHareket.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridHareket.Rows.Count; j++)
                {
                    Range myRange = (Range)sayfa.Cells[i +1][j +2 ]; // satır colon
                    myRange.Value2 = dataGridHareket[i, j].Value; //colon ve satır
                    //MessageBox.Show("deger" + myRange);
                }
            }

        }

    }
}

