using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class pracownik : Form
    {
        public pracownik()
        {
            InitializeComponent();
        }

        public pracownik(int id)
        {
            InitializeComponent();
            string MyConString = "SERVER=localhost;" +
                   "DATABASE=baza;" +
                   "UID=root;";
            string query = "SELECT * FROM pracownicy WHERE ID=" + id;
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            textBox1.Text = (string)dt.Rows[0][3];
            textBox2.Text = (string)dt.Rows[0][4];
            query = "SELECT * FROM naprawy WHERE ID_serwisanta=" + id;
            connection = new MySqlConnection(MyConString);           
            da = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            query = "SELECT SUM(czas_pr) FROM naprawy WHERE ID_serwisanta=" + id;
            connection = new MySqlConnection(MyConString);
            da = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            da.Fill(dt);
            textBox3.Text = dt.Rows[0][0].ToString();
            connection.Close();
            this.FormClosed +=pracownik_FormClosed;
        }

        private void pracownik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 pr = new Form3();
            pr.Show(); 
        }
    }
}
