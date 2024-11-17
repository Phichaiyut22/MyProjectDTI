namespace MyProjectDTI02
{
    partial class FrmLotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotto));
            rdoCloseLotto = new RadioButton();
            rdoOpenLotto = new RadioButton();
            groupBox4 = new GroupBox();
            btnLotto2Down = new Button();
            lblLotto2Down = new Label();
            groupBox3 = new GroupBox();
            btnLotto3Down = new Button();
            lblLotto3Down2 = new Label();
            lblLotto3Down1 = new Label();
            groupBox2 = new GroupBox();
            btnLotto3on = new Button();
            lblLotto3On2 = new Label();
            lblLotto3On1 = new Label();
            groupBox1 = new GroupBox();
            btnLotto1 = new Button();
            lblLotto1 = new Label();
            dtpLottoDate = new DateTimePicker();
            label1 = new Label();
            btnMainMenu = new Button();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rdoCloseLotto
            // 
            rdoCloseLotto.AutoSize = true;
            rdoCloseLotto.Checked = true;
            rdoCloseLotto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoCloseLotto.Location = new Point(524, 578);
            rdoCloseLotto.Name = "rdoCloseLotto";
            rdoCloseLotto.Size = new Size(130, 25);
            rdoCloseLotto.TabIndex = 48;
            rdoCloseLotto.TabStop = true;
            rdoCloseLotto.Text = "ปิดการออกรางวัล";
            rdoCloseLotto.UseVisualStyleBackColor = true;
            rdoCloseLotto.Click += rdoCloseLotto_Click;
            // 
            // rdoOpenLotto
            // 
            rdoOpenLotto.AutoSize = true;
            rdoOpenLotto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoOpenLotto.Location = new Point(524, 534);
            rdoOpenLotto.Name = "rdoOpenLotto";
            rdoOpenLotto.Size = new Size(134, 25);
            rdoOpenLotto.TabIndex = 47;
            rdoOpenLotto.Text = "เปิดการออกรางวัล";
            rdoOpenLotto.UseVisualStyleBackColor = true;
            rdoOpenLotto.Click += rdoOpenLotto_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLotto2Down);
            groupBox4.Controls.Add(lblLotto2Down);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(174, 509);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(267, 107);
            groupBox4.TabIndex = 46;
            groupBox4.TabStop = false;
            groupBox4.Text = "รางวัลเลขท้าย 2 ตัวล่าง";
            // 
            // btnLotto2Down
            // 
            btnLotto2Down.Enabled = false;
            btnLotto2Down.Image = Properties.Resources.start2;
            btnLotto2Down.Location = new Point(202, 37);
            btnLotto2Down.Name = "btnLotto2Down";
            btnLotto2Down.Size = new Size(42, 38);
            btnLotto2Down.TabIndex = 39;
            btnLotto2Down.UseVisualStyleBackColor = true;
            btnLotto2Down.Click += btnLotto2Down_Click;
            // 
            // lblLotto2Down
            // 
            lblLotto2Down.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto2Down.ForeColor = Color.Red;
            lblLotto2Down.Location = new Point(56, 25);
            lblLotto2Down.Name = "lblLotto2Down";
            lblLotto2Down.Size = new Size(160, 72);
            lblLotto2Down.TabIndex = 32;
            lblLotto2Down.Text = "??";
            lblLotto2Down.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLotto3Down);
            groupBox3.Controls.Add(lblLotto3Down2);
            groupBox3.Controls.Add(lblLotto3Down1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(466, 324);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 172);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "รางวัล 3 ตัวล่าง";
            // 
            // btnLotto3Down
            // 
            btnLotto3Down.Enabled = false;
            btnLotto3Down.Image = Properties.Resources.start2;
            btnLotto3Down.Location = new Point(195, 74);
            btnLotto3Down.Name = "btnLotto3Down";
            btnLotto3Down.Size = new Size(47, 42);
            btnLotto3Down.TabIndex = 35;
            btnLotto3Down.UseVisualStyleBackColor = true;
            btnLotto3Down.Click += btnLotto3Down_Click;
            // 
            // lblLotto3Down2
            // 
            lblLotto3Down2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto3Down2.ForeColor = Color.Red;
            lblLotto3Down2.Location = new Point(56, 85);
            lblLotto3Down2.Name = "lblLotto3Down2";
            lblLotto3Down2.Size = new Size(160, 72);
            lblLotto3Down2.TabIndex = 33;
            lblLotto3Down2.Text = "???";
            lblLotto3Down2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLotto3Down1
            // 
            lblLotto3Down1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto3Down1.ForeColor = Color.Red;
            lblLotto3Down1.Location = new Point(56, 25);
            lblLotto3Down1.Name = "lblLotto3Down1";
            lblLotto3Down1.Size = new Size(160, 72);
            lblLotto3Down1.TabIndex = 32;
            lblLotto3Down1.Text = "???";
            lblLotto3Down1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLotto3on);
            groupBox2.Controls.Add(lblLotto3On2);
            groupBox2.Controls.Add(lblLotto3On1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(174, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 172);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "รางวัล 3 ตัวบน";
            // 
            // btnLotto3on
            // 
            btnLotto3on.Enabled = false;
            btnLotto3on.Image = Properties.Resources.start2;
            btnLotto3on.Location = new Point(202, 74);
            btnLotto3on.Name = "btnLotto3on";
            btnLotto3on.Size = new Size(47, 42);
            btnLotto3on.TabIndex = 34;
            btnLotto3on.UseVisualStyleBackColor = true;
            btnLotto3on.Click += btnLotto3on_Click;
            // 
            // lblLotto3On2
            // 
            lblLotto3On2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto3On2.ForeColor = Color.Red;
            lblLotto3On2.Location = new Point(56, 85);
            lblLotto3On2.Name = "lblLotto3On2";
            lblLotto3On2.Size = new Size(160, 72);
            lblLotto3On2.TabIndex = 33;
            lblLotto3On2.Text = "???";
            lblLotto3On2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLotto3On1
            // 
            lblLotto3On1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto3On1.ForeColor = Color.Red;
            lblLotto3On1.Location = new Point(56, 25);
            lblLotto3On1.Name = "lblLotto3On1";
            lblLotto3On1.Size = new Size(160, 72);
            lblLotto3On1.TabIndex = 32;
            lblLotto3On1.Text = "???";
            lblLotto3On1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLotto1);
            groupBox1.Controls.Add(lblLotto1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(174, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 104);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "รางวัลที่ 1";
            // 
            // btnLotto1
            // 
            btnLotto1.Enabled = false;
            btnLotto1.Image = Properties.Resources.start2;
            btnLotto1.Location = new Point(437, 36);
            btnLotto1.Name = "btnLotto1";
            btnLotto1.Size = new Size(47, 42);
            btnLotto1.TabIndex = 33;
            btnLotto1.UseVisualStyleBackColor = true;
            btnLotto1.Click += btnLotto1_Click;
            // 
            // lblLotto1
            // 
            lblLotto1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLotto1.ForeColor = Color.Red;
            lblLotto1.Location = new Point(154, 25);
            lblLotto1.Name = "lblLotto1";
            lblLotto1.Size = new Size(249, 64);
            lblLotto1.TabIndex = 32;
            lblLotto1.Text = "??????";
            lblLotto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpLottoDate
            // 
            dtpLottoDate.Location = new Point(356, 136);
            dtpLottoDate.Name = "dtpLottoDate";
            dtpLottoDate.Size = new Size(200, 23);
            dtpLottoDate.TabIndex = 42;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 127);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 41;
            label1.Text = "ประจำงวดวันที่";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Image = Properties.Resources.pevious1;
            btnMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btnMainMenu.Location = new Point(703, 28);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(102, 65);
            btnMainMenu.TabIndex = 40;
            btnMainMenu.Text = "หน้าจอหลัก";
            btnMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(109, 28);
            label3.Name = "label3";
            label3.Size = new Size(561, 59);
            label3.TabIndex = 39;
            label3.Text = "LOTTO หวยออนไลน์";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 641);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(829, 25);
            toolStrip1.TabIndex = 49;
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
            // FrmLotto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 666);
            Controls.Add(toolStrip1);
            Controls.Add(rdoCloseLotto);
            Controls.Add(rdoOpenLotto);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtpLottoDate);
            Controls.Add(label1);
            Controls.Add(btnMainMenu);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLotto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lotto - DTI Soft V.1.0";
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoCloseLotto;
        private RadioButton rdoOpenLotto;
        private GroupBox groupBox4;
        private Button btnLotto2Down;
        private Label lblLotto2Down;
        private GroupBox groupBox3;
        private Button btnLotto3Down;
        private Label lblLotto3Down2;
        private Label lblLotto3Down1;
        private GroupBox groupBox2;
        private Button btnLotto3on;
        private Label lblLotto3On2;
        private Label lblLotto3On1;
        private GroupBox groupBox1;
        private Button btnLotto1;
        private Label lblLotto1;
        private DateTimePicker dtpLottoDate;
        private Label label1;
        private Button btnMainMenu;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private System.Windows.Forms.Timer timer1;
    }
}