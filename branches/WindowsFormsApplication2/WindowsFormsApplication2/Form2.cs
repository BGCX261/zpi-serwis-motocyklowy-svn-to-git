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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Bind();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
        }

        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;

        public void Bind()
        {
            mySqlConnection = new MySqlConnection(
                "SERVER=localhost;" +
                "DATABASE=baza;" +
                "UID=root;");
            mySqlConnection.Open();

            string query = "SELECT * FROM cennik";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView3.DataSource = bindingSource;
        }

        public DataRowCollection Rows
        {
            get { return dataTable.Rows; }
        }

        public void Save()
        {
            mySqlDataAdapter.ContinueUpdateOnError = true;
            mySqlDataAdapter.Update(dataTable);
        }
    }
}
