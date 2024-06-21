using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Salon> GetSalons()
        {
            var result = new List<Salon>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, name FROM salons", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Salon
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            return result;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
