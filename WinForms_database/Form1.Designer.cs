namespace WinForms_database
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            checkBox1 = new CheckBox();
            add_button = new Button();
            nametextbox1 = new TextBox();
            nametextbox2 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            fandomtextbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Entertainment_textbox = new TextBox();
            group_textbox = new TextBox();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "그룹";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "솔로";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 9);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 139);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "데뷔일";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 184);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 253);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(212, 184);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(363, 390);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "그룹";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            add_button.Location = new Point(254, 213);
            add_button.Name = "add_button";
            add_button.Size = new Size(87, 44);
            add_button.TabIndex = 7;
            add_button.Text = "추가";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // nametextbox1
            // 
            nametextbox1.Location = new Point(254, 34);
            nametextbox1.Name = "nametextbox1";
            nametextbox1.Size = new Size(100, 23);
            nametextbox1.TabIndex = 11;
            // 
            // nametextbox2
            // 
            nametextbox2.Location = new Point(254, 104);
            nametextbox2.Name = "nametextbox2";
            nametextbox2.Size = new Size(100, 23);
            nametextbox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 77);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "한자 이름";
            // 
            // button2
            // 
            button2.Location = new Point(254, 299);
            button2.Name = "button2";
            button2.Size = new Size(87, 44);
            button2.TabIndex = 14;
            button2.Text = "수정";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(254, 385);
            button3.Name = "button3";
            button3.Size = new Size(87, 44);
            button3.TabIndex = 15;
            button3.Text = "삭제";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(254, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // fandomtextbox
            // 
            fandomtextbox.Location = new Point(398, 53);
            fandomtextbox.Name = "fandomtextbox";
            fandomtextbox.Size = new Size(100, 23);
            fandomtextbox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 23);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 18;
            label6.Text = "팬덤 이름";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(398, 95);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 20;
            label7.Text = "소속사 이름";
            // 
            // Entertainment_textbox
            // 
            Entertainment_textbox.Location = new Point(398, 121);
            Entertainment_textbox.Name = "Entertainment_textbox";
            Entertainment_textbox.Size = new Size(100, 23);
            Entertainment_textbox.TabIndex = 19;
            // 
            // group_textbox
            // 
            group_textbox.Location = new Point(419, 386);
            group_textbox.Name = "group_textbox";
            group_textbox.Size = new Size(100, 23);
            group_textbox.TabIndex = 21;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(56, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "가수";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "O", "AB" });
            comboBox1.Location = new Point(398, 341);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 314);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 24;
            label8.Text = "혈액형";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(363, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 100);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "분야";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(56, 70);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 24;
            radioButton3.TabStop = true;
            radioButton3.Text = "유튜버";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(56, 45);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 19);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "방송인";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 450);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(group_textbox);
            Controls.Add(label7);
            Controls.Add(Entertainment_textbox);
            Controls.Add(label6);
            Controls.Add(fandomtextbox);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(nametextbox2);
            Controls.Add(label5);
            Controls.Add(nametextbox1);
            Controls.Add(add_button);
            Controls.Add(checkBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private CheckBox checkBox1;
        private Button add_button;
        private TextBox nametextbox1;
        private TextBox nametextbox2;
        private Label label5;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox fandomtextbox;
        private Label label6;
        private Label label7;
        private TextBox Entertainment_textbox;
        private TextBox group_textbox;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label8;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}