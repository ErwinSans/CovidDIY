using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    /// <remarks>PageMenu berfungsi untuk serach data covid per-kabupaten</remarks>
    public partial class PageMenu : Form
    {

        /// <summary>
        /// Form Search
        /// </summary>
        /// <remarks>Form Search berfungsi untuk serach data covid per-kabupaten</remarks>
        
        // Connection String untuk konek ke database sql server
        string cs = "data source= DESKTOP-07IPCUO;database=COVID19;MultipleActiveResultSets=True;User ID=sa;Password=erwinS12";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        /// <summary>
        /// Konstruktor default
        /// </summary>
        public PageMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// frmSearch_Load untuk mencari data didalam database COVID19
        /// </summary> 
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        /// <param name="con">berfungsi untuk membuka dan menutup akses database COVID19</param>
        /// <param name="dt">berfungsi untuk menampilkan data hasil pencarian</param>
        private void frmSearch_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from COVID19", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        /// <summary>
        /// texBox1 digunakan untuk memasukan kata kunci pencarian 
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        /// /// <param name="con">berfungsi untuk membuka dan menutup akses database COVID19</param>
        /// <param name="dt">berfungsi untuk menampilkan data hasil pencarian</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from COVID19 where Kabupaten like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void PageMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID19DataSet.COVID19' table. You can move, or remove it, as needed.
            this.cOVID19TableAdapter.Fill(this.cOVID19DataSet.COVID19);

        }

        /// <summary>
        /// Button Back berfungsi untuk pindah ke Page2
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menuForm = new Page2();
            menuForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
