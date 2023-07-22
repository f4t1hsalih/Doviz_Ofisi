namespace Doviz_Ofisi
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
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblDolarSatis = new Label();
            lblDolarAlis = new Label();
            lblEuroSatis = new Label();
            lblEuroAlis = new Label();
            groupBox1 = new GroupBox();
            btnSatisYap2 = new Button();
            btnSatisYap = new Button();
            txtKalan = new TextBox();
            txtTutar = new TextBox();
            txtMiktar = new TextBox();
            txtKur = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnDolarAl = new Button();
            btnDolarSat = new Button();
            btnEuroAl = new Button();
            btnEuroSat = new Button();
            btnSterlinSat = new Button();
            btnSterlinAl = new Button();
            lblSterlinSatis = new Label();
            lblSterlinAlis = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Dolar Alış: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 57);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Dolar Satış: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 117);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 5;
            label5.Text = "Euro Satış: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 92);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 4;
            label6.Text = "Euro Alış: ";
            // 
            // lblDolarSatis
            // 
            lblDolarSatis.AutoSize = true;
            lblDolarSatis.Location = new Point(99, 57);
            lblDolarSatis.Name = "lblDolarSatis";
            lblDolarSatis.Size = new Size(17, 20);
            lblDolarSatis.TabIndex = 7;
            lblDolarSatis.Text = "0";
            // 
            // lblDolarAlis
            // 
            lblDolarAlis.AutoSize = true;
            lblDolarAlis.Location = new Point(99, 32);
            lblDolarAlis.Name = "lblDolarAlis";
            lblDolarAlis.Size = new Size(17, 20);
            lblDolarAlis.TabIndex = 6;
            lblDolarAlis.Text = "0";
            // 
            // lblEuroSatis
            // 
            lblEuroSatis.AutoSize = true;
            lblEuroSatis.Location = new Point(99, 117);
            lblEuroSatis.Name = "lblEuroSatis";
            lblEuroSatis.Size = new Size(17, 20);
            lblEuroSatis.TabIndex = 9;
            lblEuroSatis.Text = "0";
            // 
            // lblEuroAlis
            // 
            lblEuroAlis.AutoSize = true;
            lblEuroAlis.Location = new Point(99, 92);
            lblEuroAlis.Name = "lblEuroAlis";
            lblEuroAlis.Size = new Size(17, 20);
            lblEuroAlis.TabIndex = 8;
            lblEuroAlis.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSatisYap2);
            groupBox1.Controls.Add(btnSatisYap);
            groupBox1.Controls.Add(txtKalan);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(txtKur);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(219, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 189);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnSatisYap2
            // 
            btnSatisYap2.Location = new Point(136, 152);
            btnSatisYap2.Name = "btnSatisYap2";
            btnSatisYap2.Size = new Size(95, 30);
            btnSatisYap2.TabIndex = 23;
            btnSatisYap2.Text = "Satış Yap2";
            btnSatisYap2.UseVisualStyleBackColor = true;
            btnSatisYap2.Click += btnSatisYap2_Click;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(32, 152);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(95, 30);
            btnSatisYap.TabIndex = 15;
            btnSatisYap.Text = "Satış Yap1";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // txtKalan
            // 
            txtKalan.Location = new Point(70, 119);
            txtKalan.Name = "txtKalan";
            txtKalan.ReadOnly = true;
            txtKalan.Size = new Size(161, 27);
            txtKalan.TabIndex = 22;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(70, 86);
            txtTutar.Name = "txtTutar";
            txtTutar.ReadOnly = true;
            txtTutar.Size = new Size(161, 27);
            txtTutar.TabIndex = 21;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(70, 53);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(161, 27);
            txtMiktar.TabIndex = 20;
            // 
            // txtKur
            // 
            txtKur.Location = new Point(70, 20);
            txtKur.Name = "txtKur";
            txtKur.ReadOnly = true;
            txtKur.Size = new Size(161, 27);
            txtKur.TabIndex = 19;
            txtKur.TextChanged += txtKur_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 122);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 18;
            label12.Text = "Kalan: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 89);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 17;
            label11.Text = "Tutar: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 56);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 16;
            label10.Text = "Miktar: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 23);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 15;
            label9.Text = "Kur: ";
            // 
            // btnDolarAl
            // 
            btnDolarAl.Location = new Point(168, 31);
            btnDolarAl.Name = "btnDolarAl";
            btnDolarAl.Size = new Size(30, 23);
            btnDolarAl.TabIndex = 11;
            btnDolarAl.Text = "...";
            btnDolarAl.UseVisualStyleBackColor = true;
            btnDolarAl.Click += btnDolarAl_Click;
            // 
            // btnDolarSat
            // 
            btnDolarSat.Location = new Point(168, 56);
            btnDolarSat.Name = "btnDolarSat";
            btnDolarSat.Size = new Size(30, 23);
            btnDolarSat.TabIndex = 12;
            btnDolarSat.Text = "...";
            btnDolarSat.UseVisualStyleBackColor = true;
            btnDolarSat.Click += btnDolarSat_Click;
            // 
            // btnEuroAl
            // 
            btnEuroAl.Location = new Point(168, 91);
            btnEuroAl.Name = "btnEuroAl";
            btnEuroAl.Size = new Size(30, 23);
            btnEuroAl.TabIndex = 13;
            btnEuroAl.Text = "...";
            btnEuroAl.UseVisualStyleBackColor = true;
            btnEuroAl.Click += btnEuroAl_Click;
            // 
            // btnEuroSat
            // 
            btnEuroSat.Location = new Point(168, 116);
            btnEuroSat.Name = "btnEuroSat";
            btnEuroSat.Size = new Size(30, 23);
            btnEuroSat.TabIndex = 14;
            btnEuroSat.Text = "...";
            btnEuroSat.UseVisualStyleBackColor = true;
            btnEuroSat.Click += btnEuroSat_Click;
            // 
            // btnSterlinSat
            // 
            btnSterlinSat.Location = new Point(168, 178);
            btnSterlinSat.Name = "btnSterlinSat";
            btnSterlinSat.Size = new Size(30, 23);
            btnSterlinSat.TabIndex = 20;
            btnSterlinSat.Text = "...";
            btnSterlinSat.UseVisualStyleBackColor = true;
            btnSterlinSat.Click += btnSterlinSat_Click;
            // 
            // btnSterlinAl
            // 
            btnSterlinAl.Location = new Point(168, 153);
            btnSterlinAl.Name = "btnSterlinAl";
            btnSterlinAl.Size = new Size(30, 23);
            btnSterlinAl.TabIndex = 19;
            btnSterlinAl.Text = "...";
            btnSterlinAl.UseVisualStyleBackColor = true;
            btnSterlinAl.Click += btnSterlinAl_Click;
            // 
            // lblSterlinSatis
            // 
            lblSterlinSatis.AutoSize = true;
            lblSterlinSatis.Location = new Point(99, 179);
            lblSterlinSatis.Name = "lblSterlinSatis";
            lblSterlinSatis.Size = new Size(17, 20);
            lblSterlinSatis.TabIndex = 18;
            lblSterlinSatis.Text = "0";
            // 
            // lblSterlinAlis
            // 
            lblSterlinAlis.AutoSize = true;
            lblSterlinAlis.Location = new Point(99, 154);
            lblSterlinAlis.Name = "lblSterlinAlis";
            lblSterlinAlis.Size = new Size(17, 20);
            lblSterlinAlis.TabIndex = 17;
            lblSterlinAlis.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 179);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 16;
            label7.Text = "Sterlin Satış: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 154);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 15;
            label8.Text = "Sterlin Alış: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(479, 213);
            Controls.Add(btnSterlinSat);
            Controls.Add(btnSterlinAl);
            Controls.Add(lblSterlinSatis);
            Controls.Add(lblSterlinAlis);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnEuroSat);
            Controls.Add(btnEuroAl);
            Controls.Add(btnDolarSat);
            Controls.Add(btnDolarAl);
            Controls.Add(groupBox1);
            Controls.Add(lblEuroSatis);
            Controls.Add(lblEuroAlis);
            Controls.Add(lblDolarSatis);
            Controls.Add(lblDolarAlis);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Döviz Ofisi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label lblDolarSatis;
        private Label lblDolarAlis;
        private Label lblEuroSatis;
        private Label lblEuroAlis;
        private GroupBox groupBox1;
        private Button btnDolarAl;
        private Button btnDolarSat;
        private TextBox txtKalan;
        private TextBox txtTutar;
        private TextBox txtMiktar;
        private TextBox txtKur;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnEuroAl;
        private Button btnEuroSat;
        private Button btnSatisYap;
        private Button btnSatisYap2;
        private Button btnSterlinSat;
        private Button btnSterlinAl;
        private Label lblSterlinSatis;
        private Label lblSterlinAlis;
        private Label label7;
        private Label label8;
    }
}