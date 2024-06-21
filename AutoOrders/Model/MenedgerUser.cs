using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders.Model
{
    public class MenedgerUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<MenedgerUser> GetMenedgers()
        {
            var result = new List<MenedgerUser>();
            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    " SELECT " +
                    "   id, " +
                    "   CONCAT(lastname, ' ',name, ' ',midname) as FullName" +
                    " FROM users WHERE id_role = 2 ", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new MenedgerUser
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
