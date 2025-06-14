using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmCachSuDung : Form
    {
        public frmCachSuDung()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelHuongDan.Controls.Add(formChild);
            panelHuongDan.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void frmCachSuDung_Load(object sender, EventArgs e)
        {

        }

        private void tsmHuonDan_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHuongDanSuDung());
        }

        private void tsmHuongDan_2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHuongDanSuDung_2());
        }

        private void tsmHuongDan_3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHuongDanSuDung_3());
        }
    }
}
