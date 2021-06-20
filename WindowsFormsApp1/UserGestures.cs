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

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand data = new SqlCommand("select Tarih,UrunAd,UrunMiktar,UrunTutar from tblHareketler where UserId=@userId ", baglanti);
            data.Parameters.AddWithValue("@userId", userId);
            SqlDataAdapter da = new SqlDataAdapter(data);
            System.Data.DataTable ds = new System.Data.DataTable();
            da.Fill(ds);
            guna2DataGridView2.DataSource = ds;
            baglanti.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
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
            for (int i=0; i< guna2DataGridView2.Columns.Count;i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = guna2DataGridView2.Columns[i].HeaderText;
            }
            for (int i = 0; i < guna2DataGridView2.Columns.Count; i++)
            {
                for (int j = 0; j < guna2DataGridView2.Columns.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2,1]=guna2DataGridView2[i,j].Value;
                }
            }

        }

        private void UserGestures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetsDataSet.tblHareketler' table. You can move, or remove it, as needed.
            this.tblHareketlerTableAdapter.Fill(this.projetsDataSet.tblHareketler);

        }
    }
}
