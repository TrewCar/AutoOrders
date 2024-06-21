using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class Client
    {
        public int Id { get; set; } = 0;
        public string Phone { get; set; }
        public bool IsBusinessClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public bool HasPersonalData { get; set; }
        public bool CanSendSMS { get; set; }
        public bool CompletedSurvey { get; set; }

        public void Save()
        {
            if (Id == 0)
            {
                CreateClient();
            }
            else
            {
                UpdateClient();
            }
        }

        private void CreateClient()
        {
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "INSERT INTO client (phone, bisnesClient, lastname, name, midname, email, personal_data, sms_send, complite_opros) " +
                    "VALUES (@phone, @bisnesClient, @lastname, @name, @midname, @email, @personal_data, @sms_send, @complite_opros) " +
                    "RETURNING id",
                    connection);

                command.Parameters.AddWithValue("phone", Phone);
                command.Parameters.AddWithValue("bisnesClient", IsBusinessClient);
                command.Parameters.AddWithValue("lastname", LastName);
                command.Parameters.AddWithValue("name", FirstName);
                command.Parameters.AddWithValue("midname", MiddleName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("email", Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("personal_data", HasPersonalData);
                command.Parameters.AddWithValue("sms_send", CanSendSMS);
                command.Parameters.AddWithValue("complite_opros", CompletedSurvey);

                Id = (int)command.ExecuteScalar();
            }
        }

        private void UpdateClient()
        {
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "UPDATE client SET " +
                    "phone = @phone, " +
                    "bisnesClient = @bisnesClient, " +
                    "lastname = @lastname, " +
                    "name = @name, " +
                    "midname = @midname, " +
                    "email = @email, " +
                    "personal_data = @personal_data, " +
                    "sms_send = @sms_send, " +
                    "complite_opros = @complite_opros " +
                    "WHERE id = @id",
                    connection);

                command.Parameters.AddWithValue("phone", Phone);
                command.Parameters.AddWithValue("bisnesClient", IsBusinessClient);
                command.Parameters.AddWithValue("lastname", LastName);
                command.Parameters.AddWithValue("name", FirstName);
                command.Parameters.AddWithValue("midname", MiddleName ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("email", Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("personal_data", HasPersonalData);
                command.Parameters.AddWithValue("sms_send", CanSendSMS);
                command.Parameters.AddWithValue("complite_opros", CompletedSurvey);
                command.Parameters.AddWithValue("id", Id);

                command.ExecuteNonQuery();
            }
        }

        public static List<Client> GetClientByPhone(string phoneNumber)
        {
            var result = new List<Client>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "SELECT id, phone, bisnesClient, lastname, name, midname, email, personal_data, sms_send, complite_opros " +
                    "FROM client " +
                    "WHERE phone = @phone",
                    connection);
                command.Parameters.AddWithValue("phone", phoneNumber);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Client
                    {
                        Id = reader.GetInt32(0),
                        Phone = reader.GetString(1),
                        IsBusinessClient = reader.GetBoolean(2),
                        LastName = reader.GetString(3),
                        FirstName = reader.GetString(4),
                        MiddleName = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? null : reader.GetString(6),
                        HasPersonalData = reader.GetBoolean(7),
                        CanSendSMS = reader.GetBoolean(8),
                        CompletedSurvey = reader.GetBoolean(9)
                    });
                }
            }
            return result;
        }


        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName ?? ""} ({Phone})";
        }
    }
}
