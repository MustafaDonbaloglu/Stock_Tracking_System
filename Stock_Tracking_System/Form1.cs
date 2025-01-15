using Microsoft.Data.SqlClient;
using System.Data;

namespace Stock_Tracking_System
{
    public partial class Form1 : Form
    {
        // Veritaban� ba�lant� dizesi
        private readonly string connectionString = "Data Source=Abra;Initial Catalog=StokDB; Integrated Security=True; TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
            StokListele();
        }

        private void StokListele()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Urunler", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritaban� ba�lant� hatas�: {ex.Message}");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtMiktar.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, Miktar, Fiyat) VALUES (@UrunAdi, @Miktar, @Fiyat)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                        cmd.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
                        cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("�r�n ba�ar�yla eklendi.");
                StokListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunID.Text))
            {
                MessageBox.Show("L�tfen g�ncellenecek �r�n� se�in!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Urunler SET UrunAdi = @UrunAdi, Miktar = @Miktar, Fiyat = @Fiyat WHERE UrunID = @UrunID", conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                        cmd.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
                        cmd.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));
                        cmd.Parameters.AddWithValue("@UrunID", int.Parse(txtUrunID.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("�r�n ba�ar�yla g�ncellendi.");
                StokListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunID.Text))
            {
                MessageBox.Show("L�tfen silinecek �r�n� se�in!");
                return;
            }

            if (MessageBox.Show("Bu �r�n� silmek istedi�inizden emin misiniz?", "Silme Onay�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE UrunID = @UrunID", conn))
                        {
                            cmd.Parameters.AddWithValue("@UrunID", int.Parse(txtUrunID.Text));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("�r�n ba�ar�yla silindi.");
                    StokListele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata olu�tu: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtUrunID.Text = row.Cells["UrunID"].Value?.ToString();
                txtUrunAdi.Text = row.Cells["UrunAdi"].Value?.ToString();
                txtMiktar.Text = row.Cells["Miktar"].Value?.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value?.ToString();
            }
        }

        private void Temizle()
        {
            txtUrunID.Clear();
            txtUrunAdi.Clear();
            txtMiktar.Clear();
            txtFiyat.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUrunID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}