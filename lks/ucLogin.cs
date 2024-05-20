using lks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks
{
    public partial class ucLogin : UserControl
    {
        User user = new User();
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username Dan Password Wajib Di Isi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            var status = user.login(user);
            if (status == true)
            {
                this.Hide();
                txtUsername.Clear();
                txtPassword.Clear();
                new frmUtama(LoginSession.tipe).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username Atau Password Salah");
            }
        }
    }
}
