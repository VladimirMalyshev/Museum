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
    public partial class AuthorReport : Form
    {
        public AuthorReport()
        {
            InitializeComponent();
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT distinct authors.name " +
                "FROM `authors` INNER JOIN `exhibits` ON authors.id = exhibits.authorid",
                db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string author = table.Rows[i].ItemArray[0].ToString();
                AuthorSwich.Items.Add(author); 
            }
        }

        private void AuthorSwich_Leave(object sender, EventArgs e)
        {
            if (AuthorSwich.Text == "Ведите имя автора" 
                || string.IsNullOrWhiteSpace(AuthorSwich.Text)
                || string.IsNullOrEmpty(AuthorSwich.Text))
                return;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `exhibits` WHERE `authorid` = @a", db.getConnection());
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = CheckAuthorId();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public string CheckAuthorId()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `authors` WHERE `name` = @uA", db.getConnection());
            command.Parameters.Add("@uA", MySqlDbType.VarChar).Value = AuthorSwich.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0].ItemArray[0].ToString();
        }
    }
}
