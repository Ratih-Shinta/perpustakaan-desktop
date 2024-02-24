namespace perpustakaan
{
    partial class register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtemail = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            checkBox1 = new CheckBox();
            btnregister = new Button();
            btnclose = new Button();
            label5 = new Label();
            lllogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 23);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 108);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 150);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "password :";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(344, 61);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(154, 23);
            txtemail.TabIndex = 4;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(344, 105);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(154, 23);
            txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(344, 147);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(154, 23);
            txtpassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(391, 176);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(254, 246);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(75, 23);
            btnregister.TabIndex = 8;
            btnregister.Text = "register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(423, 246);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 23);
            btnclose.TabIndex = 9;
            btnclose.Text = "close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 210);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 10;
            label5.Text = "already have account ?";
            // 
            // lllogin
            // 
            lllogin.AutoSize = true;
            lllogin.Location = new Point(408, 210);
            lllogin.Name = "lllogin";
            lllogin.Size = new Size(34, 15);
            lllogin.TabIndex = 11;
            lllogin.TabStop = true;
            lllogin.Text = "login";
            lllogin.LinkClicked += lllogin_LinkClicked;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lllogin);
            Controls.Add(label5);
            Controls.Add(btnclose);
            Controls.Add(btnregister);
            Controls.Add(checkBox1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtemail;
        private TextBox txtusername;
        private TextBox txtpassword;
        private CheckBox checkBox1;
        private Button btnregister;
        private Button btnclose;
        private Label label5;
        private LinkLabel lllogin;
    }
}