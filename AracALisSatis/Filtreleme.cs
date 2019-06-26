using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracALisSatis
{
    public partial class Filtreleme : Form
    {
        public Filtreleme()
        {
            InitializeComponent();
        }
        public string baglanti = "Server=localhost;Database=aracdatabase;port=3306;persistsecurityinfo=True;SslMode=none;Uid=root;Pwd='1234';";

        private void Filtreleme_Load(object sender, EventArgs e)
        {
            comboDoldur();
        }

        private void ilanKayitGetir()
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);
            DataTable dt = new DataTable();
            string birlestirIlan = "select tbl_ilan.ilanid,tbl_ilan.ilan_adi, tbl_ilan.ilan_fiyat, tbl_ilan.ilan_km, tbl_ilan.ilan_tarih, tbl_araba.araba_marka, tbl_araba.araba_model, tbl_sehir.sehir, tbl_yakitturu.yakıt_turu, tbl_vitesturu.vites_turu, tbl_renk.renk from (((((tbl_ilan join tbl_araba on tbl_ilan.ArabaID = tbl_araba.ArabaID) join tbl_sehir on tbl_ilan.ilan_sehirid = tbl_sehir.sehirid) join tbl_vitesturu on tbl_araba.araba_vitesturuID = tbl_vitesturu.vitesturuıd) join tbl_yakitturu on tbl_araba.araba_yakitturuid = tbl_yakitturu.yakıturuıd) join tbl_renk on tbl_araba.araba_renkId = tbl_renk.renkId)";
            bgl.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(birlestirIlan, bgl);
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;

            bgl.Close();
        }

        private void comboDoldur()
        {
            MySqlConnection mysqlbaglan = new MySqlConnection(baglanti);

            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            // Sorgumuzu gönderiyoruz.
            string sqlYakitTuru = "SELECT * FROM `Tbl_yakitTuru`";
            MySqlCommand cmd = new MySqlCommand(sqlYakitTuru, mysqlbaglan);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
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

                // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                cmbRenk.Items.Add(rdrRenk["renk"].ToString());
            }
            rdrRenk.Close();

            string sqlVitesTuru = "SELECT * FROM `Tbl_vitesTuru`";
            MySqlCommand cmdvitesTuru = new MySqlCommand(sqlVitesTuru, mysqlbaglan);
            MySqlDataReader rdrVitesTuru = cmdvitesTuru.ExecuteReader();

            while (rdrVitesTuru.Read())
            {

                // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                cmbVitesTuru.Items.Add(rdrVitesTuru["vites_turu"].ToString());
            }

            rdrVitesTuru.Close();

            string sqlSehir = "SELECT * FROM `Tbl_Sehir`";
            MySqlCommand cmdsehir = new MySqlCommand(sqlSehir, mysqlbaglan);
            MySqlDataReader rdrSehir = cmdsehir.ExecuteReader();

            while (rdrSehir.Read())
            {
                // Tabloda veri varsa sütun adını yazıp verilerimizi çekiyoruz.
                cmbSehir.Items.Add(rdrSehir["sehir"].ToString());
            }

            rdrSehir.Close();
            mysqlbaglan.Close();
        }

        private void btnTumveritabani_Click(object sender, EventArgs e)
        {
            ilanKayitGetir();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string filtreleme = "SELECT tbl_ilan.ilanid,tbl_ilan.ilan_adi, tbl_ilan.ilan_fiyat, tbl_ilan.ilan_km, tbl_ilan.ilan_tarih, tbl_araba.araba_marka, tbl_araba.araba_model, tbl_sehir.sehir, tbl_yakitturu.yakıt_turu, tbl_vitesturu.vites_turu, tbl_renk.renk from (((((tbl_ilan join tbl_araba on tbl_ilan.ArabaID = tbl_araba.ArabaID) join tbl_sehir on tbl_ilan.ilan_sehirid = tbl_sehir.sehirid) join tbl_vitesturu on tbl_araba.araba_vitesturuID = tbl_vitesturu.vitesturuıd) join tbl_yakitturu on tbl_araba.araba_yakitturuid = tbl_yakitturu.yakıturuıd) join tbl_renk on tbl_araba.araba_renkId = tbl_renk.renkId)";
            Kontrol(filtreleme);
        }

        private void Kontrol(String filtreleme)
        {
            MySqlConnection bgl = new MySqlConnection(baglanti);

            string ek = "where";
            if(cmbYakitTuru.Text != "" )
            {
                filtreleme += ek + " yakıt_turu = "+ "'" + cmbYakitTuru.SelectedItem.ToString() + "'";
                ek = "and";
            }
            if (cmbVitesTuru.Text != "")
            {
                filtreleme += ek + " vites_turu =  '" + cmbVitesTuru.SelectedItem.ToString() + "'";
                ek = "and";
            }
            if(cmbSehir.Text != "")
            {
                filtreleme += ek + " sehir = " + "'" + cmbSehir.SelectedItem.ToString() + "'" ;
                ek = "and";
            }
            if(cmbRenk.Text.ToString() != "")
            {
                filtreleme += ek + " renk = " + "'" + cmbRenk.SelectedItem.ToString() + "'";
                ek = "and";
            }
            if(txtmarka.Text != "")
            {
                filtreleme += ek + " araba_marka = " + "'" + txtmarka.Text.ToString() + "'";
                ek = "and";
            }
            if(txtModel.Text != "")
            {
                filtreleme += ek + " araba_model = " + "'" + txtModel.Text.ToString() + "'";
                ek = "and";
            }
            if(txtilanAdi.Text != "")
            {
                filtreleme += ek + " ilan_adi = " + "'" + txtilanAdi.Text.ToString() + "'";
                ek = "and";
            }
            if(txtilantarih.Text != "")
            {
                filtreleme += ek + " ilan_tarih = " + "'" + txtilantarih.Text.ToString() + "'";
                ek = "and";
            }
            if(txtkmmax.Text != "" & txtkmmin.Text != "")
            {
                filtreleme += ek + " ilan_km > " + txtkmmin.Text.ToString() + " and ilan_fiyat < " + txtkmmax.Text.ToString();
                ek = "and";
            }
            if(txtfiyatmax.Text != "" & txtfiyatmin.Text != "")
            {
                filtreleme += ek + " ilan_fiyat > " + txtfiyatmin.Text.ToString() + " and ilan_fiyat < " + txtfiyatmax.Text.ToString() ;
                ek = "and";
            }
            if(cmbSirala.Text != "")
            {
                ek = "order by";
                if(cmbSehir.SelectedItem.ToString() == "a-z sırala" )
                {
                    filtreleme += ek + "tbl_ilan" + "ASC";
                }
                else if(cmbSehir.SelectedItem.ToString() == "z-a sırala")
                {
                    filtreleme += ek + "tbl_ilan" + "DESC";
                }
            }
            DataTable dt = new DataTable();
            bgl.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(filtreleme, bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
