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
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class SaticiEkrani : Form
    {
        int userId;
        SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");

        //  string saticiMoney;
        public SaticiEkrani(int id)
        {
            userId = id;
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int id;
            baglanti.Open();
            SqlCommand command = new SqlCommand(@"insert into tblProduct (ProductName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)", baglanti);
            command.Parameters.AddWithValue("@userID", userId);
            command.Parameters.AddWithValue("@productName", txtAdi.Text);
            command.Parameters.AddWithValue("@productAmount", txtMiktar.Text);
            command.Parameters.AddWithValue("@productPrice", txtFiyat.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Urun sistemde varmı yok mu kontrol edılecektır");
            baglanti.Close();
            txtAdi.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";

            SqlCommand komut = new SqlCommand("select UserID From tblBuying where productName=@productName and ProductAmount=@productAmount and  ProductPrice=@productPrice", baglanti);
            komut.Parameters.AddWithValue("@productName", txtAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToSingle(txtMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToSingle(txtFiyat.Text));

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                id = Convert.ToInt32(dr["UserID"]);
                MessageBox.Show("alıcı id =" + id);
                MessageBox.Show("al sat işlemi yapılabilinir urun bulundu");


            }

            else
            {
                MessageBox.Show("al sat işlemi yapılamaz urun bulunmadı");

            }



        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMoney (Money,UserID) values (@Money, @UserID) ", baglanti);
            komut.Parameters.AddWithValue("@Money", txtBakiye.Text);
            komut.Parameters.AddWithValue("@UserID", userId);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bakiye Ekleme Admin onayına gönderildi onaylandıktan sonra yayınlacaktır!");
            baglanti.Close();
        }     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hareketler Hareketler = new Hareketler(userId);
            Hareketler.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void SaticiEkrani_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolar.Text = dolaralis;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int id;
            baglanti.Open();
            SqlCommand command = new SqlCommand(@"insert into tblBuying (productName,ProductAmount,ProductPrice,UserID) 
            values(@productName,@productAmount,@productPrice,@userID)", baglanti);
            command.Parameters.AddWithValue("@userID", userId);
            command.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
            command.Parameters.AddWithValue("@productAmount", txtUrunMiktar.Text);
            command.Parameters.AddWithValue("@productPrice", txtUrunFiyati.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Urun sistemde varmı yok mu kontrol edılecektır");
            baglanti.Close();
            txtAdi.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            SqlCommand komut = new SqlCommand("select UserID From tblProduct2 where productName=@productName and ProductAmount=@productAmount and  ProductPrice=@productPrice", baglanti);
            komut.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToSingle(txtUrunMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToSingle(txtUrunFiyati.Text));

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                id = Convert.ToInt32(dr["UserID"]);
                MessageBox.Show("satici id =" + id);
                MessageBox.Show("al sat işlemi yapılabilinir urun bulundu");


                // alici bilgi alma işlemleri
                float bakiye;
                int urunId;

                SqlCommand verioku = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                verioku.Parameters.AddWithValue("@userId", userId);
                verioku.ExecuteNonQuery();
                SqlDataReader oku = verioku.ExecuteReader();
/*
                if (oku.Read())
                {
                    bakiye = Convert.ToSingle(oku["MoneyAmount"]);
                    //MessageBox.Show("alıcı bakiye:" + bakiye);
                    oku.Close();
                    if (bakiye < Convert.ToInt32(lblSaticiTutar.Text))
                    {
                        MessageBox.Show("Sahip olsuğunuz bakiye urun tutarından düşük olduğu için işlem gerçekleşmemektedir.\n" +
                            "Sahip olduğunuz bakiye: " + bakiye + "\nAlınmak istenen ürünün tutarı: " + Convert.ToInt32(lblSaticiTutar.Text));
                    }
                    else         // al sat işlemi
                    {

                        SqlCommand komut = new SqlCommand(@"select ProductID from tblProduct2 where UserId= @userId", baglanti);
                        komut.Parameters.AddWithValue("@userId", lblSaticiId.Text);
                        SqlDataReader veriokuma = komut.ExecuteReader();
                        if (veriokuma.Read())
                        {
                            urunId = Convert.ToInt32(veriokuma["ProductID"]);
                            //MessageBox.Show(" satici id:" + Convert.ToInt32(lblSaticiId.Text));
                            // MessageBox.Show("urun id:"+urunId);
                            veriokuma.Close();
                            //alici bakiye düşme 

                            SqlCommand data1 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount - @money where UserID = @userID ", baglanti);
                            data1.Parameters.AddWithValue("@Money", lblSaticiTutar.Text);
                            data1.Parameters.AddWithValue("@UserID", ui);
                            data1.ExecuteNonQuery();


                            //satici bakiye artma 

                            SqlCommand data2 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                            data2.Parameters.AddWithValue("@Money", lblSaticiTutar.Text);
                            data2.Parameters.AddWithValue("@UserID", Convert.ToInt32(lblSaticiId.Text));
                            data2.ExecuteNonQuery();


                            // yeni bakiyeleri cekme

                            SqlCommand veri1 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                            veri1.Parameters.AddWithValue("@userId", Convert.ToInt32(lblSaticiId.Text));
                            veri1.ExecuteNonQuery();
                            SqlDataReader dr = veri1.ExecuteReader();
                            if (dr.Read())
                            {
                                saticiBakiye = Convert.ToInt32(dr["MoneyAmount"]);
                                //  MessageBox.Show("satici bakiye:" + saticiBakiye);
                            }
                            dr.Close();

                            SqlCommand veri2 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                            veri2.Parameters.AddWithValue("@userId", ui);
                            veri2.ExecuteNonQuery();
                            SqlDataReader data = veri2.ExecuteReader();
                            if (data.Read())
                            {
                                aliciBakiye = Convert.ToInt32(data["MoneyAmount"]);
                                // MessageBox.Show("alici bakiye:" + aliciBakiye);
                            }
                            data.Close();

                            // hareketler tablosu 
                            SqlCommand command = new SqlCommand(@"
                            insert into tblHareketler (AliciID,SaticiID,UrunID,AliciBakiye,SaticiBakiye)values(@aliciID,@saticiID,@urunID,@aliciBakiye,@saticiBakiye)", baglanti);
                            command.Parameters.AddWithValue("@aliciID", ui);
                            command.Parameters.AddWithValue("@saticiID", Convert.ToInt32(lblSaticiId.Text));
                            command.Parameters.AddWithValue("@urunID", urunId);
                            command.Parameters.AddWithValue("@aliciBakiye", aliciBakiye);
                            command.Parameters.AddWithValue("@saticiBakiye", saticiBakiye);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Alıcının Bakiyesinden 600 lira saticinin bakiyesine gönderilmiştir.");
                            //MessageBox.Show(
                            //"aliciID:" + ui +
                            //"\nsaticiID:" + Convert.ToInt32(lblSaticiId.Text) +
                            //"\nurunID:" + urunId +
                            //"\naliciBakiye:" + aliciBakiye +
                            //"\nsaticiBakiye:" + saticiBakiye);

                            //// alınan ürünü satılanürün tablosundan silme
                            SqlCommand com = new SqlCommand(@" delete from tblProduct2 where ProductID=@productID", baglanti);
                            com.Parameters.AddWithValue("@productID", urunId);
                            com.ExecuteNonQuery();
                            // tablonun güncel versiyonunu gösterme
                            //       this.tblProduct2TableAdapter.Fill(this.projetsDataSet.tblProduct2);

                        }
                        else
                        {
                            MessageBox.Show("ProductId veri okunamadı");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Hic bir veri okunamadı...");
                }




                */
                baglanti.Close();

            }
          
            else
            {
                MessageBox.Show("al sat işlemi yapılamaz urun bulunmadı");

            }


        }
    }
}
