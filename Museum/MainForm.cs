using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm register = new RegistrForm();
            register.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int location = 1;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `exhibits` WHERE `locationid` = @l", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = location;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            MessageBox.Show("Экспонатов в зале: " + table.Rows.Count.ToString(), "Отчет");
        }

        private void buttonItemReport_Click(object sender, EventArgs e)
        {
            AuthorReport report = new AuthorReport();
            report.Show();
        }

        private void buttonAuthorReport_Click(object sender, EventArgs e)
        {
            ExhibitionReport report = new ExhibitionReport();
            report.Show();
        }
    }
}
