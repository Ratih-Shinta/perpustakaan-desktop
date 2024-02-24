namespace perpustakaan
{
    partial class login
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
            txtusername = new TextBox();
            txtpassword = new TextBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            llregister = new LinkLabel();
            btnlogin = new Button();
            btnclose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 117);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "password :";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(362, 68);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(131, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(362, 114);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(131, 23);
            txtpassword.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(386, 143);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 177);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "dont have account ?";
            // 
            // llregister
            // 
            llregister.AutoSize = true;
            llregister.Location = new Point(415, 177);
            llregister.Name = "llregister";
            llregister.Size = new Size(46, 15);
            llregister.TabIndex = 7;
            llregister.TabStop = true;
            llregister.Text = "register";
            llregister.LinkClicked += llregister_LinkClicked;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(278, 221);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(418, 221);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 9;
            btnclose.Text = "close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclose);
            Controls.Add(btnlogin);
            Controls.Add(llregister);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private CheckBox checkBox1;
        private Label label4;
        private LinkLabel llregister;
        private Button btnlogin;
        private Button btnclose;
    }
}