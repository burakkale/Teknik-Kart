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
namespace YazılımSinama2
{
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bql = new sqlbaglantisi();
        void UzmanListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,AD FROM TBL_USERS", bql.baglanti());
            da.Fill(dt);
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "AD";
            lookUpEdit2.Properties.DataSource = dt;
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
        void temizle()
        {
            textBox1.Text = null;
            lookUpEdit3.Text = null;
            RchAciklama.Text = null;
            dateTimePicker4.Text = null;
            lookUpEdit2.Text = null;
            
            lookUpEdit1.Text = null;
        }
        void DurumListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_DURUMLAR", bql.baglanti());
            da.Fill(dt);
            lookUpEdit3.Properties.ValueMember = "DURUMID";
            lookUpEdit3.Properties.DisplayMember = "DURUMAD";
            lookUpEdit3.Properties.DataSource = dt;
        }
        void DurumListe2()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_DURUMLAR", bql.baglanti());
            da.Fill(dt);
            lookUpEdit5.Properties.ValueMember = "DURUMID";
            lookUpEdit5.Properties.DisplayMember = "DURUMAD";
            lookUpEdit5.Properties.DataSource = dt;
        }
        void ProjeListe()
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PROJELER", bql.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
            //watch.Stop();
            // Bir DevExpress nesnesi olan listBoxControl' a süreyi yazıyoruz.
            //  listBoxControl1.Items.Add(watch.Elapsed.Milliseconds);
        }
        void TaskStatesList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute TASKSTATESVERILER", bql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Taskliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute TASKLISTE",bql.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FrmGuncelle_Load(object sender, EventArgs e)
        {
            
            ProjeListe();
            DurumListe();
            UzmanListe();
            KartListe();
            TaskStatesList();
            Taskliste();
            DurumListe2();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textBox2.Text = dr["TASKSTATESID"].ToString();
                lookUpEdit4.Text = dr["TASKNAME"].ToString();
                lookUpEdit3.Text = dr["DURUMAD"].ToString();
                RchAciklama.Text = dr["ACIKLAMA2"].ToString();
                dateTimePicker4.Text = dr["TASKSTATEDATE"].ToString();
                lookUpEdit2.Text = dr["AD"].ToString();
                
                lookUpEdit1.Text = dr["Proje"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
                SqlCommand komut1 = new SqlCommand("UPDATE TBL_TASKSTATES SET TASKID=@P1,DURUMID=@P2,ACIKLAMA2=@P3,TASKSTATEDATE=@P4,USERID=@P5,PROJEID=@P7 WHERE TASKSTATESID=@P8", bql.baglanti());
                komut1.Parameters.AddWithValue("@p1", lookUpEdit4.EditValue);
                komut1.Parameters.AddWithValue("@p2", lookUpEdit3.EditValue);
                komut1.Parameters.AddWithValue("@p3", RchAciklama.Text);
                komut1.Parameters.AddWithValue("@p4", dateTimePicker4.Value);
                komut1.Parameters.AddWithValue("@p5", lookUpEdit2.EditValue);
                
                komut1.Parameters.AddWithValue("@p7", lookUpEdit1.EditValue);
                komut1.Parameters.AddWithValue("@p8", textBox2.Text);
                komut1.ExecuteNonQuery();
                bql.baglanti().Close();
                TaskStatesList();
                MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (lookUpEdit3.Text == "Tamamlandı.")
            {
                maskedTextBox1.Text = Convert.ToString(dateTimePicker4.Value - dateTimePicker1.Value);
                SqlCommand komut3 = new SqlCommand("UPDATE TBL_TASKS set REALDATE=@P1,DURUMID=@P3 WHERE TASKID=@P2", bql.baglanti());
                komut3.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                komut3.Parameters.AddWithValue("@p2", lookUpEdit4.EditValue);
                komut3.Parameters.AddWithValue("@p3", lookUpEdit3.EditValue);
                komut3.ExecuteNonQuery();
                bql.baglanti().Close();
                Taskliste();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnTaskKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("UPDATE TBL_TASKS SET TASKNAME=@P1,ACIKLAMA=@P2,NOTE=@P3,TASKDATE=@P4,PREDATE=@P5,DURUMID=@P7 WHERE TASKID=@P8", bql.baglanti());
            komut1.Parameters.AddWithValue("@p1", textBox1.Text);
            komut1.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut1.Parameters.AddWithValue("@p3", richTextBox2.Text);
            komut1.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut1.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
            
            komut1.Parameters.AddWithValue("@p7", lookUpEdit5.EditValue);
            komut1.Parameters.AddWithValue("@p8", textBox3.Text);
            komut1.ExecuteNonQuery();
            bql.baglanti().Close();
            
            Taskliste();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                textBox3.Text = dr["TASKID"].ToString();
                textBox1.Text = dr["TASKNAME"].ToString();
                richTextBox1.Text = dr["ACIKLAMA"].ToString();
                richTextBox2.Text = dr["NOTE"].ToString();
                dateTimePicker1.Text = dr["TASKDATE"].ToString();
                maskedTextBox2.Text = dr["PREDATE"].ToString();
                label20.Text = dr["REALDATE"].ToString();
                lookUpEdit5.Text = dr["DURUMAD"].ToString();
            }
        }
    }
}
