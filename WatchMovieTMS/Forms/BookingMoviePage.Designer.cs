namespace WatchMovieTMS.Forms
{
    partial class BookingMoviePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingMoviePage));
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_BookTicket = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Change = new System.Windows.Forms.TextBox();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Payment = new System.Windows.Forms.TextBox();
            this.chk_Ave = new System.Windows.Forms.CheckBox();
            this.chk_John = new System.Windows.Forms.CheckBox();
            this.chk_Jum = new System.Windows.Forms.CheckBox();
            this.chk_Saw = new System.Windows.Forms.CheckBox();
            this.chk_Ram = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.btn_Back.Location = new System.Drawing.Point(13, 13);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(94, 33);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back <<";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(113, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking Movie Ticket";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(127, 272);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(156, 29);
            this.txt_Quantity.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Ram);
            this.groupBox1.Controls.Add(this.chk_Saw);
            this.groupBox1.Controls.Add(this.chk_Jum);
            this.groupBox1.Controls.Add(this.chk_John);
            this.groupBox1.Controls.Add(this.chk_Ave);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.btn_BookTicket);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Change);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.txt_Payment);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 395);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Movie";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WatchMovieTMS.Properties.Resources.rampage;
            this.pictureBox5.Location = new System.Drawing.Point(591, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 172);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WatchMovieTMS.Properties.Resources.sawX;
            this.pictureBox4.Location = new System.Drawing.Point(445, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 172);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btn_BookTicket
            // 
            this.btn_BookTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BookTicket.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.btn_BookTicket.Location = new System.Drawing.Point(619, 353);
            this.btn_BookTicket.Name = "btn_BookTicket";
            this.btn_BookTicket.Size = new System.Drawing.Size(110, 36);
            this.btn_BookTicket.TabIndex = 0;
            this.btn_BookTicket.Text = "Book Ticket";
            this.btn_BookTicket.UseVisualStyleBackColor = false;
            this.btn_BookTicket.Click += new System.EventHandler(this.btn_BookTicket_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WatchMovieTMS.Properties.Resources.jumanji;
            this.pictureBox3.Location = new System.Drawing.Point(301, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WatchMovieTMS.Properties.Resources.johnWick;
            this.pictureBox2.Location = new System.Drawing.Point(159, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchMovieTMS.Properties.Resources.avengersEndgame;
            this.pictureBox1.Location = new System.Drawing.Point(19, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(318, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(9, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(318, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(9, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // txt_Change
            // 
            this.txt_Change.Enabled = false;
            this.txt_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Change.Location = new System.Drawing.Point(499, 311);
            this.txt_Change.Name = "txt_Change";
            this.txt_Change.Size = new System.Drawing.Size(156, 29);
            this.txt_Change.TabIndex = 2;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.Location = new System.Drawing.Point(127, 314);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(156, 29);
            this.txt_Amount.TabIndex = 2;
            // 
            // txt_Payment
            // 
            this.txt_Payment.Enabled = false;
            this.txt_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Payment.Location = new System.Drawing.Point(499, 269);
            this.txt_Payment.Name = "txt_Payment";
            this.txt_Payment.Size = new System.Drawing.Size(156, 29);
            this.txt_Payment.TabIndex = 2;
            // 
            // chk_Ave
            // 
            this.chk_Ave.AutoSize = true;
            this.chk_Ave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chk_Ave.ForeColor = System.Drawing.Color.Green;
            this.chk_Ave.Location = new System.Drawing.Point(32, 213);
            this.chk_Ave.Name = "chk_Ave";
            this.chk_Ave.Size = new System.Drawing.Size(89, 24);
            this.chk_Ave.TabIndex = 5;
            this.chk_Ave.Text = "P 99.00";
            this.chk_Ave.UseVisualStyleBackColor = false;
            // 
            // chk_John
            // 
            this.chk_John.AutoSize = true;
            this.chk_John.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chk_John.ForeColor = System.Drawing.Color.Green;
            this.chk_John.Location = new System.Drawing.Point(179, 213);
            this.chk_John.Name = "chk_John";
            this.chk_John.Size = new System.Drawing.Size(89, 24);
            this.chk_John.TabIndex = 5;
            this.chk_John.Text = "P 90.00";
            this.chk_John.UseVisualStyleBackColor = false;
            // 
            // chk_Jum
            // 
            this.chk_Jum.AutoSize = true;
            this.chk_Jum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chk_Jum.ForeColor = System.Drawing.Color.Green;
            this.chk_Jum.Location = new System.Drawing.Point(321, 213);
            this.chk_Jum.Name = "chk_Jum";
            this.chk_Jum.Size = new System.Drawing.Size(89, 24);
            this.chk_Jum.TabIndex = 5;
            this.chk_Jum.Text = "P 70.00";
            this.chk_Jum.UseVisualStyleBackColor = false;
            // 
            // chk_Saw
            // 
            this.chk_Saw.AutoSize = true;
            this.chk_Saw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chk_Saw.ForeColor = System.Drawing.Color.Green;
            this.chk_Saw.Location = new System.Drawing.Point(465, 213);
            this.chk_Saw.Name = "chk_Saw";
            this.chk_Saw.Size = new System.Drawing.Size(89, 24);
            this.chk_Saw.TabIndex = 5;
            this.chk_Saw.Text = "P 70.00";
            this.chk_Saw.UseVisualStyleBackColor = false;
            // 
            // chk_Ram
            // 
            this.chk_Ram.AutoSize = true;
            this.chk_Ram.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chk_Ram.ForeColor = System.Drawing.Color.Green;
            this.chk_Ram.Location = new System.Drawing.Point(611, 213);
            this.chk_Ram.Name = "chk_Ram";
            this.chk_Ram.Size = new System.Drawing.Size(89, 24);
            this.chk_Ram.TabIndex = 5;
            this.chk_Ram.Text = "P 85.00";
            this.chk_Ram.UseVisualStyleBackColor = false;
            // 
            // BookingMoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingMoviePage";
            this.Text = "BookingMoviePage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Change;
        private System.Windows.Forms.TextBox txt_Payment;
        private System.Windows.Forms.Button btn_BookTicket;
        private System.Windows.Forms.CheckBox chk_John;
        private System.Windows.Forms.CheckBox chk_Ave;
        private System.Windows.Forms.CheckBox chk_Ram;
        private System.Windows.Forms.CheckBox chk_Saw;
        private System.Windows.Forms.CheckBox chk_Jum;
    }
}