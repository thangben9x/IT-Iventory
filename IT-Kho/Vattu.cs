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
    public partial class Vattu : DevExpress.XtraEditors.XtraUserControl
    {
        public Vattu()
        {
            InitializeComponent();
        }
        private static Vattu _instance;

        public static Vattu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Vattu();
                return _instance;
            }
        }
    }
}
