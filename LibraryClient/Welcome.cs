﻿using System;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.Show();
        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            Books newBooks = new Books();
            newBooks.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin2User a2u = new Admin2User("1111111");
        }
    }
}
