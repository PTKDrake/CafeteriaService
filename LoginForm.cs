using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace CafeteriaService
{
    public partial class LoginForm : CrownForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameInput_Enter(object sender, EventArgs e)
        {
            if (usernameInput.Text == "Username") usernameInput.Text = "";
        }

        private void usernameInput_Leave(object sender, EventArgs e)
        {
            if (usernameInput.Text == "") usernameInput.Text = "Username";
        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
            if (passwordInput.Text == "Password") passwordInput.Text = "";
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            if (passwordInput.Text == "") passwordInput.Text = "Password";
        }
    }
}
