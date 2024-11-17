using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectDTI02
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
            //เอาข้อมูลที่เก็บใน name_show มาแสดงที่ Label: lblNameShow
            lblNameShow.Text = ShareData.name_show;

            //สั่ง Timer ให้ Start
            timer1.Start();
        }

        private void tbExitApp_Click(object sender, EventArgs e)
        {
            //เปิดกลับไปที่หน้าจอ FrmLogin
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.Show();
            new FrmLogin().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //แสดงวันที่ เวลา เดินแบบ RealTime
            CultureInfo culture = new CultureInfo("th-TH");
            lblDatetimeShow.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void btWelcome_Click(object sender, EventArgs e)
        {
            new FrmWelcome().Show();
            this.Hide();
        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            new FrmCalculator().Show();
            this.Hide();
        }

        private void btSAUShop_Click(object sender, EventArgs e)
        {
            new FrmSAUShop().Show();
            this.Hide();
        }

        private void btLotto_Click(object sender, EventArgs e)
        {
            new FrmLotto().Show();
            this.Hide();
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            new FrmDooDung().Show();
            this.Hide();
        }

        private void btShape_Click(object sender, EventArgs e)
        {
            new FrmShape().Show();
            this.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
            this.Hide();
        }
    }
}
