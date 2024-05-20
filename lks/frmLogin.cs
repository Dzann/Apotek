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
    public partial class frmLogin : Form
    {
        User user = new User();
        public frmLogin()
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
