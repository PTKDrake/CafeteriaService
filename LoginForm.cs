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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            if (username.Length > 0 && password.Length > 0)
            {
                if (Program.UserController.Login(username, password))
                {
                    this.Hide();
                    Program.ManagerForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập", "Thông tin đăng nhập sai",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
