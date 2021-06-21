
namespace WindowsFormsApp1
{
    partial class AdminEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridbakiye = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetsDataSet = new WindowsFormsApp1.ProjetsDataSet();
            this.lblua = new System.Windows.Forms.Label();
            this.lblup = new System.Windows.Forms.Label();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dataGridsafe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.safeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tblProductTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblProductTableAdapter();
            this.adminMoneyTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.AdminMoneyTableAdapter();
            this.tblSafeTableAdapter = new WindowsFormsApp1.ProjetsDataSetTableAdapters.tblSafeTableAdapter();
            this.buttonAlım = new Guna.UI2.WinForms.Guna2GradientButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridbakiye);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(618, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(379, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAKİYE";
            // 
            // dataGridbakiye
            // 
            this.dataGridbakiye.AutoGenerateColumns = false;
            this.dataGridbakiye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridbakiye.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridbakiye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridbakiye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridbakiye.DataSource = this.adminMoneyBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridbakiye.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridbakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridbakiye.Location = new System.Drawing.Point(3, 17);
            this.dataGridbakiye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridbakiye.Name = "dataGridbakiye";
            this.dataGridbakiye.RowHeadersWidth = 51;
            this.dataGridbakiye.RowTemplate.Height = 24;
            this.dataGridbakiye.Size = new System.Drawing.Size(373, 199);
            this.dataGridbakiye.TabIndex = 0;
            this.dataGridbakiye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunOnay_CellClick);
            this.dataGridbakiye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridbakiye_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Money";
            this.dataGridViewTextBoxColumn7.HeaderText = "Money";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // adminMoneyBindingSource
            // 
            this.adminMoneyBindingSource.DataMember = "AdminMoney";
            this.adminMoneyBindingSource.DataSource = this.projetsDataSet;
            // 
            // projetsDataSet
            // 
            this.projetsDataSet.DataSetName = "ProjetsDataSet";
            this.projetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblua
            // 
            this.lblua.AutoSize = true;
            this.lblua.ForeColor = System.Drawing.Color.Yellow;
            this.lblua.Location = new System.Drawing.Point(832, 303);
            this.lblua.Name = "lblua";
            this.lblua.Size = new System.Drawing.Size(44, 17);
            this.lblua.TabIndex = 25;
            this.lblua.Text = "XXXX";
            // 
            // lblup
            // 
            this.lblup.AutoSize = true;
            this.lblup.ForeColor = System.Drawing.Color.Yellow;
            this.lblup.Location = new System.Drawing.Point(832, 347);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(44, 17);
            this.lblup.TabIndex = 26;
            this.lblup.Text = "XXXX";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ÜRÜN ADI";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ÜRÜN ADI";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // ProductAmount
            // 
            this.ProductAmount.DataPropertyName = "ProductAmount";
            this.ProductAmount.HeaderText = "MİKTAR";
            this.ProductAmount.MinimumWidth = 6;
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Width = 125;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "FİYAT";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 125;
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
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1041, -1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 32;
            // 
            // dataGridsafe
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dataGridsafe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridsafe.AutoGenerateColumns = false;
            this.dataGridsafe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridsafe.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridsafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridsafe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridsafe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridsafe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridsafe.ColumnHeadersHeight = 27;
            this.dataGridsafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.safeDataGridViewTextBoxColumn});
            this.dataGridsafe.DataSource = this.tblSafeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridsafe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridsafe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridsafe.EnableHeadersVisualStyles = false;
            this.dataGridsafe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dataGridsafe.Location = new System.Drawing.Point(3, 17);
            this.dataGridsafe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridsafe.Name = "dataGridsafe";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridsafe.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridsafe.RowHeadersVisible = false;
            this.dataGridsafe.RowHeadersWidth = 51;
            this.dataGridsafe.RowTemplate.Height = 24;
            this.dataGridsafe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridsafe.Size = new System.Drawing.Size(348, 199);
            this.dataGridsafe.TabIndex = 1;
            this.dataGridsafe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dataGridsafe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dataGridsafe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridsafe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridsafe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridsafe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridsafe.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridsafe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dataGridsafe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dataGridsafe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridsafe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridsafe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridsafe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridsafe.ThemeStyle.HeaderStyle.Height = 27;
            this.dataGridsafe.ThemeStyle.ReadOnly = false;
            this.dataGridsafe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridsafe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridsafe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridsafe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridsafe.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridsafe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataGridsafe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // safeDataGridViewTextBoxColumn
            // 
            this.safeDataGridViewTextBoxColumn.DataPropertyName = "Safe";
            this.safeDataGridViewTextBoxColumn.HeaderText = "Safe";
            this.safeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.safeDataGridViewTextBoxColumn.Name = "safeDataGridViewTextBoxColumn";
            // 
            // tblSafeBindingSource
            // 
            this.tblSafeBindingSource.DataMember = "tblSafe";
            this.tblSafeBindingSource.DataSource = this.projetsDataSet;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.projetsDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridsafe);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(151, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(354, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(748, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "BAKİYE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(707, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "KULLANICI ID:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::WindowsFormsApp1.Properties.Resources.geriiiiiii;
            this.guna2Button1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(69, 28);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "GERİ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // adminMoneyTableAdapter
            // 
            this.adminMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // tblSafeTableAdapter
            // 
            this.tblSafeTableAdapter.ClearBeforeFill = true;
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
            this.buttonAlım.Location = new System.Drawing.Point(731, 379);
            this.buttonAlım.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlım.Name = "buttonAlım";
            this.buttonAlım.ShadowDecoration.Parent = this.buttonAlım;
            this.buttonAlım.Size = new System.Drawing.Size(168, 55);
            this.buttonAlım.TabIndex = 43;
            this.buttonAlım.Text = "Onayla";
            this.buttonAlım.Click += new System.EventHandler(this.buttonAlım_Click);
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1103, 463);
            this.Controls.Add(this.buttonAlım);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.lblua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminEkrani";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridbakiye;
    
        private System.Windows.Forms.Label lblua;
        private System.Windows.Forms.Label lblup;
     //   private ProjetsDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridsafe;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnOnayla;
       // private ProjetsDataSetTableAdapters.AdminMoneyTableAdapter adminMoneyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private ProjetsDataSet projetsDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private ProjetsDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.BindingSource adminMoneyBindingSource;
        private ProjetsDataSetTableAdapters.AdminMoneyTableAdapter adminMoneyTableAdapter;
        private System.Windows.Forms.BindingSource tblSafeBindingSource;
        private ProjetsDataSetTableAdapters.tblSafeTableAdapter tblSafeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn safeDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton buttonAlım;
    }
}