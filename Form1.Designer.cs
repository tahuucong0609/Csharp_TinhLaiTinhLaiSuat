namespace Csharp_TinhLaiTinhLaiSuat
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nudsonam = new NumericUpDown();
            cbxlaisuat = new ComboBox();
            txtsotien = new TextBox();
            btntinh = new Button();
            label5 = new Label();
            lsbketqua = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudsonam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(234, 41);
            label1.Name = "label1";
            label1.Size = new Size(342, 28);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH LÃI SUẤT TIẾT KIÊM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 123);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "SỐ TIỀN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 181);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "LÃI SUẤT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 233);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "SỐ NĂM GỬI";
            // 
            // nudsonam
            // 
            nudsonam.Location = new Point(247, 231);
            nudsonam.Name = "nudsonam";
            nudsonam.Size = new Size(188, 23);
            nudsonam.TabIndex = 4;
            // 
            // cbxlaisuat
            // 
            cbxlaisuat.FormattingEnabled = true;
            cbxlaisuat.Location = new Point(247, 178);
            cbxlaisuat.Name = "cbxlaisuat";
            cbxlaisuat.Size = new Size(188, 23);
            cbxlaisuat.TabIndex = 5;
            // 
            // txtsotien
            // 
            txtsotien.Location = new Point(247, 120);
            txtsotien.Name = "txtsotien";
            txtsotien.Size = new Size(188, 23);
            txtsotien.TabIndex = 6;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(397, 298);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(75, 23);
            btntinh.TabIndex = 7;
            btntinh.Text = "TÍNH";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 330);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "KẾT QUẢ";
            // 
            // lsbketqua
            // 
            lsbketqua.FormattingEnabled = true;
            lsbketqua.ItemHeight = 15;
            lsbketqua.Location = new Point(40, 358);
            lsbketqua.Name = "lsbketqua";
            lsbketqua.Size = new Size(736, 229);
            lsbketqua.TabIndex = 9;
            lsbketqua.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 615);
            Controls.Add(lsbketqua);
            Controls.Add(label5);
            Controls.Add(btntinh);
            Controls.Add(txtsotien);
            Controls.Add(cbxlaisuat);
            Controls.Add(nudsonam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudsonam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nudsonam;
        private ComboBox cbxlaisuat;
        private TextBox txtsotien;
        private Button btntinh;
        private Label label5;
        private ListBox lsbketqua;
    }
}
