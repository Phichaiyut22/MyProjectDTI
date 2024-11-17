namespace MyProjectDTI02
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            btMainMenu = new Button();
            lblShowResult = new Label();
            tbNum1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            tbNum2 = new TextBox();
            btPlus = new Button();
            btMinus = new Button();
            btMultiply = new Button();
            btPower = new Button();
            btDevide = new Button();
            cbbPoint = new ComboBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btMainMenu
            // 
            btMainMenu.Image = Properties.Resources.pevious1;
            btMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btMainMenu.Location = new Point(719, 44);
            btMainMenu.Name = "btMainMenu";
            btMainMenu.Size = new Size(132, 70);
            btMainMenu.TabIndex = 27;
            btMainMenu.Text = "หน้าจอหลัก";
            btMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btMainMenu.UseVisualStyleBackColor = true;
            btMainMenu.Click += btMainMenu_Click;
            // 
            // lblShowResult
            // 
            lblShowResult.BackColor = Color.Yellow;
            lblShowResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowResult.ForeColor = Color.Red;
            lblShowResult.Location = new Point(196, 450);
            lblShowResult.Name = "lblShowResult";
            lblShowResult.Size = new Size(478, 89);
            lblShowResult.TabIndex = 26;
            lblShowResult.Text = "?????";
            lblShowResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(247, 160);
            tbNum1.Name = "tbNum1";
            tbNum1.PlaceholderText = "ตัวเลขเท่านั้น";
            tbNum1.Size = new Size(281, 23);
            tbNum1.TabIndex = 25;
            tbNum1.KeyPress += tbNum1_KeyPress;
            // 
            // label3
            // 
            label3.Location = new Point(125, 210);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 24;
            label3.Text = "ป้อนตัวเลข";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(125, 158);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 23;
            label2.Text = "ป้อนตัวเลข";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(635, 70);
            label1.TabIndex = 22;
            label1.Text = "Calculator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 591);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(804, 25);
            toolStrip1.TabIndex = 21;
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
            // tbNum2
            // 
            tbNum2.Location = new Point(247, 216);
            tbNum2.Name = "tbNum2";
            tbNum2.PlaceholderText = "ตัวเลขเท่านั้น";
            tbNum2.Size = new Size(281, 23);
            tbNum2.TabIndex = 28;
            tbNum2.KeyPress += tbNumb2_KeyPress;
            // 
            // btPlus
            // 
            btPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPlus.ForeColor = Color.Blue;
            btPlus.Location = new Point(78, 285);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(71, 63);
            btPlus.TabIndex = 29;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMinus
            // 
            btMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btMinus.ForeColor = Color.Blue;
            btMinus.Location = new Point(196, 285);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(71, 63);
            btMinus.TabIndex = 30;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += btMinus_Click;
            // 
            // btMultiply
            // 
            btMultiply.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btMultiply.ForeColor = Color.Blue;
            btMultiply.Location = new Point(318, 285);
            btMultiply.Name = "btMultiply";
            btMultiply.Size = new Size(71, 63);
            btMultiply.TabIndex = 31;
            btMultiply.Text = "x";
            btMultiply.UseVisualStyleBackColor = true;
            btMultiply.Click += btMultiply_Click;
            // 
            // btPower
            // 
            btPower.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btPower.ForeColor = Color.Blue;
            btPower.Location = new Point(570, 285);
            btPower.Name = "btPower";
            btPower.Size = new Size(71, 63);
            btPower.TabIndex = 33;
            btPower.Text = "^";
            btPower.UseVisualStyleBackColor = true;
            btPower.Click += btPower_Click;
            // 
            // btDevide
            // 
            btDevide.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btDevide.ForeColor = Color.Blue;
            btDevide.Location = new Point(448, 285);
            btDevide.Name = "btDevide";
            btDevide.Size = new Size(71, 63);
            btDevide.TabIndex = 32;
            btDevide.Text = "÷";
            btDevide.UseVisualStyleBackColor = true;
            btDevide.Click += btDevide_Click;
            // 
            // cbbPoint
            // 
            cbbPoint.FormattingEnabled = true;
            cbbPoint.Items.AddRange(new object[] { "ทศนิยม 2 ตำแหน่ง", "ทศนิยม 4 ตำแหน่ง", "ทศนิยม 8 ตำแหน่ง" });
            cbbPoint.Location = new Point(252, 388);
            cbbPoint.Name = "cbbPoint";
            cbbPoint.Size = new Size(267, 23);
            cbbPoint.TabIndex = 34;
            cbbPoint.KeyPress += cbbPoint_KeyPress;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 478);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 35;
            label4.Text = "ผลลัพธ์";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 616);
            Controls.Add(label4);
            Controls.Add(cbbPoint);
            Controls.Add(btPower);
            Controls.Add(btDevide);
            Controls.Add(btMultiply);
            Controls.Add(btMinus);
            Controls.Add(btPlus);
            Controls.Add(tbNum2);
            Controls.Add(btMainMenu);
            Controls.Add(lblShowResult);
            Controls.Add(tbNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "หน้าจอเครื่องคิดเลข - DTI Sot V.1.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMainMenu;
        private Label lblShowResult;
        private TextBox tbNum1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private TextBox tbNum2;
        private Button btPlus;
        private Button btMinus;
        private Button btMultiply;
        private Button btPower;
        private Button btDevide;
        private ComboBox cbbPoint;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}