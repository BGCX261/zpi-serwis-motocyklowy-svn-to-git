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
    public partial class Serw : Form
    {
        string log;
        string pass;
        public Serw(string login)
        {
            InitializeComponent();
            label1.Text = "Witaj " + login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 okno = new Form1();
            okno.Show();
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            baza okno = new baza();
            okno.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            dodaj okno = new dodaj(log, pass);
            okno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 okno = new Form4();
            okno.ShowDialog();
        }
    }
}
