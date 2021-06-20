
namespace WindowsFormsApp1
{
    partial class SaticiEkrani
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.UrunEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBakiye = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.bakiyeEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrunMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUrunFiyati = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAlım = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtdolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.BakiyeDonustur = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbldolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // UrunEkle
            // 
            this.UrunEkle.BorderRadius = 10;
            this.UrunEkle.CheckedState.Parent = this.UrunEkle;
            this.UrunEkle.CustomImages.Parent = this.UrunEkle;
            this.UrunEkle.DisabledState.Parent = this.UrunEkle;
            this.UrunEkle.FillColor2 = System.Drawing.Color.Yellow;
            this.UrunEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.UrunEkle.ForeColor = System.Drawing.Color.Black;
            this.UrunEkle.HoverState.Parent = this.UrunEkle;
            this.UrunEkle.Location = new System.Drawing.Point(349, 268);
            this.UrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.ShadowDecoration.Parent = this.UrunEkle;
            this.UrunEkle.Size = new System.Drawing.Size(168, 55);
            this.UrunEkle.TabIndex = 18;
            this.UrunEkle.Text = "ÜRÜNÜ EKLE";
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtAdi.BorderRadius = 6;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.DefaultText = "";
            this.txtAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.DisabledState.Parent = this.txtAdi;
            this.txtAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.FocusedState.Parent = this.txtAdi;
            this.txtAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdi.HoverState.Parent = this.txtAdi;
            this.txtAdi.Location = new System.Drawing.Point(349, 84);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtAdi.PlaceholderText = "         ÜRÜN ADI";
            this.txtAdi.SelectedText = "";
            this.txtAdi.ShadowDecoration.Parent = this.txtAdi;
            this.txtAdi.Size = new System.Drawing.Size(168, 50);
            this.txtAdi.TabIndex = 33;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtFiyat.BorderRadius = 6;
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.DefaultText = "";
            this.txtFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.DisabledState.Parent = this.txtFiyat;
            this.txtFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.FocusedState.Parent = this.txtFiyat;
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.HoverState.Parent = this.txtFiyat;
            this.txtFiyat.Location = new System.Drawing.Point(349, 142);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PasswordChar = '\0';
            this.txtFiyat.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtFiyat.PlaceholderText = "            FİYATI";
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.ShadowDecoration.Parent = this.txtFiyat;
            this.txtFiyat.Size = new System.Drawing.Size(168, 50);
            this.txtFiyat.TabIndex = 34;
            // 
            // txtBakiye
            // 
            this.txtBakiye.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtBakiye.BorderRadius = 20;
            this.txtBakiye.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBakiye.DefaultText = "";
            this.txtBakiye.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBakiye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBakiye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiye.DisabledState.Parent = this.txtBakiye;
            this.txtBakiye.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBakiye.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtBakiye.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiye.FocusedState.Parent = this.txtBakiye;
            this.txtBakiye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBakiye.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBakiye.HoverState.Parent = this.txtBakiye;
            this.txtBakiye.Location = new System.Drawing.Point(580, 199);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.PasswordChar = '\0';
            this.txtBakiye.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtBakiye.PlaceholderText = "              BAKİYE";
            this.txtBakiye.SelectedText = "";
            this.txtBakiye.ShadowDecoration.Parent = this.txtBakiye;
            this.txtBakiye.Size = new System.Drawing.Size(180, 50);
            this.txtBakiye.TabIndex = 36;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(839, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 38;
            // 
            // txtMiktar
            // 
            this.txtMiktar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtMiktar.BorderRadius = 6;
            this.txtMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiktar.DefaultText = "";
            this.txtMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.DisabledState.Parent = this.txtMiktar;
            this.txtMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.FocusedState.Parent = this.txtMiktar;
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.HoverState.Parent = this.txtMiktar;
            this.txtMiktar.Location = new System.Drawing.Point(349, 199);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.PasswordChar = '\0';
            this.txtMiktar.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtMiktar.PlaceholderText = "            MİKTAR";
            this.txtMiktar.SelectedText = "";
            this.txtMiktar.ShadowDecoration.Parent = this.txtMiktar;
            this.txtMiktar.Size = new System.Drawing.Size(168, 50);
            this.txtMiktar.TabIndex = 39;
            // 
            // bakiyeEkle
            // 
            this.bakiyeEkle.CheckedState.Parent = this.bakiyeEkle;
            this.bakiyeEkle.CustomImages.Parent = this.bakiyeEkle;
            this.bakiyeEkle.DisabledState.Parent = this.bakiyeEkle;
            this.bakiyeEkle.FillColor = System.Drawing.Color.Yellow;
            this.bakiyeEkle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.bakiyeEkle.ForeColor = System.Drawing.Color.Black;
            this.bakiyeEkle.HoverState.Parent = this.bakiyeEkle;
            this.bakiyeEkle.Image = global::WindowsFormsApp1.Properties.Resources.BAKİYE;
            this.bakiyeEkle.Location = new System.Drawing.Point(632, 257);
            this.bakiyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.bakiyeEkle.Name = "bakiyeEkle";
            this.bakiyeEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.bakiyeEkle.ShadowDecoration.Parent = this.bakiyeEkle;
            this.bakiyeEkle.Size = new System.Drawing.Size(93, 69);
            this.bakiyeEkle.TabIndex = 37;
            this.bakiyeEkle.Text = "EKLE";
            this.bakiyeEkle.Click += new System.EventHandler(this.bakiyeEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.CheckedState.Parent = this.btnGeri;
            this.btnGeri.CustomImages.Parent = this.btnGeri;
            this.btnGeri.DisabledState.Parent = this.btnGeri;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.HoverState.Parent = this.btnGeri;
            this.btnGeri.Image = global::WindowsFormsApp1.Properties.Resources.geriiiiiii;
            this.btnGeri.Location = new System.Drawing.Point(-1, -1);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.ShadowDecoration.Parent = this.btnGeri;
            this.btnGeri.Size = new System.Drawing.Size(69, 28);
            this.btnGeri.TabIndex = 41;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUrunMiktar.BorderRadius = 6;
            this.txtUrunMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunMiktar.DefaultText = "";
            this.txtUrunMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunMiktar.DisabledState.Parent = this.txtUrunMiktar;
            this.txtUrunMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunMiktar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtUrunMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunMiktar.FocusedState.Parent = this.txtUrunMiktar;
            this.txtUrunMiktar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunMiktar.HoverState.Parent = this.txtUrunMiktar;
            this.txtUrunMiktar.Location = new System.Drawing.Point(99, 199);
            this.txtUrunMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.PasswordChar = '\0';
            this.txtUrunMiktar.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtUrunMiktar.PlaceholderText = "            MİKTAR";
            this.txtUrunMiktar.SelectedText = "";
            this.txtUrunMiktar.ShadowDecoration.Parent = this.txtUrunMiktar;
            this.txtUrunMiktar.Size = new System.Drawing.Size(168, 50);
            this.txtUrunMiktar.TabIndex = 45;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUrunFiyati.BorderRadius = 6;
            this.txtUrunFiyati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunFiyati.DefaultText = "";
            this.txtUrunFiyati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunFiyati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunFiyati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunFiyati.DisabledState.Parent = this.txtUrunFiyati;
            this.txtUrunFiyati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunFiyati.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtUrunFiyati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunFiyati.FocusedState.Parent = this.txtUrunFiyati;
            this.txtUrunFiyati.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunFiyati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunFiyati.HoverState.Parent = this.txtUrunFiyati;
            this.txtUrunFiyati.Location = new System.Drawing.Point(99, 142);
            this.txtUrunFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.PasswordChar = '\0';
            this.txtUrunFiyati.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtUrunFiyati.PlaceholderText = "            FİYATI";
            this.txtUrunFiyati.SelectedText = "";
            this.txtUrunFiyati.ShadowDecoration.Parent = this.txtUrunFiyati;
            this.txtUrunFiyati.Size = new System.Drawing.Size(168, 50);
            this.txtUrunFiyati.TabIndex = 44;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUrunAdi.BorderRadius = 6;
            this.txtUrunAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAdi.DefaultText = "";
            this.txtUrunAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAdi.DisabledState.Parent = this.txtUrunAdi;
            this.txtUrunAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAdi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtUrunAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAdi.FocusedState.Parent = this.txtUrunAdi;
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAdi.HoverState.Parent = this.txtUrunAdi;
            this.txtUrunAdi.Location = new System.Drawing.Point(99, 84);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtUrunAdi.PlaceholderText = "         ÜRÜN ADI";
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.ShadowDecoration.Parent = this.txtUrunAdi;
            this.txtUrunAdi.Size = new System.Drawing.Size(168, 50);
            this.txtUrunAdi.TabIndex = 43;
            // 
            // buttonAlım
            // 
            this.buttonAlım.BorderRadius = 10;
            this.buttonAlım.CheckedState.Parent = this.buttonAlım;
            this.buttonAlım.CustomImages.Parent = this.buttonAlım;
            this.buttonAlım.DisabledState.Parent = this.buttonAlım;
            this.buttonAlım.FillColor2 = System.Drawing.Color.Yellow;
            this.buttonAlım.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAlım.ForeColor = System.Drawing.Color.Black;
            this.buttonAlım.HoverState.Parent = this.buttonAlım;
            this.buttonAlım.Location = new System.Drawing.Point(99, 268);
            this.buttonAlım.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlım.Name = "buttonAlım";
            this.buttonAlım.ShadowDecoration.Parent = this.buttonAlım;
            this.buttonAlım.Size = new System.Drawing.Size(168, 55);
            this.buttonAlım.TabIndex = 42;
            this.buttonAlım.Text = "Alım İsteği";
            this.buttonAlım.Click += new System.EventHandler(this.buttonAlım_Click);
            // 
            // txtdolar
            // 
            this.txtdolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtdolar.BorderRadius = 20;
            this.txtdolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdolar.DefaultText = "";
            this.txtdolar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdolar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdolar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdolar.DisabledState.Parent = this.txtdolar;
            this.txtdolar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdolar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtdolar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdolar.FocusedState.Parent = this.txtdolar;
            this.txtdolar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdolar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdolar.HoverState.Parent = this.txtdolar;
            this.txtdolar.Location = new System.Drawing.Point(580, 84);
            this.txtdolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.PasswordChar = '\0';
            this.txtdolar.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.txtdolar.PlaceholderText = "         $ DÖNÜŞTÜR";
            this.txtdolar.SelectedText = "";
            this.txtdolar.ShadowDecoration.Parent = this.txtdolar;
            this.txtdolar.Size = new System.Drawing.Size(180, 50);
            this.txtdolar.TabIndex = 46;
            // 
            // BakiyeDonustur
            // 
            this.BakiyeDonustur.BorderRadius = 10;
            this.BakiyeDonustur.CheckedState.Parent = this.BakiyeDonustur;
            this.BakiyeDonustur.CustomImages.Parent = this.BakiyeDonustur;
            this.BakiyeDonustur.DisabledState.Parent = this.BakiyeDonustur;
            this.BakiyeDonustur.FillColor2 = System.Drawing.Color.Yellow;
            this.BakiyeDonustur.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.BakiyeDonustur.ForeColor = System.Drawing.Color.Black;
            this.BakiyeDonustur.HoverState.Parent = this.BakiyeDonustur;
            this.BakiyeDonustur.Location = new System.Drawing.Point(588, 142);
            this.BakiyeDonustur.Margin = new System.Windows.Forms.Padding(4);
            this.BakiyeDonustur.Name = "BakiyeDonustur";
            this.BakiyeDonustur.ShadowDecoration.Parent = this.BakiyeDonustur;
            this.BakiyeDonustur.Size = new System.Drawing.Size(172, 36);
            this.BakiyeDonustur.TabIndex = 47;
            this.BakiyeDonustur.Text = "DÖNÜŞTÜR";
            this.BakiyeDonustur.Click += new System.EventHandler(this.BakiyeDonustur_Click);
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldolar.Location = new System.Drawing.Point(667, 39);
            this.lbldolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(73, 29);
            this.lbldolar.TabIndex = 48;
            this.lbldolar.Text = "oooo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(577, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "$ Alış:";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::WindowsFormsApp1.Properties.Resources.ürün;
            this.guna2Button3.Location = new System.Drawing.Point(734, 460);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(148, 32);
            this.guna2Button3.TabIndex = 50;
            this.guna2Button3.Text = "HAREKETLERİM";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // SaticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(895, 505);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.BakiyeDonustur);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.txtUrunMiktar);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.buttonAlım);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.bakiyeEkle);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.UrunEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SaticiEkrani";
            this.Text = "SaticiEkrani";
            this.Load += new System.EventHandler(this.SaticiEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton UrunEkle;
        private Guna.UI2.WinForms.Guna2TextBox txtFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtBakiye;
        private Guna.UI2.WinForms.Guna2CircleButton bakiyeEkle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMiktar;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunMiktar;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunFiyati;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAdi;
        private Guna.UI2.WinForms.Guna2GradientButton buttonAlım;
        private Guna.UI2.WinForms.Guna2GradientButton BakiyeDonustur;
        private Guna.UI2.WinForms.Guna2TextBox txtdolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldolar;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}