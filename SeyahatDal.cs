using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenBiletRezervasyon
{
     public class SeyahatDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TrenBilet;integrated security=true");
        public List<Seyahat> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Seyahatler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Seyahat> seyahatler = new List<Seyahat>();

            while (reader.Read())
            {
                Seyahat seyahat = new Seyahat
                {
                    SeyahatId = Convert.ToInt32(reader["SeyahatId"]),
                    BinişYeri = reader["BinişYeri"].ToString(),
                    İnişYeri = reader["İnişYeri"].ToString(),
                    Tarih = reader["Tarih"].ToString(),
                    Saat = reader["Saat"].ToString(),
                  
                };
                seyahatler.Add(seyahat);
            }

            reader.Close();
            _connection.Close();
            return seyahatler;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Seyahat seyahat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Seyahatler values(@binişYeri,@inişYeri,@tarih,@saat)", _connection);
            command.Parameters.AddWithValue("@binişYeri", seyahat.BinişYeri);
            command.Parameters.AddWithValue("@inişYeri", seyahat.İnişYeri);
            command.Parameters.AddWithValue("@tarih", seyahat.Tarih);
            command.Parameters.AddWithValue("@saat", seyahat.Saat);
            
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_SeyahatEkle(Seyahat seyahat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_SeyahatEkle @binişYeri,@inişYeri,@tarih,@saat", _connection);
            command.Parameters.AddWithValue("@binişYeri", seyahat.BinişYeri);
            command.Parameters.AddWithValue("@inişYeri", seyahat.İnişYeri);
            command.Parameters.AddWithValue("@tarih", seyahat.Tarih);
            command.Parameters.AddWithValue("@saat", seyahat.Saat);
            
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void Update(Seyahat seyahat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Seyahatler set BinişYeri=@binişyeri, İnişYeri=@inişyeri, Tarih=@tarih, Saat=@saat, where SeyahatId=@seyahatId ", _connection);
            command.Parameters.AddWithValue("@binişyeri", seyahat.BinişYeri);
            command.Parameters.AddWithValue("@inişyeri", seyahat.İnişYeri);
            command.Parameters.AddWithValue("@tarih", seyahat.Tarih);
            command.Parameters.AddWithValue("@saat", seyahat.Saat);
            command.Parameters.AddWithValue("@seyahatId", seyahat.SeyahatId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_SeyahatGüncelle(Seyahat seyahat)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_SeyahatGüncelle @binişyeri,@inişyeri,@tarih,@saat,@seyahatid", _connection);

            command.Parameters.AddWithValue("@binişyeri", seyahat.BinişYeri);
            command.Parameters.AddWithValue("@inişyeri", seyahat.İnişYeri);
            command.Parameters.AddWithValue("@tarih", seyahat.Tarih);
            command.Parameters.AddWithValue("@saat", seyahat.Saat);
            command.Parameters.AddWithValue("@seyahatid", seyahat.SeyahatId);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Delete(int SeyahatId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Seyahatler where SeyahatId=@seyahatid ", _connection);

            command.Parameters.AddWithValue("@seyahatid", SeyahatId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_SeyahatSil(int SeyahatId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_SeyahatSil where SeyahatId=@seyahatid", _connection);

            command.Parameters.AddWithValue("@SeyahatId", SeyahatId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
