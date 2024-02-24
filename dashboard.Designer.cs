namespace perpustakaan
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtJudul = new TextBox();
            cbKetersediaan = new ComboBox();
            txtPenulis = new TextBox();
            txtPenerbit = new TextBox();
            txtID = new TextBox();
            rbFavorite = new RadioButton();
            cbFiksi = new CheckBox();
            cbNonfiksi = new CheckBox();
            dataGridView1 = new DataGridView();
            btnCreate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 20);
            label1.Name = "label1";
            label1.Size = new Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "FORM PERPUSTAKAAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 115);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "judul :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 158);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "penulis :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 203);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "genre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 247);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "penerbit :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 70);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 5;
            label6.Text = "id :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 293);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 6;
            label7.Text = "ketersediaan :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 337);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 7;
            label8.Text = "favorite :";
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(138, 107);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(121, 23);
            txtJudul.TabIndex = 8;
            // 
            // cbKetersediaan
            // 
            cbKetersediaan.FormattingEnabled = true;
            cbKetersediaan.Items.AddRange(new object[] { "", "ada", "tidak ada" });
            cbKetersediaan.Location = new Point(138, 290);
            cbKetersediaan.Name = "cbKetersediaan";
            cbKetersediaan.Size = new Size(121, 23);
            cbKetersediaan.TabIndex = 9;
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(138, 155);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(121, 23);
            txtPenulis.TabIndex = 10;
            // 
            // txtPenerbit
            // 
            txtPenerbit.Location = new Point(138, 244);
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(121, 23);
            txtPenerbit.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(138, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 23);
            txtID.TabIndex = 12;
            // 
            // rbFavorite
            // 
            rbFavorite.AutoSize = true;
            rbFavorite.Location = new Point(138, 335);
            rbFavorite.Name = "rbFavorite";
            rbFavorite.Size = new Size(65, 19);
            rbFavorite.TabIndex = 13;
            rbFavorite.TabStop = true;
            rbFavorite.Text = "favorite";
            rbFavorite.UseVisualStyleBackColor = true;
            // 
            // cbFiksi
            // 
            cbFiksi.AutoSize = true;
            cbFiksi.Location = new Point(138, 202);
            cbFiksi.Name = "cbFiksi";
            cbFiksi.Size = new Size(47, 19);
            cbFiksi.TabIndex = 14;
            cbFiksi.Text = "fiksi";
            cbFiksi.UseVisualStyleBackColor = true;
            // 
            // cbNonfiksi
            // 
            cbNonfiksi.AutoSize = true;
            cbNonfiksi.Location = new Point(191, 202);
            cbNonfiksi.Name = "cbNonfiksi";
            cbNonfiksi.Size = new Size(68, 19);
            cbNonfiksi.TabIndex = 15;
            cbNonfiksi.Text = "nonfiksi";
            cbNonfiksi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(326, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(433, 198);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(38, 386);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(138, 386);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 18;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(355, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(246, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(455, 386);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "print pdf";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(684, 386);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 22;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(684, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(517, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(144, 23);
            txtSearch.TabIndex = 24;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(cbNonfiksi);
            Controls.Add(cbFiksi);
            Controls.Add(rbFavorite);
            Controls.Add(txtID);
            Controls.Add(txtPenerbit);
            Controls.Add(txtPenulis);
            Controls.Add(cbKetersediaan);
            Controls.Add(txtJudul);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtJudul;
        private ComboBox cbKetersediaan;
        private TextBox txtPenulis;
        private TextBox txtPenerbit;
        private TextBox txtID;
        private RadioButton rbFavorite;
        private CheckBox cbFiksi;
        private CheckBox cbNonfiksi;
        private DataGridView dataGridView1;
        private Button btnCreate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnPrint;
        private Button btnClose;
        private Button btnSearch;
        private TextBox txtSearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}