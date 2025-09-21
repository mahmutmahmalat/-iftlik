using _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik.formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik
{
    public partial class Form1_Giris : Form
    {
        public Form1_Giris()
        {
            InitializeComponent();   
        }
        

      
        private void Form1_Giris_Load(object sender, EventArgs e)
        {
            Formlar_Arası_Kontrol.Efektler(this);
            this.BackgroundImage = Image.FromFile("C:\\Users\\m4491\\Desktop\\yeni proje çiftlik\\11'inci sınıfın 1'İnci dönemin ilk projesi çiftlik\\11'inci sınıfın 1'İnci dönemin ilk projesi çiftlik\\resimler\\arkaplanlogolu.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.Transparent;
           Formlar_Arası_Kontrol.YuvarlatPanel(panel2, 15); // 15px köşe kırıklığı
            Formlar_Arası_Kontrol.YuvarlatPanel(panel3,15);
            label2.Font = new Font(label2.Font, FontStyle.Underline); // Alt çizgi
            label4.Font = new Font(label4.Font, FontStyle.Underline); // Alt çizgi



        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Telefon veya e-posta") { textBox1.Text = ""; }
            if (textBox1.ForeColor == Color.Red) {  textBox1.ForeColor = Color.Black; }
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Telefon veya e-posta";
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifrenizi Girin") { textBox2.Text = ""; textBox2.PasswordChar = '*'; }
            if (textBox2.ForeColor == Color.Red) { textBox2.ForeColor = Color.Black; }


        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Şifrenizi Girin";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Formlar_Arası_Kontrol.FormCagr(this, new Form2_Şifre_Yada_E_Posta_Kayıp());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Formlar_Arası_Kontrol.Kontrıol(this)>0)
            {
               
                return;
            }
            if (!Formlar_Arası_Kontrol.GirdiKontrol(textBox1.Text))
            {
                return;
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Sağ tıklamayı engelle
                ((TextBox)sender).ContextMenu = new ContextMenu();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.SelectionLength = 0;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                if(textBox2.Text!= "Şifrenizi Girin")
                textBox2.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Formlar_Arası_Kontrol.FormCagr(this, new Form3_hesap_oluştur());
        }
    }
}
