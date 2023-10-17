using Museum;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }


        private void RegistrForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Accaunt_MouseEnter(object sender, EventArgs e)
        {
            Accaunt.ForeColor = Color.Goldenrod;
        }

        private void Accaunt_MouseLeave(object sender, EventArgs e)
        {
            Accaunt.ForeColor = Color.White;
        }

        private void Accaunt_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm register = new MainForm();
            register.Show();
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите название")
            {
                nameField.Text = string.Empty;
                nameField.ForeColor = Color.White;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameField.Text) || string.IsNullOrEmpty(nameField.Text))
            {
                nameField.Text = "Введите название";
                nameField.ForeColor = Color.DarkRed;
            }
        }

        private void authorField_Enter(object sender, EventArgs e)
        {
            if (authorField.Text == "Введите имя автора")
            {
                authorField.Text = string.Empty;
                authorField.ForeColor = Color.White;
            }
        }

        private void authorField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorField.Text) || string.IsNullOrEmpty(authorField.Text))
            {
                authorField.Text = "Введите имя автора";
                authorField.ForeColor = Color.DarkRed;
            }
        }

        private void yearField_Enter(object sender, EventArgs e)
        {
            if (yearField.Text == "Введите год")
            {
                yearField.Text = string.Empty;
                yearField.ForeColor = Color.White;
            }
        }

        private void yearField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yearField.Text) || string.IsNullOrEmpty(yearField.Text) || !yearField.Text.All(c => char.IsDigit(c)))
            {
                yearField.Text = "Введите год";
                yearField.ForeColor = Color.DarkRed;
            }
        }

        private void locationSwitch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationSwitch.Text) || string.IsNullOrEmpty(locationSwitch.Text))
            {
                locationSwitch.Text = "Выбирите расположение";
                locationSwitch.ForeColor = Color.DarkRed;
            }
        }
        private void locationSwitch_Enter(object sender, EventArgs e)
        {
            if (locationSwitch.Text == "Выбирите расположение")
            {
                locationSwitch.Text = string.Empty;
                locationSwitch.ForeColor = Color.White;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите название"
                || authorField.Text == "Введите имя автора"
                || yearField.Text == "Введите год"
                || locationSwitch.Text == "Выберите расположение")
            {
                MessageBox.Show("Empty data");
                return;
            }

            if (checkItem())
                return;
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `exhibits` (`name`, `authorid`, `year`, `locationid`) VALUES (@uN, @uA, @uY, @uL)", db.getConnection());

            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@uA", MySqlDbType.VarChar).Value = CheckAuthorId();
            command.Parameters.Add("@uY", MySqlDbType.VarChar).Value = yearField.Text;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = CheckLocationId();

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Sucsess");
            else
                MessageBox.Show("Alert");

            db.CloseConnection();

            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        public Boolean checkItem() 
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `exhibits` WHERE `name` = @uN", db.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот экспонат уже в базе");
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string CheckAuthorId()
        {

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `authors` WHERE `name` = @uN", db.getConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = authorField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {               
                return table.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                MySqlCommand commandAdd = new MySqlCommand("INSERT INTO `authors` (`name`) VALUES (@u)", db.getConnection());
                commandAdd.Parameters.Add("@u", MySqlDbType.VarChar).Value = authorField.Text;
                adapter.SelectCommand = commandAdd;
                adapter.Fill(table);
                return CheckAuthorId();
            }
        }

        public string CheckLocationId()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `locations` WHERE `location` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = locationSwitch.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            return table.Rows[0].ItemArray[0].ToString();
        }
    }


}
