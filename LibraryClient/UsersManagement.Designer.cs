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
            this.components = new System.ComponentModel.Container();
            this.groupBox_A2U = new System.Windows.Forms.GroupBox();
            this.button_A2U = new System.Windows.Forms.Button();
            this.label_Admin = new System.Windows.Forms.Label();
            this.textBox_AdminId = new System.Windows.Forms.TextBox();
            this.groupBox_U2A = new System.Windows.Forms.GroupBox();
            this.button_U2A = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserId = new System.Windows.Forms.TextBox();
            this.groupBox_delUser = new System.Windows.Forms.GroupBox();
            this.btn_DelUser = new System.Windows.Forms.Button();
            this.textBox_DelId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_AddUser = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.textBox_AddFullName = new System.Windows.Forms.TextBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.textBox_AddPsw = new System.Windows.Forms.TextBox();
            this.textBox_AddUserName = new System.Windows.Forms.TextBox();
            this.label_AddPsw = new System.Windows.Forms.Label();
            this.label_AddUserName = new System.Windows.Forms.Label();
            this.dataGridView_Admins = new System.Windows.Forms.DataGridView();
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPswDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagerDataSet_Admins = new LibraryClient.LibraryManagerDataSet_Admins();
            this.adminsTableAdapter = new LibraryClient.LibraryManagerDataSet_AdminsTableAdapters.AdminsTableAdapter();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPswDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagerDataSet_Users = new LibraryClient.LibraryManagerDataSet_Users();
            this.usersTableAdapter = new LibraryClient.LibraryManagerDataSet_UsersTableAdapters.UsersTableAdapter();
            this.groupBox_A2U.SuspendLayout();
            this.groupBox_U2A.SuspendLayout();
            this.groupBox_delUser.SuspendLayout();
            this.groupBox_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_A2U
            // 
            this.groupBox_A2U.Controls.Add(this.button_A2U);
            this.groupBox_A2U.Controls.Add(this.label_Admin);
            this.groupBox_A2U.Controls.Add(this.textBox_AdminId);
            this.groupBox_A2U.Location = new System.Drawing.Point(12, 12);
            this.groupBox_A2U.Name = "groupBox_A2U";
            this.groupBox_A2U.Size = new System.Drawing.Size(150, 150);
            this.groupBox_A2U.TabIndex = 0;
            this.groupBox_A2U.TabStop = false;
            this.groupBox_A2U.Text = "管理员用户 -> 普通账户";
            // 
            // button_A2U
            // 
            this.button_A2U.Location = new System.Drawing.Point(24, 102);
            this.button_A2U.Name = "button_A2U";
            this.button_A2U.Size = new System.Drawing.Size(100, 33);
            this.button_A2U.TabIndex = 2;
            this.button_A2U.Text = "转换";
            this.button_A2U.UseVisualStyleBackColor = true;
            this.button_A2U.Click += new System.EventHandler(this.button_A2U_Click);
            // 
            // label_Admin
            // 
            this.label_Admin.AutoSize = true;
            this.label_Admin.Location = new System.Drawing.Point(31, 31);
            this.label_Admin.Name = "label_Admin";
            this.label_Admin.Size = new System.Drawing.Size(79, 13);
            this.label_Admin.TabIndex = 1;
            this.label_Admin.Text = "请输入用户名";
            // 
            // textBox_AdminId
            // 
            this.textBox_AdminId.Location = new System.Drawing.Point(24, 58);
            this.textBox_AdminId.Multiline = true;
            this.textBox_AdminId.Name = "textBox_AdminId";
            this.textBox_AdminId.Size = new System.Drawing.Size(100, 29);
            this.textBox_AdminId.TabIndex = 0;
            // 
            // groupBox_U2A
            // 
            this.groupBox_U2A.Controls.Add(this.button_U2A);
            this.groupBox_U2A.Controls.Add(this.label2);
            this.groupBox_U2A.Controls.Add(this.textBox_UserId);
            this.groupBox_U2A.Location = new System.Drawing.Point(12, 187);
            this.groupBox_U2A.Name = "groupBox_U2A";
            this.groupBox_U2A.Size = new System.Drawing.Size(150, 150);
            this.groupBox_U2A.TabIndex = 1;
            this.groupBox_U2A.TabStop = false;
            this.groupBox_U2A.Text = "普通用户 -> 管理员账户";
            // 
            // button_U2A
            // 
            this.button_U2A.Location = new System.Drawing.Point(24, 102);
            this.button_U2A.Name = "button_U2A";
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
            // textBox_UserId
            // 
            this.textBox_UserId.Location = new System.Drawing.Point(24, 58);
            this.textBox_UserId.Multiline = true;
            this.textBox_UserId.Name = "textBox_UserId";
            this.textBox_UserId.Size = new System.Drawing.Size(100, 29);
            this.textBox_UserId.TabIndex = 0;
            // 
            // groupBox_delUser
            // 
            this.groupBox_delUser.Controls.Add(this.btn_DelUser);
            this.groupBox_delUser.Controls.Add(this.textBox_DelId);
            this.groupBox_delUser.Controls.Add(this.label1);
            this.groupBox_delUser.Location = new System.Drawing.Point(13, 352);
            this.groupBox_delUser.Name = "groupBox_delUser";
            this.groupBox_delUser.Size = new System.Drawing.Size(149, 150);
            this.groupBox_delUser.TabIndex = 2;
            this.groupBox_delUser.TabStop = false;
            this.groupBox_delUser.Text = "删除用户";
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.Location = new System.Drawing.Point(23, 102);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.Size = new System.Drawing.Size(100, 33);
            this.btn_DelUser.TabIndex = 4;
            this.btn_DelUser.Text = "删除";
            this.btn_DelUser.UseVisualStyleBackColor = true;
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click);
            // 
            // textBox_DelId
            // 
            this.textBox_DelId.Location = new System.Drawing.Point(23, 54);
            this.textBox_DelId.Multiline = true;
            this.textBox_DelId.Name = "textBox_DelId";
            this.textBox_DelId.Size = new System.Drawing.Size(100, 29);
            this.textBox_DelId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入用户名";
            // 
            // groupBox_AddUser
            // 
            this.groupBox_AddUser.Controls.Add(this.btn_Add);
            this.groupBox_AddUser.Controls.Add(this.textBox_AddFullName);
            this.groupBox_AddUser.Controls.Add(this.label_FullName);
            this.groupBox_AddUser.Controls.Add(this.textBox_AddPsw);
            this.groupBox_AddUser.Controls.Add(this.textBox_AddUserName);
            this.groupBox_AddUser.Controls.Add(this.label_AddPsw);
            this.groupBox_AddUser.Controls.Add(this.label_AddUserName);
            this.groupBox_AddUser.Location = new System.Drawing.Point(184, 12);
            this.groupBox_AddUser.Name = "groupBox_AddUser";
            this.groupBox_AddUser.Size = new System.Drawing.Size(386, 150);
            this.groupBox_AddUser.TabIndex = 3;
            this.groupBox_AddUser.TabStop = false;
            this.groupBox_AddUser.Text = "添加账号";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(150, 102);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 33);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // textBox_AddFullName
            // 
            this.textBox_AddFullName.Location = new System.Drawing.Point(75, 65);
            this.textBox_AddFullName.Name = "textBox_AddFullName";
            this.textBox_AddFullName.Size = new System.Drawing.Size(112, 20);
            this.textBox_AddFullName.TabIndex = 5;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(26, 68);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(31, 13);
            this.label_FullName.TabIndex = 4;
            this.label_FullName.Text = "姓名";
            // 
            // textBox_AddPsw
            // 
            this.textBox_AddPsw.Location = new System.Drawing.Point(244, 27);
            this.textBox_AddPsw.Name = "textBox_AddPsw";
            this.textBox_AddPsw.Size = new System.Drawing.Size(112, 20);
            this.textBox_AddPsw.TabIndex = 3;
            // 
            // textBox_AddUserName
            // 
            this.textBox_AddUserName.Location = new System.Drawing.Point(75, 27);
            this.textBox_AddUserName.Name = "textBox_AddUserName";
            this.textBox_AddUserName.Size = new System.Drawing.Size(112, 20);
            this.textBox_AddUserName.TabIndex = 2;
            // 
            // label_AddPsw
            // 
            this.label_AddPsw.AutoSize = true;
            this.label_AddPsw.Location = new System.Drawing.Point(207, 30);
            this.label_AddPsw.Name = "label_AddPsw";
            this.label_AddPsw.Size = new System.Drawing.Size(31, 13);
            this.label_AddPsw.TabIndex = 1;
            this.label_AddPsw.Text = "密码";
            // 
            // label_AddUserName
            // 
            this.label_AddUserName.AutoSize = true;
            this.label_AddUserName.Location = new System.Drawing.Point(26, 31);
            this.label_AddUserName.Name = "label_AddUserName";
            this.label_AddUserName.Size = new System.Drawing.Size(43, 13);
            this.label_AddUserName.TabIndex = 0;
            this.label_AddUserName.Text = "用户名";
            // 
            // dataGridView_Admins
            // 
            this.dataGridView_Admins.AutoGenerateColumns = false;
            this.dataGridView_Admins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Admins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIdDataGridViewTextBoxColumn,
            this.adminPswDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridView_Admins.DataSource = this.adminsBindingSource;
            this.dataGridView_Admins.Location = new System.Drawing.Point(184, 187);
            this.dataGridView_Admins.Name = "dataGridView_Admins";
            this.dataGridView_Admins.Size = new System.Drawing.Size(386, 150);
            this.dataGridView_Admins.TabIndex = 4;
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            // 
            // adminPswDataGridViewTextBoxColumn
            // 
            this.adminPswDataGridViewTextBoxColumn.DataPropertyName = "AdminPsw";
            this.adminPswDataGridViewTextBoxColumn.HeaderText = "AdminPsw";
            this.adminPswDataGridViewTextBoxColumn.Name = "adminPswDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.libraryManagerDataSet_Admins;
            // 
            // libraryManagerDataSet_Admins
            // 
            this.libraryManagerDataSet_Admins.DataSetName = "LibraryManagerDataSet_Admins";
            this.libraryManagerDataSet_Admins.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AutoGenerateColumns = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userPswDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn1});
            this.dataGridView_Users.DataSource = this.usersBindingSource;
            this.dataGridView_Users.Location = new System.Drawing.Point(184, 352);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(386, 150);
            this.dataGridView_Users.TabIndex = 5;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // userPswDataGridViewTextBoxColumn
            // 
            this.userPswDataGridViewTextBoxColumn.DataPropertyName = "UserPsw";
            this.userPswDataGridViewTextBoxColumn.HeaderText = "UserPsw";
            this.userPswDataGridViewTextBoxColumn.Name = "userPswDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.libraryManagerDataSet_Users;
            // 
            // libraryManagerDataSet_Users
            // 
            this.libraryManagerDataSet_Users.DataSetName = "LibraryManagerDataSet_Users";
            this.libraryManagerDataSet_Users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 515);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.dataGridView_Admins);
            this.Controls.Add(this.groupBox_AddUser);
            this.Controls.Add(this.groupBox_delUser);
            this.Controls.Add(this.groupBox_U2A);
            this.Controls.Add(this.groupBox_A2U);
            this.Name = "UsersManagement";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UsersManagement_Load);
            this.groupBox_A2U.ResumeLayout(false);
            this.groupBox_A2U.PerformLayout();
            this.groupBox_U2A.ResumeLayout(false);
            this.groupBox_U2A.PerformLayout();
            this.groupBox_delUser.ResumeLayout(false);
            this.groupBox_delUser.PerformLayout();
            this.groupBox_AddUser.ResumeLayout(false);
            this.groupBox_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Users)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_delUser;
        private System.Windows.Forms.Button btn_DelUser;
        private System.Windows.Forms.TextBox textBox_DelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_AddUser;
        private System.Windows.Forms.DataGridView dataGridView_Admins;
        private LibraryManagerDataSet_Admins libraryManagerDataSet_Admins;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LibraryManagerDataSet_AdminsTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPswDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private LibraryManagerDataSet_Users libraryManagerDataSet_Users;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibraryManagerDataSet_UsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPswDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox_AddPsw;
        private System.Windows.Forms.TextBox textBox_AddUserName;
        private System.Windows.Forms.Label label_AddPsw;
        private System.Windows.Forms.Label label_AddUserName;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox textBox_AddFullName;
        private System.Windows.Forms.Button btn_Add;
    }
}