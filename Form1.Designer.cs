namespace DoThaiTai_Buoi3
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
            txtCr = new TextBox();
            txtCd = new TextBox();
            btnKt = new Button();
            btnKt2 = new Button();
            txtGt = new TextBox();
            txtSdt = new TextBox();
            txtNs = new TextBox();
            txtHt = new TextBox();
            txtMs = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 74);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "Chiều rộng:";
            // 
            // txtCr
            // 
            txtCr.Location = new Point(171, 71);
            txtCr.Name = "txtCr";
            txtCr.Size = new Size(100, 33);
            txtCr.TabIndex = 1;
            // 
            // txtCd
            // 
            txtCd.Location = new Point(171, 32);
            txtCd.Name = "txtCd";
            txtCd.Size = new Size(100, 33);
            txtCd.TabIndex = 1;
            // 
            // btnKt
            // 
            btnKt.Location = new Point(277, 110);
            btnKt.Name = "btnKt";
            btnKt.Size = new Size(100, 33);
            btnKt.TabIndex = 2;
            btnKt.Text = "Kiểm tra";
            btnKt.UseVisualStyleBackColor = true;
            btnKt.Click += btnKt_Click;
            // 
            // btnKt2
            // 
            btnKt2.Location = new Point(277, 344);
            btnKt2.Name = "btnKt2";
            btnKt2.Size = new Size(100, 33);
            btnKt2.TabIndex = 13;
            btnKt2.Text = "Kiểm tra";
            btnKt2.UseVisualStyleBackColor = true;
            btnKt2.Click += btnKt2_Click;
            // 
            // txtGt
            // 
            txtGt.Location = new Point(171, 305);
            txtGt.Name = "txtGt";
            txtGt.Size = new Size(206, 33);
            txtGt.TabIndex = 8;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(171, 266);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(206, 33);
            txtSdt.TabIndex = 9;
            // 
            // txtNs
            // 
            txtNs.Location = new Point(171, 227);
            txtNs.Name = "txtNs";
            txtNs.Size = new Size(206, 33);
            txtNs.TabIndex = 10;
            // 
            // txtHt
            // 
            txtHt.Location = new Point(171, 188);
            txtHt.Name = "txtHt";
            txtHt.Size = new Size(206, 33);
            txtHt.TabIndex = 11;
            // 
            // txtMs
            // 
            txtMs.Location = new Point(171, 149);
            txtMs.Name = "txtMs";
            txtMs.Size = new Size(206, 33);
            txtMs.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 269);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 3;
            label5.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 230);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 4;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 191);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 5;
            label3.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 152);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 6;
            label6.Text = "MSSV:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 308);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 7;
            label7.Text = "Giới tính:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(btnKt2);
            Controls.Add(txtGt);
            Controls.Add(txtSdt);
            Controls.Add(txtNs);
            Controls.Add(txtHt);
            Controls.Add(txtMs);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnKt);
            Controls.Add(txtCd);
            Controls.Add(txtCr);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCr;
        private TextBox txtCd;
        private Button btnKt;
        private Button btnKt2;
        private TextBox txtGt;
        private TextBox txtSdt;
        private TextBox txtNs;
        private TextBox txtHt;
        private TextBox txtMs;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}
