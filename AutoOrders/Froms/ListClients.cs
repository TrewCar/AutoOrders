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
    public partial class ListClients : Form
    {
        public ListClients()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "SELECT " +
                    "	id AS \"ID\", " +
                    "	phone AS \"Телефон\", " +
                    "	CASE " +
                    "		WHEN bisnesclient = true THEN 'Бизнес' " +
                    "		ELSE 'Индивидуальный' " +
                    "	END AS \"Тип клиента\", " +
                    "	lastname AS \"Фамилия\",  " +
                    "	name AS \"Имя\",  " +
                    "	midname AS \"Отчество\",  " +
                    "	email AS \"Email\",  " +
                    "	CASE " +
                    "		WHEN personal_data = true THEN 'Да' " +
                    "		ELSE '' " +
                    "	END AS \"Согл. на обработку данных\",  " +
                    "	CASE " +
                    "		WHEN sms_send = true THEN 'Да' " +
                    "		ELSE '' " +
                    "	END AS \"Согл. на рассылку\",  " +
                    "	CASE " +
                    "		WHEN complite_opros = true THEN 'Да' " +
                    "		ELSE '' " +
                    "	END AS \"Согл. на прохождение опросов\" " +
                    "FROM client; ",
                    connection);
                command.Parameters.AddWithValue("idMenedger", Session.UserID);
                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewClients.DataSource = dataTable;
            }
        }
    }
}
