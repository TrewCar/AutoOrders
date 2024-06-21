using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoOrders
{
    public partial class ListOrders : Form
    {
        public ListOrders()
        {
            InitializeComponent();
            LoadOrders();
        }
        private void LoadOrders()
        {
            string where = string.Empty;
            if (!string.IsNullOrEmpty(textBoxIdOrder.Text))
            {
                where += " WHERE o.id = " + textBoxIdOrder.Text;
            }

            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "SELECT  " +
                    "    o.id AS \"ID\", " +
                    "    CONCAT(COALESCE(o.typeVizit, ''), ' ', TO_CHAR(o.date, 'HH24:MI DD-MM-YYYY')) AS \"Обращение\", " +
                    "    stat.name as \"Статус\", " +
                    "    CONCAT(COALESCE(o.brend, ''), ' ', COALESCE(o.model, ''), ' ', COALESCE(o.color, '')) AS \"Автомобиль\", " +
                    "    CONCAT(u.lastname, ' ', u.name, ' ', COALESCE(u.midname, '')) AS \"Клиент\", " +
                    "    COALESCE(o.how_found, '') AS \"Источник\", " +
                    "    CONCAT(COALESCE(s.name, ''), ' \\ ', CONCAT(COALESCE(os.lastname, ''), ' ', COALESCE(os.name, ''), ' ', COALESCE(os.midname, ''))) AS \"Автосалон \\ менеджер\", " +
                    "    CONCAT(a.lastname, ' ', a.name, ' ', COALESCE(a.midname, '')) AS \"Администратор\" " +
                    "FROM orders o " +
                    "LEFT JOIN client u ON o.id_client = u.id " +
                    "LEFT JOIN users os ON o.id_menedger = os.id " +
                    "LEFT JOIN users a ON o.id_admin = a.id " +
                    "LEFT JOIN salons s ON o.id_salon = s.id " +
                    "LEFT JOIN status stat ON o.status = stat.id " +
                   $"{where} " +
                    "ORDER BY o.id desc; ",
                    connection);
                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewOrders.DataSource = dataTable;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxIdOrder.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxIdOrder.Text = textBoxIdOrder.Text.Remove(textBoxIdOrder.Text.Length - 1);
            }
        }

        private void ButtonDrawDataGrid_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
