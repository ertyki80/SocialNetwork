using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using SocialNetwork.BusinessLogic.Helpers;
using SocialNetwork.Models;

namespace SocialNetwork.WinFormApp
{
    public partial class Login : MaterialForm
    {
        private Users _currentUser;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"Email";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = @"Password";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == @"Email")
            {
                textBox1.Text = "";

            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == @"Password")
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var authorizeLogic = new AutorizeLogic();
            var userExist = authorizeLogic.Login(textBox1.Text, textBox2.Text);
            if (userExist)
            {
                _currentUser = authorizeLogic.GetUser();
                Console.WriteLine(@"Login successful");
                Console.WriteLine(@"{0} {1} {2}", _currentUser.Name.First, _currentUser.Name.Last, _currentUser.Email);
                this.Close();
            }
        }
    }
}
