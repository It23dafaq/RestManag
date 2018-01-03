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
            this.Orektika = new System.Windows.Forms.TabControl();
            this.Seats = new System.Windows.Forms.TabPage();
            this.Drinks = new System.Windows.Forms.TabPage();
            this.Appetizer = new System.Windows.Forms.TabPage();
            this.MainDish = new System.Windows.Forms.TabPage();
            this.Dessert = new System.Windows.Forms.TabPage();
            this.Payment = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Orektika.SuspendLayout();
            this.Payment.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Orektika
            // 
            this.Orektika.Controls.Add(this.Seats);
            this.Orektika.Controls.Add(this.Drinks);
            this.Orektika.Controls.Add(this.Appetizer);
            this.Orektika.Controls.Add(this.MainDish);
            this.Orektika.Controls.Add(this.Dessert);
            this.Orektika.Controls.Add(this.Payment);
            this.Orektika.Location = new System.Drawing.Point(-1, 2);
            this.Orektika.Name = "Orektika";
            this.Orektika.SelectedIndex = 0;
            this.Orektika.Size = new System.Drawing.Size(965, 557);
            this.Orektika.TabIndex = 0;
            // 
            // Seats
            // 
            this.Seats.Location = new System.Drawing.Point(4, 22);
            this.Seats.Name = "Seats";
            this.Seats.Padding = new System.Windows.Forms.Padding(3);
            this.Seats.Size = new System.Drawing.Size(957, 531);
            this.Seats.TabIndex = 3;
            this.Seats.Text = "Seats";
            this.Seats.UseVisualStyleBackColor = true;
            // 
            // Drinks
            // 
            this.Drinks.Location = new System.Drawing.Point(4, 22);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(957, 531);
            this.Drinks.TabIndex = 5;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = true;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // Appetizer
            // 
            this.Appetizer.Location = new System.Drawing.Point(4, 22);
            this.Appetizer.Name = "Appetizer";
            this.Appetizer.Padding = new System.Windows.Forms.Padding(3);
            this.Appetizer.Size = new System.Drawing.Size(957, 531);
            this.Appetizer.TabIndex = 0;
            this.Appetizer.Text = "Appetizer";
            this.Appetizer.UseVisualStyleBackColor = true;
            // 
            // MainDish
            // 
            this.MainDish.Location = new System.Drawing.Point(4, 22);
            this.MainDish.Name = "MainDish";
            this.MainDish.Padding = new System.Windows.Forms.Padding(3);
            this.MainDish.Size = new System.Drawing.Size(957, 531);
            this.MainDish.TabIndex = 1;
            this.MainDish.Text = "Main Dish";
            this.MainDish.UseVisualStyleBackColor = true;
            // 
            // Dessert
            // 
            this.Dessert.Location = new System.Drawing.Point(4, 22);
            this.Dessert.Name = "Dessert";
            this.Dessert.Padding = new System.Windows.Forms.Padding(3);
            this.Dessert.Size = new System.Drawing.Size(957, 531);
            this.Dessert.TabIndex = 2;
            this.Dessert.Text = "Dessert";
            this.Dessert.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.splitContainer1);
            this.Payment.Location = new System.Drawing.Point(4, 22);
            this.Payment.Name = "Payment";
            this.Payment.Padding = new System.Windows.Forms.Padding(3);
            this.Payment.Size = new System.Drawing.Size(957, 531);
            this.Payment.TabIndex = 4;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(951, 525);
            this.splitContainer1.SplitterDistance = 750;
            this.splitContainer1.TabIndex = 0;
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(21, 561);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(116, 45);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Orektika);
            this.Controls.Add(this.ADD);
            this.Name = "Waiter";
            this.Text = "Waitter";
            this.Load += new System.EventHandler(this.Waiter_Load);
            this.Orektika.ResumeLayout(false);
            this.Payment.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Orektika;
        private System.Windows.Forms.TabPage Appetizer;
        private System.Windows.Forms.TabPage MainDish;
        private System.Windows.Forms.TabPage Dessert;
        private System.Windows.Forms.TabPage Seats;
        private System.Windows.Forms.TabPage Payment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage Drinks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

    }
}