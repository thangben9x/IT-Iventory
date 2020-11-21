using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IT_Kho
{
    public partial class Taikhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public Taikhoan()
        {
            InitializeComponent();
        }
        private static Taikhoan _instance;

        public static Taikhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Taikhoan();
                return _instance;
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
