using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenBiletRezervasyon
{
   public class View2Dal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TrenBilet; integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
        }

        public List<View2> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from VW2", _connection);


            SqlDataReader reader = command.ExecuteReader();

            List<View2> view2s = new List<View2>();

            while (reader.Read())
            {
                View2 view2 = new View2
                {

                    Yaş = Convert.ToInt32(reader["Yaş"]),
                    İnişYeri = reader["İnişYeri"].ToString(),
                    SonFiyat = Convert.ToInt32(reader["SonFiyat"]),

                };

                view2s.Add(view2);
            }

            reader.Close();
            _connection.Close();
            return view2s;
        }
    }
}

