namespace WatchMovieTMS.Forms
{
    partial class Admin_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_HomePage));
            this.btn_viewUsers = new System.Windows.Forms.Button();
            this.btn_Movies = new System.Windows.Forms.Button();
            this.dgv_showInfo = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtA_Username = new System.Windows.Forms.TextBox();
            this.txtA_Password = new System.Windows.Forms.TextBox();
            this.btn_Signout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewUsers
            // 
            this.btn_viewUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_viewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewUsers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewUsers.Location = new System.Drawing.Point(54, 91);
            this.btn_viewUsers.Name = "btn_viewUsers";
            this.btn_viewUsers.Size = new System.Drawing.Size(169, 52);
            this.btn_viewUsers.TabIndex = 6;
            this.btn_viewUsers.Text = "View Users";
            this.btn_viewUsers.UseVisualStyleBackColor = false;
            this.btn_viewUsers.Click += new System.EventHandler(this.btn_viewUsers_Click);
            // 
            // btn_Movies
            // 
            this.btn_Movies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Movies.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Movies.Location = new System.Drawing.Point(603, 326);
            this.btn_Movies.Name = "btn_Movies";
            this.btn_Movies.Size = new System.Drawing.Size(169, 52);
            this.btn_Movies.TabIndex = 6;
            this.btn_Movies.Text = "View Movies";
            this.btn_Movies.UseVisualStyleBackColor = false;
            this.btn_Movies.Click += new System.EventHandler(this.btn_Movies_Click);
            // 
            // dgv_showInfo
            // 
            this.dgv_showInfo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_showInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showInfo.Location = new System.Drawing.Point(295, 69);
            this.dgv_showInfo.Name = "dgv_showInfo";
            this.dgv_showInfo.Size = new System.Drawing.Size(477, 242);
            this.dgv_showInfo.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(39, 168);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 29);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(150, 168);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 29);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // txtA_Username
            // 
            this.txtA_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Username.Location = new System.Drawing.Point(122, 218);
            this.txtA_Username.Name = "txtA_Username";
            this.txtA_Username.Size = new System.Drawing.Size(125, 22);
            this.txtA_Username.TabIndex = 9;
            // 
            // txtA_Password
            // 
            this.txtA_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Password.Location = new System.Drawing.Point(122, 246);
            this.txtA_Password.Name = "txtA_Password";
            this.txtA_Password.Size = new System.Drawing.Size(125, 22);
            this.txtA_Password.TabIndex = 9;
            // 
            // btn_Signout
            // 
            this.btn_Signout.BackColor = System.Drawing.Color.Green;
            this.btn_Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signout.ForeColor = System.Drawing.Color.White;
            this.btn_Signout.Location = new System.Drawing.Point(661, 12);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(111, 35);
            this.btn_Signout.TabIndex = 10;
            this.btn_Signout.Text = "Sign-out";
            this.btn_Signout.UseVisualStyleBackColor = false;
            this.btn_Signout.Click += new System.EventHandler(this.btn_Signout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(39, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(41, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "UserType";
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.cmb_UserType.Location = new System.Drawing.Point(122, 274);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(125, 21);
            this.cmb_UserType.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchMovieTMS.Properties.Resources.WatchMovie_Logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cmb_UserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Signout);
            this.Controls.Add(this.txtA_Password);
            this.Controls.Add(this.txtA_Username);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_showInfo);
            this.Controls.Add(this.btn_Movies);
            this.Controls.Add(this.btn_viewUsers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_HomePage";
            this.Text = "Admin_HomePage";
            this.Load += new System.EventHandler(this.Admin_HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_viewUsers;
        private System.Windows.Forms.Button btn_Movies;
        private System.Windows.Forms.DataGridView dgv_showInfo;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txtA_Username;
        private System.Windows.Forms.TextBox txtA_Password;
        private System.Windows.Forms.Button btn_Signout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_UserType;
    }
}