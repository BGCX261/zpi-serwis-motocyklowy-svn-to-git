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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string login = loginBX.Text;
            string password = passBX.Text;
            string MyConString = "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            string command = "select ID, posada from pracownicy where login='" + login + "' and haslo='" + password + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][1]) == 1)
                {
                    Serw serw = new Serw(login);                   
                    serw.Show();
                    this.Hide();
                }
                else
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
