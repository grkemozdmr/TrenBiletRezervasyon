using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenBiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadYolcular();
            LoadSeyahatler();
            LoadBiletler();
        }
        BiletDal _biletDal = new BiletDal();

        SeyahatDal _seyahatDal = new SeyahatDal();

        YolcuDal _yolcuDal = new YolcuDal();

        View1Dal _view1Dal = new View1Dal();
        View2Dal _view2Dal = new View2Dal();

        private void LoadYolcular()
        {
            dgwYolcular.DataSource = _yolcuDal.GetAll();

        }
       

        private void LoadSeyahatler()
        {
            dgwSeyahat.DataSource = _seyahatDal.GetAll();
        }

        private void LoadBiletler()
        {
            dgwBilet.DataSource = _biletDal.GetAll();
        }
        private void LoadView1()
        {
            dataGridView1.DataSource = _view1Dal.GetAll();
        }
        private void LoadView2()
        {
            dataGridView1.DataSource = _view2Dal.GetAll();
        }
       

        private void btnYolcuEkle_Click(object sender, EventArgs e)
        {
            _yolcuDal.Add(new Yolcu
            {
                İsim = tbxİsim.Text,
                Yaş = Convert.ToInt32(tbxYaş.Text),
                Cinsiyet = tbxCinsiyet.Text,
                İletişimNo = Convert.ToInt32(tbxİletişimNo.Text),
                Adres = tbxAdres.Text
            });
            LoadYolcular();
            MessageBox.Show("Yolcu Eklendi!");
        }

        


        private void dgwYolcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxİsimGüncelle.Text = dgwYolcular.CurrentRow.Cells[1].Value.ToString();
            tbxYaşGüncelle.Text = dgwYolcular.CurrentRow.Cells[2].Value.ToString();
            tbxCinsiyetGüncelle.Text = dgwYolcular.CurrentRow.Cells[3].Value.ToString();
            tbxİletişimNoGüncelle.Text = dgwYolcular.CurrentRow.Cells[4].Value.ToString();
            tbxAdresGüncelle.Text = dgwYolcular.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Yolcu yolcu = new Yolcu
            {
                YolcuId = Convert.ToInt32(dgwYolcular.CurrentRow.Cells[0].Value),
                İsim = tbxİsimGüncelle.Text,
                Yaş = Convert.ToInt32(tbxYaşGüncelle.Text),
                Cinsiyet = tbxCinsiyetGüncelle.Text,
                İletişimNo = Convert.ToInt32(tbxİletişimNoGüncelle.Text),
                Adres = tbxAdresGüncelle.Text
        };
            _yolcuDal.Update(yolcu);
            LoadYolcular();
            MessageBox.Show("Güncellendi!");
        }

        private void btnKaldır_Click(object sender, EventArgs e)
        {
            int YolcuId = Convert.ToInt32(dgwYolcular.CurrentRow.Cells[0].Value);
            _yolcuDal.Delete(YolcuId);
            LoadYolcular();
            MessageBox.Show("Kaldırıldı!");

        }

        private void btnSeyahatEkle_Click(object sender, EventArgs e)
        {
            _seyahatDal.Add(new Seyahat
            {
                
                BinişYeri = tbxBiniş.Text,
                İnişYeri = tbxİniş.Text,
                Tarih = tbxTarih.Text,
                Saat = tbxSaat.Text,
                
            });
            LoadSeyahatler();
            MessageBox.Show("Seyahat Bilgisi Eklendi!");
        }

        private void btnSeyahatGüncelle_Click(object sender, EventArgs e)
        {
            Seyahat seyahat = new Seyahat
            {
                SeyahatId = Convert.ToInt32(dgwSeyahat.CurrentRow.Cells[0].Value),
                BinişYeri = tbxBinişGüncelle.Text,
                İnişYeri = tbxİnişGüncelle.Text,
                Tarih = tbxTarihGüncelle.Text,
                Saat = tbxSaatGüncelle.Text,
            };
            _seyahatDal.SP_SeyahatGüncelle(seyahat);
            LoadSeyahatler();
            MessageBox.Show("Seyahat Bilgisi Güncellendi!");
        }

        private void btnSeyahatKaldır_Click(object sender, EventArgs e)
        {
            int SeyahatId = Convert.ToInt32(dgwSeyahat.CurrentRow.Cells[0].Value);
            _seyahatDal.Delete(SeyahatId);
            LoadSeyahatler();
            MessageBox.Show("Kaldırıldı!");
        }

        private void dgwSeyahat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBinişGüncelle.Text = dgwSeyahat.CurrentRow.Cells[1].Value.ToString();
            tbxİnişGüncelle.Text = dgwSeyahat.CurrentRow.Cells[2].Value.ToString();
            tbxTarihGüncelle.Text = dgwSeyahat.CurrentRow.Cells[3].Value.ToString();
            tbxSaatGüncelle.Text = dgwSeyahat.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            _biletDal.Add(new Bilet
            {

               
                BiletFiyatı = Convert.ToInt32(tbxFiyat.Text),
                SonFiyat = Convert.ToInt32(tbxSonFiyat.Text),

            });
            LoadBiletler();
            MessageBox.Show("Bilet Bilgisi Eklendi!");
        }

        private void btnBiletGüncelleme_Click(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet
            {
                BiletId = Convert.ToInt32(dgwBilet.CurrentRow.Cells[0].Value),
               
                BiletFiyatı = Convert.ToInt32(tbxBiletGüncelleme.Text),
                SonFiyat  = Convert.ToInt32(tbxSonGüncelleme.Text),
            };
            _biletDal.SP_Update(bilet);
            LoadBiletler();
            MessageBox.Show("Bilet Bilgisi Güncellendi!");
        }
        
        private void btnBiletKaldır_Click(object sender, EventArgs e)
        {
            int BiletId = Convert.ToInt32(dgwBilet.CurrentRow.Cells[0].Value);
            _biletDal.Delete(BiletId);
            LoadBiletler();
            MessageBox.Show("Kaldırıldı!");
        }

        private void dgwBilet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBiletGüncelleme.Text = dgwBilet.CurrentRow.Cells[1].Value.ToString();
            tbxSonGüncelleme.Text = dgwBilet.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadView1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadView2();
        }
    }
}
