namespace LibraryClient
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.bun_Login = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_NewBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bun_Login
            // 
            this.bun_Login.Font = new System.Drawing.Font("SimHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bun_Login.Location = new System.Drawing.Point(849, 12);
            this.bun_Login.Name = "bun_Login";
            this.bun_Login.Size = new System.Drawing.Size(103, 50);
            this.bun_Login.TabIndex = 0;
            this.bun_Login.Text = "用户登录";
            this.bun_Login.UseVisualStyleBackColor = true;
            this.bun_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Books
            // 
            this.btn_Books.Font = new System.Drawing.Font("SimHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Books.Location = new System.Drawing.Point(849, 80);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(103, 48);
            this.btn_Books.TabIndex = 1;
            this.btn_Books.Text = "图书查询";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.btn_Books_Click);
            // 
            // btn_NewBooks
            // 
            this.btn_NewBooks.Font = new System.Drawing.Font("SimHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewBooks.Location = new System.Drawing.Point(849, 146);
            this.btn_NewBooks.Name = "btn_NewBooks";
            this.btn_NewBooks.Size = new System.Drawing.Size(103, 50);
            this.btn_NewBooks.TabIndex = 2;
            this.btn_NewBooks.Text = "新书推荐";
            this.btn_NewBooks.UseVisualStyleBackColor = true;
            this.btn_NewBooks.Click += new System.EventHandler(this.btn_NewBooks_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.btn_NewBooks);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.bun_Login);
            this.MaximumSize = new System.Drawing.Size(1000, 618);
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎进入图书馆系统";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bun_Login;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_NewBooks;
    }
}

