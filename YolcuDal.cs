using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TrenBiletRezervasyon
{
    public class YolcuDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=TrenBilet;integrated security=true");
        public List<Yolcu> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Yolcular", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Yolcu> yolcular = new List<Yolcu>();

            while (reader.Read())
            {
                Yolcu yolcu = new Yolcu
                {
                    YolcuId = Convert.ToInt32(reader["YolcuId"]),
                    İsim = reader["İsim"].ToString(),
                    Yaş = Convert.ToInt32(reader["Yaş"]),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    İletişimNo = Convert.ToInt32(reader["İletişimNo"]),
                    Adres = reader["Adres"].ToString(),
                };
                yolcular.Add(yolcu);
            }

            reader.Close();
            _connection.Close();
            return yolcular;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Yolcu yolcu)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Yolcular values(@isim,@yaş,@cinsiyet,@iletişimNo,@adres)", _connection);
            command.Parameters.AddWithValue("@isim", yolcu.İsim);
            command.Parameters.AddWithValue("@yaş", yolcu.Yaş);
            command.Parameters.AddWithValue("@cinsiyet", yolcu.Cinsiyet);
            command.Parameters.AddWithValue("@iletişimNo", yolcu.İletişimNo);
            command.Parameters.AddWithValue("@adres", yolcu.Adres);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_YolcuEkle(Yolcu yolcu)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_YolcuEkle @isim,@yaş,@cinsiyet,@iletişimNo,@adres", _connection);
            command.Parameters.AddWithValue("@isim", yolcu.İsim);
            command.Parameters.AddWithValue("@yaş", yolcu.Yaş);
            command.Parameters.AddWithValue("@cinsiyet", yolcu.Cinsiyet);
            command.Parameters.AddWithValue("@iletişimNo", yolcu.İletişimNo);
            command.Parameters.AddWithValue("@adres", yolcu.Adres);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void Update(Yolcu yolcu)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Yolcular set İsim=@isim, Yaş=@yaş, Cinsiyet=@cinsiyet, İletişimNo=@iletişimNo, Adres=@adres where YolcuId=@yolcuId ", _connection);
            command.Parameters.AddWithValue("@isim", yolcu.İsim);
            command.Parameters.AddWithValue("@yaş", yolcu.Yaş);
            command.Parameters.AddWithValue("@cinsiyet", yolcu.Cinsiyet);
            command.Parameters.AddWithValue("@iletişimNo", yolcu.İletişimNo);
            command.Parameters.AddWithValue("@adres", yolcu.Adres);
            command.Parameters.AddWithValue("@yolcuId", yolcu.YolcuId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_Update(Yolcu yolcu)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_YolcuGüncelle set İsim=@isim, Yaş=@yaş, Cinsiyet=@cinsiyet, İletişimNo=@iletişimNo, Adres=@adres where YolcuId=@yolcuId", _connection);

            command.Parameters.AddWithValue("@isim", yolcu.İsim);
            command.Parameters.AddWithValue("@yaş", yolcu.Yaş);
            command.Parameters.AddWithValue("@cinsiyet", yolcu.Cinsiyet);
            command.Parameters.AddWithValue("@iletişimNo", yolcu.İletişimNo);
            command.Parameters.AddWithValue("@adres", yolcu.Adres);
            command.Parameters.AddWithValue("@yolcuId", yolcu.YolcuId);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Delete(int YolcuId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Yolcular where YolcuId=@yolcuid ", _connection);

            command.Parameters.AddWithValue("@yolcuid", YolcuId);
            command.ExecuteNonQuery();


            _connection.Close();


        }
        public void SP_YolcuSil(int YolcuId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Exec SP_YolcuSil where YolcuId=@yolcuid", _connection);

            command.Parameters.AddWithValue("@YolcuId", YolcuId);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
