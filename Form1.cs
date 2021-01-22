using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace YazılımSinama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bql = new sqlbaglantisi();
        void ProjeListe()
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,AD FROM TBL_PROJELER", bql.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
            //watch.Stop();
            // Bir DevExpress nesnesi olan listBoxControl' a süreyi yazıyoruz.
          //  listBoxControl1.Items.Add(watch.Elapsed.Milliseconds);
        }
      void KartListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TASKID,TASKNAME FROM TBL_TASKS", bql.baglanti());
            da.Fill(dt);
            lookUpEdit4.Properties.ValueMember = "TASKID";
            lookUpEdit4.Properties.DisplayMember = "TASKNAME";
            lookUpEdit4.Properties.DataSource = dt;
        }
        void DurumListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DURUMID,DURUMAD FROM TBL_DURUMLAR", bql.baglanti());
            da.Fill(dt);
            lookUpEdit3.Properties.ValueMember = "DURUMID";
            lookUpEdit3.Properties.DisplayMember = "DURUMAD";
            lookUpEdit3.Properties.DataSource = dt;
        }
        void UzmanListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,AD FROM TBL_USERS", bql.baglanti());
            da.Fill(dt);
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "AD";
            lookUpEdit2.Properties.DataSource = dt;
        }
        void DurumListe2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_DURUMLAR where DURUMID=1", bql.baglanti());
            da.Fill(dt);
            lookUpEdit5.Properties.ValueMember = "DURUMID";
            lookUpEdit5.Properties.DisplayMember = "DURUMAD";
            lookUpEdit5.Properties.DataSource = dt;
        }
        bool durum;
        void mukerrer()
        {
            
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_TASKS WHERE TASKNAME=@P1", bql.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTeknik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
                
            }
            else
            {
                durum = true;
                
            }
            bql.baglanti().Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            ProjeListe();
            UzmanListe();
            DurumListe();
            KartListe();
            DurumListe2();
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            
            
                if (RchAciklama.Text != "")
                {
                    SqlCommand komut2 = new SqlCommand("INSERT INTO TBL_TASKSTATES(DURUMID,ACIKLAMA2,TASKSTATEDATE,USERID,PROJEID,TASKID) VALUES(@h1,@h2,@h3,@h4,@h6,@h7)", bql.baglanti());
                    //komut2.Parameters.AddWithValue("@h1", TxtTeknik.Text);
                    komut2.Parameters.AddWithValue("@h1", lookUpEdit3.EditValue);
                    komut2.Parameters.AddWithValue("@h2", RchAciklama.Text);
                    komut2.Parameters.AddWithValue("@h3", dateTimePicker4.Value);
                    komut2.Parameters.AddWithValue("@h4", lookUpEdit2.EditValue);

                    komut2.Parameters.AddWithValue("@h6", lookUpEdit1.EditValue);
                    komut2.Parameters.AddWithValue("@h7", lookUpEdit4.EditValue);
                    komut2.ExecuteNonQuery();
                    bql.baglanti().Close();
                    MessageBox.Show("KAYDEDİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İlgili Alanları Doldurmak Zorunludur", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (lookUpEdit3.Text == "Tamamlandı.")
                {
                    maskedTextBox1.Text = Convert.ToString(dateTimePicker4.Value - dateTimePicker1.Value);
                    SqlCommand komut3 = new SqlCommand("UPDATE TBL_TASKS set REALDATE=@P1,DURUMID=@P3 WHERE TASKID=@P2", bql.baglanti());
                    komut3.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                    komut3.Parameters.AddWithValue("@p2", lookUpEdit4.EditValue);
                    komut3.Parameters.AddWithValue("@p3", lookUpEdit3.EditValue);
                    komut3.ExecuteNonQuery();
                    bql.baglanti().Close();

                
            }
            
            
                
                
            
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                if (TxtTeknik.Text != "" && TxtTeknik.Text.Length <= 50)
                {
                    label17.Text = Convert.ToString(dateTimePicker3.Value - dateTimePicker1.Value);
                    SqlCommand komut = new SqlCommand("INSERT INTO TBL_TASKS(TASKNAME,TASKDATE,ACIKLAMA,NOTE,PREDATE,DURUMID) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bql.baglanti());
                    komut.Parameters.AddWithValue("@P1", TxtTeknik.Text);
                    komut.Parameters.AddWithValue("@P2", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@p3", RchİsAciklama.Text);
                    komut.Parameters.AddWithValue("@p4", RchNotlar.Text);
                    komut.Parameters.AddWithValue("@p5", label17.Text);
                    komut.Parameters.AddWithValue("@p6", lookUpEdit5.EditValue);

                    //komut.Parameters.AddWithValue("@p7", lookUpEdit1.EditValue);
                    komut.ExecuteNonQuery();
                    bql.baglanti().Close();
                    MessageBox.Show("Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KartListe();

                }
                else
                {
                    MessageBox.Show("Lütfen İş Adını Max 50 karakter Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                
                    MessageBox.Show("Bu Kayıt Zaten Var", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

    }
}
