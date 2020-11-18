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
            if (!container.Controls.Contains(Nhapkho.Instance))
            {
                container.Controls.Add(Nhapkho.Instance);
                Nhapkho.Instance.Dock = DockStyle.Fill;
                Nhapkho.Instance.BringToFront();
            }
            Nhapkho.Instance.BringToFront();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
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
    }
}
