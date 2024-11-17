namespace MyProjectDTI02
{
    partial class FrmDooDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDooDung));
            groupBox4 = new GroupBox();
            btnSelectImage = new Button();
            pbShowImage = new PictureBox();
            btnEnd = new Button();
            btnDooDung = new Button();
            btnNew = new Button();
            groupBox2 = new GroupBox();
            lblName = new Label();
            lblBirthDate = new Label();
            lblAge = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            lblIdCard = new Label();
            groupBox3 = new GroupBox();
            lblShowResultDung = new Label();
            label14 = new Label();
            label9 = new Label();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            nudHight = new NumericUpDown();
            nudWeight = new NumericUpDown();
            dtpBirthDate = new DateTimePicker();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            mtbIDCard = new MaskedTextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnMainMenu = new Button();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbShowImage).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSelectImage);
            groupBox4.Controls.Add(pbShowImage);
            groupBox4.Location = new Point(217, 375);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(175, 164);
            groupBox4.TabIndex = 41;
            groupBox4.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(137, 121);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(31, 28);
            btnSelectImage.TabIndex = 1;
            btnSelectImage.Text = "...";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // pbShowImage
            // 
            pbShowImage.Image = Properties.Resources.marvel1;
            pbShowImage.Location = new Point(18, 20);
            pbShowImage.Name = "pbShowImage";
            pbShowImage.Size = new Size(113, 129);
            pbShowImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbShowImage.TabIndex = 0;
            pbShowImage.TabStop = false;
            // 
            // btnEnd
            // 
            btnEnd.Image = Properties.Resources.exit1;
            btnEnd.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnd.Location = new Point(58, 490);
            btnEnd.Name = "btnEnd";
            btnEnd.Padding = new Padding(5, 0, 0, 0);
            btnEnd.Size = new Size(140, 51);
            btnEnd.TabIndex = 40;
            btnEnd.Text = "จบโปรแกรม";
            btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnDooDung
            // 
            btnDooDung.Image = Properties.Resources.find1;
            btnDooDung.ImageAlign = ContentAlignment.MiddleLeft;
            btnDooDung.Location = new Point(58, 433);
            btnDooDung.Name = "btnDooDung";
            btnDooDung.Padding = new Padding(5, 0, 0, 0);
            btnDooDung.Size = new Size(140, 51);
            btnDooDung.TabIndex = 39;
            btnDooDung.Text = "ดูดวง";
            btnDooDung.UseVisualStyleBackColor = true;
            btnDooDung.Click += btnDooDung_Click;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources.new1;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(58, 377);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(5, 0, 0, 0);
            btnNew.Size = new Size(140, 51);
            btnNew.TabIndex = 38;
            btnNew.Text = "ใหม่";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblName);
            groupBox2.Controls.Add(lblBirthDate);
            groupBox2.Controls.Add(lblAge);
            groupBox2.Controls.Add(lblHeight);
            groupBox2.Controls.Add(lblWeight);
            groupBox2.Controls.Add(lblIdCard);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(409, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 412);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลดวงของคุณ";
            // 
            // lblName
            // 
            lblName.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Green;
            lblName.Location = new Point(109, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(185, 16);
            lblName.TabIndex = 26;
            lblName.Text = "XXXXXXXXXX";
            // 
            // lblBirthDate
            // 
            lblBirthDate.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthDate.ForeColor = Color.Green;
            lblBirthDate.Location = new Point(109, 122);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(199, 15);
            lblBirthDate.TabIndex = 25;
            lblBirthDate.Text = "XXXXXXXXXX";
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = Color.Green;
            lblAge.Location = new Point(109, 165);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(185, 18);
            lblAge.TabIndex = 24;
            lblAge.Text = "XXXXXXXXXX";
            // 
            // lblHeight
            // 
            lblHeight.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeight.ForeColor = Color.Green;
            lblHeight.Location = new Point(109, 247);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(185, 16);
            lblHeight.TabIndex = 23;
            lblHeight.Text = "XXXXXXXXXX";
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeight.ForeColor = Color.Green;
            lblWeight.Location = new Point(109, 204);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(185, 19);
            lblWeight.TabIndex = 22;
            lblWeight.Text = "XXXXXXXXXX";
            // 
            // lblIdCard
            // 
            lblIdCard.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdCard.ForeColor = Color.Green;
            lblIdCard.Location = new Point(109, 38);
            lblIdCard.Name = "lblIdCard";
            lblIdCard.Size = new Size(185, 17);
            lblIdCard.TabIndex = 21;
            lblIdCard.Text = "XXXXXXXXXX";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblShowResultDung);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 283);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 110);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            // 
            // lblShowResultDung
            // 
            lblShowResultDung.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowResultDung.ForeColor = Color.BlueViolet;
            lblShowResultDung.Location = new Point(34, 43);
            lblShowResultDung.Name = "lblShowResultDung";
            lblShowResultDung.Size = new Size(504, 38);
            lblShowResultDung.TabIndex = 21;
            lblShowResultDung.Text = "ผลดวง";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(15, 165);
            label14.Name = "label14";
            label14.Size = new Size(59, 16);
            label14.TabIndex = 19;
            label14.Text = "อายุ";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(15, 247);
            label9.Name = "label9";
            label9.Size = new Size(59, 16);
            label9.TabIndex = 18;
            label9.Text = "ส่วนสูง";
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(15, 38);
            label13.Name = "label13";
            label13.Size = new Size(59, 16);
            label13.TabIndex = 14;
            label13.Text = "ID Card";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(15, 204);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 17;
            label10.Text = "น้ำหนัก";
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(15, 80);
            label12.Name = "label12";
            label12.Size = new Size(59, 16);
            label12.TabIndex = 15;
            label12.Text = "ชื่อ-สกุล";
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(15, 122);
            label11.Name = "label11";
            label11.Size = new Size(70, 16);
            label11.TabIndex = 16;
            label11.Text = "ว/ด/ป เกิด";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nudHight);
            groupBox1.Controls.Add(nudWeight);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(mtbIDCard);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(58, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 239);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(203, 200);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 13;
            label8.Text = "เซนติเมตร";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(203, 165);
            label7.Name = "label7";
            label7.Size = new Size(59, 16);
            label7.TabIndex = 12;
            label7.Text = "กิโลกรัม";
            // 
            // nudHight
            // 
            nudHight.DecimalPlaces = 2;
            nudHight.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudHight.Location = new Point(90, 200);
            nudHight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudHight.Name = "nudHight";
            nudHight.Size = new Size(98, 23);
            nudHight.TabIndex = 11;
            nudHight.Tag = "";
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 2;
            nudWeight.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudWeight.Location = new Point(90, 160);
            nudWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(98, 23);
            nudWeight.TabIndex = 10;
            nudWeight.Tag = "";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(90, 114);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(90, 74);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 23);
            tbName.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 204);
            label6.Name = "label6";
            label6.Size = new Size(59, 16);
            label6.TabIndex = 4;
            label6.Text = "ส่วนสูง";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 162);
            label5.Name = "label5";
            label5.Size = new Size(59, 16);
            label5.TabIndex = 3;
            label5.Text = "น้ำหนัก";
            // 
            // mtbIDCard
            // 
            mtbIDCard.Location = new Point(90, 32);
            mtbIDCard.Mask = "0-0000-00000-00-0";
            mtbIDCard.Name = "mtbIDCard";
            mtbIDCard.Size = new Size(200, 23);
            mtbIDCard.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 122);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 2;
            label4.Text = "ว/ด/ป เกิด";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ-สกุล";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 38);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 0;
            label2.Text = "ID Card";
            // 
            // btnMainMenu
            // 
            btnMainMenu.Image = Properties.Resources.pevious1;
            btnMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btnMainMenu.Location = new Point(660, 40);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(102, 65);
            btnMainMenu.TabIndex = 35;
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
            label3.Location = new Point(55, 40);
            label3.Name = "label3";
            label3.Size = new Size(561, 65);
            label3.TabIndex = 34;
            label3.Text = "ดูดวงแม่นๆ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 607);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(959, 25);
            toolStrip1.TabIndex = 42;
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
            // FrmDooDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 632);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox4);
            Controls.Add(btnEnd);
            Controls.Add(btnDooDung);
            Controls.Add(btnNew);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMainMenu);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDooDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ดูดวงแม่นๆ - DTI Soft V.1.0";
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbShowImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnSelectImage;
        private PictureBox pbShowImage;
        private Button btnEnd;
        private Button btnDooDung;
        private Button btnNew;
        private GroupBox groupBox2;
        private Label lblName;
        private Label lblBirthDate;
        private Label lblAge;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblIdCard;
        private GroupBox groupBox3;
        private Label lblShowResultDung;
        private Label label14;
        private Label label9;
        private Label label13;
        private Label label10;
        private Label label12;
        private Label label11;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private NumericUpDown nudHight;
        private NumericUpDown nudWeight;
        private DateTimePicker dtpBirthDate;
        private TextBox tbName;
        private Label label6;
        private Label label5;
        private MaskedTextBox mtbIDCard;
        private Label label4;
        private Label label1;
        private Label label2;
        private Button btnMainMenu;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private System.Windows.Forms.Timer timer1;
    }
}