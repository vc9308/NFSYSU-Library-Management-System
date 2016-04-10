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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_UrName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string id = textBox_UrName.Text;
            string psw = textBox_Psw.Text;
            bool access = false;

            if(id == "" && psw == "")
            {
                MessageBox.Show("请输入用户名和密码");
            }
            else if(id == "")
            {
                MessageBox.Show("请输入用户名");
            }
            else if(psw == "")
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                LoginDAL login = new LoginDAL();

                if (radioBtn_Admin.Checked)
                {
                    login.Login4Admin(id, psw, ref access);
                    if (access)
                    {
                        ManageChoice newForm = new ManageChoice();
                        newForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("您输入的用户名或密码可能有误");
                    }
                }
                else
                {
                    login.Login4User(id, psw, ref access);
                    if (access)
                    {
                        Users newForm = new Users();
                        newForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("您输入的用户名或密码可能有误");
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtn_User_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            radioBtn_User.Select();
        }

        private void textBox_Psw_TextChanged(object sender, EventArgs e)
        {
            textBox_Psw.PasswordChar = '*';
        }
    }
}
