﻿using System;
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
    public partial class Giris : Form
    {
        
        public Giris()
        {
            InitializeComponent();
        }
       SqlConnection baglanti = new SqlConnection(@"Data Source=desktop-6LL8GP9;Initial Catalog=Projets;Integrated Security=True");
       
        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            UserAdmin userAdmin = new UserAdmin();

            int id;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UserID From tblUsers where UserLogin_Name=@Username AND Password=@Password", baglanti);
            komut.Parameters.AddWithValue("@Username", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@Password", txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                id = Convert.ToInt32(dr["UserID"]);
                SaticiEkrani saticiEkrani = new SaticiEkrani(id);
                saticiEkrani.Show();
                this.Hide();



            }
            else if (txtsifre.Text == "admin" && txtKullaniciAd.Text == "admin")
            {
                AdminEkrani adminEkrani = new AdminEkrani();
                adminEkrani.Show();
                this.Hide();
            }
           
            else
            {
                MessageBox.Show("yanlıs sıfre veya kulanıcı adı");

            }
            baglanti.Close();

        }

      

        private void btnKayıt_Click_1(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
            this.Hide();
        }
    }
}
