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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prac okno = new prac();
            okno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 okno = new Form1();
            okno.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baza okno = new baza();
            okno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 okno = new Form3();
            okno.Show();
        }

    }
}
