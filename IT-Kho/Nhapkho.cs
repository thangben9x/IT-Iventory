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
    public partial class Nhapkho : DevExpress.XtraEditors.XtraUserControl
    {
        public Nhapkho()
        {
            InitializeComponent();
        }
        private static Nhapkho _instance;

        public static Nhapkho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Nhapkho();
                return _instance;
            }
        }
    }
}
