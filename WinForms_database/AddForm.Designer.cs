namespace WinForms_database
{
    partial class AddForm
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
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox3 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "회원 목록";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 349);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(237, 71);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(181, 349);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 39);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "제품";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "수량";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(458, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(458, 197);
            button1.Name = "button1";
            button1.Size = new Size(138, 67);
            button1.TabIndex = 6;
            button1.Text = "담기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(629, 71);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(159, 349);
            listBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(12, 461);
            button2.Name = "button2";
            button2.Size = new Size(776, 53);
            button2.TabIndex = 8;
            button2.Text = "생성";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(458, 308);
            button3.Name = "button3";
            button3.Size = new Size(138, 67);
            button3.TabIndex = 9;
            button3.Text = "삭제";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 583);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox3;
        private Button button2;
        private Button button3;
    }
}