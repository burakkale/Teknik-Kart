using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YazılımSinama2
{
    
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        RadForm1 fr;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (fr2 == null || fr.IsDisposed)
            {
                fr2 = new Form1();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        Form1 fr2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new RadForm1();
                fr.MdiParent = this;
                fr.Show();
            }
           
        }
    }
}
