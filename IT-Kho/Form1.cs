using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT_Kho
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(Nhapkho.Instance))
            {
                container.Controls.Add(Nhapkho.Instance);
                Nhapkho.Instance.Dock = DockStyle.Fill;
                Nhapkho.Instance.BringToFront();
            }
            Nhapkho.Instance.BringToFront();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public static string mp = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select *from  PhongBan";
            lookUpEdit1.Properties.DataSource = Connect.getTable(sql);
            lookUpEdit1.Properties.DisplayMember = "tenphong";
            lookUpEdit1.Properties.ValueMember = "maphong";
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            mp = lookUpEdit1.EditValue.ToString();
            XtraForm1 x = new XtraForm1();
            x.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Fix_Update.Instance))
            {
                container.Controls.Add(Fix_Update.Instance);
                Fix_Update.Instance.Dock = DockStyle.Fill;
                Fix_Update.Instance.BringToFront();
            }
            Fix_Update.Instance.BringToFront();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Ton.Instance))
            {
                container.Controls.Add(Ton.Instance);
                Ton.Instance.Dock = DockStyle.Fill;
                Ton.Instance.BringToFront();
            }
            Ton.Instance.BringToFront();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ThuHoi.Instance))
            {
                container.Controls.Add(ThuHoi.Instance);
                ThuHoi.Instance.Dock = DockStyle.Fill;
                ThuHoi.Instance.BringToFront();
            }
            ThuHoi.Instance.BringToFront();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(TonKi.Instance))
            {
                container.Controls.Add(TonKi.Instance);
                TonKi.Instance.Dock = DockStyle.Fill;
                TonKi.Instance.BringToFront();
            }
            TonKi.Instance.BringToFront();
        }
    }
}
