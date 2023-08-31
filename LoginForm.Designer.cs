using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace CafeteriaService
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel3 = new Panel();
            loginButton = new ReaLTaiizor.Controls.MaterialButton();
            passwordInput = new ReaLTaiizor.Controls.HopeTextBox();
            usernameInput = new ReaLTaiizor.Controls.HopeTextBox();
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordInput);
            panel1.Controls.Add(usernameInput);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.icon1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(97, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(70, 70);
            panel3.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            loginButton.Location = new Point(100, 314);
            loginButton.Margin = new Padding(4, 6, 4, 6);
            loginButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(64, 36);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = false;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordInput
            // 
            passwordInput.BackColor = Color.Salmon;
            passwordInput.BaseColor = Color.Transparent;
            passwordInput.BorderColorA = Color.DodgerBlue;
            passwordInput.BorderColorB = Color.DarkGray;
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.ForeColor = Color.Gainsboro;
            passwordInput.Hint = "Password";
            passwordInput.Location = new Point(4, 220);
            passwordInput.MaxLength = 50;
            passwordInput.Multiline = false;
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '\0';
            passwordInput.ScrollBars = ScrollBars.None;
            passwordInput.SelectedText = "";
            passwordInput.SelectionLength = 0;
            passwordInput.SelectionStart = 0;
            passwordInput.Size = new Size(256, 38);
            passwordInput.TabIndex = 2;
            passwordInput.TabStop = false;
            passwordInput.Text = "123@123";
            passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameInput
            // 
            usernameInput.BackColor = Color.Salmon;
            usernameInput.BaseColor = Color.Transparent;
            usernameInput.BorderColorA = Color.DodgerBlue;
            usernameInput.BorderColorB = Color.DarkGray;
            usernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.ForeColor = Color.Gainsboro;
            usernameInput.Hint = "Username";
            usernameInput.Location = new Point(4, 161);
            usernameInput.MaxLength = 50;
            usernameInput.Multiline = false;
            usernameInput.Name = "usernameInput";
            usernameInput.PasswordChar = '\0';
            usernameInput.ScrollBars = ScrollBars.None;
            usernameInput.SelectedText = "";
            usernameInput.SelectionLength = 0;
            usernameInput.SelectionStart = 0;
            usernameInput.Size = new Size(256, 38);
            usernameInput.TabIndex = 1;
            usernameInput.TabStop = false;
            usernameInput.Text = "ptkdrake";
            usernameInput.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.login_side;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(nightControlBox1);
            panel2.Location = new Point(264, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 450);
            panel2.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(396, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // parrotFormEllipse1
            // 
            parrotFormEllipse1.CornerRadius = 10;
            parrotFormEllipse1.EffectedForm = this;
            // 
            // parrotFormHandle1
            // 
            parrotFormHandle1.DockAtTop = true;
            parrotFormHandle1.HandleControl = panel2;
            // 
            // parrotFormHandle2
            // 
            parrotFormHandle2.DockAtTop = true;
            parrotFormHandle2.HandleControl = panel1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login Here";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopeTextBox usernameInput;
        private ReaLTaiizor.Controls.MaterialButton loginButton;
        private ReaLTaiizor.Controls.HopeTextBox passwordInput;
        private Panel panel3;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
    }
}