using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenBiletRezervasyon
{
    public class View1Dal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TrenBilet; integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }

        public List<View1> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from VW1", _connection);


            SqlDataReader reader = command.ExecuteReader();

            List<View1> view1s = new List<View1>();

            while (reader.Read())
            {
                View1 view1 = new View1
                {

                    İsim = reader["İsim"].ToString(),
                    BinişYeri = reader["BinişYeri"].ToString(),
                    BiletFiyatı = Convert.ToInt32(reader["BiletFiyatı"]),

                };

                view1s.Add(view1);
            }

            reader.Close();
            _connection.Close();
            return view1s;
        }
    }
}
