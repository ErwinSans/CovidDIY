using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidDIY
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>Page2 dapat upload image, create, update, search, dan delete data</remarks>
    public partial class Page2 : Form
    {
        /// <summary>
        /// curImage berfungsi untuk memilih gambar 
        /// </summary>
    
        Image curImage;

        /// <summary>
        /// curFileName untuk membuka folder explorer
        /// </summary>
        string curFileName;

        //connectionString untuk menghubungkan ke databse sql server
        //savedImageName untuk menyimpan gambar yang sudah dipilih
        string connectionString = "data source= DESKTOP-07IPCUO;database=COVID19;MultipleActiveResultSets=True;User ID=sa;Password=erwinS12"; //The savedImage will store the path of the image file. //Initialize the variable;
        string savedImageName = "0";

        DataTable dt;
        DataRow dr;
        string code;
        string i;

        /// <summary>
        /// konstruktor default
        /// </summary>
        public Page2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Page2_Load berhubungan dengan database
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void Page2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOVID19DataSet.COVID19' table. You can move, or remove it, as needed.
            this.cOVID19TableAdapter.Fill(this.cOVID19DataSet.COVID19);

        }

        /// <summary>
        /// Button Update berfungsi untuk update data covid
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button2_Click(object sender, EventArgs e)
        {
            ///
            //sql connection
            string sql = "SELECT * FROM COVID19";
            string KABUPATEN = kabupaten.Text.ToString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            //sql connection
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet("COVID19");
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet dataSet = new DataSet("COVID19");

            //column database COVID19
            adapter.Fill(ds, "COVID19");
            DataRow row = ds.Tables["COVID19"].Rows.Find(KABUPATEN);
            row["Suspected"] = suspected.Text;
            row["Exposed"] = exposed.Text;
            row["Infected"] = infected.Text;
            row["Recovered"] = recovered.Text;
            row["Dead"] = dead.Text;
            adapter.Update(ds, "COVID19");
            connection.Close();

            MessageBox.Show("Update data Successful");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Button3 (exit) untuk exit dari tampilan utama
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menuForm = new Form1();
            menuForm.Show();
        }


        /// <summary>
        /// Insert Data
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (kabupaten.Text != "")
            {
                
                //untuk mengakses ke sql server
                FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdata = new byte[file.Length];
                file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                file.Close();
                string sql = "SELECT * FROM COVID19";

                //sql connection
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                //ds untuk mengakses db COVID19 disql
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder cmBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet("COVID19");

                //column database COVID19
                adapter.Fill(ds, "COVID19");
                DataRow row = ds.Tables["COVID19"].NewRow();
                row["Kabupaten"] = kabupaten.Text;
                row["Suspected"] = suspected.Text;
                row["Exposed"] = exposed.Text;
                row["Infected"] = infected.Text;
                row["Recovered"] = recovered.Text;
                row["Dead"] = dead.Text;
                row["Image"] = rawdata;
                ds.Tables["COVID19"].Rows.Add(row);
                adapter.Update(ds, "COVID19");
                connection.Close();
                MessageBox.Show("Insert Successfull");
                this.cOVID19DataSet.Reset();
                this.cOVID19TableAdapter.Fill(this.cOVID19DataSet.COVID19);

            }
        }

        /// <summary>
        /// Input nama kabupaten
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void kabupaten_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button6 (Browse) berfungsi untuk membuka file explorer mencari lokasi gambar logo disimpan
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = openDlg.FileName;
                textBox2.Text = curFileName;
            }
        }

        /// <summary>
        /// Untuk update data
        /// </summary>
        private void updateData()
        {
            try
            {
                this.cOVID19DataSet.Reset();
                this.cOVID19TableAdapter.Fill(this.cOVID19DataSet.COVID19);
            }
            catch (System.Exception ex)
            {

            }
        }

        /// <summary>
        /// konstruktor default
        /// </summary>
        private void initiaLoad()
        {

        }

        /// <summary>
        /// menampilkan logo yang diupload/dipilih sesuai dengan nama kabupaten
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button5 berfungsi untuk delete data
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void button5_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM COVID19";
            string KABUPATEN = kabupaten.Text.ToString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder cmBuilder = new SqlCommandBuilder(adapter);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet("COVID19");

            adapter.Fill(ds, "COVID19");
            DataRow row = ds.Tables["COVID19"].Rows.Find(KABUPATEN);
            row.Delete();
            adapter.Update(ds, "COVID19");

            updateData();
            this.cOVID19DataSet.Reset();
            this.cOVID19TableAdapter.Fill(this.cOVID19DataSet.COVID19);
            connection.Close();
            initiaLoad();

            MessageBox.Show("Delete Successfull");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button4 untuk pindah ke halaman search
        /// </summary>
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menuForm = new PageMenu();
            menuForm.Show();
        }

        /// <summary>
        /// Input jumlah suspected
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void suspected_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Input jumlah exposed
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void exposed_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Input jumlah infected
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void infected_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Input jumlah recovered
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void recovered_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Input jumlah dead 
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void dead_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// menampilan tabel hasil inputan
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Menampilkan lokasi directory logo
        /// </summary>
        /// <param name="sender">paramenter yang berisi referensi kontrol</param>
        /// <param name="e">parameter yang berisi data informasi</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
