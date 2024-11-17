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
    public partial class FrmDooDung : Form
    {
        public FrmDooDung()
        {
            InitializeComponent();

            lblNameShow.Text = ShareData.name_show;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("th-TH");
            lblDatetimeShow.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", culture);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new FrmMainMenu().Show();
            this.Hide();
        }

        private void btnDooDung_Click(object sender, EventArgs e)
        {
            // validate UI
            if (mtbIDCard.MaskCompleted == false)
            {
                ShareData.showWarningMSG("ตรวจสอบการป้อน ID card ");

            }
            else if (tbName.Text.Length == 0)
            {
                ShareData.showWarningMSG("ตรวจสอบการป้อนชื่อ-สกุล");
            }
            else if (dtpBirthDate.Value.Date >= DateTime.Now.Date)
            {
                ShareData.showWarningMSG("ตรวจสอบวันเดือนปีเกิด ต้องไม่มากว่าหรือเท่ากับปัจจุบัน");
            }
            else if (nudWeight.Value == 0)
            {
                ShareData.showWarningMSG("ตรวจสอบการป้อนน้ำหนัก");
            }
            else if (nudHight.Value == 0)
            {
                ShareData.showWarningMSG("ตรวจสอบการป้อนส่วนสูง");
            }
            else
            {
                //เอาข้อมูลที่ป้อนไปแสดง แล้วประมวลผลตามเดือนเกิด
                lblIdCard.Text = mtbIDCard.Text;
                lblName.Text = tbName.Text;
                CultureInfo culture = new CultureInfo("th-TH");
                lblBirthDate.Text = dtpBirthDate.Value.ToString("dd MMMM พ.ศ. yyyy", culture);
                lblAge.Text = (DateTime.Now.Date.Year - dtpBirthDate.Value.Date.Year).ToString();
                lblWeight.Text = nudWeight.Value.ToString("0.00");
                lblHeight.Text = nudHight.Value.ToString("0.00");
                // ผลดวง
                int mount = dtpBirthDate.Value.Date.Month;
                switch (mount)
                {
                    case 1: lblShowResultDung.Text = "ฃ่วงนี้ดีน่ะ"; break;
                    case 2: lblShowResultDung.Text = "ฃ่วงนี้ไม่ดีน่ะ"; break;
                    case 3: lblShowResultDung.Text = "กำลังจะรวย!!!!"; break;
                    case 4: lblShowResultDung.Text = "เดินทางบ่อย"; break;
                    case 5: lblShowResultDung.Text = "จะถูกหักหลัง"; break;
                    case 6: lblShowResultDung.Text = "จะเดินทางไปต่างประเทศ"; break;
                    case 7: lblShowResultDung.Text = "มีโอกาสเปลี่ยนงาน"; break;
                    case 8: lblShowResultDung.Text = "มีโอกาสเจอเนื้อคู่"; break;
                    case 9: lblShowResultDung.Text = "มีโอกาสเลื่อนขั้น"; break;
                    case 10: lblShowResultDung.Text = "ระวังเรื่องสุขภาพ"; break;
                    case 11: lblShowResultDung.Text = "ระวังอุบัติเหตุ"; break;
                    case 12: lblShowResultDung.Text = "ไม่มีเคราะห์"; break;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //ทุกอย่างกลับเป็นเหมือนเดิม 
            mtbIDCard.Clear();
            tbName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            nudWeight.Value = 0;
            nudHight.Value = 0;
            lblIdCard.Text = "000000000";
            lblName.Text = "000000000";
            lblWeight.Text = "000000000";
            lblBirthDate.Text = "000000000";
            lblHeight.Text = "000000000";
            lblShowResultDung.Text = "ผลดวง";
            lblAge.Text = "000000000";
        }
    }
}
