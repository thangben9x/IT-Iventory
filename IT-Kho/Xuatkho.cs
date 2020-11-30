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
    public partial class Xuatkho : DevExpress.XtraEditors.XtraUserControl
    {
        public Xuatkho()
        {
            InitializeComponent();
        }
        private static Xuatkho _instance;

        public static Xuatkho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Xuatkho();
                return _instance;
            }
        }
    }
}
