using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracALisSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string baglanti = "Server=localhost;Database=aracdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";
        int arabaFlag = 0, ilanFlag = 0, guncellemeFlag=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboboxDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HataKontrolMesaji();
            VeriEkle();
            MessageBox.Show("Veritabanına ekleme işlemi gerçekleşmiştir.");
            texttemizle();
            txtIlanAdi.Clear();
        }

        public void texttemizle()
        {
            txtIlanAdi.Clear();
            txtIlanFiyat.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtKm.Clear();
            cmbRenk.Text = "";
            cmbVitesTuru.Text = "";
            cmbYakitTuru.Text = "";
            cmbSehir.Text = "";
        }
        public void VeriEkle()
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            bgl.Open();

            string komutAraba = " ", komutIlan = " ";
            int renkid = 0, YakitTuruID=0, VitesTuruID= 0, arabaid = 0, sehirid=0;

            //secilen Renk Id sini bulmak için. 
            string mysqlRenk = "SELECT * FROM `Tbl_Renk`";
            MySqlCommand cmdRenk = new MySqlCommand(mysqlRenk, bgl);
            MySqlDataReader rdrRenk = cmdRenk.ExecuteReader();

            while (rdrRenk.Read())
            {
                if(rdrRenk["Renk"].ToString() == cmbRenk.SelectedItem.ToString())
                {
                    renkid = Convert.ToInt32(rdrRenk["RenkID"].ToString());
                    continue;
                }
            }
            rdrRenk.Close();

            //secilen YakitTuru id sini bulmak için 
            string mysqlYakitTuru = "SELECT * FROM `Tbl_yakitTuru`";
            MySqlCommand cmdYakitTuru = new MySqlCommand(mysqlYakitTuru, bgl);
            MySqlDataReader rdrYakitTuru = cmdYakitTuru.ExecuteReader();

            while (rdrYakitTuru.Read())
            {
                if (rdrYakitTuru["yakıt_Turu"].ToString() == cmbYakitTuru.SelectedItem.ToString())
                {
                    YakitTuruID = Convert.ToInt32(rdrYakitTuru["yakıturuıd"].ToString());
                    continue;
                }
            }
            rdrYakitTuru.Close();

            //secilen Vites turu idsini bulmak icin 
            string mysqlVitesTuru = "SELECT * FROM `Tbl_vitesTuru`";
            MySqlCommand cmdvitesTuru = new MySqlCommand(mysqlVitesTuru, bgl);
            MySqlDataReader rdrVitesTuru = cmdvitesTuru.ExecuteReader();

            while (rdrVitesTuru.Read())
            {
                if (rdrVitesTuru["vites_turu"].ToString() == cmbVitesTuru.SelectedItem.ToString())
                {
                    VitesTuruID = Convert.ToInt32(rdrVitesTuru["vitesturuıd"].ToString());
                    continue;
                }
            }
            rdrVitesTuru.Close();

            komutAraba = "insert into Tbl_Araba(Araba_Marka,Araba_Model,Araba_VitesTuruID,Araba_YakitTuruID,Araba_RenkID) values('" + txtMarka.Text + "', '" + txtModel.Text + "' , '" + VitesTuruID + "' , '" + YakitTuruID + "' , '" + renkid + "')";
            MySqlCommand kmtAraba = new MySqlCommand(komutAraba, bgl);
            kmtAraba.ExecuteNonQuery();

            //ilan verilecek arabanin idsini bulmak icin 
            string mysqlAraba = "SELECT * FROM `tbl_araba`";
            MySqlCommand cmdAraba = new MySqlCommand(mysqlAraba, bgl);
            MySqlDataReader rdrAraba = cmdAraba.ExecuteReader();

            while (rdrAraba.Read())
            {
                if ((rdrAraba["araba_marka"].ToString() == txtMarka.Text) )
                {
                    arabaid = Convert.ToInt32(rdrAraba["arabaid"].ToString());
                }
            }
            rdrAraba.Close();

            //ilan verilen şehrin idsini bulmak için
            string mysqlSehir = "SELECT * FROM `Tbl_Sehir`";
            MySqlCommand cmdsehir = new MySqlCommand(mysqlSehir, bgl);
            MySqlDataReader rdrSehir = cmdsehir.ExecuteReader();

            while (rdrSehir.Read())
            {
                if (rdrSehir["sehir"].ToString() == cmbSehir.SelectedItem.ToString())
                {
                    sehirid = Convert.ToInt32(rdrSehir["sehirId"].ToString());
                    continue;
                }
            }
            rdrSehir.Close();
            
            komutIlan = "insert into Tbl_ilan(Ilan_adi, Ilan_Fiyat,Ilan_Km,Ilan_Tarih,ArabaID,Ilan_SehirID) values('" + txtIlanAdi.Text + "', '" + txtIlanFiyat.Text + "' , '" + txtKm.Text + "' , '" + dtpTarih.Text + "' , '" + arabaid + "' , '" + sehirid + "')";
            MySqlCommand kmtIlan = new MySqlCommand(komutIlan, bgl);
            kmtIlan.ExecuteNonQuery();
        }

        private void arabaListele_Click(object sender, EventArgs e)
        {
            arabaFlag = 1;
            //kayitGetir();
            arabaKayitGetir();
        }

        private void IlanListele_Click(object sender, EventArgs e)
        {
            ilanFlag = 1;
            //kayitGetir();
            ilanKayitGetir();
        }

        private void arabaKayitGetir()
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            DataTable dt = new DataTable();
            string birlestirAraba = "select tbl_araba.arabaid, tbl_araba.araba_marka, tbl_araba.araba_model, tbl_vitesturu.vites_turu, tbl_yakitturu.yakıt_turu, tbl_renk.renk from (((tbl_araba join tbl_vitesturu on tbl_araba.araba_vitesturuID = tbl_vitesturu.vitesturuıd) join tbl_yakitturu on tbl_araba.araba_yakitturuid = tbl_yakitturu.yakıturuıd) join tbl_renk on tbl_araba.araba_renkId = tbl_renk.renkId)";
            bgl.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(birlestirAraba, bgl);
            da.Fill(dt);
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridView.DataSource = dt;
                //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            }
            else if (tabControl1.SelectedIndex == 2)
                dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void ilanKayitGetir()
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            DataTable dt = new DataTable();
            string birlestirIlan = "select tbl_ilan.ilanid,tbl_ilan.ilan_adi, tbl_ilan.ilan_fiyat, tbl_ilan.ilan_km, tbl_ilan.ilan_tarih, tbl_araba.araba_marka, tbl_araba.araba_model, tbl_sehir.sehir, tbl_yakitturu.yakıt_turu, tbl_vitesturu.vites_turu, tbl_renk.renk from (((((tbl_ilan join tbl_araba on tbl_ilan.ArabaID = tbl_araba.ArabaID) join tbl_sehir on tbl_ilan.ilan_sehirid = tbl_sehir.sehirid) join tbl_vitesturu on tbl_araba.araba_vitesturuID = tbl_vitesturu.vitesturuıd) join tbl_yakitturu on tbl_araba.araba_yakitturuid = tbl_yakitturu.yakıturuıd) join tbl_renk on tbl_araba.araba_renkId = tbl_renk.renkId)";
            bgl.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(birlestirIlan, bgl);
            da.Fill(dt);
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridView.DataSource = dt;
                //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            }
            else if (tabControl1.SelectedIndex == 2)
                dataGridView1.DataSource = dt;
            bgl.Close();
        }

        private void arabaKayitSil(int arabaid)
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            string araba = "DELETE FROM tbl_araba where arabaid = '" + arabaid + "';";
            string ilan = "DELETE FROM tbl_ilan where arabaid = '" + arabaid + "';";
            MySqlCommand ilankomut = new MySqlCommand(ilan, bgl);
            MySqlCommand komut = new MySqlCommand(araba, bgl);
            ilankomut.Parameters.AddWithValue("@arabaid", arabaid);
            komut.Parameters.AddWithValue("@arabaid", arabaid);
            bgl.Open();
            ilankomut.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            bgl.Close();
        }

        private void ilanKayitSil(int ilanid)
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            string ilan = "DELETE FROM tbl_ilan where ilanid = '" + ilanid + "';";
            MySqlCommand ilankomut = new MySqlCommand(ilan, bgl);
            ilankomut.Parameters.AddWithValue("@ilanid", ilanid);
            bgl.Open();
            ilankomut.ExecuteNonQuery();
            bgl.Close();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                if (arabaFlag == 1)
                {
                    arabaKayitSil(id);
                    arabaKayitGetir();
                }
                else if (ilanFlag == 1)
                {
                    ilanKayitSil(id);
                    ilanKayitGetir();
                }
                
            }  
        }

        public void comboboxDoldur()
        {
            MySqlConnection mysqlbaglan = new MySqlConnection(baglanti);

            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                // Eğer tablo içi boş ise kayıtlı kullanıcı yok diye bildirim verdireceğiz.
                bool kontrolEt = false;

                // ComboBox'ımızı temizliyoruz.
                cmbYakitTuru.Items.Clear();
                cmbVitesTuru.Items.Clear();
                cmbRenk.Items.Clear();
                cmbSehir.Items.Clear();

                // Sorgumuzu gönderiyoruz.
                string sqlYakitTuru = "SELECT * FROM `Tbl_yakitTuru`";
                MySqlCommand cmd = new MySqlCommand(sqlYakitTuru, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // Tablo dolu ise aktif yapıyoruz.
                    kontrolEt = true;

                    // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                    cmbYakitTuru.Items.Add(rdr["yakıt_Turu"].ToString());
                }

                // Bağlantılarımı kapatıyoruz.
                rdr.Close();

                string sqlRenk = "SELECT * FROM `Tbl_Renk`";
                MySqlCommand cmdRenk = new MySqlCommand(sqlRenk, mysqlbaglan);
                MySqlDataReader rdrRenk = cmdRenk.ExecuteReader();

                while (rdrRenk.Read())
                {
                    // Tablo dolu ise aktif yapıyoruz.
                    kontrolEt = true;

                    // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                    cmbRenk.Items.Add(rdrRenk["renk"].ToString());
                }
                rdrRenk.Close();

                string sqlVitesTuru = "SELECT * FROM `Tbl_vitesTuru`";
                MySqlCommand cmdvitesTuru = new MySqlCommand(sqlVitesTuru, mysqlbaglan);
                MySqlDataReader rdrVitesTuru = cmdvitesTuru.ExecuteReader();

                while (rdrVitesTuru.Read())
                {
                    // Tablo dolu ise aktif yapıyoruz.
                    kontrolEt = true;

                    // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                    cmbVitesTuru.Items.Add(rdrVitesTuru["vites_turu"].ToString());
                }

                rdrVitesTuru.Close();

                string sqlSehir = "SELECT * FROM `Tbl_Sehir`";
                MySqlCommand cmdsehir = new MySqlCommand(sqlSehir, mysqlbaglan);
                MySqlDataReader rdrSehir = cmdsehir.ExecuteReader();

                while (rdrSehir.Read())
                {
                    // Tablo dolu ise aktif yapıyoruz.
                    kontrolEt = true;

                    // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                    cmbSehir.Items.Add(rdrSehir["sehir"].ToString());
                }

                rdrSehir.Close();
                mysqlbaglan.Close();

                // Eğer tablo boş ise bir mesaj gönderiyoruz.
                if (kontrolEt == false)
                {
                    MessageBox.Show("Kayıtlı il yok !");
                    return;
                }
            }
            else
            {
                // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                MessageBox.Show("Bağlantı yok, veri getirilemez.");
            }
        }

        private void HataKontrolMesaji()
        {
            if (txtMarka.Text == " ")
                errorIlanAdi.SetError(txtMarka, "Bir deger girmek zorundasin");
            else if (txtModel.Text == " ")
                errorIlanAdi.SetError(txtModel, "Bir deger girmek zorundasin");
            else if (txtIlanAdi.Text == " ")
                errorIlanAdi.SetError(txtIlanAdi, "Bir deger girmek zorundasin");
            else if (txtIlanFiyat.Text == " ")
                errorIlanAdi.SetError(txtIlanFiyat, "Bir deger girmek zorundasin");
            else if (txtKm.Text == " ")
                errorIlanAdi.SetError(txtKm, "Bir deger girmek zorundasin");
            else if (dtpTarih.Text == " ")
                errorIlanAdi.SetError(dtpTarih, "Bir deger girmek zorundasin");
            else if (cmbRenk.SelectedText == " ")
                errorIlanAdi.SetError(cmbRenk, "Bir deger seçmek zorundasin");
            else if (cmbSehir.SelectedText == " ")
                errorIlanAdi.SetError(cmbSehir, "Bir deger girmek zorundasin");
            else if (cmbVitesTuru.SelectedText == " ")
                errorIlanAdi.SetError(cmbVitesTuru, "Bir deger girmek zorundasin");
            else if (cmbYakitTuru.SelectedText == " ")
                errorIlanAdi.SetError(cmbYakitTuru, "Bir deger girmek zorundasin");
        }

        private void cmbRenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if(char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(cmbRenk, "Sayısal deger girmemelisiniz.");
            }
        }

        private void cmbSehir_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if (char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(cmbSehir, "Sayısal deger girmemelisiniz.");
            }
        }

        private void cmbYakitTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if (char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(cmbYakitTuru, "Sayısal deger girmemelisiniz.");
            }
        }

        private void cmbVitesTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if (char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(cmbVitesTuru, "Sayısal deger girmemelisiniz.");
            }
        }

        private void txtIlanFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if (!char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(txtIlanFiyat, "Sayısal deger girmelisiniz.");
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //klavyeden girilen degerin kontrolü için e.KeyChar
            if (!char.IsDigit(e.KeyChar))
            {
                errorIlanAdi.SetError(txtKm, "Sayısal deger girmelisiniz.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            guncellemeFlag = 1;
            ilanKayitGetir();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            Filtreleme frm = new Filtreleme();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview secili satirdaki degerleri textbox aktariyoruz.

            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtkilometre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtmarkaguncel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtModelGuncel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSehirGuncel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtyakitturuguncelleme.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtVitesTuru.Text =dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtRenkGuncelleme.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        { 
            string guncelleme;
            MySqlConnection bgl = new MySqlConnection(baglanti);
            bgl.Open();
            
            guncelleme = "Update tbl_ilan Join tbl_araba on tbl_ilan.arabaid= tbl_araba.arabaid join tbl_sehir on tbl_ilan.ilan_sehirid= tbl_sehir.sehirid join tbl_yakitturu on tbl_araba.araba_yakitturuid= tbl_yakitturu.yakıturuıd join tbl_vitesturu on tbl_araba.araba_vitesturuID = tbl_vitesturu.vitesturuıd join tbl_renk on tbl_araba.araba_renkid = tbl_renk.renkid set ilan_adi = '" + txtad.Text + "',ilan_fiyat='"+txtfiyat.Text+ "',Ilan_Km='" + txtkilometre.Text +"',Ilan_Tarih='" + txttarih.Text +"',araba_marka='" + txtmarkaguncel.Text +"',araba_model='" + txtModelGuncel.Text + "',sehir='" + txtSehirGuncel.Text +"',yakıt_turu='" + txtyakitturuguncelleme.Text+ "',vites_turu='" + txtVitesTuru.Text +"',renk='" + txtRenkGuncelleme.Text + "'   where ilanid = '" + txtid.Text +"';";
            
            MySqlCommand ilan = new MySqlCommand(guncelleme, bgl);
            ilan.ExecuteNonQuery();

            ilanKayitGetir();

        }
    }
}
