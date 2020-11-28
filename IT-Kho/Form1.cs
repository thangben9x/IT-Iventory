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

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(Nhapmoi.Instance))
            {
                container.Controls.Add(Nhapmoi.Instance);
                Nhapmoi.Instance.Dock = DockStyle.Fill;
                Nhapmoi.Instance.BringToFront();
            }
            Nhapmoi.Instance.BringToFront();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Nhapmoi.Instance))
            {
                container.Controls.Add(Nhapmoi.Instance);
                Nhapmoi.Instance.Dock = DockStyle.Fill;
                Nhapmoi.Instance.BringToFront();
            }
            Nhapmoi.Instance.BringToFront();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(Xuatkho.Instance))
            {
                container.Controls.Add(Xuatkho.Instance);
                Xuatkho.Instance.Dock = DockStyle.Fill;
                Xuatkho.Instance.BringToFront();
            }
            Xuatkho.Instance.BringToFront();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Xuatkho.Instance))
            {
                container.Controls.Add(Xuatkho.Instance);
                Xuatkho.Instance.Dock = DockStyle.Fill;
                Xuatkho.Instance.BringToFront();
            }
            Xuatkho.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(VatTu.Instance))
            {
                container.Controls.Add(VatTu.Instance);
                VatTu.Instance.Dock = DockStyle.Fill;
                VatTu.Instance.BringToFront();
            }
            VatTu.Instance.BringToFront();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Taikhoan.Instance))
            {
                container.Controls.Add(Taikhoan.Instance);
                Taikhoan.Instance.Dock = DockStyle.Fill;
                Taikhoan.Instance.BringToFront();
            }
            Taikhoan.Instance.BringToFront();
        }




        //Chuyển hướng tới Nhập thiết bị đã có trong kho
        private void barLargeButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(Nhapmoi.Instance))
            {
                container.Controls.Add(Nhapmoi.Instance);
                Nhapmoi.Instance.Dock = DockStyle.Fill;
                Nhapmoi.Instance.BringToFront();
            }
            Nhapmoi.Instance.BringToFront();
        }

        //Chuyển hướng tới Nhập thiết bị chưa có trong kho
        private void barLargeButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(CCTK.Instance))
            {
                container.Controls.Add(CCTK.Instance);
                CCTK.Instance.Dock = DockStyle.Fill;
                CCTK.Instance.BringToFront();
            }
            CCTK.Instance.BringToFront();
        }
    }
}
