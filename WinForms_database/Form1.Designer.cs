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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            수행자 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(64, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(152, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 27);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(260, 55);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(152, 349);
            listBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(501, 175);
            button1.Name = "button1";
            button1.Size = new Size(128, 62);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 260);
            button2.Name = "button2";
            button2.Size = new Size(128, 62);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(501, 343);
            button3.Name = "button3";
            button3.Size = new Size(128, 62);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 139);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "내용";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(511, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(454, 419);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(445, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // 수행자
            // 
            수행자.AutoSize = true;
            수행자.Location = new Point(454, 105);
            수행자.Name = "수행자";
            수행자.Size = new Size(43, 15);
            수행자.TabIndex = 18;
            수행자.Text = "수행자";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(511, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(수행자);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label 수행자;
        private TextBox textBox1;
    }
}