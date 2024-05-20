
namespace lks.uc
{
    partial class ucTransaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipeResep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoResep = new System.Windows.Forms.TextBox();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpTglResep = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.dgKeranjang = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.txtUang = new System.Windows.Forms.TextBox();
            this.btnPrintSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe Resep";
            // 
            // cbxTipeResep
            // 
            this.cbxTipeResep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipeResep.FormattingEnabled = true;
            this.cbxTipeResep.Items.AddRange(new object[] {
            "TANPA RESEP",
            "DENGAN RESEP"});
            this.cbxTipeResep.Location = new System.Drawing.Point(32, 90);
            this.cbxTipeResep.Name = "cbxTipeResep";
            this.cbxTipeResep.Size = new System.Drawing.Size(264, 21);
            this.cbxTipeResep.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Resep";
            // 
            // txtNoResep
            // 
            this.txtNoResep.Location = new System.Drawing.Point(32, 154);
            this.txtNoResep.Name = "txtNoResep";
            this.txtNoResep.Size = new System.Drawing.Size(264, 20);
            this.txtNoResep.TabIndex = 4;
            // 
            // txtNamaDokter
            // 
            this.txtNamaDokter.Location = new System.Drawing.Point(398, 90);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(264, 20);
            this.txtNamaDokter.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Dokter";
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Location = new System.Drawing.Point(398, 154);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(264, 20);
            this.txtNamaObat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama Obat";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(398, 219);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(264, 20);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity";
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Location = new System.Drawing.Point(32, 283);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(264, 20);
            this.txtNamaPasien.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nama Pasien";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tanggal Resep";
            // 
            // dpTglResep
            // 
            this.dpTglResep.Location = new System.Drawing.Point(32, 219);
            this.dpTglResep.Name = "dpTglResep";
            this.dpTglResep.Size = new System.Drawing.Size(264, 20);
            this.dpTglResep.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(32, 327);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(140, 23);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambahkan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(522, 327);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(140, 23);
            this.btnKosongkan.TabIndex = 16;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // dgKeranjang
            // 
            this.dgKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKeranjang.Location = new System.Drawing.Point(32, 357);
            this.dgKeranjang.Name = "dgKeranjang";
            this.dgKeranjang.Size = new System.Drawing.Size(630, 175);
            this.dgKeranjang.TabIndex = 17;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(148, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 18;
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembalian.Location = new System.Drawing.Point(148, 560);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(0, 25);
            this.lblKembalian.TabIndex = 19;
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(32, 585);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(140, 23);
            this.btnBayar.TabIndex = 20;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // txtUang
            // 
            this.txtUang.Location = new System.Drawing.Point(178, 585);
            this.txtUang.Name = "txtUang";
            this.txtUang.Size = new System.Drawing.Size(264, 20);
            this.txtUang.TabIndex = 21;
            // 
            // btnPrintSave
            // 
            this.btnPrintSave.Location = new System.Drawing.Point(522, 582);
            this.btnPrintSave.Name = "btnPrintSave";
            this.btnPrintSave.Size = new System.Drawing.Size(140, 23);
            this.btnPrintSave.TabIndex = 22;
            this.btnPrintSave.Text = "Print  Save";
            this.btnPrintSave.UseVisualStyleBackColor = true;
            this.btnPrintSave.Click += new System.EventHandler(this.btnPrintSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(127, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = ":";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Kembalian";
            // 
            // ucTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPrintSave);
            this.Controls.Add(this.txtUang);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgKeranjang);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dpTglResep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaDokter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoResep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipeResep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucTransaksi";
            this.Size = new System.Drawing.Size(705, 611);
            this.Load += new System.EventHandler(this.ucTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipeResep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoResep;
        private System.Windows.Forms.TextBox txtNamaDokter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpTglResep;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.DataGridView dgKeranjang;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.TextBox txtUang;
        private System.Windows.Forms.Button btnPrintSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
