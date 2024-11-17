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
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();

            lblNameShow.Text = ShareData.name_show;

            timer1.Start();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new FrmMainMenu().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            lblDatetimeShow.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);

        }

        private void rdoOpenLotto_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่่าถูกเลือกไหม 
            if (rdoOpenLotto.Checked == true)
            {
                btnLotto1.Enabled = true;
                btnLotto3on.Enabled = true;
                btnLotto3Down.Enabled = true;
                btnLotto2Down.Enabled = true;
            }
        }

        private void rdoCloseLotto_Click(object sender, EventArgs e)
        {
            //ตรวจสอบว่่าถูกเลือกไหม 
            if (rdoCloseLotto.Checked == true)
            {
                btnLotto1.Enabled = false;
                btnLotto3on.Enabled = false;
                btnLotto3Down.Enabled = false;
                btnLotto2Down.Enabled = false;
                lblLotto1.Text = "??????";
                lblLotto3Down1.Text = "???";
                lblLotto3Down2.Text= "???";
                lblLotto3On1.Text = "???";
                lblLotto3On2.Text = "???";
                dtpLottoDate.Value = DateTime.Now;
            }
        }

        private void btnLotto1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า วันที่1 -16 
            if (dtpLottoDate.Value.Day != 1 && dtpLottoDate.Value.Day != 16)
            {
                ShareData.showWarningMSG("หวยออกวันที่ 1 หรือ 16 น่ะจร้ะ");
            }
            else
            {
                //ออกแบบ
                Random random = new Random();
                //คำสั่ง next จะสุ่มเลขตั้งแต่  0    -   n-1
                string loto = random.Next(100000).ToString("000000");
                lblLotto1.Text = loto;

            }
        }

        private void btnLotto3on_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า วันที่1 -16 
            if (dtpLottoDate.Value.Day != 1 && dtpLottoDate.Value.Day != 16)
            {
                ShareData.showWarningMSG("หวยออกวันที่ 1 หรือ 16 น่ะจร้ะ");
            }
            else
            {
                //ออกแบบ
                Random random = new Random();
                //คำสั่ง next จะสุ่มเลขตั้งแต่  0    -   n-1
                string loto = random.Next(1000).ToString("000");
                lblLotto3On1.Text = loto;
                loto = random.Next(1000).ToString("000");
                lblLotto3On2.Text = loto;

            }
        }

        private void btnLotto3Down_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า วันที่1 -16 
            if (dtpLottoDate.Value.Day != 1 && dtpLottoDate.Value.Day != 16)
            {
                ShareData.showWarningMSG("หวยออกวันที่ 1 หรือ 16 น่ะจร้ะ");
            }
            else
            {
                //ออกแบบ
                Random random = new Random();
                //คำสั่ง next จะสุ่มเลขตั้งแต่  0    -   n-1
                string loto = random.Next(1000).ToString("000");
                lblLotto3Down1.Text = loto;
                loto = random.Next(1000).ToString("000");
                lblLotto3Down2.Text = loto;

            }
        }

        private void btnLotto2Down_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่า วันที่1 -16 
            if (dtpLottoDate.Value.Day != 1 && dtpLottoDate.Value.Day != 16)
            {
                ShareData.showWarningMSG("หวยออกวันที่ 1 หรือ 16 น่ะจร้ะ");
            }
            else
            {
                //ออกแบบ
                Random random = new Random();
                //คำสั่ง next จะสุ่มเลขตั้งแต่  0    -   n-1
                string loto = random.Next(100).ToString("00");
                lblLotto2Down.Text = loto;
                

            }
        }
    }
}
