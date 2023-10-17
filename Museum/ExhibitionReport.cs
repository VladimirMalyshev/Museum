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
    public partial class ExhibitionReport : Form
    {
        public ExhibitionReport()
        {
            InitializeComponent();
            DB db = new DB();
            DataTable table = new DataTable();
            var location = "3";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT authors.name AS 'Автор', " +
                "exhibits.name AS 'Картина', " +
                "year  AS 'Год' FROM `exhibits` " +
                "INNER JOIN `authors` ON exhibits.authorid = authors.id "
                + "WHERE locationid = @l",
                db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = location;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
