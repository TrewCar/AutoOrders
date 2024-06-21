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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginText.Text;
            string password = passText.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both login and password.");
                return;
            }

            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "SELECT u.id, u.id_role, r.name " +
                    "FROM users u " +
                    "JOIN roles r ON u.id_role = r.id " +
                    "WHERE u.login = @login AND u.password = @password",
                    connection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("password", password);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Session.UserID = reader.GetInt32(0);
                        Session.Role = reader.GetInt32(1);
                        Session.RoleName = reader.GetString(2);

                        MessageBox.Show($"Добро пожаловать, {login}! Вы вошли под ролью {Session.RoleName}.");
                        LoginText.Text = "";
                        passText.Text = "";
                        var form = new Main();
                        form.FormClosed += OnFormClosed;
                        form.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
