namespace MyProjectDTI02
{
    partial class FrmSAUShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAUShop));
            groupBox1 = new GroupBox();
            btCancel = new Button();
            label23 = new Label();
            lblTotolPay = new Label();
            label21 = new Label();
            btCalculate = new Button();
            cbbSale = new ComboBox();
            label20 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            lblBookPay = new Label();
            lblRulerPay = new Label();
            lblRubberPay = new Label();
            lblPencilPay = new Label();
            lblPenPay = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbBook = new TextBox();
            tbRuler = new TextBox();
            tbRubber = new TextBox();
            tbPencil = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbPen = new TextBox();
            chkBook = new CheckBox();
            chkRuler = new CheckBox();
            chkRubber = new CheckBox();
            chkPencil = new CheckBox();
            chkPen = new CheckBox();
            btMainMenu = new Button();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCancel);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(lblTotolPay);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(btCalculate);
            groupBox1.Location = new Point(124, 416);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 97);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            // 
            // btCancel
            // 
            btCancel.Image = Properties.Resources.cancel;
            btCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btCancel.Location = new Point(515, 32);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(92, 40);
            btCancel.TabIndex = 59;
            btCancel.Text = "ยกเลิก";
            btCancel.TextAlign = ContentAlignment.MiddleRight;
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // label23
            // 
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(342, 39);
            label23.Name = "label23";
            label23.Size = new Size(54, 23);
            label23.TabIndex = 58;
            label23.Text = "บาท";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotolPay
            // 
            lblTotolPay.BackColor = Color.FromArgb(255, 255, 128);
            lblTotolPay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotolPay.ForeColor = Color.Red;
            lblTotolPay.Location = new Point(165, 22);
            lblTotolPay.Name = "lblTotolPay";
            lblTotolPay.Size = new Size(171, 54);
            lblTotolPay.TabIndex = 58;
            lblTotolPay.Text = "0.00";
            lblTotolPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(31, 39);
            label21.Name = "label21";
            label21.Size = new Size(128, 23);
            label21.TabIndex = 58;
            label21.Text = "รวมเป็นเงินทั้งสิ้น";
            label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btCalculate
            // 
            btCalculate.Image = Properties.Resources.calculator2;
            btCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btCalculate.Location = new Point(402, 32);
            btCalculate.Name = "btCalculate";
            btCalculate.Size = new Size(92, 40);
            btCalculate.TabIndex = 0;
            btCalculate.Text = "คำนวณ";
            btCalculate.TextAlign = ContentAlignment.MiddleRight;
            btCalculate.UseVisualStyleBackColor = true;
            btCalculate.Click += btCalculate_Click;
            // 
            // cbbSale
            // 
            cbbSale.FormattingEnabled = true;
            cbbSale.Items.AddRange(new object[] { "ไม่มีส่วนลด", "นักศึกษาลด 10%", "เจ้าหน้าที่ลด 7%", "อาจารย์ลด 5%" });
            cbbSale.Location = new Point(316, 378);
            cbbSale.Name = "cbbSale";
            cbbSale.Size = new Size(111, 23);
            cbbSale.TabIndex = 89;
            cbbSale.KeyPress += cbbSale_KeyPress;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(147, 375);
            label20.Name = "label20";
            label20.Size = new Size(120, 23);
            label20.TabIndex = 88;
            label20.Text = "ส่วนลด";
            label20.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(639, 332);
            label15.Name = "label15";
            label15.Size = new Size(54, 23);
            label15.TabIndex = 87;
            label15.Text = "บาท";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(639, 293);
            label16.Name = "label16";
            label16.Size = new Size(54, 23);
            label16.TabIndex = 86;
            label16.Text = "บาท";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(639, 252);
            label17.Name = "label17";
            label17.Size = new Size(54, 23);
            label17.TabIndex = 85;
            label17.Text = "บาท";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(639, 209);
            label18.Name = "label18";
            label18.Size = new Size(54, 23);
            label18.TabIndex = 84;
            label18.Text = "บาท";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(639, 168);
            label19.Name = "label19";
            label19.Size = new Size(54, 23);
            label19.TabIndex = 83;
            label19.Text = "บาท";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBookPay
            // 
            lblBookPay.BackColor = Color.FromArgb(255, 255, 128);
            lblBookPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookPay.ForeColor = Color.Red;
            lblBookPay.Location = new Point(490, 332);
            lblBookPay.Name = "lblBookPay";
            lblBookPay.Size = new Size(128, 23);
            lblBookPay.TabIndex = 82;
            lblBookPay.Text = "0.00";
            lblBookPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRulerPay
            // 
            lblRulerPay.BackColor = Color.FromArgb(255, 255, 128);
            lblRulerPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRulerPay.ForeColor = Color.Red;
            lblRulerPay.Location = new Point(490, 291);
            lblRulerPay.Name = "lblRulerPay";
            lblRulerPay.Size = new Size(128, 23);
            lblRulerPay.TabIndex = 81;
            lblRulerPay.Text = "0.00";
            lblRulerPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRubberPay
            // 
            lblRubberPay.BackColor = Color.FromArgb(255, 255, 128);
            lblRubberPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRubberPay.ForeColor = Color.Red;
            lblRubberPay.Location = new Point(490, 250);
            lblRubberPay.Name = "lblRubberPay";
            lblRubberPay.Size = new Size(128, 23);
            lblRubberPay.TabIndex = 80;
            lblRubberPay.Text = "0.00";
            lblRubberPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPencilPay
            // 
            lblPencilPay.BackColor = Color.FromArgb(255, 255, 128);
            lblPencilPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPencilPay.ForeColor = Color.Red;
            lblPencilPay.Location = new Point(490, 209);
            lblPencilPay.Name = "lblPencilPay";
            lblPencilPay.Size = new Size(128, 23);
            lblPencilPay.TabIndex = 79;
            lblPencilPay.Text = "0.00";
            lblPencilPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPenPay
            // 
            lblPenPay.BackColor = Color.FromArgb(255, 255, 128);
            lblPenPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPenPay.ForeColor = Color.Red;
            lblPenPay.Location = new Point(490, 168);
            lblPenPay.Name = "lblPenPay";
            lblPenPay.Size = new Size(128, 23);
            lblPenPay.TabIndex = 78;
            lblPenPay.Text = "0.00";
            lblPenPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(498, 127);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 77;
            label9.Text = "คิดเป็นเงิน";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(442, 332);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 76;
            label8.Text = "เล่ม";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(442, 291);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 75;
            label7.Text = "อัน";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(442, 250);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 74;
            label6.Text = "ด้าม";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(442, 209);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 73;
            label5.Text = "ด้าม";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(442, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 72;
            label4.Text = "ด้าม";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbBook
            // 
            tbBook.Enabled = false;
            tbBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBook.Location = new Point(316, 330);
            tbBook.Name = "tbBook";
            tbBook.PlaceholderText = "0";
            tbBook.Size = new Size(111, 29);
            tbBook.TabIndex = 71;
            tbBook.TextAlign = HorizontalAlignment.Right;
            tbBook.KeyPress += tbBook_KeyPress;
            tbBook.KeyUp += tbBook_KeyUp;
            // 
            // tbRuler
            // 
            tbRuler.Enabled = false;
            tbRuler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbRuler.Location = new Point(316, 289);
            tbRuler.Name = "tbRuler";
            tbRuler.PlaceholderText = "0";
            tbRuler.Size = new Size(111, 29);
            tbRuler.TabIndex = 70;
            tbRuler.TextAlign = HorizontalAlignment.Right;
            tbRuler.KeyPress += tbRuler_KeyPress;
            tbRuler.KeyUp += tbRuler_KeyUp;
            // 
            // tbRubber
            // 
            tbRubber.Enabled = false;
            tbRubber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbRubber.Location = new Point(316, 248);
            tbRubber.Name = "tbRubber";
            tbRubber.PlaceholderText = "0";
            tbRubber.Size = new Size(111, 29);
            tbRubber.TabIndex = 69;
            tbRubber.TextAlign = HorizontalAlignment.Right;
            tbRubber.KeyPress += tbRubber_KeyPress;
            tbRubber.KeyUp += tbRubber_KeyUp;
            // 
            // tbPencil
            // 
            tbPencil.Enabled = false;
            tbPencil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPencil.Location = new Point(316, 207);
            tbPencil.Name = "tbPencil";
            tbPencil.PlaceholderText = "0";
            tbPencil.Size = new Size(111, 29);
            tbPencil.TabIndex = 68;
            tbPencil.TextAlign = HorizontalAlignment.Right;
            tbPencil.KeyPress += tbPencil_KeyPress;
            tbPencil.KeyUp += tbPencil_KeyUp;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(307, 127);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 67;
            label2.Text = "จำนวน";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 127);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 66;
            label1.Text = "รายการสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPen
            // 
            tbPen.Enabled = false;
            tbPen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPen.Location = new Point(316, 164);
            tbPen.Name = "tbPen";
            tbPen.PlaceholderText = "0";
            tbPen.Size = new Size(111, 29);
            tbPen.TabIndex = 65;
            tbPen.TextAlign = HorizontalAlignment.Right;
            tbPen.TextChanged += tbPen_TextChanged;
            tbPen.KeyPress += tbPen_KeyPress;
            tbPen.KeyUp += tbPen_KeyUp;
            // 
            // chkBook
            // 
            chkBook.AutoSize = true;
            chkBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkBook.Location = new Point(124, 332);
            chkBook.Name = "chkBook";
            chkBook.Size = new Size(156, 25);
            chkBook.TabIndex = 64;
            chkBook.Text = "สมุด 10.25 บาท/เล่ม";
            chkBook.UseVisualStyleBackColor = true;
            chkBook.Click += chkBook_Click;
            // 
            // chkRuler
            // 
            chkRuler.AutoSize = true;
            chkRuler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkRuler.Location = new Point(124, 291);
            chkRuler.Name = "chkRuler";
            chkRuler.Size = new Size(151, 25);
            chkRuler.TabIndex = 63;
            chkRuler.Text = "ไม้บรรทัด 2 บาท/อัน";
            chkRuler.UseVisualStyleBackColor = true;
            chkRuler.Click += chkRuler_Click;
            // 
            // chkRubber
            // 
            chkRubber.AutoSize = true;
            chkRubber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkRubber.Location = new Point(124, 250);
            chkRubber.Name = "chkRubber";
            chkRubber.Size = new Size(164, 25);
            chkRubber.TabIndex = 62;
            chkRubber.Text = "ยางลบ 2.50 บาท/ก้อน";
            chkRubber.UseVisualStyleBackColor = true;
            chkRubber.Click += chkRubber_Click;
            // 
            // chkPencil
            // 
            chkPencil.AutoSize = true;
            chkPencil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkPencil.Location = new Point(124, 209);
            chkPencil.Name = "chkPencil";
            chkPencil.Size = new Size(159, 25);
            chkPencil.TabIndex = 61;
            chkPencil.Text = "ดินสอ 1.50 บาท/ด้าม";
            chkPencil.UseVisualStyleBackColor = true;
            chkPencil.Click += chkPencil_Click;
            // 
            // chkPen
            // 
            chkPen.AutoSize = true;
            chkPen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkPen.Location = new Point(124, 168);
            chkPen.Name = "chkPen";
            chkPen.Size = new Size(143, 25);
            chkPen.TabIndex = 60;
            chkPen.Text = "ปากกา 5 บาท/ด้าม";
            chkPen.UseVisualStyleBackColor = true;
            chkPen.Click += chkPen_Click;
            // 
            // btMainMenu
            // 
            btMainMenu.Image = Properties.Resources.pevious1;
            btMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btMainMenu.Location = new Point(694, 41);
            btMainMenu.Name = "btMainMenu";
            btMainMenu.Size = new Size(102, 65);
            btMainMenu.TabIndex = 59;
            btMainMenu.Text = "หน้าจอหลัก";
            btMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btMainMenu.UseVisualStyleBackColor = true;
            btMainMenu.Click += btMainMenu_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(100, 41);
            label3.Name = "label3";
            label3.Size = new Size(561, 59);
            label3.TabIndex = 58;
            label3.Text = "SAU Shop";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 551);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 25);
            toolStrip1.TabIndex = 91;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblNameShow
            // 
            lblNameShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameShow.ForeColor = Color.Blue;
            lblNameShow.Name = "lblNameShow";
            lblNameShow.Size = new Size(43, 22);
            lblNameShow.Text = "name?";
            // 
            // lblDatetimeShow
            // 
            lblDatetimeShow.Name = "lblDatetimeShow";
            lblDatetimeShow.Size = new Size(59, 22);
            lblDatetimeShow.Text = "datetime?";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmSAUShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 576);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(cbbSale);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(lblBookPay);
            Controls.Add(lblRulerPay);
            Controls.Add(lblRubberPay);
            Controls.Add(lblPencilPay);
            Controls.Add(lblPenPay);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbBook);
            Controls.Add(tbRuler);
            Controls.Add(tbRubber);
            Controls.Add(tbPencil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPen);
            Controls.Add(chkBook);
            Controls.Add(chkRuler);
            Controls.Add(chkRubber);
            Controls.Add(chkPencil);
            Controls.Add(chkPen);
            Controls.Add(btMainMenu);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSAUShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAU SHop - DTI Soft V.1.0";
            Load += FrmSAUShop_Load;
            groupBox1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btCancel;
        private Label label23;
        private Label lblTotolPay;
        private Label label21;
        private Button btCalculate;
        private ComboBox cbbSale;
        private Label label20;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label lblBookPay;
        private Label lblRulerPay;
        private Label lblRubberPay;
        private Label lblPencilPay;
        private Label lblPenPay;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbBook;
        private TextBox tbRuler;
        private TextBox tbRubber;
        private TextBox tbPencil;
        private Label label2;
        private Label label1;
        private TextBox tbPen;
        private CheckBox chkBook;
        private CheckBox chkRuler;
        private CheckBox chkRubber;
        private CheckBox chkPencil;
        private CheckBox chkPen;
        private Button btMainMenu;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private System.Windows.Forms.Timer timer1;
    }
}