using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_inci_sınıfın_1_İnci_dönemin_ilk_projesi_çiftlik.formlar
{
    public static class Formlar_Arası_Kontrol
    {
        
        public static void FormCagr(Form MevcutForm,Form HedefForm)//Bu Fonksyion Yeni form açmak için yapıldı.
        {
            HedefForm.Show();
            MevcutForm.Hide();
        }
        public static void Efektler(Control kontrolar)
        {
            foreach(Control nesne in kontrolar.Controls) 
            {
                if (nesne is TextBox tb)
                {
                    tb.BackColor = Color.White; // Opak ama sade
                    tb.BorderStyle = BorderStyle.None;
                }
                 if(nesne is Button btn)//burda Buttonları tesbit edip o butonun uzerine gelince renk değişecek çıkınca ana rengine dönecek.
                {
                    btn.MouseHover += (s, e) => btn.BackColor = Color.Green;
                    btn.MouseLeave += (s, e) => btn.BackColor = SystemColors.Control;
                }
                if (nesne is Label lbl)
                {
                    if (lbl.Name == "label2"||lbl.Name=="label4")
                    {
                        lbl.MouseHover += (s, e) => lbl.ForeColor = Color.BlueViolet;

                        lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.Blue;
                    }     
                }

                if (nesne.HasChildren)//burda groupbox yada panel
                {
                    Efektler(nesne); 
                }
            }
        }
        public static void YuvarlatPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnl.Region = new Region(path);
        }
        public static int Kontrıol(Control controlgrup)
        {//Bu fonksiyon boş ama onları tespit edip yazı rengini kırmızıya çeviriyor 
            int hataSayisi = 0;

            foreach (Control k in controlgrup.Controls)
            {
                if (k is TextBox tb)
                {
                  
                    if (string.IsNullOrWhiteSpace(tb.Text) || tb.Text == "Telefon veya e-posta" || tb.Text == "Şifrenizi Girin")
                    {
                        tb.ForeColor = Color.Red;
                        hataSayisi++;
                    }
                   
                }
                else if (k is ComboBox cb)
                {
                    if (cb.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cb.Text))
                    {
                        cb.ForeColor = Color.Red;
                        hataSayisi++;
                    }
                    
                }

                if (k.HasChildren)
                {
                    hataSayisi += Kontrıol(k);
                }
            }

            return hataSayisi;
        }

        public static bool GirdiKontrol(string input)
        {
            // Telefon kontrolü: 11 haneli rakam
            if (Regex.IsMatch(input, @"^\d{11}$"))
            { 
                return true;
            }

            // E-posta kontrolü: @ içermeli ve format uygun olmalı
            if (input.Contains("@") && Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }

            // Hiçbiri değilse özel uyarı
            if (input.All(char.IsDigit))
            {
                MessageBox.Show("Telefon numarası 11 hane olmalı. Şu anki giriş: " + input.Length + " hane.", "Hatalı Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (input.Contains("@"))
            {
                MessageBox.Show("E-posta formatı hatalı. Lütfen '@' ve '.' içeren geçerli bir adres girin.", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası (11 hane) veya e-posta adresi giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }



    }

    }


