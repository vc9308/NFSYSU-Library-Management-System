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

        }

        private void btn_DelUser_Click(object sender, EventArgs e)
        {
            string id = textBox_DelId.Text;
            UsersDAL.Del(id);
        }
    }
}
