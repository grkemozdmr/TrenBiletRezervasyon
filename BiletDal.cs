using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenBiletRezervasyon
{
   public class BiletDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TrenBilet;integrated security=true");
        public List<Bilet> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Biletler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Bilet> biletler = new List<Bilet>();

            while (reader.Read())
            {
                Bilet bilet = new Bilet
                {
                    BiletId = Convert.ToInt32(reader["BiletId"]),
                    BiletFiyatı = Convert.ToInt32(reader["BiletFiyatı"]),
                    SonFiyat = Convert.ToInt32(reader["SonFiyat"]),

                };
                biletler.Add(bilet);
            }

            reader.Close();
            _connection.Close();
            return biletler;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Bilet bilet)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Biletler values(@biletFiyat,@sonFiyat)", _connection);
            command.Parameters.AddWithValue("@biletFiyatı", bilet.BiletFiyatı);
            command.Parameters.AddWithValue("@inişYeri", bilet.SonFiyat);
            
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_BiletEkle(Bilet bilet)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_BiletEkle @biletFiyat,@sonFiyat", _connection);
            command.Parameters.AddWithValue("@biletFiyatı", bilet.BiletFiyatı);
            command.Parameters.AddWithValue("@inişYeri", bilet.SonFiyat);
            

            command.ExecuteNonQuery();

            
            _connection.Close();


        }
        public void Update(Bilet bilet)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Biletler set BiletFiyatı=@biletfiyatı, SonFiyat=@sonfiyat, where BiletId=@biletId ", _connection);
            command.Parameters.AddWithValue("@biletfiyatı", bilet.BiletFiyatı);
            command.Parameters.AddWithValue("@sonfiyat", bilet.SonFiyat);
           

            command.Parameters.AddWithValue("@biletId", bilet.BiletId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_Update(Bilet bilet)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_BiletGüncelle set BiletFiyatı=@biletfiyatı, SonFiyat=@sonfiyat, where BiletId=@biletId", _connection);

            command.Parameters.AddWithValue("@biletfiyatı", bilet.BiletFiyatı);
            command.Parameters.AddWithValue("@sonfiyat", bilet.SonFiyat);

            command.Parameters.AddWithValue("@biletId", bilet.BiletId);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Delete(int BiletId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Biletler where BiletId=@biletid ", _connection);

            command.Parameters.AddWithValue("@biletid", BiletId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_BiletSil(int BiletId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_BiletSil where BiletId=@biletid", _connection);

            command.Parameters.AddWithValue("@BiletId", BiletId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }

}

