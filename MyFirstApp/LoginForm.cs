using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class LoginForm : Form
    {
        public BindingSource BindingSource { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            BindingSource = new BindingSource();

            this.helpProvider.SetHelpString(this.usernameTextBox, "Enter your username");
            this.helpProvider.SetHelpString(this.passwordTextBox, "Enter your password");
            this.helpProvider.SetHelpString(this.loginButton, "Login to ListPlay");

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if ((BindingSource.DataSource as Database).LoginUser(this.usernameTextBox.Text,
                this.passwordTextBox.Text))
            {


                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                this.errorProvider.SetError(this.usernameTextBox, "Incorrect username/password combination.");
                this.errorProvider.SetError(this.passwordTextBox, "Incorrect username/password combination.");

            }


        }
    }
}
