namespace LibraryClient
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UrName = new System.Windows.Forms.TextBox();
            this.textBox_Psw = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.radioBtn_User = new System.Windows.Forms.RadioButton();
            this.radioBtn_Admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(78, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // textBox_UrName
            // 
            this.textBox_UrName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_UrName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UrName.Location = new System.Drawing.Point(153, 64);
            this.textBox_UrName.Name = "textBox_UrName";
            this.textBox_UrName.Size = new System.Drawing.Size(162, 26);
            this.textBox_UrName.TabIndex = 2;
            this.textBox_UrName.TextChanged += new System.EventHandler(this.textBox_UrName_TextChanged);
            // 
            // textBox_Psw
            // 
            this.textBox_Psw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Psw.Location = new System.Drawing.Point(153, 102);
            this.textBox_Psw.Multiline = true;
            this.textBox_Psw.Name = "textBox_Psw";
            this.textBox_Psw.Size = new System.Drawing.Size(162, 26);
            this.textBox_Psw.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("SimHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(99, 153);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 32);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("SimHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(227, 153);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "返回";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // radioBtn_User
            // 
            this.radioBtn_User.AutoSize = true;
            this.radioBtn_User.Location = new System.Drawing.Point(94, 28);
            this.radioBtn_User.Name = "radioBtn_User";
            this.radioBtn_User.Size = new System.Drawing.Size(73, 17);
            this.radioBtn_User.TabIndex = 6;
            this.radioBtn_User.TabStop = true;
            this.radioBtn_User.Text = "普通用户";
            this.radioBtn_User.UseVisualStyleBackColor = true;
            this.radioBtn_User.CheckedChanged += new System.EventHandler(this.radioBtn_User_CheckedChanged);
            // 
            // radioBtn_Admin
            // 
            this.radioBtn_Admin.AutoSize = true;
            this.radioBtn_Admin.Location = new System.Drawing.Point(236, 28);
            this.radioBtn_Admin.Name = "radioBtn_Admin";
            this.radioBtn_Admin.Size = new System.Drawing.Size(61, 17);
            this.radioBtn_Admin.TabIndex = 7;
            this.radioBtn_Admin.TabStop = true;
            this.radioBtn_Admin.Text = "管理员";
            this.radioBtn_Admin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 208);
            this.Controls.Add(this.radioBtn_Admin);
            this.Controls.Add(this.radioBtn_User);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_Psw);
            this.Controls.Add(this.textBox_UrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 247);
            this.MinimumSize = new System.Drawing.Size(400, 247);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UrName;
        private System.Windows.Forms.TextBox textBox_Psw;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton radioBtn_User;
        private System.Windows.Forms.RadioButton radioBtn_Admin;
    }
}