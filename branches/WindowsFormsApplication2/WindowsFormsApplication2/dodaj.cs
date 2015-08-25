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
    public partial class dodaj : Form
    {
        string log;
        string pass;
        DateTime OC;
        int ID = 100;

        public dodaj(string login, string password)
        {
            log = login;
            pass = password;
            InitializeComponent();
        }

        private void dodaj_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            DBConnect baza = new DBConnect(log, pass);
            DateTime data_czas_teraz = DateTime.Now;
            DateTime data = data_czas_teraz.Date;
            TimeSpan czas = data_czas_teraz.TimeOfDay;
            baza.Insert_Praca(ID, vin_BX.Text, marka_BX.Text, model_BX.Text, int.Parse(rocznik_BX.Text), teroc_BX.Text, data, czas, opis_BX.Text, int.Parse(IDklient_BX.Text), int.Parse(IDserw_BX.Text));
            MessageBox.Show("Dodano wpis do bazy danych");
            ID++;
        }

        private void terbad_BX_Click(object sender, EventArgs e)
        {
      
        }

        public void monthCalendar1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        public void teroc_BX_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar2_MouseUp(object sender, MouseEventArgs e)
        {
            switch (monthCalendar2.HitTest(e.Location).HitArea)
            {
                case MonthCalendar.HitArea.Date: break;
                case MonthCalendar.HitArea.NextMonthDate: break;
                case MonthCalendar.HitArea.PrevMonthDate: break;
                default: return;
            }
            teroc_BX.Text = monthCalendar2.SelectionStart.ToShortDateString();
            OC = monthCalendar2.SelectionStart;
            monthCalendar2.Visible = false;
        }



        private void datazak_BX_Click(object sender, EventArgs e)
        {
           
        }

        private void monthCalendar5_MouseUp(object sender, MouseEventArgs e)
        {

        }


    }
}
