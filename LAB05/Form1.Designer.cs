namespace LAB05
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
            send_btn = new Button();
            from_textBox = new TextBox();
            to_textBox = new TextBox();
            pass_textBox = new TextBox();
            subject_textBox = new TextBox();
            body_richTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // send_btn
            // 
            send_btn.Location = new Point(12, 40);
            send_btn.Name = "send_btn";
            send_btn.Size = new Size(94, 63);
            send_btn.TabIndex = 0;
            send_btn.Text = "SEND";
            send_btn.UseVisualStyleBackColor = true;
            send_btn.Click += send_btn_Click;
            // 
            // from_textBox
            // 
            from_textBox.Location = new Point(197, 43);
            from_textBox.Name = "from_textBox";
            from_textBox.Size = new Size(238, 27);
            from_textBox.TabIndex = 1;
            // 
            // to_textBox
            // 
            to_textBox.Location = new Point(197, 76);
            to_textBox.Name = "to_textBox";
            to_textBox.Size = new Size(238, 27);
            to_textBox.TabIndex = 2;
            // 
            // pass_textBox
            // 
            pass_textBox.Location = new Point(557, 42);
            pass_textBox.Name = "pass_textBox";
            pass_textBox.Size = new Size(154, 27);
            pass_textBox.TabIndex = 3;
            // 
            // subject_textBox
            // 
            subject_textBox.Location = new Point(150, 131);
            subject_textBox.Name = "subject_textBox";
            subject_textBox.Size = new Size(561, 27);
            subject_textBox.TabIndex = 4;
            subject_textBox.TextChanged += textBox4_TextChanged;
            // 
            // body_richTextBox
            // 
            body_richTextBox.Location = new Point(150, 167);
            body_richTextBox.Name = "body_richTextBox";
            body_richTextBox.Size = new Size(561, 253);
            body_richTextBox.TabIndex = 5;
            body_richTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 79);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 8;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 131);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 9;
            label4.Text = "Subject:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 167);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Body:";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(body_richTextBox);
            Controls.Add(subject_textBox);
            Controls.Add(pass_textBox);
            Controls.Add(to_textBox);
            Controls.Add(from_textBox);
            Controls.Add(send_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send_btn;
        private TextBox from_textBox;
        private TextBox to_textBox;
        private TextBox pass_textBox;
        private TextBox subject_textBox;
        private RichTextBox body_richTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
