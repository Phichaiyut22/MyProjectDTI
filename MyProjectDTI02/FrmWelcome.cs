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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
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

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            new FrmMainMenu().Show();
            this.Hide();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //validate
            if (tbName.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย...");
            }
            else if (dtpBirthDate.Value.Date >= DateTime.Now.Date)
            {
                ShareData.showWarningMSG("วัน เดือน ปีเกิดต้องน้อยกว่าวันปัจจุบัน....");
            }
            else
            {
                //เอาข้อมูลที่ป้อน และเลือก มาแสดงพร้อมกับ อายุที่คำนวณได้  
                //โดยนำข้อมูลทั้งหมดมาเชื่อมต่อกันแต่อยู่คนละบรรทัด
                string dataShow = "";

                dataShow = dataShow + "ชื่อ: " + tbName.Text + "\n";

                CultureInfo culture = new CultureInfo("th-TH");
                dataShow = dataShow + "เกิดวันที่: " + dtpBirthDate.Value.Date.ToString("dd เดือน MMMM พ.ศ. yyyy", culture) + "\n";

                int age = DateTime.Now.Year - dtpBirthDate.Value.Date.Year;
                dataShow = dataShow + "อายุ: " + age + " ปี\n";

                if (rdoMale.Checked == true)
                {
                    dataShow = dataShow + "เพศ: ชาย";
                }
                else
                {
                    dataShow = dataShow + "เพศ: หญิง";
                }

                lblShowResult.Text = dataShow;
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            rdoMale.Checked = true;
            lblShowResult.Text = "?????";
        }
    }
}
