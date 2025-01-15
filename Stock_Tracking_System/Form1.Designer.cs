using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stock_Tracking_System
{
    partial class Form1 : Form  // Form sınıfından kalıtım aldığından emin olun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUrunID = new TextBox();
            txtUrunAdi = new TextBox();
            txtMiktar = new TextBox();
            txtFiyat = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUrunID);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtUrunID
            // 
            resources.ApplyResources(txtUrunID, "txtUrunID");
            txtUrunID.Name = "txtUrunID";
            txtUrunID.ReadOnly = true;
            txtUrunID.TextChanged += txtUrunID_TextChanged;
            // 
            // txtUrunAdi
            // 
            resources.ApplyResources(txtUrunAdi, "txtUrunAdi");
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.TextChanged += txtUrunAdi_TextChanged;
            // 
            // txtMiktar
            // 
            resources.ApplyResources(txtMiktar, "txtMiktar");
            txtMiktar.Name = "txtMiktar";
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtFiyat
            // 
            resources.ApplyResources(txtFiyat, "txtFiyat");
            txtFiyat.Name = "txtFiyat";
            // 
            // btnEkle
            // 
            resources.ApplyResources(btnEkle, "btnEkle");
            btnEkle.Name = "btnEkle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            resources.ApplyResources(btnGuncelle, "btnGuncelle");
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            resources.ApplyResources(btnSil, "btnSil");
            btnSil.Name = "btnSil";
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            ((ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}