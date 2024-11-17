namespace MyProjectDTI02
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            btnMainMenu = new Button();
            label1 = new Label();
            btSelectImage = new Button();
            pbStu = new PictureBox();
            btClose = new Button();
            btCancel = new Button();
            btRegister = new Button();
            cbConfirm = new CheckBox();
            lsbStuSubjectSelect = new ListBox();
            btUnSelectAll = new Button();
            btUnSelectOne = new Button();
            btSelectAll = new Button();
            btSelectOne = new Button();
            label7 = new Label();
            lstSubjectShow = new ListBox();
            cbbStuLevel = new ComboBox();
            label6 = new Label();
            rdStuFund = new RadioButton();
            rdStuNormal = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            tbStuFullname = new TextBox();
            label3 = new Label();
            tbStuNo = new TextBox();
            label2 = new Label();
            mcdRegister = new MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStu).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 612);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(831, 25);
            toolStrip1.TabIndex = 2;
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
            // btnMainMenu
            // 
            btnMainMenu.Image = Properties.Resources.pevious1;
            btnMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btnMainMenu.Location = new Point(666, 34);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(102, 65);
            btnMainMenu.TabIndex = 84;
            btnMainMenu.Text = "หน้าจอหลัก";
            btnMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(61, 34);
            label1.Name = "label1";
            label1.Size = new Size(561, 65);
            label1.TabIndex = 83;
            label1.Text = "ลงทะเบียนเรียน";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(727, 347);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(31, 28);
            btSelectImage.TabIndex = 82;
            btSelectImage.Text = "...";
            btSelectImage.UseVisualStyleBackColor = true;
            // 
            // pbStu
            // 
            pbStu.BorderStyle = BorderStyle.FixedSingle;
            pbStu.Location = new Point(506, 131);
            pbStu.Margin = new Padding(2);
            pbStu.Name = "pbStu";
            pbStu.Size = new Size(206, 245);
            pbStu.SizeMode = PictureBoxSizeMode.CenterImage;
            pbStu.TabIndex = 81;
            pbStu.TabStop = false;
            // 
            // btClose
            // 
            btClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.Black;
            btClose.Image = Properties.Resources.exit3;
            btClose.Location = new Point(506, 508);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(252, 47);
            btClose.TabIndex = 80;
            btClose.Text = "ปิดโปรแกรม";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btClose.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.ForeColor = Color.Black;
            btCancel.Image = Properties.Resources.cancel2;
            btCancel.Location = new Point(506, 453);
            btCancel.Margin = new Padding(2);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(252, 47);
            btCancel.TabIndex = 79;
            btCancel.Text = "ยกเลิก";
            btCancel.TextAlign = ContentAlignment.MiddleRight;
            btCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            btRegister.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btRegister.ForeColor = Color.Black;
            btRegister.Image = Properties.Resources.add;
            btRegister.Location = new Point(644, 400);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(114, 47);
            btRegister.TabIndex = 78;
            btRegister.Text = "ลงทะเบียน";
            btRegister.TextAlign = ContentAlignment.MiddleRight;
            btRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btRegister.UseVisualStyleBackColor = true;
            // 
            // cbConfirm
            // 
            cbConfirm.AutoSize = true;
            cbConfirm.Location = new Point(506, 417);
            cbConfirm.Margin = new Padding(2);
            cbConfirm.Name = "cbConfirm";
            cbConfirm.Size = new Size(114, 19);
            cbConfirm.TabIndex = 77;
            cbConfirm.Text = "ยืนยันการลงทะเบียน";
            cbConfirm.UseVisualStyleBackColor = true;
            // 
            // lsbStuSubjectSelect
            // 
            lsbStuSubjectSelect.FormattingEnabled = true;
            lsbStuSubjectSelect.ItemHeight = 15;
            lsbStuSubjectSelect.Location = new Point(331, 401);
            lsbStuSubjectSelect.Margin = new Padding(2);
            lsbStuSubjectSelect.Name = "lsbStuSubjectSelect";
            lsbStuSubjectSelect.Size = new Size(158, 154);
            lsbStuSubjectSelect.TabIndex = 76;
            // 
            // btUnSelectAll
            // 
            btUnSelectAll.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUnSelectAll.ForeColor = Color.Red;
            btUnSelectAll.Location = new Point(237, 512);
            btUnSelectAll.Margin = new Padding(2);
            btUnSelectAll.Name = "btUnSelectAll";
            btUnSelectAll.Size = new Size(75, 32);
            btUnSelectAll.TabIndex = 75;
            btUnSelectAll.Text = "<<";
            btUnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btUnSelectOne
            // 
            btUnSelectOne.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btUnSelectOne.ForeColor = Color.Red;
            btUnSelectOne.Location = new Point(237, 476);
            btUnSelectOne.Margin = new Padding(2);
            btUnSelectOne.Name = "btUnSelectOne";
            btUnSelectOne.Size = new Size(75, 32);
            btUnSelectOne.TabIndex = 74;
            btUnSelectOne.Text = "<";
            btUnSelectOne.UseVisualStyleBackColor = true;
            // 
            // btSelectAll
            // 
            btSelectAll.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSelectAll.ForeColor = Color.LimeGreen;
            btSelectAll.Location = new Point(237, 437);
            btSelectAll.Margin = new Padding(2);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(75, 32);
            btSelectAll.TabIndex = 73;
            btSelectAll.Text = ">>";
            btSelectAll.UseVisualStyleBackColor = true;
            // 
            // btSelectOne
            // 
            btSelectOne.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSelectOne.ForeColor = Color.LimeGreen;
            btSelectOne.Location = new Point(237, 401);
            btSelectOne.Margin = new Padding(2);
            btSelectOne.Name = "btSelectOne";
            btSelectOne.Size = new Size(75, 32);
            btSelectOne.TabIndex = 72;
            btSelectOne.Text = ">";
            btSelectOne.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(59, 381);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 71;
            label7.Text = "รายวิชาที่ลงทะเบียน";
            // 
            // lstSubjectShow
            // 
            lstSubjectShow.FormattingEnabled = true;
            lstSubjectShow.ItemHeight = 15;
            lstSubjectShow.Items.AddRange(new object[] { "ภาษาไทย", "ภาษาอังกฤษ", "ภาษาญี่ปุ่น", "ภาษาจีน", "สังคมศึกษา", "คณิตศาสตร์", "พลศึกษา", "ประวัติศาสตร์", "คอมพิวเตอร์เบื้องต้น", "บัญชีเบื้องต้น", "กฎหมายเบื้องต้น" });
            lstSubjectShow.Location = new Point(62, 401);
            lstSubjectShow.Margin = new Padding(2);
            lstSubjectShow.Name = "lstSubjectShow";
            lstSubjectShow.Size = new Size(158, 154);
            lstSubjectShow.TabIndex = 70;
            // 
            // cbbStuLevel
            // 
            cbbStuLevel.FormattingEnabled = true;
            cbbStuLevel.Items.AddRange(new object[] { "ชั้นมัธยมศึกษาปีที่ 1", "ชั้นมัธยมศึกษาปีที่ 2", "ชั้นมัธยมศึกษาปีที่ 3", "ชั้นมัธยมศึกษาปีที่ 4", "ชั้นมัธยมศึกษาปีที่ 5", "ชั้นมัธยมศึกษาปีที่ 6" });
            cbbStuLevel.Location = new Point(62, 346);
            cbbStuLevel.Margin = new Padding(2);
            cbbStuLevel.Name = "cbbStuLevel";
            cbbStuLevel.Size = new Size(193, 23);
            cbbStuLevel.TabIndex = 69;
            cbbStuLevel.Text = "ชั้นมัธยมศึกษาปีที่ 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 327);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 68;
            label6.Text = "ระดับชั้น";
            // 
            // rdStuFund
            // 
            rdStuFund.AutoSize = true;
            rdStuFund.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdStuFund.Location = new Point(422, 292);
            rdStuFund.Margin = new Padding(2);
            rdStuFund.Name = "rdStuFund";
            rdStuFund.Size = new Size(64, 19);
            rdStuFund.TabIndex = 67;
            rdStuFund.Text = "กองทุนฯ";
            rdStuFund.UseVisualStyleBackColor = true;
            // 
            // rdStuNormal
            // 
            rdStuNormal.AutoSize = true;
            rdStuNormal.Checked = true;
            rdStuNormal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdStuNormal.Location = new Point(346, 292);
            rdStuNormal.Margin = new Padding(2);
            rdStuNormal.Name = "rdStuNormal";
            rdStuNormal.Size = new Size(46, 19);
            rdStuNormal.TabIndex = 66;
            rdStuNormal.TabStop = true;
            rdStuNormal.Text = "ปกติ";
            rdStuNormal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(345, 263);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 65;
            label5.Text = "ประเภทนักเรียน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(345, 194);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 64;
            label4.Text = "ชื่อ-สกุล";
            // 
            // tbStuFullname
            // 
            tbStuFullname.Location = new Point(347, 220);
            tbStuFullname.Margin = new Padding(2);
            tbStuFullname.Name = "tbStuFullname";
            tbStuFullname.Size = new Size(142, 23);
            tbStuFullname.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(345, 128);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 62;
            label3.Text = "เลขประจำตัวนักเรียน";
            // 
            // tbStuNo
            // 
            tbStuNo.Location = new Point(347, 154);
            tbStuNo.Margin = new Padding(2);
            tbStuNo.Name = "tbStuNo";
            tbStuNo.Size = new Size(142, 23);
            tbStuNo.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 60;
            label2.Text = "วันที่ลงทะเบียน";
            // 
            // mcdRegister
            // 
            mcdRegister.Location = new Point(62, 154);
            mcdRegister.Margin = new Padding(8);
            mcdRegister.Name = "mcdRegister";
            mcdRegister.TabIndex = 59;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 637);
            Controls.Add(btnMainMenu);
            Controls.Add(label1);
            Controls.Add(btSelectImage);
            Controls.Add(pbStu);
            Controls.Add(btClose);
            Controls.Add(btCancel);
            Controls.Add(btRegister);
            Controls.Add(cbConfirm);
            Controls.Add(lsbStuSubjectSelect);
            Controls.Add(btUnSelectAll);
            Controls.Add(btUnSelectOne);
            Controls.Add(btSelectAll);
            Controls.Add(btSelectOne);
            Controls.Add(label7);
            Controls.Add(lstSubjectShow);
            Controls.Add(cbbStuLevel);
            Controls.Add(label6);
            Controls.Add(rdStuFund);
            Controls.Add(rdStuNormal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbStuFullname);
            Controls.Add(label3);
            Controls.Add(tbStuNo);
            Controls.Add(label2);
            Controls.Add(mcdRegister);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ลงทะเบียนเรียน - DTI Soft V.1.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private Button btnMainMenu;
        private Label label1;
        private Button btSelectImage;
        private PictureBox pbStu;
        private Button btClose;
        private Button btCancel;
        private Button btRegister;
        private CheckBox cbConfirm;
        private ListBox lsbStuSubjectSelect;
        private Button btUnSelectAll;
        private Button btUnSelectOne;
        private Button btSelectAll;
        private Button btSelectOne;
        private Label label7;
        private ListBox lstSubjectShow;
        private ComboBox cbbStuLevel;
        private Label label6;
        private RadioButton rdStuFund;
        private RadioButton rdStuNormal;
        private Label label5;
        private Label label4;
        private TextBox tbStuFullname;
        private Label label3;
        private TextBox tbStuNo;
        private Label label2;
        private MonthCalendar mcdRegister;
        private System.Windows.Forms.Timer timer1;
    }
}