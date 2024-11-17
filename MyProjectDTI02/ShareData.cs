using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectDTI02
{
    internal class ShareData
    {
        public static string name_show = "";

        public static void showWarningMSG(string msg)
        {
            MessageBox.Show(
                   msg,
                   "คำเตือน",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
            );
        }
        public static void inputNumberOnly(KeyPressEventArgs e)
        {
            //ตรวจสอบถ้าไม่ใช่ปุ่มตัวเลขให้ยกเลิก 
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
