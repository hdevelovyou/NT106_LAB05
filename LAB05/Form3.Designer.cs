namespace LAB05
{
    partial class Form3
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
            tbTo = new TextBox();
            tbFrom = new TextBox();
            tbSubject = new TextBox();
            tbPasswd = new TextBox();
            tbBody = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSend = new Button();
            btnAttach = new Button();
            tbPath = new TextBox();
            SuspendLayout();
            // 
            // tbTo
            // 
            tbTo.Location = new Point(149, 107);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(234, 27);
            tbTo.TabIndex = 0;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(149, 34);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(234, 27);
            tbFrom.TabIndex = 0;
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(149, 216);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(846, 27);
            tbSubject.TabIndex = 1;
            // 
            // tbPasswd
            // 
            tbPasswd.Location = new Point(740, 34);
            tbPasswd.Name = "tbPasswd";
            tbPasswd.Size = new Size(255, 27);
            tbPasswd.TabIndex = 2;
            // 
            // tbBody
            // 
            tbBody.Location = new Point(37, 347);
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(846, 265);
            tbBody.TabIndex = 3;
            tbBody.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 4;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 114);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 5;
            label2.Text = "To";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 41);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 219);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 314);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 8;
            label5.Text = "Body";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(901, 550);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 62);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(901, 346);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(94, 29);
            btnAttach.TabIndex = 10;
            btnAttach.Text = "attach";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(901, 398);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(250, 27);
            tbPath.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 624);
            Controls.Add(tbPath);
            Controls.Add(btnAttach);
            Controls.Add(btnSend);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBody);
            Controls.Add(tbPasswd);
            Controls.Add(tbSubject);
            Controls.Add(tbFrom);
            Controls.Add(tbTo);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTo;
        private TextBox tbFrom;
        private TextBox tbSubject;
        private TextBox tbPasswd;
        private RichTextBox tbBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSend;
        private Button btnAttach;
        private TextBox tbPath;
    }
}