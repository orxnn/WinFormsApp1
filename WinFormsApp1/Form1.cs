using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Qeydiyyatdan keçən istifadəçiləri yaddaşda saxlamaq üçün Dictionary
        private static Dictionary<string, string> users = new Dictionary<string, string>();

        // 1. QEYDİYYAT DÜYMƏSİ (Sign in)
        private void button2_Click(object sender, EventArgs e)
        {
            string newUser = textBox4.Text.Trim();
            string newPass = textBox3.Text.Trim();

            // Boş xana yoxlanışı
            if (string.IsNullOrEmpty(newUser) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Xana boş ola bilməz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // İstifadəçinin mövcudluq yoxlanışı
            if (users.ContainsKey(newUser))
            {
                MessageBox.Show("Bu istifadəçi artıq mövcuddur!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Yeni istifadəçini əlavə et
                users.Add(newUser, newPass);
                MessageBox.Show("Uğurla qeydiyyatdan keçdiniz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xanaları təmizlə
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        // 2. GİRİŞ DÜYMƏSİ (Login)
        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = textBox1.Text.Trim();
            string loginPass = textBox2.Text.Trim();

            // Boş xana yoxlanışı
            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(loginPass))
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə boş ola bilməz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Şifrə və istifadəçi adının doğruluğunu yoxlayırıq
            if (users.ContainsKey(loginUser) && users[loginUser] == loginPass)
            {
                MessageBox.Show("Sistemə uğurla daxil oldunuz!", "Xoş gəldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Giriş uğurlu olduqda xanaları təmizləyirik
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
