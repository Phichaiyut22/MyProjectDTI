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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();

            lblNameShow.Text = ShareData.name_show;

            timer1.Start();

            cbbPoint.SelectedIndex = 0;

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

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNumb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            calAndShow("+");
        }


        private void calAndShow(string symbol)
        {
            if (tbNum1.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนตัวเลขตัวที่ 1 ด้วย...");
            }
            else if (tbNum2.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนตัวเลขตัวที่ 2 ด้วย...");
            }
            else
            {
                //แปลงสิ่งที่ป้อนใน TextBox ซึ่งเป็นข้อความให้เป็นตัวเลข
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result = 0;

                if (symbol == "+")
                {
                    result = num1 + num2;
                }
                else if (symbol == "-")
                {
                    result = num1 - num2;
                }
                else if (symbol == "*")
                {
                    result = num1 * num2;
                }
                else if (symbol == "/")
                {
                    result = num1 / num2;
                }
                else if (symbol == "^")
                {
                    result = Math.Pow(num1, num2);
                }

                //คำนวณเสร็จตรวจสอบว่าจะแสดงทศนิยมกี่ตำแหน่ง แล้วนำไปกำหนดให้กับ lblShowResult
                if (cbbPoint.SelectedIndex == 0)
                {
                    lblShowResult.Text = result.ToString("#,##0.00");
                }
                else if (cbbPoint.SelectedIndex == 1)
                {
                    lblShowResult.Text = result.ToString("#,##0.0000");
                }
                else
                {
                    lblShowResult.Text = result.ToString("#,##0.000000000");
                }
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            calAndShow("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calAndShow("*");
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            calAndShow("/");
        }

        private void btPower_Click(object sender, EventArgs e)
        {
            calAndShow("^");
        }
    }
}
