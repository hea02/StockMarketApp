using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using excel= Microsoft.Office.Interop.Excel;


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
            SqlCommand data = new SqlCommand("select Tarih,UrunAd,UrunMiktar,UrunTutar  from tblHareketler where AliciID=@userId or SaticiID=@userId ", baglanti);
            data.Parameters.AddWithValue("@userId", userId);
            SqlDataAdapter da = new SqlDataAdapter(data);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            baglanti.Close();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            //BakiyeVeUrun bakiyeVeUrun = new BakiyeVeUrun();
            //bakiyeVeUrun.Show();
            //this.Hide();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
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
    }
}
