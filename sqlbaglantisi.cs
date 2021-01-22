using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace YazılımSinama2
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-GU4OJS6\SQLEXPRESS;Initial Catalog=Dbo_YazilimSinama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
