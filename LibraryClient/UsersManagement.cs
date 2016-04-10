using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDAL;

namespace LibraryClient
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();
        }

        private void button_A2U_Click(object sender, EventArgs e)
        {
            string id = textBox_AdminId.Text;
            User2Admin u2a = new User2Admin(id);
            textBox_AdminId.Text = "";
        }

        private void UsersManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagerDataSet_Users.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libraryManagerDataSet_Users.Users);
            // TODO: This line of code loads data into the 'libraryManagerDataSet_Admins.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryManagerDataSet_Admins.Admins);

        }

        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            string id = textBox_DelId.Text;
            UsersDAL.Del(id);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string userId = textBox_AddUserId.Text;
            string psw = textBox_AddPsw.Text;
            string fName = textBox_AddFullName.Text;

            if (userId == "" || psw == "" || fName == "")
            {
                string warning1 = "", warning2 = "", warning3 = "";
                if (userId == "")
                {
                    warning1 = "用户名 ";
                }
                if (psw == "")
                {
                    warning2 = "密码 ";
                }
                if (fName == "")
                {
                    warning3 = "姓名 ";
                }
                string warning = string.Format("请输入{0}{1}{2}", warning1, warning2, warning3);
                MessageBox.Show(warning);
            }
            else
            {
                UsersDAL.Create(userId, psw, fName);
                textBox_AddFullName.Text = string.Empty;
                textBox_AddUserId.Text = string.Empty;
                textBox_AddPsw.Text = string.Empty;
            }
        }

        private void button_U2A_Click(object sender, EventArgs e)
        {
            string id = textBox_UserId.Text;
            User2Admin u2a = new User2Admin(id);
            textBox_UserId.Text = "";
        }
    }
}
