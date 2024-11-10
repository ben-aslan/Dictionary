using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\db_sozluk.accdb");
        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand eklekomutu = new OleDbCommand("insert into ingturkce (ingilizce,turkce) values ('" + t_ingilizce.Text + "','" + t_turkce.Text + "')", baglanti);
                eklekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sözlük veri tabanına eklendi...", "Veri tabanı işlemleri");
                t_ingilizce.Clear();
                t_turkce.Clear();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Veri tabani işlemleri");
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand guncellekomutu = new OleDbCommand("update ingturkce set turkce='" + t_turkce.Text + "' where ingilizce='" + t_ingilizce.Text + "'", baglanti);
                guncellekomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sözlük veri tabanında güncellendi...", "Veri tabanı işlemleri");
                t_ingilizce.Clear();
                t_turkce.Clear();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Veri tabani işlemleri");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand silkomutu = new OleDbCommand("delete from ingturkce where ingilizce='"+t_ingilizce.Text+"'", baglanti);
                silkomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sözlük veri tabanından silindi...", "Veri tabanı işlemleri");
                t_ingilizce.Clear();
                t_turkce.Clear();
            }
            catch (Exception aciklama)
            {
                baglanti.Close();
                MessageBox.Show(aciklama.Message, "Veri tabani işlemleri");
            }
        }

        private void t_ingilizce_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                baglanti.Open();
                OleDbCommand aramakomutu = new OleDbCommand("select ingilizce,turkce from ingturkce where ingilizce like'" + t_ingilizce.Text + "%'", baglanti);
                OleDbDataReader oku = aramakomutu.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["ingilizce"].ToString() + "=" + oku["turkce"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                baglanti.Close();
            }
        }
    }
}
