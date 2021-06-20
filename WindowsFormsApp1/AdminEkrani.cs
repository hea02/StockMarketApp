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

namespace WindowsFormsApp1
{
    public partial class AdminEkrani : Form
    {
        int userId;
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
        public AdminEkrani()
        {
            
            InitializeComponent();

            
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetsDataSet.tblSafe' table. You can move, or remove it, as needed.
            this.tblSafeTableAdapter.Fill(this.projetsDataSet.tblSafe);
            // TODO: This line of code loads data into the 'projetsDataSet.AdminMoney' table. You can move, or remove it, as needed.
            this.adminMoneyTableAdapter.Fill(this.projetsDataSet.AdminMoney);
            // TODO: This line of code loads data into the 'projetsDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.projetsDataSet.tblProduct);
            

        }

      
        private void dataGridUrunOnay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridbakiye.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridbakiye.CurrentRow.Selected = true;
                lblua.Text = dataGridbakiye.Rows[e.RowIndex].Cells["User"].FormattedValue.ToString();
                lblup.Text = dataGridbakiye.Rows[e.RowIndex].Cells["Money"].FormattedValue.ToString();  
            }
            
        }

        private void buttonAlım_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UserID From tblAdminMoney2 where UserID=@userID", baglanti);
            komut.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                // update
                dr.Close();
                SqlCommand komut3 = new SqlCommand(@"
                update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                komut3.Parameters.AddWithValue("@Money", lblup.Text);
                komut3.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
                komut3.ExecuteNonQuery();
                MessageBox.Show("Onay İşlemi Gerçekleşti.");

            }

            else
            {
                // insert
                dr.Close();
                SqlCommand komut2 = new SqlCommand(@"
                insert into tblAdminMoney2 (MoneyAmount,UserID) 
                values(@moneyAmount,@userID)", baglanti);
                komut2.Parameters.AddWithValue("@moneyAmount", Convert.ToSingle(lblup.Text));
                komut2.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
                komut2.ExecuteNonQuery();
                MessageBox.Show("Onay İşlemi Gerçekleşti.");

            }
            SqlCommand command = new SqlCommand(@"delete from AdminMoney where UserID=@userID", baglanti);
            command.Parameters.AddWithValue("@userID", Convert.ToInt32(lblua.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Bekleme listesinden silinip onaylanmıstır.");

            //  this.adminMoneyTableAdapter.Fill(this.projetsDataSet.AdminMoney);
            baglanti.Close();
        }
    }
}
