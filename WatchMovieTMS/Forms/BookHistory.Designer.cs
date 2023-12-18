namespace WatchMovieTMS.Forms
{
    partial class BookHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookHistory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_BookHistory = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_SearchHistory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WatchMovieTMS.Properties.Resources.WatchMovie_Logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_BookHistory
            // 
            this.dgv_BookHistory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_BookHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookHistory.Location = new System.Drawing.Point(12, 158);
            this.dgv_BookHistory.Name = "dgv_BookHistory";
            this.dgv_BookHistory.Size = new System.Drawing.Size(552, 281);
            this.dgv_BookHistory.TabIndex = 6;
            this.dgv_BookHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookHistory_CellContentClick);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.btn_Back.Location = new System.Drawing.Point(12, 71);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(94, 33);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back <<";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_SearchHistory
            // 
            this.txt_SearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchHistory.Location = new System.Drawing.Point(118, 126);
            this.txt_SearchHistory.Name = "txt_SearchHistory";
            this.txt_SearchHistory.Size = new System.Drawing.Size(210, 26);
            this.txt_SearchHistory.TabIndex = 8;
            this.txt_SearchHistory.TextChanged += new System.EventHandler(this.txt_SearchHistory_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search: ";
            // 
            // BookHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(223)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SearchHistory);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_BookHistory);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookHistory";
            this.Text = "BookHistory";
            this.Load += new System.EventHandler(this.BookHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_BookHistory;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_SearchHistory;
        private System.Windows.Forms.Label label2;
    }
}