namespace RestManag
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.restDatabaseDataSet1 = new RestManag.RestDatabaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.programtab = new System.Windows.Forms.TabControl();
            this.programt = new System.Windows.Forms.TabPage();
            this.payrollt = new System.Windows.Forms.TabPage();
            this.orderst = new System.Windows.Forms.TabPage();
            this.totalt = new System.Windows.Forms.TabPage();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.tablest = new System.Windows.Forms.TabPage();
            this.paymentt = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restDatabaseDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.programtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // restDatabaseDataSet1
            // 
            this.restDatabaseDataSet1.DataSetName = "RestDatabaseDataSet";
            this.restDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.programtab);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 446);
            this.panel1.TabIndex = 0;
            // 
            // programtab
            // 
            this.programtab.Controls.Add(this.programt);
            this.programtab.Controls.Add(this.payrollt);
            this.programtab.Controls.Add(this.orderst);
            this.programtab.Controls.Add(this.paymentt);
            this.programtab.Controls.Add(this.totalt);
            this.programtab.Controls.Add(this.tablest);
            this.programtab.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programtab.ImageList = this.imageList1;
            this.programtab.Location = new System.Drawing.Point(0, 4);
            this.programtab.Name = "programtab";
            this.programtab.SelectedIndex = 0;
            this.programtab.Size = new System.Drawing.Size(893, 442);
            this.programtab.TabIndex = 0;
            // 
            // programt
            // 
            this.programt.ImageIndex = 0;
            this.programt.Location = new System.Drawing.Point(4, 31);
            this.programt.Name = "programt";
            this.programt.Padding = new System.Windows.Forms.Padding(3);
            this.programt.Size = new System.Drawing.Size(885, 407);
            this.programt.TabIndex = 0;
            this.programt.Text = "Program";
            this.programt.UseVisualStyleBackColor = true;
            // 
            // payrollt
            // 
            this.payrollt.ImageIndex = 1;
            this.payrollt.Location = new System.Drawing.Point(4, 31);
            this.payrollt.Name = "payrollt";
            this.payrollt.Padding = new System.Windows.Forms.Padding(3);
            this.payrollt.Size = new System.Drawing.Size(885, 407);
            this.payrollt.TabIndex = 1;
            this.payrollt.Text = "Payroll";
            this.payrollt.UseVisualStyleBackColor = true;
            // 
            // orderst
            // 
            this.orderst.ImageIndex = 2;
            this.orderst.Location = new System.Drawing.Point(4, 31);
            this.orderst.Name = "orderst";
            this.orderst.Padding = new System.Windows.Forms.Padding(3);
            this.orderst.Size = new System.Drawing.Size(885, 407);
            this.orderst.TabIndex = 2;
            this.orderst.Text = "Orders";
            this.orderst.UseVisualStyleBackColor = true;
            // 
            // totalt
            // 
            this.totalt.ImageIndex = 4;
            this.totalt.Location = new System.Drawing.Point(4, 31);
            this.totalt.Name = "totalt";
            this.totalt.Padding = new System.Windows.Forms.Padding(3);
            this.totalt.Size = new System.Drawing.Size(885, 407);
            this.totalt.TabIndex = 3;
            this.totalt.Text = "Total";
            this.totalt.UseVisualStyleBackColor = true;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logoutbutton.Image = global::RestManag.Properties.Resources._67DE68533ACEFA4662846E6EC64D8C417888207FAEC5F2F62F_pimgpsh_fullsize_distr;
            this.logoutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbutton.Location = new System.Drawing.Point(797, 448);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(92, 32);
            this.logoutbutton.TabIndex = 1;
            this.logoutbutton.Text = "    Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // tablest
            // 
            this.tablest.ImageIndex = 5;
            this.tablest.Location = new System.Drawing.Point(4, 31);
            this.tablest.Name = "tablest";
            this.tablest.Padding = new System.Windows.Forms.Padding(3);
            this.tablest.Size = new System.Drawing.Size(885, 407);
            this.tablest.TabIndex = 4;
            this.tablest.Text = "Tables";
            this.tablest.UseVisualStyleBackColor = true;
            // 
            // paymentt
            // 
            this.paymentt.ImageIndex = 3;
            this.paymentt.Location = new System.Drawing.Point(4, 31);
            this.paymentt.Name = "paymentt";
            this.paymentt.Padding = new System.Windows.Forms.Padding(3);
            this.paymentt.Size = new System.Drawing.Size(885, 407);
            this.paymentt.TabIndex = 5;
            this.paymentt.Text = "Payment";
            this.paymentt.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "^FC67486DB7C6FFDDCB2AAC9CB79FF50686F895BF105800735C^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(1, "^3571942658B6D3D7B1088F4EB2947E836B25B6958EF37858F3^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(2, "^765B014C1BC2DDD82CEAB1473A610906B596AE8AC1C69BE32B^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(3, "^EACEB9109AD19CAD9C14CC28FD6E369F07335766A694A4BC89^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(4, "^BF506391190B1CE9C229840892F778C30D924FF7023B687E04^pimgpsh_fullsize_distr.png");
            this.imageList1.Images.SetKeyName(5, "^22C6953459BA1F947B96A92050982FFA9CF96CA203524BC7E7^pimgpsh_fullsize_distr.png");
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(893, 492);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.restDatabaseDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.programtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RestDatabaseDataSet restDatabaseDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl programtab;
        private System.Windows.Forms.TabPage programt;
        private System.Windows.Forms.TabPage payrollt;
        private System.Windows.Forms.TabPage orderst;
        private System.Windows.Forms.TabPage totalt;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.TabPage paymentt;
        private System.Windows.Forms.TabPage tablest;
        private System.Windows.Forms.ImageList imageList1;
    }
}