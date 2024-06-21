using Npgsql;
using System;

namespace AutoOrders.Model
{
    public class Order
    {
        public int Id;
        public DateTime date;

        public Status status;

        public Salon Salon;
        public MenedgerUser Menedger;

        public string TypeVizit;
        public string How_found;

        public BrandCar BrandCar;
        public ModelCar ModelCar;
        public ColorCar ColorCar;

        public Client Client;

        public void Create()
        {
            Client.Save();

            using (var connection = new NpgsqlConnection(ConfigDB.CON_STR))
            {
                connection.Open();
                var command = new NpgsqlCommand(
                    "INSERT INTO orders(id_salon, id_admin, id_client, id_menedger, how_found, typevizit, brend, model, color) " +
                    "VALUES (@salon, @admin, @client, @menedger, @how_found, @typeVizit, @brend, @model, @color) " +
                    "RETURNING id",
                    connection);

                command.Parameters.AddWithValue("salon", Salon.Id);
                command.Parameters.AddWithValue("admin", Session.UserID);
                command.Parameters.AddWithValue("client", Client.Id);
                command.Parameters.AddWithValue("menedger", Menedger.Id);
                command.Parameters.AddWithValue("how_found", How_found);
                command.Parameters.AddWithValue("typeVizit", TypeVizit);
                command.Parameters.AddWithValue("brend", BrandCar.Name);
                command.Parameters.AddWithValue("model", ModelCar.Name);
                command.Parameters.AddWithValue("color", ColorCar.Name);

                Id = (int)command.ExecuteScalar();
            }
        }
    }
}
