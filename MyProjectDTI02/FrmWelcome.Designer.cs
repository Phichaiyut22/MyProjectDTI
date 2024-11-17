namespace MyProjectDTI02
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            lblNameShow = new ToolStripLabel();
            lblDatetimeShow = new ToolStripLabel();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpBirthDate = new DateTimePicker();
            lblShowResult = new Label();
            btMainMenu = new Button();
            btOk = new Button();
            btCancel = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(635, 70);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblNameShow, lblDatetimeShow });
            toolStrip1.Location = new Point(0, 613);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(908, 25);
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
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(395, 259);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(47, 19);
            rdoFemale.TabIndex = 15;
            rdoFemale.Text = "หญิง";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(292, 259);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(43, 19);
            rdoMale.TabIndex = 14;
            rdoMale.TabStop = true;
            rdoMale.Text = "ชาย";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(247, 154);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "ภาษาอังกฤษเท่านั้น";
            tbName.Size = new Size(281, 23);
            tbName.TabIndex = 12;
            tbName.KeyPress += tbName_KeyPress;
            // 
            // label3
            // 
            label3.Location = new Point(125, 204);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 11;
            label3.Text = "วัน เดือน ปี เกิด :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(125, 152);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 10;
            label2.Text = "ชื่อผู้ใช้ :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(251, 207);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(277, 23);
            dtpBirthDate.TabIndex = 18;
            // 
            // lblShowResult
            // 
            lblShowResult.BackColor = Color.Yellow;
            lblShowResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowResult.ForeColor = Color.Blue;
            lblShowResult.Location = new Point(39, 303);
            lblShowResult.Name = "lblShowResult";
            lblShowResult.Size = new Size(635, 261);
            lblShowResult.TabIndex = 19;
            lblShowResult.Text = "?????";
            lblShowResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            btMainMenu.Image = Properties.Resources.pevious1;
            btMainMenu.ImageAlign = ContentAlignment.TopCenter;
            btMainMenu.Location = new Point(721, 152);
            btMainMenu.Name = "btMainMenu";
            btMainMenu.Size = new Size(132, 70);
            btMainMenu.TabIndex = 20;
            btMainMenu.Text = "หน้าจอหลัก";
            btMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btMainMenu.UseVisualStyleBackColor = true;
            btMainMenu.Click += btMainMenu_Click;
            // 
            // btOk
            // 
            btOk.Image = Properties.Resources.ok;
            btOk.ImageAlign = ContentAlignment.TopCenter;
            btOk.Location = new Point(721, 259);
            btOk.Name = "btOk";
            btOk.Size = new Size(132, 70);
            btOk.TabIndex = 21;
            btOk.Text = "ตกลง";
            btOk.TextAlign = ContentAlignment.BottomCenter;
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Image = Properties.Resources.cancel1;
            btCancel.ImageAlign = ContentAlignment.TopCenter;
            btCancel.Location = new Point(721, 389);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(132, 70);
            btCancel.TabIndex = 22;
            btCancel.Text = "ยกเลิก";
            btCancel.TextAlign = ContentAlignment.BottomCenter;
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 638);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(btMainMenu);
            Controls.Add(lblShowResult);
            Controls.Add(dtpBirthDate);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "หน้าจอ Welcome - DTI Soft V.1.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblNameShow;
        private ToolStripLabel lblDatetimeShow;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private TextBox tbName;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpBirthDate;
        private Label lblShowResult;
        private Button btMainMenu;
        private Button btOk;
        private Button btCancel;
        private System.Windows.Forms.Timer timer1;
    }
}