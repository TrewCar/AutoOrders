using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class ColorCar
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<ColorCar> GetColors()
        {
            var result = new List<ColorCar>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, name FROM color", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new ColorCar
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
