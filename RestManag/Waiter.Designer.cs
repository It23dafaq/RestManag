namespace RestManag
{
    partial class Waiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tablest = new System.Windows.Forms.TabPage();
            this.drinkst = new System.Windows.Forms.TabPage();
            this.appetizert = new System.Windows.Forms.TabPage();
            this.maindishest = new System.Windows.Forms.TabPage();
            this.dessertt = new System.Windows.Forms.TabPage();
            this.paymentt = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Removebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Logoutw = new System.Windows.Forms.Button();
            this.correctDatabaseDataSet = new RestManag.CorrectDatabaseDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new RestManag.CorrectDatabaseDataSetTableAdapters.ProductTableAdapter();
            this.productOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new RestManag.CorrectDatabaseDataSetTableAdapters.OrderTableAdapter();
            this.orderPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new RestManag.CorrectDatabaseDataSetTableAdapters.PaymentTableAdapter();
            this.correctDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderPaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderPaymentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.drinkst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1044, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 473);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tablest);
            this.tabControl1.Controls.Add(this.drinkst);
            this.tabControl1.Controls.Add(this.appetizert);
            this.tabControl1.Controls.Add(this.maindishest);
            this.tabControl1.Controls.Add(this.dessertt);
            this.tabControl1.Controls.Add(this.paymentt);
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // Tablest
            // 
            this.Tablest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablest.ImageIndex = 2;
            this.Tablest.Location = new System.Drawing.Point(4, 31);
            this.Tablest.Name = "Tablest";
            this.Tablest.Padding = new System.Windows.Forms.Padding(3);
            this.Tablest.Size = new System.Drawing.Size(591, 438);
            this.Tablest.TabIndex = 0;
            this.Tablest.Text = "Tables";
            this.Tablest.UseVisualStyleBackColor = true;
            // 
            // drinkst
            // 
            this.drinkst.Controls.Add(this.pictureBox1);
            this.drinkst.Controls.Add(this.listBox1);
            this.drinkst.ImageIndex = 1;
            this.drinkst.Location = new System.Drawing.Point(4, 31);
            this.drinkst.Name = "drinkst";
            this.drinkst.Padding = new System.Windows.Forms.Padding(3);
            this.drinkst.Size = new System.Drawing.Size(591, 438);
            this.drinkst.TabIndex = 1;
            this.drinkst.Text = "Drinks";
            this.drinkst.UseVisualStyleBackColor = true;
            // 
            // appetizert
            // 
            this.appetizert.ImageIndex = 2;
            this.appetizert.Location = new System.Drawing.Point(4, 31);
            this.appetizert.Name = "appetizert";
            this.appetizert.Padding = new System.Windows.Forms.Padding(3);
            this.appetizert.Size = new System.Drawing.Size(591, 438);
            this.appetizert.TabIndex = 2;
            this.appetizert.Text = "Appetizer";
            this.appetizert.UseVisualStyleBackColor = true;
            // 
            // maindishest
            // 
            this.maindishest.ImageIndex = 3;
            this.maindishest.Location = new System.Drawing.Point(4, 31);
            this.maindishest.Name = "maindishest";
            this.maindishest.Padding = new System.Windows.Forms.Padding(3);
            this.maindishest.Size = new System.Drawing.Size(591, 438);
            this.maindishest.TabIndex = 3;
            this.maindishest.Text = "Main Dishes";
            this.maindishest.UseVisualStyleBackColor = true;
            // 
            // dessertt
            // 
            this.dessertt.ImageIndex = 4;
            this.dessertt.Location = new System.Drawing.Point(4, 31);
            this.dessertt.Name = "dessertt";
            this.dessertt.Padding = new System.Windows.Forms.Padding(3);
            this.dessertt.Size = new System.Drawing.Size(591, 438);
            this.dessertt.TabIndex = 4;
            this.dessertt.Text = "Dessert";
            this.dessertt.UseVisualStyleBackColor = true;
            // 
            // paymentt
            // 
            this.paymentt.ImageIndex = 5;
            this.paymentt.Location = new System.Drawing.Point(4, 31);
            this.paymentt.Name = "paymentt";
            this.paymentt.Padding = new System.Windows.Forms.Padding(3);
            this.paymentt.Size = new System.Drawing.Size(591, 438);
            this.paymentt.TabIndex = 5;
            this.paymentt.Text = "Payment";
            this.paymentt.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "^22C6953459BA1F947B96A92050982FFA9CF96CA203524BC7E7^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(1, "^75C09A6C1FD02176924FAD7D727F8FB94509726E820353562F^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(2, "^A45F9E29822DE411093644E12ACA5467121729900BE8AB0551^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(3, "^65C87862FF7923CE49D77EA441EB304D0FC37E0574857F90DC^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(4, "^62E110857CB926F60E571B41D01F45D7D4508B25AEC13279C9^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(5, "^EACEB9109AD19CAD9C14CC28FD6E369F07335766A694A4BC89^pimgpsh_fullsize_distr.png");
            // 
            // Removebutton
            // 
            this.Removebutton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Removebutton.Image = global::RestManag.Properties.Resources._5FC673A9C9288F4AA7262B8164A53743B2AD3CF94BC4C9AEA3_pimgpsh_fullsize_distr;
            this.Removebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removebutton.Location = new System.Drawing.Point(163, 496);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(98, 30);
            this.Removebutton.TabIndex = 6;
            this.Removebutton.Text = "    Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Addbutton.Image = global::RestManag.Properties.Resources._DC68CEE5D7E4F20258F9B0F18E9138F2BC26907DE5AE74B2B2_pimgpsh_fullsize_distr;
            this.Addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbutton.Location = new System.Drawing.Point(42, 495);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(78, 30);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = " Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Logoutw
            // 
            this.Logoutw.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Logoutw.Image = global::RestManag.Properties.Resources._67DE68533ACEFA4662846E6EC64D8C417888207FAEC5F2F62F_pimgpsh_fullsize_distr;
            this.Logoutw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutw.Location = new System.Drawing.Point(493, 495);
            this.Logoutw.Name = "Logoutw";
            this.Logoutw.Size = new System.Drawing.Size(99, 30);
            this.Logoutw.TabIndex = 4;
            this.Logoutw.Text = "    Logout";
            this.Logoutw.UseVisualStyleBackColor = true;
            this.Logoutw.Click += new System.EventHandler(this.Logoutw_Click);
            // 
            // correctDatabaseDataSet
            // 
            this.correctDatabaseDataSet.DataSetName = "CorrectDatabaseDataSet";
            this.correctDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.correctDatabaseDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productOrderBindingSource
            // 
            this.productOrderBindingSource.DataMember = "ProductOrder";
            this.productOrderBindingSource.DataSource = this.productBindingSource;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderPaymentBindingSource
            // 
            this.orderPaymentBindingSource.DataMember = "OrderPayment";
            this.orderPaymentBindingSource.DataSource = this.productOrderBindingSource;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // correctDatabaseDataSetBindingSource
            // 
            this.correctDatabaseDataSetBindingSource.DataSource = this.correctDatabaseDataSet;
            this.correctDatabaseDataSetBindingSource.Position = 0;
            // 
            // orderPaymentBindingSource1
            // 
            this.orderPaymentBindingSource1.DataMember = "OrderPayment";
            this.orderPaymentBindingSource1.DataSource = this.productOrderBindingSource;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(38, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 312);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 312);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(605, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 267);
            this.dataGridView1.TabIndex = 7;
            // 
            // orderPaymentBindingSource2
            // 
            this.orderPaymentBindingSource2.DataMember = "OrderPayment";
            this.orderPaymentBindingSource2.DataSource = this.productOrderBindingSource;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.correctDatabaseDataSetBindingSource;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Logoutw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.Text = "Waitter";
            this.Load += new System.EventHandler(this.Waiter_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.drinkst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPaymentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tablest;
        private System.Windows.Forms.TabPage drinkst;
        private System.Windows.Forms.TabPage appetizert;
        private System.Windows.Forms.TabPage maindishest;
        private System.Windows.Forms.TabPage dessertt;
        private System.Windows.Forms.TabPage paymentt;
        private System.Windows.Forms.Button Logoutw;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.ImageList imageList1;
        private CorrectDatabaseDataSet correctDatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CorrectDatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productOrderBindingSource;
        private CorrectDatabaseDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderPaymentBindingSource;
        private CorrectDatabaseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource correctDatabaseDataSetBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource orderPaymentBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource orderPaymentBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}