
namespace WindowsFormsApp1
{
    partial class Hareketler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DataGridHareket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProduct2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetsDataSet = new WindowsFormsApp1.ProjetsDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaticiId = new System.Windows.Forms.Label();
            this.lblSaticiUrunAd = new System.Windows.Forms.Label();
            this.lblSaticiUrunMiktar = new System.Windows.Forms.Label();
            this.lblSaticiFiyat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSaticiTutar = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAl = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tblProduct2TableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblProduct2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(721, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // DataGridHareket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridHareket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridHareket.AutoGenerateColumns = false;
            this.DataGridHareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHareket.BackgroundColor = System.Drawing.Color.White;
            this.DataGridHareket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridHareket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHareket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridHareket.ColumnHeadersHeight = 21;
            this.DataGridHareket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridHareket.DataSource = this.tblProduct2BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridHareket.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridHareket.EnableHeadersVisualStyles = false;
            this.DataGridHareket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridHareket.Location = new System.Drawing.Point(13, 53);
            this.DataGridHareket.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridHareket.Name = "DataGridHareket";
            this.DataGridHareket.RowHeadersVisible = false;
            this.DataGridHareket.RowHeadersWidth = 51;
            this.DataGridHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridHareket.Size = new System.Drawing.Size(499, 313);
            this.DataGridHareket.TabIndex = 1;
            this.DataGridHareket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridHareket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridHareket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridHareket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridHareket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridHareket.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridHareket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridHareket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridHareket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridHareket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridHareket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridHareket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridHareket.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridHareket.ThemeStyle.ReadOnly = false;
            this.DataGridHareket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridHareket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridHareket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridHareket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridHareket.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridHareket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridHareket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridHareket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.DataGridHareket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductAmount";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductAmount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductPrice";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tblProduct2BindingSource
            // 
            this.tblProduct2BindingSource.DataMember = "tblProduct2";
            this.tblProduct2BindingSource.DataSource = this.projetsDataSet;
            // 
            // projetsDataSet
            // 
            this.projetsDataSet.DataSetName = "ProjetsDataSet";
            this.projetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(571, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "FİYAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(565, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "ÜRÜN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(548, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "MİKTAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(561, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "SATICI:";
            // 
            // lblSaticiId
            // 
            this.lblSaticiId.AutoSize = true;
            this.lblSaticiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiId.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaticiId.Location = new System.Drawing.Point(669, 101);
            this.lblSaticiId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaticiId.Name = "lblSaticiId";
            this.lblSaticiId.Size = new System.Drawing.Size(70, 24);
            this.lblSaticiId.TabIndex = 8;
            this.lblSaticiId.Text = "XXXX";
            // 
            // lblSaticiUrunAd
            // 
            this.lblSaticiUrunAd.AutoSize = true;
            this.lblSaticiUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiUrunAd.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaticiUrunAd.Location = new System.Drawing.Point(669, 142);
            this.lblSaticiUrunAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaticiUrunAd.Name = "lblSaticiUrunAd";
            this.lblSaticiUrunAd.Size = new System.Drawing.Size(70, 24);
            this.lblSaticiUrunAd.TabIndex = 9;
            this.lblSaticiUrunAd.Text = "XXXX";
            // 
            // lblSaticiUrunMiktar
            // 
            this.lblSaticiUrunMiktar.AutoSize = true;
            this.lblSaticiUrunMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiUrunMiktar.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaticiUrunMiktar.Location = new System.Drawing.Point(669, 185);
            this.lblSaticiUrunMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaticiUrunMiktar.Name = "lblSaticiUrunMiktar";
            this.lblSaticiUrunMiktar.Size = new System.Drawing.Size(70, 24);
            this.lblSaticiUrunMiktar.TabIndex = 10;
            this.lblSaticiUrunMiktar.Text = "XXXX";
            // 
            // lblSaticiFiyat
            // 
            this.lblSaticiFiyat.AutoSize = true;
            this.lblSaticiFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiFiyat.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaticiFiyat.Location = new System.Drawing.Point(669, 228);
            this.lblSaticiFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaticiFiyat.Name = "lblSaticiFiyat";
            this.lblSaticiFiyat.Size = new System.Drawing.Size(70, 24);
            this.lblSaticiFiyat.TabIndex = 11;
            this.lblSaticiFiyat.Text = "XXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(557, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "TUTAR:";
            // 
            // lblSaticiTutar
            // 
            this.lblSaticiTutar.AutoSize = true;
            this.lblSaticiTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaticiTutar.ForeColor = System.Drawing.Color.Yellow;
            this.lblSaticiTutar.Location = new System.Drawing.Point(669, 265);
            this.lblSaticiTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaticiTutar.Name = "lblSaticiTutar";
            this.lblSaticiTutar.Size = new System.Drawing.Size(70, 24);
            this.lblSaticiTutar.TabIndex = 13;
            this.lblSaticiTutar.Text = "XXXX";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::WindowsFormsApp1.Properties.Resources.geriiiiiii;
            this.guna2Button2.Location = new System.Drawing.Point(1, -1);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(69, 28);
            this.guna2Button2.TabIndex = 34;
            this.guna2Button2.Text = "GERİ";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnAl
            // 
            this.btnAl.Animated = true;
            this.btnAl.AutoRoundedCorners = true;
            this.btnAl.BorderRadius = 21;
            this.btnAl.CheckedState.Parent = this.btnAl;
            this.btnAl.CustomImages.Parent = this.btnAl;
            this.btnAl.DisabledState.Parent = this.btnAl;
            this.btnAl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.ForeColor = System.Drawing.Color.White;
            this.btnAl.HoverState.Parent = this.btnAl;
            this.btnAl.Image = global::WindowsFormsApp1.Properties.Resources.ALIŞ;
            this.btnAl.Location = new System.Drawing.Point(561, 314);
            this.btnAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAl.Name = "btnAl";
            this.btnAl.ShadowDecoration.Parent = this.btnAl;
            this.btnAl.Size = new System.Drawing.Size(203, 44);
            this.btnAl.TabIndex = 7;
            this.btnAl.Text = "SATIN AL";
            this.btnAl.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // tblProduct2TableAdapter
            // 
            this.tblProduct2TableAdapter.ClearBeforeFill = true;
            // 
            // Hareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(781, 384);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lblSaticiTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSaticiFiyat);
            this.Controls.Add(this.lblSaticiUrunMiktar);
            this.Controls.Add(this.lblSaticiUrunAd);
            this.Controls.Add(this.lblSaticiId);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridHareket);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Hareketler";
            this.Text = "Hareketler";
            this.Load += new System.EventHandler(this.Hareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProduct2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataGridHareket;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaticiTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaticiFiyat;
        private System.Windows.Forms.Label lblSaticiUrunMiktar;
        private System.Windows.Forms.Label lblSaticiUrunAd;
        private System.Windows.Forms.Label lblSaticiId;
        private Guna.UI2.WinForms.Guna2Button btnAl;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
      //  private ProjetsDataSetTableAdapters.tblProduct2TableAdapter tblProduct2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblProduct2BindingSource;
        private ProjetsDataSetTableAdapters.tblProduct2TableAdapter tblProduct2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}