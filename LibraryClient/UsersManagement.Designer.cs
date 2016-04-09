namespace LibraryClient
{
    partial class UsersManagement
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
            this.groupBox_A2U = new System.Windows.Forms.GroupBox();
            this.textBox_AdminId = new System.Windows.Forms.TextBox();
            this.label_Admin = new System.Windows.Forms.Label();
            this.button_A2U = new System.Windows.Forms.Button();
            this.groupBox_U2A = new System.Windows.Forms.GroupBox();
            this.button_U2A = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserId = new System.Windows.Forms.TextBox();
            this.groupBox_A2U.SuspendLayout();
            this.groupBox_U2A.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox_A2U.Controls.Add(this.button_A2U);
            this.groupBox_A2U.Controls.Add(this.label_Admin);
            this.groupBox_A2U.Controls.Add(this.textBox_AdminId);
            this.groupBox_A2U.Location = new System.Drawing.Point(12, 12);
            this.groupBox_A2U.Name = "groupBox1";
            this.groupBox_A2U.Size = new System.Drawing.Size(150, 150);
            this.groupBox_A2U.TabIndex = 0;
            this.groupBox_A2U.TabStop = false;
            this.groupBox_A2U.Text = "管理员用户 -> 普通账户";
            // 
            // textBox_AdminId
            // 
            this.textBox_AdminId.Location = new System.Drawing.Point(24, 58);
            this.textBox_AdminId.Multiline = true;
            this.textBox_AdminId.Name = "textBox1";
            this.textBox_AdminId.Size = new System.Drawing.Size(100, 29);
            this.textBox_AdminId.TabIndex = 0;
            // 
            // label1
            // 
            this.label_Admin.AutoSize = true;
            this.label_Admin.Location = new System.Drawing.Point(31, 31);
            this.label_Admin.Name = "label1";
            this.label_Admin.Size = new System.Drawing.Size(79, 13);
            this.label_Admin.TabIndex = 1;
            this.label_Admin.Text = "请输入用户名";
            // 
            // button1
            // 
            this.button_A2U.Location = new System.Drawing.Point(24, 102);
            this.button_A2U.Name = "button1";
            this.button_A2U.Size = new System.Drawing.Size(100, 33);
            this.button_A2U.TabIndex = 2;
            this.button_A2U.Text = "转换";
            this.button_A2U.UseVisualStyleBackColor = true;
            this.button_A2U.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox_U2A.Controls.Add(this.button_U2A);
            this.groupBox_U2A.Controls.Add(this.label2);
            this.groupBox_U2A.Controls.Add(this.textBox_UserId);
            this.groupBox_U2A.Location = new System.Drawing.Point(12, 187);
            this.groupBox_U2A.Name = "groupBox2";
            this.groupBox_U2A.Size = new System.Drawing.Size(150, 150);
            this.groupBox_U2A.TabIndex = 1;
            this.groupBox_U2A.TabStop = false;
            this.groupBox_U2A.Text = "普通用户 -> 管理员账户";
            // 
            // button2
            // 
            this.button_U2A.Location = new System.Drawing.Point(24, 102);
            this.button_U2A.Name = "button2";
            this.button_U2A.Size = new System.Drawing.Size(100, 33);
            this.button_U2A.TabIndex = 2;
            this.button_U2A.Text = "转换";
            this.button_U2A.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入用户名";
            // 
            // textBox2
            // 
            this.textBox_UserId.Location = new System.Drawing.Point(24, 58);
            this.textBox_UserId.Multiline = true;
            this.textBox_UserId.Name = "textBox2";
            this.textBox_UserId.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserId.TabIndex = 0;
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.groupBox_U2A);
            this.Controls.Add(this.groupBox_A2U);
            this.Name = "UsersManagement";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UsersManagement_Load);
            this.groupBox_A2U.ResumeLayout(false);
            this.groupBox_A2U.PerformLayout();
            this.groupBox_U2A.ResumeLayout(false);
            this.groupBox_U2A.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_A2U;
        private System.Windows.Forms.Button button_A2U;
        private System.Windows.Forms.Label label_Admin;
        private System.Windows.Forms.TextBox textBox_AdminId;
        private System.Windows.Forms.GroupBox groupBox_U2A;
        private System.Windows.Forms.Button button_U2A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserId;
    }
}