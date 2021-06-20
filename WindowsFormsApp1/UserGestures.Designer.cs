
namespace WindowsFormsApp1
{
    partial class UserGestures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbHareket = new System.Windows.Forms.GroupBox();
            this.dataGridHareket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnHareket = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.projetsDataSet = new WindowsFormsApp1.ProjetsDataSet();
            this.tblHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHareketlerTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblHareketlerTableAdapter();
            this.grbHareket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHareketlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHareket
            // 
            this.grbHareket.Controls.Add(this.dataGridHareket);
            this.grbHareket.Location = new System.Drawing.Point(29, 66);
            this.grbHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHareket.Name = "grbHareket";
            this.grbHareket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbHareket.Size = new System.Drawing.Size(696, 302);
            this.grbHareket.TabIndex = 3;
            this.grbHareket.TabStop = false;
            this.grbHareket.Text = "groupBox1";
            // 
            // dataGridHareket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dataGridHareket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHareket.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridHareket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridHareket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHareket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHareket.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHareket.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHareket.EnableHeadersVisualStyles = false;
            this.dataGridHareket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dataGridHareket.Location = new System.Drawing.Point(3, 17);
            this.dataGridHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHareket.Name = "dataGridHareket";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHareket.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridHareket.RowHeadersVisible = false;
            this.dataGridHareket.RowHeadersWidth = 51;
            this.dataGridHareket.RowTemplate.Height = 24;
            this.dataGridHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHareket.Size = new System.Drawing.Size(690, 283);
            this.dataGridHareket.TabIndex = 3;
            this.dataGridHareket.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dataGridHareket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dataGridHareket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridHareket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridHareket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridHareket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridHareket.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridHareket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dataGridHareket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dataGridHareket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridHareket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridHareket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridHareket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridHareket.ThemeStyle.HeaderStyle.Height = 27;
            this.dataGridHareket.ThemeStyle.ReadOnly = false;
            this.dataGridHareket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridHareket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridHareket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridHareket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridHareket.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridHareket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataGridHareket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnHareket
            // 
            this.btnHareket.Location = new System.Drawing.Point(249, 373);
            this.btnHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(164, 30);
            this.btnHareket.TabIndex = 4;
            this.btnHareket.Text = "Hareketleri Göster";
            this.btnHareket.UseVisualStyleBackColor = true;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(41, 25);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 36);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(249, 407);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(164, 30);
            this.btnexcel.TabIndex = 6;
            this.btnexcel.Text = "Exel Aktar";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // projetsDataSet
            // 
            this.projetsDataSet.DataSetName = "ProjetsDataSet";
            this.projetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHareketlerBindingSource
            // 
            this.tblHareketlerBindingSource.DataMember = "tblHareketler";
            this.tblHareketlerBindingSource.DataSource = this.projetsDataSet;
            // 
            // tblHareketlerTableAdapter
            // 
            this.tblHareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // UserGestures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.grbHareket);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserGestures";
            this.Text = "UserGestures";
         //   this.Load += new System.EventHandler(this.UserGestures_Load);
            this.grbHareket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHareketlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHareket;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridHareket;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnexcel;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblHareketlerBindingSource;
        private ProjetsDataSetTableAdapters.tblHareketlerTableAdapter tblHareketlerTableAdapter;
    }
}