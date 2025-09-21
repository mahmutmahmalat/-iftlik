using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik.formlar
{
    public partial class Form3_hesap_oluştur : Form
    {
        public Form3_hesap_oluştur()
        {
            InitializeComponent();
        }

        private void Form3_hesap_oluştur_Load(object sender, EventArgs e)
        {
            Formlar_Arası_Kontrol.Efektler(this);
            this.BackgroundImage = Image.FromFile("C:\\Users\\m4491\\Desktop\\yeni proje çiftlik\\11'inci sınıfın 1'İnci dönemin ilk projesi çiftlik\\11'inci sınıfın 1'İnci dönemin ilk projesi çiftlik\\resimler\\kayıt.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            Formlar_Arası_Kontrol.YuvarlatPanel(panel1,15);
            Formlar_Arası_Kontrol.YuvarlatPanel(panel2,15);
            Formlar_Arası_Kontrol.YuvarlatPanel(panel3,15);
            Formlar_Arası_Kontrol.YuvarlatPanel(panel4,15);
            label2.Font = new Font(label2.Font, FontStyle.Underline); // Alt çizgi
            label4.Font = new Font(label4.Font, FontStyle.Underline); // Alt çizgi
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Formlar_Arası_Kontrol.FormCagr(this,new Form1_Giris());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.isteasistan.com/Kullanici-Sozlesmesi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

            }
            else { MessageBox.Show("Kullanım sözleşmesini kabul etmelisiniz","uyarı mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "Telefon No") { textBox4.Text = ""; }
            if (textBox4.ForeColor == Color.Red) { textBox4.ForeColor = Color.Black; }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Telefon No";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "e-posta") { textBox1.Text = ""; }
            if (textBox1.ForeColor == Color.Red) { textBox1.ForeColor = Color.Black; }
        }
    }
}
