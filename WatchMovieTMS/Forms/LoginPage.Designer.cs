namespace WatchMovieTMS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RegAcc = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.txtb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btn_RegAcc);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Controls.Add(this.txtb_Password);
            this.groupBox1.Controls.Add(this.txtb_Username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(191, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // btn_RegAcc
            // 
            this.btn_RegAcc.BackColor = System.Drawing.Color.Green;
            this.btn_RegAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegAcc.ForeColor = System.Drawing.Color.White;
            this.btn_RegAcc.Location = new System.Drawing.Point(186, 234);
            this.btn_RegAcc.Name = "btn_RegAcc";
            this.btn_RegAcc.Size = new System.Drawing.Size(72, 25);
            this.btn_RegAcc.TabIndex = 3;
            this.btn_RegAcc.Text = "Register";
            this.btn_RegAcc.UseVisualStyleBackColor = false;
            this.btn_RegAcc.Click += new System.EventHandler(this.btn_RegAcc_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Green;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(186, 156);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(96, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(10, 113);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.PasswordChar = '*';
            this.txtb_Password.Size = new System.Drawing.Size(211, 26);
            this.txtb_Password.TabIndex = 1;
            // 
            // txtb_Username
            // 
            this.txtb_Username.Location = new System.Drawing.Point(10, 56);
            this.txtb_Username.Name = "txtb_Username";
            this.txtb_Username.Size = new System.Drawing.Size(211, 26);
            this.txtb_Username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doesn\'t have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchMovieTMS.Properties.Resources.WatchMovie_Logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(167, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "WATCHMOVIE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_RegAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

