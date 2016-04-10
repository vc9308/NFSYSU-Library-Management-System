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

            textBox_AddFullName.Text = string.Empty;
            textBox_AddUserName.Text = string.Empty;
            textBox_AddPsw.Text = string.Empty;
        }
    }
}
