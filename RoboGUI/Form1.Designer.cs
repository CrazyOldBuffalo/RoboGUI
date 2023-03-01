namespace RoboGUI
{
    partial class Form1
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
            btnForward = new Button();
            LeftBtn = new Button();
            Rightbtn = new Button();
            BtnBack = new Button();
            SerialText = new TextBox();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            AutoModeOff_Btn = new Button();
            AutoModeOn_Btn = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.FromArgb(159, 115, 171);
            btnForward.ForeColor = Color.White;
            btnForward.Location = new Point(293, 26);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(167, 62);
            btnForward.TabIndex = 0;
            btnForward.Text = "Forward";
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // LeftBtn
            // 
            LeftBtn.BackColor = Color.FromArgb(159, 115, 171);
            LeftBtn.Location = new Point(120, 94);
            LeftBtn.Name = "LeftBtn";
            LeftBtn.Size = new Size(167, 62);
            LeftBtn.TabIndex = 1;
            LeftBtn.Text = "Left";
            LeftBtn.UseVisualStyleBackColor = false;
            LeftBtn.Click += LeftBtn_Click;
            // 
            // Rightbtn
            // 
            Rightbtn.BackColor = Color.FromArgb(159, 115, 171);
            Rightbtn.Location = new Point(466, 94);
            Rightbtn.Name = "Rightbtn";
            Rightbtn.Size = new Size(167, 62);
            Rightbtn.TabIndex = 2;
            Rightbtn.Text = "Right";
            Rightbtn.UseVisualStyleBackColor = false;
            Rightbtn.Click += RightBtn_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(159, 115, 171);
            BtnBack.Location = new Point(293, 162);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(167, 62);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // SerialText
            // 
            SerialText.Location = new Point(6, 26);
            SerialText.Multiline = true;
            SerialText.Name = "SerialText";
            SerialText.ReadOnly = true;
            SerialText.Size = new Size(520, 353);
            SerialText.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(567, 431);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 46);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(63, 59, 108);
            groupBox1.Controls.Add(btnForward);
            groupBox1.Controls.Add(LeftBtn);
            groupBox1.Controls.Add(Rightbtn);
            groupBox1.Controls.Add(BtnBack);
            groupBox1.ForeColor = SystemColors.Window;
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 237);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Robot Controls";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(80, 87, 122);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1313, 391);
            splitContainer1.SplitterDistance = 771;
            splitContainer1.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(63, 59, 108);
            groupBox3.Controls.Add(AutoModeOff_Btn);
            groupBox3.Controls.Add(AutoModeOn_Btn);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(0, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(768, 142);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "AutoMode Controls";
            // 
            // AutoModeOff_Btn
            // 
            AutoModeOff_Btn.BackColor = Color.FromArgb(159, 115, 171);
            AutoModeOff_Btn.Location = new Point(466, 26);
            AutoModeOff_Btn.Name = "AutoModeOff_Btn";
            AutoModeOff_Btn.Size = new Size(167, 110);
            AutoModeOff_Btn.TabIndex = 5;
            AutoModeOff_Btn.Text = "AutoMode \r\nOff";
            AutoModeOff_Btn.UseVisualStyleBackColor = false;
            AutoModeOff_Btn.Click += AutoModeOff_Btn_Click;
            // 
            // AutoModeOn_Btn
            // 
            AutoModeOn_Btn.BackColor = Color.FromArgb(159, 115, 171);
            AutoModeOn_Btn.Location = new Point(120, 26);
            AutoModeOn_Btn.Name = "AutoModeOn_Btn";
            AutoModeOn_Btn.Size = new Size(167, 110);
            AutoModeOn_Btn.TabIndex = 4;
            AutoModeOn_Btn.Text = "AutoMode \r\nOn";
            AutoModeOn_Btn.UseVisualStyleBackColor = false;
            AutoModeOn_Btn.Click += AutoModeOn_Btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(63, 59, 108);
            groupBox2.Controls.Add(SerialText);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 385);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Robot Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 66, 88);
            ClientSize = new Size(1337, 499);
            Controls.Add(btnClose);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Rescue Robot";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnForward;
        private Button LeftBtn;
        private Button Rightbtn;
        private Button BtnBack;
        private TextBox SerialText;
        private Button btnClose;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button AutoModeOff_Btn;
        private Button AutoModeOn_Btn;
    }
}