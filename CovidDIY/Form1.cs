using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CovidDIY
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>form 1 berfungsi untuk login</remarks>
    public partial class Form1 : Form
    {
        //konstruktor default
        /// <summary>
        /// main class
        /// </summary>
        /// <remarks>menampilkan halaman login</remarks>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Label username
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Input Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Input username
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Label password
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Menampilkan logo 
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button1 (login) berfungsi untuk masuk kedalam aplikasi
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        /// <param name = "if" > if berguna untuk konfirmasi username password yg dimasukan benar/salah </param>
        /// <param name = "else" > else berguna untuk konfirmasi username password yg dimasukan benar/salah</param>
        /// jika benar maka langsung masuk kedalam aplikasi, jika salah maka akan muncul pesan error.

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && Password.Text == "1234")
            {
                this.Hide();

                Form menuUtama = new Page2();
                menuUtama.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password " +
                    "(Username:admin || pass:1234)");
                return;
            }
        }

        /// <summary>
        /// Button2 (exit) berfungsi untuk keluar dari app
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
