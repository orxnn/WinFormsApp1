using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Login düyməsi üçün
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfən, bütün xanaları doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Giriş uğurludur!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menuform menu = new Menuform();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-poçt/nömrə və ya kod yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear düyməsi üçün
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        // Exit düyməsi üçün
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}