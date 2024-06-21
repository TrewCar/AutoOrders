using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class ModelCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<ModelCar> GetModels(int id_brand)
        {
            var result = new List<ModelCar>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, name FROM model WHERE brand_id = @brandID", connection);
                command.Parameters.AddWithValue("brandID", id_brand);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new ModelCar
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
