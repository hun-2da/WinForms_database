namespace WinForms_database
{
    partial class Form2
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            listBox3 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(550, 251);
            button4.Name = "button4";
            button4.Size = new Size(127, 72);
            button4.TabIndex = 23;
            button4.Text = "모든 제품 빼기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AllRemoveButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(550, 154);
            button3.Name = "button3";
            button3.Size = new Size(127, 72);
            button3.TabIndex = 22;
            button3.Text = "선택한 제품 빼기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RemoveButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 354);
            button2.Name = "button2";
            button2.Size = new Size(548, 55);
            button2.TabIndex = 21;
            button2.Text = "위 주문 상세대로 주문 생성";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 124);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 20;
            label4.Text = "주문상세";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "아이폰 3개", "맥북 2개" });
            listBox3.Location = new Point(431, 154);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(100, 169);
            listBox3.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(550, 69);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 18;
            button1.Text = "담기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 44);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 16;
            label3.Text = "수량";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 42);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 15;
            label2.Text = "제품";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "아이폰", "맥북", "모니터" });
            listBox2.Location = new Point(287, 69);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(115, 244);
            listBox2.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "이인규" });
            listBox1.Location = new Point(129, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(130, 244);
            listBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 42);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 12;
            label1.Text = "회원목록";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(listBox3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Label label4;
        private ListBox listBox3;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label1;
    }
}