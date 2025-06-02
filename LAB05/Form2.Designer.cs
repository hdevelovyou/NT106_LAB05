namespace LAB05
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbMail = new TextBox();
            tbPass = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnLogin = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 66);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 120);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 120);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Recent:";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(146, 27);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(297, 27);
            tbMail.TabIndex = 4;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(146, 63);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(297, 27);
            tbPass.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 120);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 6;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 120);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 7;
            label6.Text = "0";
            label6.Click += label6_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(578, 30);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 60);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(68, 157);
            listView1.Name = "listView1";
            listView1.Size = new Size(656, 281);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnLogin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbPass);
            Controls.Add(tbMail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMail;
        private TextBox tbPass;
        private Label label5;
        private Label label6;
        private Button btnLogin;
        private ListView listView1;
    }
}