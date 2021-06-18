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


        private void SaticiEkrani_Load(object sender, EventArgs e)
        {
            //string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            //var xmldosya = new XmlDocument();
            //xmldosya.Load(bugun);

            //string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            //lbldolar.Text = dolaralis;
        }
        float guncelAliciBakiye=0, guncelSaticiBakiye=0;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            int  urunId,saticiId;
            float urunTutar, aliciBakiye;
             float saticiBakiye,stcBakiye;
           
            baglanti.Open();
            SqlCommand command = new SqlCommand(@"insert into tblBuying (productName,ProductAmount,ProductPrice) 
            values(@productName,@productAmount,@productPrice)", baglanti);
            //command.Parameters.AddWithValue("@userID", userId);
            command.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
            command.Parameters.AddWithValue("@productAmount", txtUrunMiktar.Text);
            command.Parameters.AddWithValue("@productPrice", txtUrunFiyati.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Urun sistemde varmı yok mu kontrol edılecektır");
 
            SqlCommand komut = new SqlCommand("select UserID , ProductAmount* ProductPrice as UrunTutar From tblProduct2 where productName=@productName and ProductAmount=@productAmount and  ProductPrice=@productPrice", baglanti);
            komut.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToSingle(txtUrunMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToSingle(txtUrunFiyati.Text));
            SqlDataReader dr = komut.ExecuteReader();
            //txtAdi.Text = "";
            //txtMiktar.Text = "";
            //txtFiyat.Text = "";
            if (dr.Read())
            {

                saticiId = Convert.ToInt32(dr["UserID"]);
                MessageBox.Show("satici id =" + saticiId);
                MessageBox.Show("al sat işlemi yapılabilinir urun bulundu");
                urunTutar = Convert.ToSingle(dr["UrunTutar"]);
                dr.Close();
                // alici bilgi alma işlemleri
                
               
                //satıcı bakıye alma
                SqlCommand veri = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                veri.Parameters.AddWithValue("@userId", saticiId);
                veri.ExecuteNonQuery();
                SqlDataReader dataReader = veri.ExecuteReader();
                if (dataReader.Read())
                {
                    saticiBakiye = Convert.ToSingle(dataReader["MoneyAmount"]);
                    MessageBox.Show("satici bakiye =" + saticiBakiye);
                    stcBakiye = saticiBakiye;
                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show("satici bakiye okunamadı");
                }
                //alıcı bakıye alma
                SqlCommand verioku = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                verioku.Parameters.AddWithValue("@userId", userId);
                verioku.ExecuteNonQuery();
                SqlDataReader oku = verioku.ExecuteReader();

                if (oku.Read())
                {
                    aliciBakiye = Convert.ToSingle(oku["MoneyAmount"]);
                    MessageBox.Show("alici bakiye =" + aliciBakiye);
                    
                    //MessageBox.Show("alıcı bakiye:" + bakiye);
                    MessageBox.Show("urun tutar  =" + urunTutar);
                    oku.Close();
                    

                    if (aliciBakiye < urunTutar)
                    {
                        MessageBox.Show("Sahip olsuğunuz bakiye urun tutarından düşük olduğu için işlem gerçekleşmemektedir.\n" +
                            "Sahip olduğunuz bakiye: " + aliciBakiye + "\nAlınmak istenen ürünün tutarı: " + urunTutar);
                    }
                    else
                    {
                       
                            SqlCommand komut2 = new SqlCommand(@"select ProductID from tblProduct2 where UserId= @userId", baglanti);
                            komut2.Parameters.AddWithValue("@userId", saticiId);
                            SqlDataReader veriokuma = komut2.ExecuteReader();

                            if (veriokuma.Read())
                            {

                            urunId = Convert.ToInt32(veriokuma["ProductID"]);
                                MessageBox.Show(" satici id:" + saticiId);
                                MessageBox.Show("alici id =" + userId);
                               MessageBox.Show("urun id:"+urunId);
                                veriokuma.Close();
                            MessageBox.Show(" Para transferi gercekleşiyor..." );
                           
                            //alici bakiye düşme 
                            SqlCommand data1 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount - @money where UserID = @userID ", baglanti);
                            data1.Parameters.AddWithValue("@Money", urunTutar);
                            data1.Parameters.AddWithValue("@UserID", userId);
                            data1.ExecuteNonQuery();

                            //satici bakiye artma 
                            SqlCommand data2 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                            data2.Parameters.AddWithValue("@Money", urunTutar);
                            data2.Parameters.AddWithValue("@UserID", saticiId);
                            data2.ExecuteNonQuery();

                            veriokuma.Close();

                            // güncel alici bakiye 
                           

                            SqlCommand data3 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2  where UserID = @userID ", baglanti);
                            
                            data3.Parameters.AddWithValue("@UserID", userId);
                            data3.ExecuteNonQuery();
                            SqlDataReader data3oku = data3.ExecuteReader();
                            if (data3oku.Read())
                            {
                                guncelAliciBakiye = Convert.ToSingle(data3oku["MoneyAmount"]);
                                MessageBox.Show(" güncel satici bakiye =" + guncelAliciBakiye);
                                data3oku.Close();
                            }
                            MessageBox.Show("satici id" + saticiId);
                            //güncel satici bakiye 
                            SqlCommand data4 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2  where UserID = @userID ", baglanti);
                     
                            data4.Parameters.AddWithValue("@UserID", saticiId);
                            data4.ExecuteNonQuery();
                            SqlDataReader data4oku = data4.ExecuteReader();
                            if (data4oku.Read())
                            {
                                guncelSaticiBakiye = Convert.ToSingle(data4oku["MoneyAmount"]);
                                MessageBox.Show(" güncel satici bakiye =" + guncelSaticiBakiye);
                                data4oku.Close();

                            }

                            SqlCommand command2 = new SqlCommand(@"
                            insert into tblHareketler (AliciID,SaticiID,UrunID,AliciBakiye,SaticiBakiye)values(@aliciID,@saticiID,@urunID,@aliciBakiye,@saticiBakiye)", baglanti);
                                command2.Parameters.AddWithValue("@aliciID", userId);
                                command2.Parameters.AddWithValue("@saticiID", saticiId);
                                command2.Parameters.AddWithValue("@urunID", urunId);
                                command2.Parameters.AddWithValue("@aliciBakiye", guncelAliciBakiye);
                                command2.Parameters.AddWithValue("@saticiBakiye", guncelSaticiBakiye);
                                command2.ExecuteNonQuery();
                                MessageBox.Show("Alıcının Bakiyesinden"+urunTutar+" lira saticinin bakiyesine gönderilmiştir.");
                            MessageBox.Show(
                            "aliciID:" + userId +
                            "\nsaticiID:" + saticiId +
                            "\nurunID:" + urunId +
                            "\naliciBakiye:" + guncelAliciBakiye +
                            "\nsaticiBakiye:" + guncelSaticiBakiye);

                            //// alınan ürünü satılanürün tablosundan silme
                            //SqlCommand com = new SqlCommand(@" delete from tblProduct2 where ProductID=@productID", baglanti);
                            //com.Parameters.AddWithValue("@productID", urunId);
                            //com.ExecuteNonQuery();
                            // tablonun güncel versiyonunu gösterme yapılcak

                            
                        }
                            else
                            {
                                MessageBox.Show("ProductId verisi okunamadı");
                            }
                    }

                }
                else
                {
                    MessageBox.Show("alıcı bakiye verisi okunamadı");
                }

            }
            else
            {
                MessageBox.Show("al sat işlemi yapılamaz urun bulunmadı");

            }


            baglanti.Close();


        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            int dlr;
            dlr = Convert.ToInt32(lbldolar.Text);
            int miktar;
            miktar = Convert.ToInt32(txtdolar.Text);
            int tutar;
            tutar = dlr * miktar;
            txtBakiye.Text = Convert.ToString(tutar);
        }
    }
}
