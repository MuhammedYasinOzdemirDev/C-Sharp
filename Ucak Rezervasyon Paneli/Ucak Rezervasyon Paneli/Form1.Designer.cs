﻿namespace Ucak_Rezervasyon_Paneli
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
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(96, 150);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(181, 25);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(96, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 143);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 120);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 5;
            label3.Text = "Tarih:";
            // 
            // button1
            // 
            button1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(283, 65);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 4;
            button1.Text = "<>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Balıkesir", "Mersin", "Adana" });
            comboBox2.Location = new Point(96, 43);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(181, 30);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Balıkesir", "Mersin", "Adana" });
            comboBox1.Location = new Point(96, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 30);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-3, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(379, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(295, 85);
            button2.Name = "button2";
            button2.Size = new Size(114, 42);
            button2.TabIndex = 7;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("SimSun", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(120, 117);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(169, 27);
            maskedTextBox3.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("SimSun", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(120, 85);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(169, 27);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(120, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(70, 120);
            label7.Name = "label7";
            label7.Size = new Size(39, 23);
            label7.TabIndex = 3;
            label7.Text = "Tel:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 85);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 2;
            label6.Text = "T.C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 50);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 1;
            label5.Text = "Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(11, 314);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(777, 104);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 101);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(31, 24);
            label8.Name = "label8";
            label8.Size = new Size(419, 50);
            label8.TabIndex = 0;
            label8.Text = "Türk Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
    }
}