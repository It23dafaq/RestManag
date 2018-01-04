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
            this.panel1 = new System.Windows.Forms.Panel();
            this.programtab = new System.Windows.Forms.TabControl();
            this.programt = new System.Windows.Forms.TabPage();
            this.payrollt = new System.Windows.Forms.TabPage();
            this.orderst = new System.Windows.Forms.TabPage();
            this.paymentt = new System.Windows.Forms.TabPage();
            this.totalt = new System.Windows.Forms.TabPage();
            this.tablest = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usenameLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourSpin = new System.Windows.Forms.NumericUpDown();
            this.minuteSpin = new System.Windows.Forms.NumericUpDown();
            this.colon = new System.Windows.Forms.Label();
            this.durationSpin = new System.Windows.Forms.NumericUpDown();
            this.hoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correctDatabaseDataSet = new RestManag.CorrectDatabaseDataSet();
            this.tableTableAdapter1 = new RestManag.CorrectDatabaseDataSetTableAdapters.TableTableAdapter();
            this.hoursTableAdapter = new RestManag.CorrectDatabaseDataSetTableAdapters.HoursTableAdapter();
            this.usersTableAdapter1 = new RestManag.CorrectDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.programtab.SuspendLayout();
            this.programt.SuspendLayout();
            this.tablest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.programt.Controls.Add(this.durationSpin);
            this.programt.Controls.Add(this.colon);
            this.programt.Controls.Add(this.minuteSpin);
            this.programt.Controls.Add(this.hourSpin);
            this.programt.Controls.Add(this.dateTimePicker);
            this.programt.Controls.Add(this.deleteButton);
            this.programt.Controls.Add(this.addButton);
            this.programt.Controls.Add(this.durationLabel);
            this.programt.Controls.Add(this.timeLabel);
            this.programt.Controls.Add(this.startLabel);
            this.programt.Controls.Add(this.usenameLabel);
            this.programt.Controls.Add(this.textBox1);
            this.programt.Controls.Add(this.dataGridView1);
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
            // tablest
            // 
            this.tablest.Controls.Add(this.tableLayoutPanel1);
            this.tablest.ImageIndex = 5;
            this.tablest.Location = new System.Drawing.Point(4, 31);
            this.tablest.Name = "tablest";
            this.tablest.Padding = new System.Windows.Forms.Padding(3);
            this.tablest.Size = new System.Drawing.Size(885, 407);
            this.tablest.TabIndex = 4;
            this.tablest.Text = "Tables";
            this.tablest.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(194, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 297);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 1;
            // 
            // usenameLabel
            // 
            this.usenameLabel.AutoSize = true;
            this.usenameLabel.Location = new System.Drawing.Point(589, 21);
            this.usenameLabel.Name = "usenameLabel";
            this.usenameLabel.Size = new System.Drawing.Size(80, 22);
            this.usenameLabel.TabIndex = 5;
            this.usenameLabel.Text = "Username";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(589, 82);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(43, 22);
            this.startLabel.TabIndex = 6;
            this.startLabel.Text = "Start";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(589, 142);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 22);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Time";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(589, 201);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(71, 22);
            this.durationLabel.TabIndex = 8;
            this.durationLabel.Text = "Duration";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(605, 280);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 32);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(756, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 32);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(687, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(190, 29);
            this.dateTimePicker.TabIndex = 10;
            // 
            // hourSpin
            // 
            this.hourSpin.Location = new System.Drawing.Point(687, 140);
            this.hourSpin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourSpin.Name = "hourSpin";
            this.hourSpin.Size = new System.Drawing.Size(45, 29);
            this.hourSpin.TabIndex = 11;
            // 
            // minuteSpin
            // 
            this.minuteSpin.Location = new System.Drawing.Point(758, 140);
            this.minuteSpin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteSpin.Name = "minuteSpin";
            this.minuteSpin.Size = new System.Drawing.Size(45, 29);
            this.minuteSpin.TabIndex = 12;
            // 
            // colon
            // 
            this.colon.AutoSize = true;
            this.colon.Location = new System.Drawing.Point(738, 142);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(14, 22);
            this.colon.TabIndex = 13;
            this.colon.Text = ":";
            // 
            // durationSpin
            // 
            this.durationSpin.Location = new System.Drawing.Point(687, 202);
            this.durationSpin.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.durationSpin.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.durationSpin.Name = "durationSpin";
            this.durationSpin.Size = new System.Drawing.Size(45, 29);
            this.durationSpin.TabIndex = 14;
            this.durationSpin.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // hoursBindingSource
            // 
            this.hoursBindingSource.DataMember = "Hours";
            this.hoursBindingSource.DataSource = this.correctDatabaseDataSet;
            // 
            // correctDatabaseDataSet
            // 
            this.correctDatabaseDataSet.DataSetName = "CorrectDatabaseDataSet";
            this.correctDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // hoursTableAdapter
            // 
            this.hoursTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.Frozen = true;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.Frozen = true;
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.Frozen = true;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.Frozen = true;
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.programtab.ResumeLayout(false);
            this.programt.ResumeLayout(false);
            this.programt.PerformLayout();
            this.tablest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
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
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private CorrectDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CorrectDatabaseDataSet correctDatabaseDataSet;
        private System.Windows.Forms.BindingSource hoursBindingSource;
        private CorrectDatabaseDataSetTableAdapters.HoursTableAdapter hoursTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label usenameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.NumericUpDown minuteSpin;
        private System.Windows.Forms.NumericUpDown hourSpin;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown durationSpin;
        private CorrectDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}