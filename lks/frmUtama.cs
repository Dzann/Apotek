using lks.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks
{
    public partial class frmUtama : Form
    {
        ucKelolaObat menuObat = new ucKelolaObat();
        ucKelolaResep menuResep = new ucKelolaResep();
        ucKelolaUser menuUser = new ucKelolaUser();
        ucLaporan menuLaporan = new ucLaporan();
        ucLogActivity menuLog = new ucLogActivity();
        ucTransaksi menuTransaksi = new ucTransaksi();
        ucPengaturan menuPengaturan = new ucPengaturan();
        public frmUtama(string tipe)
        {
            InitializeComponent();

            menuObat.Dock = DockStyle.Fill;
            menuResep.Dock = DockStyle.Fill;
            menuUser.Dock = DockStyle.Fill;
            menuLaporan.Dock = DockStyle.Fill;
            menuLog.Dock = DockStyle.Fill;
            menuTransaksi.Dock = DockStyle.Fill;

            // set nama welcome
            labelWelcome.Text = "Selamat Datang, " + LoginSession.nama;
            labelNamaAplikasi.Text = Properties.Settings.Default.namaAplikasi;

            multiAuth(tipe);
        }

        private void multiAuth(string tipe)
        {
            if (tipe != "ADMIN")
                flowLayoutPanel1.Visible = false;
            else
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuLog);
            }

            if (tipe == "APOTEKER")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuResep);
            }
            else if (tipe == "KASIR")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuTransaksi);
            }
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuUser);
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuObat);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLaporan);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLog);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuPengaturan);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CultureInfo ci = new CultureInfo("id-ID");

        private void labelNamaAplikasi_Click(object sender, EventArgs e)
        {

        }
    }
}
    