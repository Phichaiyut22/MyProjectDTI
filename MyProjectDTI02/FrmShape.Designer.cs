namespace MyProjectDTI02
{
    partial class FrmShape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShape));
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCircleCancel = new Button();
            btnCircleCalculate = new Button();
            lblCircleResult = new Label();
            label2 = new Label();
            rdoCircleRound = new RadioButton();
            rdoCircleArea = new RadioButton();
            tbCircleRadius = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tbSquareHeight = new TextBox();
            label8 = new Label();
            btnSquareCancel = new Button();
            btnSquareCalculate = new Button();
            lblSquareResult = new Label();
            label6 = new Label();
            rdoSquareRound = new RadioButton();
            rdoSquareArea = new RadioButton();
            tbSquareWidth = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            tbTriangleCorner = new TextBox();
            label13 = new Label();
            tbTriangleHeight = new TextBox();
            label9 = new Label();
            btnTriangleCancel = new Button();
            btnTriangleCalculate = new Button();
            lblTriangleResult = new Label();
            label11 = new Label();
            rdoTriangleRound = new RadioButton();
            rdoTriangleArea = new RadioButton();
            tbTriangleBase = new TextBox();
            label12 = new Label();
            btnMainMenu = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 513);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(67, 132);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(658, 325);
            tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCircleCancel);
            tabPage1.Controls.Add(btnCircleCalculate);
            tabPage1.Controls.Add(lblCircleResult);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(rdoCircleRound);
            tabPage1.Controls.Add(rdoCircleArea);
            tabPage1.Controls.Add(tbCircleRadius);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(650, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "วงกลม";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCircleCancel
            // 
            btnCircleCancel.Image = Properties.Resources.cancel2;
            btnCircleCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCircleCancel.Location = new Point(474, 168);
            btnCircleCancel.Name = "btnCircleCancel";
            btnCircleCancel.Size = new Size(92, 40);
            btnCircleCancel.TabIndex = 61;
            btnCircleCancel.Text = "ยกเลิก";
            btnCircleCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCircleCancel.UseVisualStyleBackColor = true;
            // 
            // btnCircleCalculate
            // 
            btnCircleCalculate.Image = Properties.Resources.calculator2;
            btnCircleCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCircleCalculate.Location = new Point(474, 111);
            btnCircleCalculate.Name = "btnCircleCalculate";
            btnCircleCalculate.Size = new Size(92, 40);
            btnCircleCalculate.TabIndex = 60;
            btnCircleCalculate.Text = "คำนวณ";
            btnCircleCalculate.TextAlign = ContentAlignment.MiddleRight;
            btnCircleCalculate.UseVisualStyleBackColor = true;
            // 
            // lblCircleResult
            // 
            lblCircleResult.BackColor = Color.Yellow;
            lblCircleResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCircleResult.ForeColor = Color.Red;
            lblCircleResult.Location = new Point(82, 222);
            lblCircleResult.Name = "lblCircleResult";
            lblCircleResult.Size = new Size(330, 37);
            lblCircleResult.TabIndex = 5;
            lblCircleResult.Text = "0.00";
            lblCircleResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 193);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 4;
            label2.Text = "ผลลัพธ์";
            // 
            // rdoCircleRound
            // 
            rdoCircleRound.AutoSize = true;
            rdoCircleRound.Location = new Point(85, 152);
            rdoCircleRound.Name = "rdoCircleRound";
            rdoCircleRound.Size = new Size(115, 25);
            rdoCircleRound.TabIndex = 3;
            rdoCircleRound.Text = "เส้นรอบวงกลม";
            rdoCircleRound.UseVisualStyleBackColor = true;
            // 
            // rdoCircleArea
            // 
            rdoCircleArea.AutoSize = true;
            rdoCircleArea.Checked = true;
            rdoCircleArea.Location = new Point(85, 114);
            rdoCircleArea.Name = "rdoCircleArea";
            rdoCircleArea.Size = new Size(107, 25);
            rdoCircleArea.TabIndex = 2;
            rdoCircleArea.TabStop = true;
            rdoCircleArea.Text = "พื้นที่ทรงกลม";
            rdoCircleArea.UseVisualStyleBackColor = true;
            // 
            // tbCircleRadius
            // 
            tbCircleRadius.Location = new Point(82, 67);
            tbCircleRadius.Name = "tbCircleRadius";
            tbCircleRadius.Size = new Size(330, 29);
            tbCircleRadius.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "ป้อนรัศมี";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbSquareHeight);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btnSquareCancel);
            tabPage2.Controls.Add(btnSquareCalculate);
            tabPage2.Controls.Add(lblSquareResult);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(rdoSquareRound);
            tabPage2.Controls.Add(rdoSquareArea);
            tabPage2.Controls.Add(tbSquareWidth);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(650, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "สี่เหลี่ยม";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbSquareHeight
            // 
            tbSquareHeight.Location = new Point(272, 67);
            tbSquareHeight.Name = "tbSquareHeight";
            tbSquareHeight.Size = new Size(139, 29);
            tbSquareHeight.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(270, 34);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 70;
            label8.Text = "ป้อนยาว";
            // 
            // btnSquareCancel
            // 
            btnSquareCancel.Image = Properties.Resources.cancel2;
            btnSquareCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnSquareCancel.Location = new Point(478, 168);
            btnSquareCancel.Name = "btnSquareCancel";
            btnSquareCancel.Size = new Size(92, 40);
            btnSquareCancel.TabIndex = 69;
            btnSquareCancel.Text = "ยกเลิก";
            btnSquareCancel.TextAlign = ContentAlignment.MiddleRight;
            btnSquareCancel.UseVisualStyleBackColor = true;
            // 
            // btnSquareCalculate
            // 
            btnSquareCalculate.Image = Properties.Resources.calculator2;
            btnSquareCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSquareCalculate.Location = new Point(478, 111);
            btnSquareCalculate.Name = "btnSquareCalculate";
            btnSquareCalculate.Size = new Size(92, 40);
            btnSquareCalculate.TabIndex = 68;
            btnSquareCalculate.Text = "คำนวณ";
            btnSquareCalculate.TextAlign = ContentAlignment.MiddleRight;
            btnSquareCalculate.UseVisualStyleBackColor = true;
            // 
            // lblSquareResult
            // 
            lblSquareResult.BackColor = Color.Yellow;
            lblSquareResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSquareResult.ForeColor = Color.Red;
            lblSquareResult.Location = new Point(86, 222);
            lblSquareResult.Name = "lblSquareResult";
            lblSquareResult.Size = new Size(330, 37);
            lblSquareResult.TabIndex = 67;
            lblSquareResult.Text = "0.00";
            lblSquareResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 193);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 66;
            label6.Text = "ผลลัพธ์";
            // 
            // rdoSquareRound
            // 
            rdoSquareRound.AutoSize = true;
            rdoSquareRound.Location = new Point(89, 152);
            rdoSquareRound.Name = "rdoSquareRound";
            rdoSquareRound.Size = new Size(123, 25);
            rdoSquareRound.TabIndex = 65;
            rdoSquareRound.Text = "เส้นรอบสี่เหลี่ยม";
            rdoSquareRound.UseVisualStyleBackColor = true;
            // 
            // rdoSquareArea
            // 
            rdoSquareArea.AutoSize = true;
            rdoSquareArea.Checked = true;
            rdoSquareArea.Location = new Point(89, 114);
            rdoSquareArea.Name = "rdoSquareArea";
            rdoSquareArea.Size = new Size(106, 25);
            rdoSquareArea.TabIndex = 64;
            rdoSquareArea.TabStop = true;
            rdoSquareArea.Text = "พื้นที่สี่เหลี่ยม";
            rdoSquareArea.UseVisualStyleBackColor = true;
            // 
            // tbSquareWidth
            // 
            tbSquareWidth.Location = new Point(86, 67);
            tbSquareWidth.Name = "tbSquareWidth";
            tbSquareWidth.Size = new Size(139, 29);
            tbSquareWidth.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 34);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 62;
            label7.Text = "ป้อนกว้าง";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbTriangleCorner);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(tbTriangleHeight);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(btnTriangleCancel);
            tabPage3.Controls.Add(btnTriangleCalculate);
            tabPage3.Controls.Add(lblTriangleResult);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(rdoTriangleRound);
            tabPage3.Controls.Add(rdoTriangleArea);
            tabPage3.Controls.Add(tbTriangleBase);
            tabPage3.Controls.Add(label12);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(650, 291);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbTriangleCorner
            // 
            tbTriangleCorner.Location = new Point(449, 67);
            tbTriangleCorner.Name = "tbTriangleCorner";
            tbTriangleCorner.Size = new Size(139, 29);
            tbTriangleCorner.TabIndex = 83;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(444, 31);
            label13.Name = "label13";
            label13.Size = new Size(155, 21);
            label13.TabIndex = 82;
            label13.Text = "ป้อนด้านตรงข้ามมุมฉาก";
            // 
            // tbTriangleHeight
            // 
            tbTriangleHeight.Location = new Point(272, 67);
            tbTriangleHeight.Name = "tbTriangleHeight";
            tbTriangleHeight.Size = new Size(139, 29);
            tbTriangleHeight.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(267, 31);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 80;
            label9.Text = "ป้อนสูง";
            // 
            // btnTriangleCancel
            // 
            btnTriangleCancel.Image = Properties.Resources.cancel2;
            btnTriangleCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnTriangleCancel.Location = new Point(478, 168);
            btnTriangleCancel.Name = "btnTriangleCancel";
            btnTriangleCancel.Size = new Size(92, 40);
            btnTriangleCancel.TabIndex = 79;
            btnTriangleCancel.Text = "ยกเลิก";
            btnTriangleCancel.TextAlign = ContentAlignment.MiddleRight;
            btnTriangleCancel.UseVisualStyleBackColor = true;
            // 
            // btnTriangleCalculate
            // 
            btnTriangleCalculate.Image = Properties.Resources.calculator2;
            btnTriangleCalculate.ImageAlign = ContentAlignment.MiddleLeft;
            btnTriangleCalculate.Location = new Point(478, 111);
            btnTriangleCalculate.Name = "btnTriangleCalculate";
            btnTriangleCalculate.Size = new Size(92, 40);
            btnTriangleCalculate.TabIndex = 78;
            btnTriangleCalculate.Text = "คำนวณ";
            btnTriangleCalculate.TextAlign = ContentAlignment.MiddleRight;
            btnTriangleCalculate.UseVisualStyleBackColor = true;
            // 
            // lblTriangleResult
            // 
            lblTriangleResult.BackColor = Color.Yellow;
            lblTriangleResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTriangleResult.ForeColor = Color.Red;
            lblTriangleResult.Location = new Point(86, 222);
            lblTriangleResult.Name = "lblTriangleResult";
            lblTriangleResult.Size = new Size(330, 37);
            lblTriangleResult.TabIndex = 77;
            lblTriangleResult.Text = "0.00";
            lblTriangleResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 190);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 76;
            label11.Text = "ผลลัพธ์";
            // 
            // rdoTriangleRound
            // 
            rdoTriangleRound.AutoSize = true;
            rdoTriangleRound.Location = new Point(86, 149);
            rdoTriangleRound.Name = "rdoTriangleRound";
            rdoTriangleRound.Size = new Size(139, 25);
            rdoTriangleRound.TabIndex = 75;
            rdoTriangleRound.Text = "เส้นรอบสามเหลี่ยม";
            rdoTriangleRound.UseVisualStyleBackColor = true;
            // 
            // rdoTriangleArea
            // 
            rdoTriangleArea.AutoSize = true;
            rdoTriangleArea.Checked = true;
            rdoTriangleArea.Location = new Point(86, 111);
            rdoTriangleArea.Name = "rdoTriangleArea";
            rdoTriangleArea.Size = new Size(122, 25);
            rdoTriangleArea.TabIndex = 74;
            rdoTriangleArea.TabStop = true;
            rdoTriangleArea.Text = "พื้นที่สามเหลี่ยม";
            rdoTriangleArea.UseVisualStyleBackColor = true;
            // 
            // tbTriangleBase
            // 
            tbTriangleBase.Location = new Point(86, 67);
            tbTriangleBase.Name = "tbTriangleBase";
            tbTriangleBase.Size = new Size(139, 29);
            tbTriangleBase.TabIndex = 73;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(81, 31);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 72;
            label12.Text = "ป้อนฐาน";
            // 
            // btnMainMenu
            // 
            btnMainMenu.Image = Properties.Resources.pevious1;
            btnMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btnMainMenu.Location = new Point(623, 38);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(102, 65);
            btnMainMenu.TabIndex = 29;
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
            label3.Location = new Point(67, 50);
            label3.Name = "label3";
            label3.Size = new Size(527, 41);
            label3.TabIndex = 28;
            label3.Text = "คำนวณรูปทรง";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmShape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(tabControl1);
            Controls.Add(btnMainMenu);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmShape";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "คำนวณรูปทรง - DTI Soft V.1.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnCircleCancel;
        private Button btnCircleCalculate;
        private Label lblCircleResult;
        private Label label2;
        private RadioButton rdoCircleRound;
        private RadioButton rdoCircleArea;
        private TextBox tbCircleRadius;
        private Label label1;
        private TabPage tabPage2;
        private TextBox tbSquareHeight;
        private Label label8;
        private Button btnSquareCancel;
        private Button btnSquareCalculate;
        private Label lblSquareResult;
        private Label label6;
        private RadioButton rdoSquareRound;
        private RadioButton rdoSquareArea;
        private TextBox tbSquareWidth;
        private Label label7;
        private TabPage tabPage3;
        private TextBox tbTriangleCorner;
        private Label label13;
        private TextBox tbTriangleHeight;
        private Label label9;
        private Button btnTriangleCancel;
        private Button btnTriangleCalculate;
        private Label lblTriangleResult;
        private Label label11;
        private RadioButton rdoTriangleRound;
        private RadioButton rdoTriangleArea;
        private TextBox tbTriangleBase;
        private Label label12;
        private Button btnMainMenu;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}