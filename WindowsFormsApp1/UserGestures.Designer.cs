
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbHareket = new System.Windows.Forms.GroupBox();
            this.dataGridHareket = new Guna.UI2.WinForms.Guna2DataGridView();
            this.projetsDataSet = new WindowsFormsApp1.ProjetsDataSet();
            this.tblHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHareketlerTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblHareketlerTableAdapter();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnHareket = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnexcel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGeri = new Guna.UI2.WinForms.Guna2Button();
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
            this.grbHareket.Size = new System.Drawing.Size(777, 302);
            this.grbHareket.TabIndex = 3;
            this.grbHareket.TabStop = false;
            // 
            // dataGridHareket
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dataGridHareket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridHareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHareket.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridHareket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridHareket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridHareket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHareket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridHareket.ColumnHeadersHeight = 27;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHareket.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHareket.EnableHeadersVisualStyles = false;
            this.dataGridHareket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dataGridHareket.Location = new System.Drawing.Point(3, 17);
            this.dataGridHareket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHareket.Name = "dataGridHareket";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHareket.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridHareket.RowHeadersVisible = false;
            this.dataGridHareket.RowHeadersWidth = 51;
            this.dataGridHareket.RowTemplate.Height = 24;
            this.dataGridHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHareket.Size = new System.Drawing.Size(771, 283);
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
            // btnHareket
            // 
            this.btnHareket.BorderRadius = 10;
            this.btnHareket.CheckedState.Parent = this.btnHareket;
            this.btnHareket.CustomImages.Parent = this.btnHareket;
            this.btnHareket.DisabledState.Parent = this.btnHareket;
            this.btnHareket.FillColor2 = System.Drawing.Color.Yellow;
            this.btnHareket.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.btnHareket.ForeColor = System.Drawing.Color.Black;
            this.btnHareket.HoverState.Parent = this.btnHareket;
            this.btnHareket.Location = new System.Drawing.Point(277, 393);
            this.btnHareket.Margin = new System.Windows.Forms.Padding(4);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.ShadowDecoration.Parent = this.btnHareket;
            this.btnHareket.Size = new System.Drawing.Size(291, 29);
            this.btnHareket.TabIndex = 43;
            this.btnHareket.Text = "Hareketleri Göster";
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click_1);
            // 
            // btnexcel
            // 
            this.btnexcel.BorderRadius = 10;
            this.btnexcel.CheckedState.Parent = this.btnexcel;
            this.btnexcel.CustomImages.Parent = this.btnexcel;
            this.btnexcel.DisabledState.Parent = this.btnexcel;
            this.btnexcel.FillColor2 = System.Drawing.Color.Yellow;
            this.btnexcel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.btnexcel.ForeColor = System.Drawing.Color.Black;
            this.btnexcel.HoverState.Parent = this.btnexcel;
            this.btnexcel.Location = new System.Drawing.Point(277, 430);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.ShadowDecoration.Parent = this.btnexcel;
            this.btnexcel.Size = new System.Drawing.Size(291, 29);
            this.btnexcel.TabIndex = 44;
            this.btnexcel.Text = "Exel Aktar";
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click_1);
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
            this.btnGeri.Location = new System.Drawing.Point(32, 13);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.ShadowDecoration.Parent = this.btnGeri;
            this.btnGeri.Size = new System.Drawing.Size(69, 28);
            this.btnGeri.TabIndex = 45;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click_1);
            // 
            // UserGestures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.grbHareket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserGestures";
            this.Text = "UserGestures";
            this.grbHareket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHareketlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHareket;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridHareket;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblHareketlerBindingSource;
        private ProjetsDataSetTableAdapters.tblHareketlerTableAdapter tblHareketlerTableAdapter;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnHareket;
        private Guna.UI2.WinForms.Guna2GradientButton btnexcel;
        private Guna.UI2.WinForms.Guna2Button btnGeri;
    }
}