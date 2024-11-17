namespace MyProjectDTI02
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            rdoStudent = new RadioButton();
            rdoTeacher = new RadioButton();
            btLogin = new Button();
            btExit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Btmlogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(599, 64);
            label1.TabIndex = 0;
            label1.Text = "DTI Soft V.1.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(93, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(289, 172);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 2;
            label2.Text = "ชื่อผู้ใช้ :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(289, 215);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 3;
            label3.Text = "รหัสผ่าน :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(411, 174);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "ภาษาอังกฤษเท่านั้น";
            tbUsername.Size = new Size(281, 23);
            tbUsername.TabIndex = 4;
            tbUsername.KeyPress += tbUsername_KeyPress;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(411, 224);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "เป็นตัวเลขเท่านั้น ไม่ตำกว่า 6 ตัว";
            tbPassword.Size = new Size(281, 23);
            tbPassword.TabIndex = 5;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // rdoStudent
            // 
            rdoStudent.AutoSize = true;
            rdoStudent.Checked = true;
            rdoStudent.Location = new Point(456, 279);
            rdoStudent.Name = "rdoStudent";
            rdoStudent.Size = new Size(66, 19);
            rdoStudent.TabIndex = 6;
            rdoStudent.TabStop = true;
            rdoStudent.Text = "Student";
            rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoTeacher
            // 
            rdoTeacher.AutoSize = true;
            rdoTeacher.Location = new Point(559, 279);
            rdoTeacher.Name = "rdoTeacher";
            rdoTeacher.Size = new Size(65, 19);
            rdoTeacher.TabIndex = 7;
            rdoTeacher.Text = "Teacher";
            rdoTeacher.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            btLogin.Image = Properties.Resources.start;
            btLogin.Location = new Point(411, 324);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(128, 41);
            btLogin.TabIndex = 8;
            btLogin.Text = "เข้าใช้งานระบบ";
            btLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.cancel;
            btExit.Location = new Point(564, 324);
            btExit.Name = "btExit";
            btExit.Size = new Size(128, 41);
            btExit.TabIndex = 9;
            btExit.Text = "ยกเลิก";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // Btmlogout
            // 
            Btmlogout.Image = Properties.Resources.exit3;
            Btmlogout.ImageAlign = ContentAlignment.MiddleRight;
            Btmlogout.Location = new Point(411, 371);
            Btmlogout.Name = "Btmlogout";
            Btmlogout.Size = new Size(281, 34);
            Btmlogout.TabIndex = 10;
            Btmlogout.Text = "ออกจากระบบ";
            Btmlogout.TextAlign = ContentAlignment.MiddleLeft;
            Btmlogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btmlogout.UseVisualStyleBackColor = true;
            Btmlogout.Click += Btmlogout_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 406);
            Controls.Add(Btmlogout);
            Controls.Add(btExit);
            Controls.Add(btLogin);
            Controls.Add(rdoTeacher);
            Controls.Add(rdoStudent);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - DTI Soft V.1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private RadioButton rdoStudent;
        private RadioButton rdoTeacher;
        private Button btLogin;
        private Button btExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Btmlogout;
    }
}
