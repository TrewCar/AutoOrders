using AutoOrders.Model;
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
using System.Windows.Forms.VisualStyles;

namespace AutoOrders
{
    public partial class SetStateOrders : Form
    {
        public SetStateOrders()
        {
            InitializeComponent();
            LoadOrders();
            comboBoxStatus.Items.AddRange(Status.GetStatuses().ToArray());
        }

        private void LoadOrders()
        {
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "SELECT  " +
                    "	o.id as \"Номер записи\",  " +
                    "   o.date as \"Дата записи\", " +
                    "	o.brend as \"Бренд\",  " +
                    "	o.model as \"Модель\",  " +
                    "	o.color as \"Цвет\",  " +
                    "	CONCAT(u.lastname, ' ',u.name, ' ',u.midname) as \"Заказщик\",   " +
                    "	s.name as \"Статус\" " +
                    "FROM orders o " +
                    "left JOIN status s ON o.status = s.id " +
                    "left join client u on u.id = o.id_client " +
                    "WHERE id_menedger = @idMenedger " +
                    "order by o.id desc",
                    connection);
                command.Parameters.AddWithValue("idMenedger", Session.UserID);
                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewOrders.DataSource = dataTable;
            }
        }
       

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                idOrder.Text = $"{selectedRow.Cells["Номер записи"].Value}";
                client.Text = $"{selectedRow.Cells["Заказщик"].Value}";
                textBoxOrderDetails.Text = $"{selectedRow.Cells["Бренд"].Value} {selectedRow.Cells["Модель"].Value} ({selectedRow.Cells["Цвет"].Value})";
                comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(s => s.Name == (string)selectedRow.Cells["Статус"].Value);
            }
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0 || comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста выберите заявку и/или статус");
                return;
            }

            var selectedRow = dataGridViewOrders.SelectedRows[0];
            var selectedOrderId = (int)selectedRow.Cells["Номер записи"].Value;
            var selectedStatus = (Status)comboBoxStatus.SelectedItem;

            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand("UPDATE orders SET status = @status WHERE id = @id", connection);
                command.Parameters.AddWithValue("status", selectedStatus.Id);
                command.Parameters.AddWithValue("id", selectedOrderId);
                command.ExecuteNonQuery();
                idOrder.Text = "";
                client.Text = "";
                textBoxOrderDetails.Text = "";
            }

            LoadOrders();
            MessageBox.Show("Статус успешно заменен");
        }

    }
}
