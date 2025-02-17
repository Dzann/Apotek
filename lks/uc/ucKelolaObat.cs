﻿using lks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks.uc
{
    public partial class ucKelolaObat : UserControl
    {
        Obat obat = new Obat();
        public ucKelolaObat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucKelolaObat_Load(object sender, EventArgs e)
        {
            clear();
            obat.getData(null, dgObat);
        }

        private void clear()
        {
            txtNamaObat.Clear();
            txtKodeObat.Clear();
            dpExp.Value = DateTime.Now;
            txtJumlah.Clear();
            txtHarga.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJumlah.Text) || String.IsNullOrEmpty(txtHarga.Text))
                {
                    MessageBox.Show("Lengkap Semua Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                obat.nama_obat = txtNamaObat.Text;
                obat.kode_obat = txtKodeObat.Text;
                obat.exp_date = dpExp.Value;
                obat.jumlah = Convert.ToInt64(txtJumlah.Text);
                obat.harga = Convert.ToInt64(txtHarga.Text);
                int n = obat.addData(obat);
                if (n == 0)
                    MessageBox.Show("Data Gagal Disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data Berhasil Disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    obat.getData(null, dgObat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (obat.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJumlah.Text) || String.IsNullOrEmpty(txtHarga.Text))
                {
                    MessageBox.Show("Lengkapi Semua Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                obat.nama_obat = txtNamaObat.Text;
                obat.kode_obat = txtKodeObat.Text;
                obat.exp_date = dpExp.Value;
                obat.jumlah = Convert.ToInt64(txtJumlah.Text);
                obat.harga = Convert.ToInt64(txtHarga.Text);
                int n = obat.editData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obat.id = 0;
                    clear();
                    obat.getData(null, dgObat);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (obat.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = obat.deleteData(obat);
                if(n == 0)
                {
                    MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Data berhasil dihapus", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obat.id = 0;
                    clear();
                    obat.getData(null, dgObat);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                obat.id = Convert.ToInt32(dgObat.Rows[row_index].Cells[0].Value.ToString());
                obat.kode_obat = dgObat.Rows[row_index].Cells[1].Value.ToString();
                obat.nama_obat = dgObat.Rows[row_index].Cells[2].Value.ToString();
                obat.exp_date = Convert.ToDateTime(dgObat.Rows[row_index].Cells[3].Value.ToString());
                obat.jumlah = Convert.ToInt64(dgObat.Rows[row_index].Cells[4].Value.ToString());
                obat.harga = Convert.ToInt64(dgObat.Rows[row_index].Cells[5].Value.ToString());
                txtKodeObat.Text = obat.kode_obat;
                txtNamaObat.Text = obat.nama_obat;
                dpExp.Value = obat.exp_date;
                txtJumlah.Text = obat.jumlah.ToString();
                txtHarga.Text = obat.harga.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            obat.getData(txtFind.Text, dgObat);
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }
        private void Validasi_AngkaTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
    }
}
