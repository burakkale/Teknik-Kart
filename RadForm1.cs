using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
namespace YazılımSinama2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bql = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TASKNAME FROM TBL_TASKS", bql.baglanti());
            da.Fill(dt);
            dragAndDropRadGrid1.DataSource = dt;
           
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void dragAndDropRadGrid1_DoubleClick(object sender, EventArgs e)
        {
            FrmGuncelle fr = new FrmGuncelle();
            fr.Show();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

        }
    }
}
