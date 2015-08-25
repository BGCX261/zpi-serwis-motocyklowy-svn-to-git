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
    public partial class baza : Form
    {
        public baza()
        {
            InitializeComponent();
        }

        private void baza_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM naprawy";
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

        private int getEmployeeWorkTime(int ID)
        {
            int result = 0;
            string query = "SELECT SUM(czas_pr) AS result FROM naprawy WHERE ID_serwisanta = " + ID.ToString();
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) result = (int) dr["result"];
            dr.Close();
            connection.Close();
            return result;
        }//czas pracy pracownika

        private List<string> getCustomerInfo(string DATA, bool SELECT)
        {
            List<string> result = new List<string>();
            string query = "";
            if (SELECT) query = "SELECT DISTINCT klienci.imie, klienci.nazwisko, klienci.numer_kontakt, klienci.adres FROM klienci " +
                           "JOIN naprawy ON klienci.ID = naprawy.ID_klienta " +
                           "WHERE VIN = " + "'" + DATA + "'";
            else query = "SELECT imie, numer_kontakt, adres FROM klienci WHERE nazwisko = " + "'" + DATA + "'";
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result.Add(dr["imie"].ToString());
                result.Add(dr["nazwisko"].ToString());
                result.Add(dr["numer_kontakt"].ToString());
                result.Add(dr["adres"].ToString());
            }
            dr.Close();
            connection.Close();
            return result;
        }//wyszukiwanie informacji dotyczących klienta

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked) MessageBox.Show("Nie wybrano typu wyszukiwania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<string> result;
                string show = "";
                if (radioButton1.Checked)
                {
                    result = getCustomerInfo(textBox1.Text, true);
                    if (result.Count == 0) MessageBox.Show("Brak danych");
                    else
                    {
                        for (int i = 0; i < result.Count; i++) show += result + "  ";
                        MessageBox.Show(show, "Informacje o kliencie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton2.Checked)
                {
                    result = getCustomerInfo(textBox1.Text, false);
                    if (result.Count == 0) MessageBox.Show("Brak danych");
                    else
                    {
                        for (int i = 0; i < result.Count; i++) if (i == 1) show += textBox1.Text + "  "; else show += result + "  ";
                        MessageBox.Show(show, "Informacje o kliencie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }
    }
}
