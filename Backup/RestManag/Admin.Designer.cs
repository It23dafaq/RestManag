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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.managmentstaff = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Month = new System.Windows.Forms.TableLayoutPanel();
            this.Monthla = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeuteraLabel = new System.Windows.Forms.Label();
            this.TrithLabel = new System.Windows.Forms.Label();
            this.TetarthLabel = new System.Windows.Forms.Label();
            this.PemthLabel = new System.Windows.Forms.Label();
            this.ParaskeuhLabel = new System.Windows.Forms.Label();
            this.SavvatoLabel = new System.Windows.Forms.Label();
            this.Kiriakilebel = new System.Windows.Forms.Label();
            this.singlepayment = new System.Windows.Forms.TabPage();
            this.totalpayment = new System.Windows.Forms.TabPage();
            this.Addstaff = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.managmentstaff.SuspendLayout();
            this.Month.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.managmentstaff);
            this.tabControl1.Controls.Add(this.singlepayment);
            this.tabControl1.Controls.Add(this.totalpayment);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // managmentstaff
            // 
            this.managmentstaff.Controls.Add(this.dateTimePicker1);
            this.managmentstaff.Controls.Add(this.Month);
            this.managmentstaff.Controls.Add(this.table);
            this.managmentstaff.Controls.Add(this.Addstaff);
            this.managmentstaff.Location = new System.Drawing.Point(4, 22);
            this.managmentstaff.Name = "managmentstaff";
            this.managmentstaff.Padding = new System.Windows.Forms.Padding(3);
            this.managmentstaff.Size = new System.Drawing.Size(726, 399);
            this.managmentstaff.TabIndex = 0;
            this.managmentstaff.Text = "Managment Staff";
            this.managmentstaff.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-51, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Visible = false;
            // 
            // Month
            // 
            this.Month.ColumnCount = 1;
            this.Month.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Month.Controls.Add(this.Monthla, 0, 0);
            this.Month.Location = new System.Drawing.Point(116, 23);
            this.Month.Name = "Month";
            this.Month.RowCount = 1;
            this.Month.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Month.Size = new System.Drawing.Size(484, 42);
            this.Month.TabIndex = 1;
            // 
            // Monthla
            // 
            this.Monthla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Monthla.AutoSize = true;
            this.Monthla.BackColor = System.Drawing.Color.DarkGray;
            this.Monthla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Monthla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthla.Location = new System.Drawing.Point(3, 0);
            this.Monthla.Name = "Monthla";
            this.Monthla.Size = new System.Drawing.Size(478, 42);
            this.Monthla.TabIndex = 0;
            this.Monthla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 8;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.table.Controls.Add(this.label2, 0, 2);
            this.table.Controls.Add(this.label3, 1, 0);
            this.table.Controls.Add(this.label4, 2, 0);
            this.table.Controls.Add(this.label5, 3, 0);
            this.table.Controls.Add(this.label6, 4, 0);
            this.table.Controls.Add(this.label7, 5, 0);
            this.table.Controls.Add(this.label8, 6, 0);
            this.table.Controls.Add(this.label9, 7, 0);
            this.table.Controls.Add(this.label1, 0, 1);
            this.table.Controls.Add(this.TrithLabel, 2, 1);
            this.table.Controls.Add(this.TetarthLabel, 3, 1);
            this.table.Controls.Add(this.PemthLabel, 4, 1);
            this.table.Controls.Add(this.ParaskeuhLabel, 5, 1);
            this.table.Controls.Add(this.SavvatoLabel, 6, 1);
            this.table.Controls.Add(this.Kiriakilebel, 7, 1);
            this.table.Controls.Add(this.DeuteraLabel, 1, 1);
            this.table.Location = new System.Drawing.Point(6, 68);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.20382F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.79618F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(714, 293);
            this.table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(4, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 130);
            this.label2.TabIndex = 1;
            this.label2.Text = "4-2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(73, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Δευτερα";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(1);
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Τριτη";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(1);
            this.label5.Size = new System.Drawing.Size(93, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Τεταρτη";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 1);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(1);
            this.label6.Size = new System.Drawing.Size(93, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Πεμτη";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 1);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(1);
            this.label7.Size = new System.Drawing.Size(97, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "Παρασκευη";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(1);
            this.label8.Size = new System.Drawing.Size(90, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Σαββατο";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(625, 1);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(1);
            this.label9.Size = new System.Drawing.Size(85, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Κυριακη";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(33, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "8-4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeuteraLabel
            // 
            this.DeuteraLabel.AutoSize = true;
            this.DeuteraLabel.Location = new System.Drawing.Point(44, 40);
            this.DeuteraLabel.Name = "DeuteraLabel";
            this.DeuteraLabel.Size = new System.Drawing.Size(13, 13);
            this.DeuteraLabel.TabIndex = 9;
            this.DeuteraLabel.Text = "d";
            // 
            // TrithLabel
            // 
            this.TrithLabel.AutoSize = true;
            this.TrithLabel.Location = new System.Drawing.Point(124, 40);
            this.TrithLabel.Name = "TrithLabel";
            this.TrithLabel.Size = new System.Drawing.Size(13, 13);
            this.TrithLabel.TabIndex = 10;
            this.TrithLabel.Text = "d";
            // 
            // TetarthLabel
            // 
            this.TetarthLabel.AutoSize = true;
            this.TetarthLabel.Location = new System.Drawing.Point(224, 40);
            this.TetarthLabel.Name = "TetarthLabel";
            this.TetarthLabel.Size = new System.Drawing.Size(13, 13);
            this.TetarthLabel.TabIndex = 11;
            this.TetarthLabel.Text = "d";
            // 
            // PemthLabel
            // 
            this.PemthLabel.AutoSize = true;
            this.PemthLabel.Location = new System.Drawing.Point(324, 40);
            this.PemthLabel.Name = "PemthLabel";
            this.PemthLabel.Size = new System.Drawing.Size(13, 13);
            this.PemthLabel.TabIndex = 12;
            this.PemthLabel.Text = "d";
            // 
            // ParaskeuhLabel
            // 
            this.ParaskeuhLabel.AutoSize = true;
            this.ParaskeuhLabel.Location = new System.Drawing.Point(424, 40);
            this.ParaskeuhLabel.Name = "ParaskeuhLabel";
            this.ParaskeuhLabel.Size = new System.Drawing.Size(13, 13);
            this.ParaskeuhLabel.TabIndex = 13;
            this.ParaskeuhLabel.Text = "d";
            // 
            // SavvatoLabel
            // 
            this.SavvatoLabel.AutoSize = true;
            this.SavvatoLabel.Location = new System.Drawing.Point(528, 40);
            this.SavvatoLabel.Name = "SavvatoLabel";
            this.SavvatoLabel.Size = new System.Drawing.Size(13, 13);
            this.SavvatoLabel.TabIndex = 14;
            this.SavvatoLabel.Text = "d";
            // 
            // Kiriakilebel
            // 
            this.Kiriakilebel.AutoSize = true;
            this.Kiriakilebel.Location = new System.Drawing.Point(625, 40);
            this.Kiriakilebel.Name = "Kiriakilebel";
            this.Kiriakilebel.Size = new System.Drawing.Size(13, 13);
            this.Kiriakilebel.TabIndex = 15;
            this.Kiriakilebel.Text = "d";
            // 
            // singlepayment
            // 
            this.singlepayment.Location = new System.Drawing.Point(4, 22);
            this.singlepayment.Name = "singlepayment";
            this.singlepayment.Padding = new System.Windows.Forms.Padding(3);
            this.singlepayment.Size = new System.Drawing.Size(726, 399);
            this.singlepayment.TabIndex = 1;
            this.singlepayment.Text = "Single Payment";
            this.singlepayment.UseVisualStyleBackColor = true;
            // 
            // totalpayment
            // 
            this.totalpayment.Location = new System.Drawing.Point(4, 22);
            this.totalpayment.Name = "totalpayment";
            this.totalpayment.Size = new System.Drawing.Size(726, 399);
            this.totalpayment.TabIndex = 2;
            this.totalpayment.Text = "Total Payment";
            this.totalpayment.UseVisualStyleBackColor = true;
            // 
            // Addstaff
            // 
            this.Addstaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Addstaff.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Addstaff.Location = new System.Drawing.Point(50, 364);
            this.Addstaff.Name = "Addstaff";
            this.Addstaff.Size = new System.Drawing.Size(73, 23);
            this.Addstaff.TabIndex = 16;
            this.Addstaff.Text = "Add";
            this.Addstaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Addstaff.UseVisualStyleBackColor = true;
            this.Addstaff.Click += new System.EventHandler(this.Addstaff_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.managmentstaff.ResumeLayout(false);
            this.Month.ResumeLayout(false);
            this.Month.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage managmentstaff;
        private System.Windows.Forms.TabPage singlepayment;
        private System.Windows.Forms.TabPage totalpayment;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel Month;
        private System.Windows.Forms.Label Monthla;
        private System.Windows.Forms.Label DeuteraLabel;
        private System.Windows.Forms.Label TrithLabel;
        private System.Windows.Forms.Label TetarthLabel;
        private System.Windows.Forms.Label PemthLabel;
        private System.Windows.Forms.Label ParaskeuhLabel;
        private System.Windows.Forms.Label SavvatoLabel;
        private System.Windows.Forms.Label Kiriakilebel;
        private System.Windows.Forms.Button Addstaff;
    }
}