namespace MyProjectDTI02
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            label1 = new Label();
            btWelcome = new Button();
            btCalculator = new Button();
            btLotto = new Button();
            btSAUShop = new Button();
            tbExitApp = new Button();
            btRegister = new Button();
            btShape = new Button();
            btDooDung = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 600);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(942, 25);
            toolStrip1.TabIndex = 0;
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
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(47, 32);
            label1.Name = "label1";
            label1.Size = new Size(820, 70);
            label1.TabIndex = 1;
            label1.Text = "DTI Soft V.1.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btWelcome
            // 
            btWelcome.Image = Properties.Resources.menu1;
            btWelcome.Location = new Point(47, 129);
            btWelcome.Name = "btWelcome";
            btWelcome.Size = new Size(168, 196);
            btWelcome.TabIndex = 2;
            btWelcome.Text = "Go to Welcome";
            btWelcome.TextAlign = ContentAlignment.BottomCenter;
            btWelcome.TextImageRelation = TextImageRelation.ImageAboveText;
            btWelcome.UseVisualStyleBackColor = true;
            btWelcome.Click += btWelcome_Click;
            // 
            // btCalculator
            // 
            btCalculator.Image = Properties.Resources.menu2;
            btCalculator.Location = new Point(267, 129);
            btCalculator.Name = "btCalculator";
            btCalculator.Size = new Size(168, 196);
            btCalculator.TabIndex = 3;
            btCalculator.Text = "Go to Calculator";
            btCalculator.TextAlign = ContentAlignment.BottomCenter;
            btCalculator.TextImageRelation = TextImageRelation.ImageAboveText;
            btCalculator.UseVisualStyleBackColor = true;
            btCalculator.Click += btCalculator_Click;
            // 
            // btLotto
            // 
            btLotto.Image = Properties.Resources.menu4;
            btLotto.Location = new Point(699, 129);
            btLotto.Name = "btLotto";
            btLotto.Size = new Size(168, 196);
            btLotto.TabIndex = 5;
            btLotto.Text = "Go to Lotto";
            btLotto.TextAlign = ContentAlignment.BottomCenter;
            btLotto.TextImageRelation = TextImageRelation.ImageAboveText;
            btLotto.UseVisualStyleBackColor = true;
            btLotto.Click += btLotto_Click;
            // 
            // btSAUShop
            // 
            btSAUShop.Image = Properties.Resources.menu3;
            btSAUShop.Location = new Point(479, 129);
            btSAUShop.Name = "btSAUShop";
            btSAUShop.Size = new Size(168, 196);
            btSAUShop.TabIndex = 4;
            btSAUShop.Text = "Go to SAU Shop";
            btSAUShop.TextAlign = ContentAlignment.BottomCenter;
            btSAUShop.TextImageRelation = TextImageRelation.ImageAboveText;
            btSAUShop.UseVisualStyleBackColor = true;
            btSAUShop.Click += btSAUShop_Click;
            // 
            // tbExitApp
            // 
            tbExitApp.Image = Properties.Resources.exitapp;
            tbExitApp.Location = new Point(699, 359);
            tbExitApp.Name = "tbExitApp";
            tbExitApp.Size = new Size(168, 196);
            tbExitApp.TabIndex = 9;
            tbExitApp.Text = "ออกจากระบบ";
            tbExitApp.TextAlign = ContentAlignment.BottomCenter;
            tbExitApp.TextImageRelation = TextImageRelation.ImageAboveText;
            tbExitApp.UseVisualStyleBackColor = true;
            tbExitApp.Click += tbExitApp_Click;
            // 
            // btRegister
            // 
            btRegister.Image = Properties.Resources.menu6;
            btRegister.Location = new Point(479, 359);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(168, 196);
            btRegister.TabIndex = 8;
            btRegister.Text = "Go to Register";
            btRegister.TextAlign = ContentAlignment.BottomCenter;
            btRegister.TextImageRelation = TextImageRelation.ImageAboveText;
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // btShape
            // 
            btShape.Image = Properties.Resources.menu7;
            btShape.Location = new Point(267, 359);
            btShape.Name = "btShape";
            btShape.Size = new Size(168, 196);
            btShape.TabIndex = 7;
            btShape.Text = "Go to Shape Area";
            btShape.TextAlign = ContentAlignment.BottomCenter;
            btShape.TextImageRelation = TextImageRelation.ImageAboveText;
            btShape.UseVisualStyleBackColor = true;
            btShape.Click += btShape_Click;
            // 
            // btDooDung
            // 
            btDooDung.Image = Properties.Resources.menu5;
            btDooDung.Location = new Point(47, 359);
            btDooDung.Name = "btDooDung";
            btDooDung.Size = new Size(168, 196);
            btDooDung.TabIndex = 6;
            btDooDung.Text = "Go to DooDung";
            btDooDung.TextAlign = ContentAlignment.BottomCenter;
            btDooDung.TextImageRelation = TextImageRelation.ImageAboveText;
            btDooDung.UseVisualStyleBackColor = true;
            btDooDung.Click += btDooDung_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 625);
            Controls.Add(tbExitApp);
            Controls.Add(btRegister);
            Controls.Add(btShape);
            Controls.Add(btDooDung);
            Controls.Add(btLotto);
            Controls.Add(btSAUShop);
            Controls.Add(btCalculator);
            Controls.Add(btWelcome);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "หน้าจอหลัก - DTI Soft V.1.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private Label label1;
        private Button btWelcome;
        private Button btCalculator;
        private Button btLotto;
        private Button btSAUShop;
        private Button tbExitApp;
        private Button btRegister;
        private Button btShape;
        private Button btDooDung;
        private System.Windows.Forms.Timer timer1;
    }
}