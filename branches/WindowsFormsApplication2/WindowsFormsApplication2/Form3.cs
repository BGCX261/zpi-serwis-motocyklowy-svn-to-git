using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string query = "SELECT id, imie, nazwisko, data_zatrudnienia FROM pracownicy WHERE data_zwolnienia IS NULL and posada=1";
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            connection.Close();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Szczegóły";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, imie, nazwisko, data_zatrudnienia FROM pracownicy WHERE data_zwolnienia IS NULL and posada=1";
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT imie, nazwisko, data_zatrudnienia FROM pracownicy WHERE data_zwolnienia IS NULL";
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                string query = "SELECT imie, nazwisko, data_zatrudnienia FROM pracownicy WHERE ";
                if (comboBox1.SelectedIndex == 1)
                {
                    query += "imie REGEXP \"";
                }
                else if (comboBox1.SelectedIndex == 0)
                {

                    query += "nazwisko REGEXP \"";
                }
                query += textBox1.Text;
                query += "\"";
                string MyConString = "SERVER=localhost;" +
                    "DATABASE=baza;" +
                    "UID=root2;" +
                    "PASSWORD=qwerty;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView2.DataSource = dt;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null)
                return;
 
                int id = (int)dataGridView.CurrentRow.Cells[1].Value;
                pracownik pr = new pracownik(id);
                pr.Show();
                this.Close();
        }
    }
}
