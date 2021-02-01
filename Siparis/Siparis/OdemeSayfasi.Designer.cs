namespace Siparis
{
    partial class OdemeSayfasi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tutarr = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.isimSoyisim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tutarrr = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yil = new System.Windows.Forms.TextBox();
            this.ay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.TextBox();
            this.kartTip = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kartNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme seçenekleri";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "0";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(244, 48);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(96, 17);
            this.payment.TabIndex = 13;
            this.payment.Text = "Toplam tutar :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.Bnum);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tutarr);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.isimSoyisim);
            this.groupBox4.Location = new System.Drawing.Point(473, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 163);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "çek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Banka Numarası";
            // 
            // Bnum
            // 
            this.Bnum.AccessibleName = "";
            this.Bnum.Location = new System.Drawing.Point(143, 81);
            this.Bnum.Name = "Bnum";
            this.Bnum.Size = new System.Drawing.Size(200, 22);
            this.Bnum.TabIndex = 12;
            this.Bnum.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ödenecek Tutar";
            // 
            // tutarr
            // 
            this.tutarr.AccessibleName = "";
            this.tutarr.Location = new System.Drawing.Point(143, 121);
            this.tutarr.MaxLength = 90000;
            this.tutarr.Name = "tutarr";
            this.tutarr.Size = new System.Drawing.Size(200, 22);
            this.tutarr.TabIndex = 10;
            this.tutarr.Tag = "";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(362, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Öde";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ad soyad";
            // 
            // isimSoyisim
            // 
            this.isimSoyisim.AccessibleName = "";
            this.isimSoyisim.Location = new System.Drawing.Point(143, 40);
            this.isimSoyisim.Name = "isimSoyisim";
            this.isimSoyisim.Size = new System.Drawing.Size(200, 22);
            this.isimSoyisim.TabIndex = 0;
            this.isimSoyisim.Tag = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tutarrr);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(473, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 83);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "nakit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ödenecek Tutar";
            // 
            // tutarrr
            // 
            this.tutarrr.AccessibleName = "";
            this.tutarrr.Location = new System.Drawing.Point(123, 35);
            this.tutarrr.MaxLength = 90000;
            this.tutarrr.Name = "tutarrr";
            this.tutarrr.Size = new System.Drawing.Size(200, 22);
            this.tutarrr.TabIndex = 10;
            this.tutarrr.Tag = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(340, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Öde";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.yil);
            this.groupBox2.Controls.Add(this.ay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tutar);
            this.groupBox2.Controls.Add(this.kartTip);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cvv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.kartNo);
            this.groupBox2.Location = new System.Drawing.Point(6, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 237);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "kart";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Yıl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "ay";
            // 
            // yil
            // 
            this.yil.AccessibleName = "";
            this.yil.Location = new System.Drawing.Point(280, 117);
            this.yil.Name = "yil";
            this.yil.Size = new System.Drawing.Size(78, 22);
            this.yil.TabIndex = 13;
            this.yil.Tag = "";
            // 
            // ay
            // 
            this.ay.AccessibleName = "";
            this.ay.Location = new System.Drawing.Point(182, 117);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(51, 22);
            this.ay.TabIndex = 12;
            this.ay.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ödenecek Tutar";
            // 
            // tutar
            // 
            this.tutar.AccessibleName = "";
            this.tutar.Location = new System.Drawing.Point(143, 202);
            this.tutar.MaxLength = 90000;
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(215, 22);
            this.tutar.TabIndex = 10;
            this.tutar.Tag = "";
            // 
            // kartTip
            // 
            this.kartTip.FormattingEnabled = true;
            this.kartTip.Items.AddRange(new object[] {
            "Master Card",
            "Visa"});
            this.kartTip.Location = new System.Drawing.Point(143, 73);
            this.kartTip.Name = "kartTip";
            this.kartTip.Size = new System.Drawing.Size(215, 24);
            this.kartTip.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(382, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Öde";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cvv";
            // 
            // cvv
            // 
            this.cvv.AccessibleName = "";
            this.cvv.Location = new System.Drawing.Point(143, 159);
            this.cvv.MaxLength = 3;
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(215, 22);
            this.cvv.TabIndex = 6;
            this.cvv.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Son Kullanma tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "KartTipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart numarası";
            // 
            // kartNo
            // 
            this.kartNo.AccessibleName = "";
            this.kartNo.Location = new System.Drawing.Point(143, 40);
            this.kartNo.Name = "kartNo";
            this.kartNo.Size = new System.Drawing.Size(215, 22);
            this.kartNo.TabIndex = 0;
            this.kartNo.Tag = "";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kartNo;
        private System.Windows.Forms.ComboBox kartTip;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tutarr;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox isimSoyisim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tutarrr;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Bnum;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox yil;
        private System.Windows.Forms.TextBox ay;
    }
}