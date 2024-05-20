
namespace lks.uc
{
    partial class ucPengaturan
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
            this.txtNamaAplikasi = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnSImpan = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengaturan Aplikasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Toko / Aplikasi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNamaAplikasi
            // 
            this.txtNamaAplikasi.Location = new System.Drawing.Point(21, 98);
            this.txtNamaAplikasi.Name = "txtNamaAplikasi";
            this.txtNamaAplikasi.Size = new System.Drawing.Size(273, 20);
            this.txtNamaAplikasi.TabIndex = 3;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(21, 161);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(273, 20);
            this.txtLat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lat";
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(328, 161);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(275, 20);
            this.txtLng.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lng";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGo.Location = new System.Drawing.Point(609, 161);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnSImpan
            // 
            this.btnSImpan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSImpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSImpan.Location = new System.Drawing.Point(21, 539);
            this.btnSImpan.Name = "btnSImpan";
            this.btnSImpan.Size = new System.Drawing.Size(180, 52);
            this.btnSImpan.TabIndex = 9;
            this.btnSImpan.Text = "SIMPAN";
            this.btnSImpan.UseVisualStyleBackColor = false;
            this.btnSImpan.Click += new System.EventHandler(this.btnSImpan_Click);
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Red;
            this.panelMap.Location = new System.Drawing.Point(21, 200);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(663, 333);
            this.panelMap.TabIndex = 10;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ucPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnSImpan);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaAplikasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucPengaturan";
            this.Size = new System.Drawing.Size(705, 611);
            this.Load += new System.EventHandler(this.ucPengaturan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaAplikasi;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnSImpan;
        private System.Windows.Forms.Panel panelMap;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
