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
    public partial class prac : Form
    {
        public prac()
        {
            InitializeComponent();
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            string command = "select User from mysql.user;";
            MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "User";
            connection.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect baza = new DBConnect("admin", "qwerty");
            if (textBox1.Text == null || textBox2.Text == null)
                MessageBox.Show("Wpisz dane");
            else
            {
                string prac = textBox1.Text.Replace(" ", "_");
                baza.Create_User(prac, textBox2.Text);
            }

            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            string command = "select User from mysql.user;";
            MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
                comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "User";
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.Text;

            if (selectedItem == "root" || selectedItem == "pma" || selectedItem == "gosc" || selectedItem == "admin" || selectedItem == "")
            {
                MessageBox.Show("Nie możesz!");
            }
            else
            {
                string pracownik = selectedItem;
                string prac = pracownik.Replace(" ", "_");
                string MyConString = "SERVER=localhost;" +
                    "DATABASE=baza;" +
                    "UID=root;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                connection.Open();
                string query = "DROP USER " + prac + "@localhost;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                string command = "select User from mysql.user;";
                MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "User";
                connection.Close();
            }
        }
    }
}
