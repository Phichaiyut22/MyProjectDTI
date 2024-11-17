namespace MyProjectDTI02
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ตรวจสอบ TextBox ที่กดว่าไม่ใช่ปุ่มตัวอักษรและปุ่มคอนโทรลให้ยกเลิก
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //ตรวจสอบถ้า เป้น enter เรียก BTN login work
            if (e.KeyChar == (char)13)
            {
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ตรวจสอบTextBox ที่กดว่าไม่ใช่ปุ่มตัวเลขและปุ่มคอนโทรลให้ยกเลิก
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            

            //ตรวจสอบถ้า เป้น enter เรียก BTN login work
            if (e.KeyChar == (char)13) 
            {
                btLogin.PerformClick();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Validate หน้าจอ
            //if ( tbUsername.Text == "" )
            if (tbUsername.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อน username ด้วย. . . "
                );
            }
            else if (tbPassword.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อน password ด้วย. . . "
);
            }
            else if (tbPassword.Text.Length < 6)
            {
                ShareData.showWarningMSG("ป้อน Password ต้อง 6 ตัวอักษรขึ้นไป...."

               );
            }
            else if (tbUsername.Text.ToUpper() == "SAU" && tbPassword.Text == "123456789")
            {
                //จะเอาชื่อ และประเภท Student/Teacher เก็บในตัวแปรตรงกลางที่เตรียมไว้
                if (rdoStudent.Checked == true)
                {
                    ShareData.name_show = "SAU-Student";
                }
                else
                {
                    ShareData.name_show = "SAU-Teacher";
                }
                //เปิดหน้าจอ FrmMainMenu
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                this.Hide();
            }
            else
            {
                //แสดง MSG Username/Password ไม่ถูกต้อง

                ShareData.showWarningMSG("  \"Username/Password ไม่ถูกต้อง....\""


                );
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //ให้เคลียหน้าจอให้ทุกอย่างกลับเป็ฯเหมือนเดิม
            //tbUsername.Text = "";
            tbUsername.Clear();
            tbPassword.Clear();
            rdoStudent.Checked = true;
        }

        private void Btmlogout_Click(object sender, EventArgs e)
        {
            //แสดง msg ผ่านผู้ใช่จะออกจากรับบไหม  yes / no 
            if (MessageBox.Show("ต้องการออกจากระบบใช่ไหม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                // ปิดโปรแกรม
                Application.Exit();
            }
        }
    }
}
