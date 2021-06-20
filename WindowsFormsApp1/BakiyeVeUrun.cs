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
        float gnclAliciBakiye = 0, gnclSaticiBakiye = 0, aliciBakiye;
        int saticiId;
        private void UrunEkle_Click(object sender, EventArgs e)
        {

            int urunId,aliciId;
            float urunTutar, saticiBakiye;

            baglanti.Open();
        
            MessageBox.Show("Urun sistemde alan var mı yok mu kontrol edılecektır");
            //alıcı id donucek
            SqlCommand komut = new SqlCommand("select UserID , ProductAmount* ProductPrice as UrunTutar From tblProduct2 where productName=@productName and ProductAmount=@productAmount and  ProductPrice=@productPrice", baglanti);
            komut.Parameters.AddWithValue("@productName", txtAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToSingle(txtMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToSingle(txtFiyat.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                aliciId = Convert.ToInt32(dr["UserID"]);
                MessageBox.Show("alici id =" + aliciId);
                MessageBox.Show("al sat işlemi yapılabilinir urun bulundu");
                urunTutar = Convert.ToSingle(dr["UrunTutar"]);
                dr.Close();
                // alici bilgi alma işlemleri


                //alici bakıye alma
                SqlCommand veri = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                veri.Parameters.AddWithValue("@userId", aliciId);
                veri.ExecuteNonQuery();
                SqlDataReader dataReader = veri.ExecuteReader();
                if (dataReader.Read())
                {
                    aliciBakiye = Convert.ToSingle(dataReader["MoneyAmount"]);
                    MessageBox.Show("alici bakiye =" + aliciBakiye);
                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show(" bakiye okunamadı");
                }
                //satici bakıye alma
                SqlCommand verioku = new SqlCommand(@"select MoneyAmount from tblAdminMoney2 where UserId= @userId", baglanti);
                verioku.Parameters.AddWithValue("@userId", userId);
                verioku.ExecuteNonQuery();
                SqlDataReader oku = verioku.ExecuteReader();

                if (oku.Read())
                {
                    saticiBakiye = Convert.ToSingle(oku["MoneyAmount"]);
                    MessageBox.Show("satici bakiye =" + saticiBakiye);

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

                        SqlCommand komut2 = new SqlCommand(@"select ProductID from tblProduct2 where UserID= @aliciId", baglanti);
                        komut2.Parameters.AddWithValue("@aliciId", aliciId);
                        SqlDataReader veriokuma = komut2.ExecuteReader();

                        if (veriokuma.Read())
                        {

                            urunId = Convert.ToInt32(veriokuma["ProductID"]);
                            MessageBox.Show(" satici id:" + userId);
                            MessageBox.Show("alici id =" + aliciId);
                            MessageBox.Show("urun id:" + urunId);
                            veriokuma.Close();
                            MessageBox.Show(" Para transferi gercekleşiyor...");

                            //alici bakiye düşme 
                            SqlCommand data1 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount - @money where UserID = @userID ", baglanti);
                            data1.Parameters.AddWithValue("@Money", urunTutar);
                            data1.Parameters.AddWithValue("@UserID", aliciId);
                            data1.ExecuteNonQuery();

                            //satici bakiye artma 
                            SqlCommand data2 = new SqlCommand(@"update tblAdminMoney2 set MoneyAmount = MoneyAmount + @money where UserID = @userID ", baglanti);
                            data2.Parameters.AddWithValue("@Money", urunTutar);
                            data2.Parameters.AddWithValue("@UserID", userId);
                            data2.ExecuteNonQuery();

                            veriokuma.Close();

                            // güncel alici bakiye 


                            SqlCommand data3 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2  where UserID = @userID ", baglanti);
                            data3.Parameters.AddWithValue("@UserID", aliciId);
                            data3.ExecuteNonQuery();
                            SqlDataReader data3oku = data3.ExecuteReader();

                            if (data3oku.Read())
                            {
                                gnclAliciBakiye = Convert.ToSingle(data3oku["MoneyAmount"]);
                                MessageBox.Show(" güncel alici bakiye =" + gnclAliciBakiye);
                                data3oku.Close();
                            }
                            MessageBox.Show("alici id" + aliciId);
                            //güncel satici bakiye 
                            SqlCommand data4 = new SqlCommand(@"select MoneyAmount from tblAdminMoney2  where UserID = @userID ", baglanti);
                            data4.Parameters.AddWithValue("@UserID", userId);
                            data4.ExecuteNonQuery();
                            SqlDataReader data4oku = data4.ExecuteReader();

                            if (data4oku.Read())
                            {
                                gnclSaticiBakiye = Convert.ToSingle(data4oku["MoneyAmount"]);
                                MessageBox.Show(" güncel satici bakiye =" + gnclSaticiBakiye);
                                data4oku.Close();

                            }

                            // 1% kasaya atıyoruz update tblSafe set Safe= Safe+0.1
                            SqlCommand data5 = new SqlCommand("addSafe ", baglanti);
                            data5.CommandType=CommandType.StoredProcedure;
                            data5.Parameters.Add("@safe",SqlDbType.Float);
                            data5.Parameters["@safe"].Value = urunTutar / 100;
                            data5.ExecuteNonQuery();
                            MessageBox.Show("kasaya düşen 1% lik tutar = " + urunTutar / 100);

                            // tarih hesaplama
                            DateTime tarih;
                            tarih = DateTime.Now.Date;
                            tarih.ToString().TrimEnd('0', ':');


                            SqlCommand command2 = new SqlCommand(@"
                            insert into tblHareketler (AliciID,SaticiID,UrunID,AliciBakiye,SaticiBakiye,Tarih,UrunAd,UrunMiktar,UrunTutar,UserId)
                            values(@aliciID,@saticiID,@urunID,@aliciBakiye,@saticiBakiye,@tarih,@urunAd,@urunMiktar,@urunTutar,@userId)", baglanti);
                            command2.Parameters.AddWithValue("@aliciID", aliciId);
                            command2.Parameters.AddWithValue("@saticiID", userId);
                            command2.Parameters.AddWithValue("@urunID", urunId);
                            command2.Parameters.AddWithValue("@aliciBakiye", gnclAliciBakiye);
                            command2.Parameters.AddWithValue("@saticiBakiye", gnclSaticiBakiye);
                            command2.Parameters.AddWithValue("@tarih", tarih);
                            command2.Parameters.AddWithValue("@urunAd", txtAdi.Text);
                            command2.Parameters.AddWithValue("@urunMiktar", Convert.ToSingle(txtMiktar.Text));
                            command2.Parameters.AddWithValue("@urunTutar", urunTutar);
                            command2.Parameters.AddWithValue("@userId", userId);


                            command2.ExecuteNonQuery();
                            MessageBox.Show("Alıcının Bakiyesinden" + urunTutar + " lira saticinin bakiyesine gönderilmiştir.");
                            MessageBox.Show(
                            "aliciID:" + aliciId +
                            "\nsaticiID:" + userId +
                            "\nurunID:" + urunId +
                            "\naliciBakiye:" + gnclAliciBakiye +
                            "\nsaticiBakiye:" + gnclSaticiBakiye);

                            //// alınan ürünü satılanürün tablosundan silme
                            //SqlCommand com = new SqlCommand(@" delete from tblProduct2 where ProductID=@productID", baglanti);
                            //com.Parameters.AddWithValue("@productID", urunId);
                            //com.ExecuteNonQuery();
                            // tablonun güncel versiyonunu gösterme yapılcak


                        }
                        else
                        {
                            veriokuma.Close();
                            MessageBox.Show("ProductId verisi okunamadı");
                        }
                    }

                }
                else
                {
                    oku.Read();
                    MessageBox.Show("alıcı bakiye verisi okunamadı");
                }

            }
            else
            {
                dr.Close();
                MessageBox.Show("al sat işlemi yapılamaz. Cünkü bu urunu alan kimse yok");
                // yok ise satan yanı tblproduct2  tablosuna ekleme
                SqlCommand command3 = new SqlCommand(@"insert into  tblBuying ( ReceiverID,ProductName,ProductAmount,ProductPrice) 
                values(@receiverID,@productName,@productAmount,@productPrice)", baglanti);
                command3.Parameters.AddWithValue("@receiverID", userId);
                command3.Parameters.AddWithValue("@productName", txtAdi.Text);
                command3.Parameters.AddWithValue("@productAmount", txtMiktar.Text);
                command3.Parameters.AddWithValue("@productPrice", txtFiyat.Text);
                command3.ExecuteNonQuery();
            }


            baglanti.Close();



        }
        private void bakiyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AdminMoney (Money,UserID) values (@Money, @UserID) ", baglanti);
            komut.Parameters.AddWithValue("@Money", txtBakiye.Text);
            komut.Parameters.AddWithValue("@UserID", userId);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bakiye Ekleme Admin onayına gönderildi onaylandıktan sonra yayınlacaktır!");
            baglanti.Close();
        }     

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }


        private void SaticiEkrani_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolar.Text = dolaralis;
        }
        float guncelAliciBakiye=0, guncelSaticiBakiye=0;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserGestures userGestures = new UserGestures(userId);
            userGestures.Show();
            this.Hide();
        }

        private void buttonAlım_Click(object sender, EventArgs e)
        {
            int  urunId,saticiId;
            float urunTutar, aliciBakiye;
             float saticiBakiye,stcBakiye;
           
            baglanti.Open();
           
            MessageBox.Show("Urun sistemde varmı yok mu kontrol edılecektır");
 
            SqlCommand komut = new SqlCommand("select ReceiverID , ProductAmount* ProductPrice as UrunTutar From tblBuying where ProductName=@productName and ProductAmount=@productAmount and  ProductPrice=@productPrice", baglanti);
            komut.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@productAmount", Convert.ToSingle(txtUrunMiktar.Text));
            komut.Parameters.AddWithValue("@productPrice", Convert.ToSingle(txtUrunFiyati.Text));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                saticiId = Convert.ToInt32(dr["ReceiverID"]);
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
                       
                            SqlCommand komut2 = new SqlCommand(@"select BuyID from tblBuying where ReceiverID= @receiverID", baglanti);
                            komut2.Parameters.AddWithValue("@receiverID", saticiId);
                            SqlDataReader veriokuma = komut2.ExecuteReader();

                            if (veriokuma.Read())
                            {

                            urunId = Convert.ToInt32(veriokuma["BuyID"]);
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
                                MessageBox.Show(" güncel alici bakiye =" + guncelAliciBakiye);
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
                            // 1% kasaya atıyoruz update tblSafe set Safe= Safe+0.1
                            SqlCommand data5 = new SqlCommand("addSafe ", baglanti);
                            data5.CommandType = CommandType.StoredProcedure;
                            data5.Parameters.Add("@safe", SqlDbType.Float);
                            data5.Parameters["@safe"].Value = urunTutar / 100;
                            data5.ExecuteNonQuery();
                            MessageBox.Show("kasaya düşen 1% lik tutar = " + urunTutar / 100);

                            // tarih hesaplama
                            DateTime tarih;
                            tarih = DateTime.Now.Date;
                            tarih.ToString().TrimEnd('0', ':');



                            SqlCommand command2 = new SqlCommand(@"
                            insert into tblHareketler (AliciID,SaticiID,UrunID,AliciBakiye,SaticiBakiye,Tarih,UrunAd,UrunMiktar,UrunTutar,UserId)
                            values(@aliciID,@saticiID,@urunID,@aliciBakiye,@saticiBakiye,@tarih,@urunAd,@urunMiktar,@urunTutar,@userId)", baglanti);
                            command2.Parameters.AddWithValue("@aliciID", userId);
                            command2.Parameters.AddWithValue("@saticiID", saticiId);
                            command2.Parameters.AddWithValue("@urunID", urunId);
                            command2.Parameters.AddWithValue("@aliciBakiye", guncelAliciBakiye);
                            command2.Parameters.AddWithValue("@saticiBakiye", guncelSaticiBakiye);
                            command2.Parameters.AddWithValue("@tarih", tarih);
                            command2.Parameters.AddWithValue("@urunAd", txtUrunAdi.Text);
                            command2.Parameters.AddWithValue("@urunMiktar", Convert.ToSingle(txtUrunMiktar.Text));
                            command2.Parameters.AddWithValue("@urunTutar", urunTutar);
                            command2.Parameters.AddWithValue("@userId", userId);


                            command2.ExecuteNonQuery();
                                MessageBox.Show("Alıcının Bakiyesinden"+urunTutar+" lira saticinin bakiyesine gönderilmiştir.");
                            MessageBox.Show(
                            "aliciID:" + userId +
                            "\nsaticiID:" + saticiId +
                            "\nurunID:" + urunId +
                            "\naliciBakiye:" + guncelAliciBakiye +
                            "\nsaticiBakiye:" + guncelSaticiBakiye);

                            //alınan ürünü satılanürün tablosundan silme
                            //SqlCommand com = new SqlCommand(@" delete from tblProduct2 where ProductID=@productID", baglanti);
                            //com.Parameters.AddWithValue("@productID", urunId);
                            //com.ExecuteNonQuery();
                            // tablonun güncel versiyonunu gösterme yapılcak

                            
                            }
                            else
                            {
                            veriokuma.Close();
                            MessageBox.Show("ProductId verisi okunamadı");
                            }
                    }

                }
                else
                {
                    oku.Close();
                    MessageBox.Show("alıcı bakiye verisi okunamadı");
                }

            }
            else
            {
                dr.Close();
                MessageBox.Show("al sat işlemi yapılamaz urun bulunmadı.Urunuzun beklemede");
                // bekleme tblbuying tablosonua ekleme fonksiyonlar 
                SqlCommand command3 = new SqlCommand(@"insert into tblProduct2 (UserID,ProductName,ProductAmount,ProductPrice) 
                values(@userID,@productName,@productAmount,@productPrice)", baglanti);
                command3.Parameters.AddWithValue("@userID", userId);
                command3.Parameters.AddWithValue("@productName", txtUrunAdi.Text);
                command3.Parameters.AddWithValue("@productAmount", txtUrunMiktar.Text);
                command3.Parameters.AddWithValue("@productPrice", txtUrunFiyati.Text);
                command3.ExecuteNonQuery();
            }


            baglanti.Close();


        }

        private void BakiyeDonustur_Click(object sender, EventArgs e)
        {


            int dlr;
            dlr = Convert.ToInt32(txtdolar.Text);
            int miktar;
            miktar = Convert.ToInt32(txtdolar.Text);
            int tutar;
            tutar = dlr * miktar;
            txtBakiye.Text = Convert.ToString(tutar);
        }
    }
}
