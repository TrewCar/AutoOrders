using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class BrandCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<BrandCar> GetBrands()
        {
            var result = new List<BrandCar>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT id, name FROM brand", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new BrandCar
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
