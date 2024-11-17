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
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
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

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            cbbSale.SelectedIndex = 0;
        }

        private void cbbSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chkPen_Click(object sender, EventArgs e)
        {
            //ตรวจสอบ ว่า ติ๊กหรือ ไม่ติ๊ก หากติ๊กให้ช่องจำนวนใช้ได้ หากไม่ติ๊กให้ช่องป้อนจำนวนเป็น 0 ช่องคิดเป็นเงิน 0
            if (chkPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Text = "0";
                lblPenPay.Text = "0.00";
                tbPen.Enabled = false;
            }
        }

        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ตรวจสอบถ้าไม่ใช่ปุ่มตัวเลขให้ยกเลิก 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbPen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Length == 0)
            {
                ShareData.showWarningMSG("ช่องจำนวนปากกาต้องไม่ว่าง");
            }
            else
            {
                // ดังนั้น ถ้าปุ่มกดเป็นตัวเลข หรือ Ctrl ต่างๆ ให้เอาจำนวนที่ป้อนมาคำนวน ราคาแสดงที่ lable ข้างหลัง 
                double Pay = double.Parse(tbPen.Text) * 5;
                lblPenPay.Text = Pay.ToString("#,##0.00");
            }

        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.inputNumberOnly(e);
        }

        private void chkPencil_Click(object sender, EventArgs e)
        {
            //ตรวจสอบ ว่า ติ๊กหรือ ไม่ติ๊ก หากติ๊กให้ช่องจำนวนใช้ได้ หากไม่ติ๊กให้ช่องป้อนจำนวนเป็น 0 ช่องคิดเป็นเงิน 0
            if (chkPencil.Checked == true)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Text = "0";
                lblPencilPay.Text = "0.00";
                tbPencil.Enabled = false;
            }

        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Length == 0)
            {
                ShareData.showWarningMSG("ช่องจำนวนิดินสอต้องไม่ว่าง");
            }
            else
            {
                // ดังนั้น ถ้าปุ่มกดเป็นตัวเลข หรือ Ctrl ต่างๆ ให้เอาจำนวนที่ป้อนมาคำนวน ราคาแสดงที่ lable ข้างหลัง 
                double Pay = double.Parse(tbPencil.Text) * 1.5;
                lblPencilPay.Text = Pay.ToString("#,##0.00");
            }
        }

        private void chkRubber_Click(object sender, EventArgs e)
        {
            //ตรวจสอบ ว่า ติ๊กหรือ ไม่ติ๊ก หากติ๊กให้ช่องจำนวนใช้ได้ หากไม่ติ๊กให้ช่องป้อนจำนวนเป็น 0 ช่องคิดเป็นเงิน 0
            if (chkRubber.Checked == true)
            {
                tbRubber.Enabled = true;
            }
            else
            {
                tbRubber.Text = "0";
                lblRubberPay.Text = "0.00";
                tbRubber.Enabled = false;
            }
        }

        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.inputNumberOnly(e);
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRubber.Text.Length == 0)
            {
                ShareData.showWarningMSG("ช่องจำนวนยางลบต้องไม่ว่าง");
            }
            else
            {
                // ดังนั้น ถ้าปุ่มกดเป็นตัวเลข หรือ Ctrl ต่างๆ ให้เอาจำนวนที่ป้อนมาคำนวน ราคาแสดงที่ lable ข้างหลัง 
                double Pay = double.Parse(tbRubber.Text) * 2.5;
                lblRubberPay.Text = Pay.ToString("#,##0.00");
            }
        }

        private void chkRuler_Click(object sender, EventArgs e)
        {
            //ตรวจสอบ ว่า ติ๊กหรือ ไม่ติ๊ก หากติ๊กให้ช่องจำนวนใช้ได้ หากไม่ติ๊กให้ช่องป้อนจำนวนเป็น 0 ช่องคิดเป็นเงิน 0
            if (chkRuler.Checked == true)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Text = "0";
                lblRulerPay.Text = "0.00";
                tbRuler.Enabled = false;
            }
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.inputNumberOnly(e);
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Length == 0)
            {
                ShareData.showWarningMSG("ช่องจำนวนไม้บรรทัดต้องไม่ว่าง");
            }
            else
            {
                // ดังนั้น ถ้าปุ่มกดเป็นตัวเลข หรือ Ctrl ต่างๆ ให้เอาจำนวนที่ป้อนมาคำนวน ราคาแสดงที่ lable ข้างหลัง 
                double Pay = double.Parse(tbRuler.Text) * 2;
                lblRulerPay.Text = Pay.ToString("#,##0.00");
            }
        }

        private void chkBook_Click(object sender, EventArgs e)
        {
            //ตรวจสอบ ว่า ติ๊กหรือ ไม่ติ๊ก หากติ๊กให้ช่องจำนวนใช้ได้ หากไม่ติ๊กให้ช่องป้อนจำนวนเป็น 0 ช่องคิดเป็นเงิน 0
            if (chkBook.Checked == true)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Text = "0";
                lblBookPay.Text = "0.00";
                tbBook.Enabled = false;
            }
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.inputNumberOnly(e);
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Length == 0)
            {
                ShareData.showWarningMSG("ช่องจำนวนหนังสือต้องไม่ว่าง");
            }
            else
            {
                // ดังนั้น ถ้าปุ่มกดเป็นตัวเลข หรือ Ctrl ต่างๆ ให้เอาจำนวนที่ป้อนมาคำนวน ราคาแสดงที่ lable ข้างหลัง 
                double Pay = double.Parse(tbBook.Text) * 10.25;
                lblBookPay.Text = Pay.ToString("#,##0.00");
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            //นำคิดเป็นเงินของแต่ล่ะสินค้า มารวมกัน และตรวจสอบว่า มีส่วนหรือไม่อย่่างไร และ แสดงผล 
            double payTotalBeforeSale = double.Parse(lblPenPay.Text) +
                                         double.Parse(lblPencilPay.Text) +
                                         double.Parse(lblRubberPay.Text) +
                                         double.Parse(lblRulerPay.Text) +
                                         double.Parse(lblBookPay.Text);

            double payTotalAfterSale;
            if (cbbSale.SelectedIndex == 0)
            {
                payTotalAfterSale = payTotalBeforeSale;
            }
            else if (cbbSale.SelectedIndex == 1)
            {
                payTotalAfterSale = payTotalBeforeSale - (payTotalBeforeSale * 10 / 100);
            }
            else if (cbbSale.SelectedIndex == 2)
            {
                payTotalAfterSale = payTotalBeforeSale - (payTotalBeforeSale * 7 / 100);
            }
            else
            {
                payTotalAfterSale = payTotalBeforeSale - (payTotalBeforeSale * 5 / 100);
            }
            lblTotolPay.Text = payTotalAfterSale.ToString("#,##0.00");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //ทุกอย่างกลับเป็นเหมือนเดิม 
            chkPen.Checked = false;
            chkPencil.Checked = false;
            chkRubber.Checked = false;
            chkRuler.Checked = false;
            chkBook.Checked = false;

            tbPen.Text = "0";
            tbPen.Enabled = false;

            tbPencil.Text = "0";
            tbPencil.Enabled = false;

            tbRubber.Text = "0";
            tbRubber.Enabled = false;

            tbRuler.Text = "0";
            tbRuler.Enabled = false;

            tbBook.Text = "0";
            tbBook.Enabled = false;

            lblPenPay.Text = "0.00";
            lblPencilPay.Text = "0.00";
            lblRubberPay.Text = "0.00";
            lblRulerPay.Text = "0.00";
            lblBookPay.Text = "0.00";

            cbbSale.SelectedIndex = 0;

            lblTotolPay.Text = "0.00";
        }
    }
}
