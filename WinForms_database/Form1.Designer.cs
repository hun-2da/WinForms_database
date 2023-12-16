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
            checkBox1 = new CheckBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label2 = new Label();
            listBox2 = new ListBox();
            label1 = new Label();
            listBox1 = new ListBox();
            AddTodoDetailButton = new Button();
            checkBox2 = new CheckBox();
            label5 = new Label();
            textBox3 = new TextBox();
            AddTodoButton = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1090, 299);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "수행여부";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1090, 241);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 21;
            label4.Text = "내용";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1090, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1088, 185);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 19;
            label3.Text = "수행자";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1090, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1088, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(1090, 346);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "할일추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(584, 123);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 15;
            label2.Text = "세부목록";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(584, 156);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(178, 214);
            listBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 123);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 13;
            label1.Text = "할일목록";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(130, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(418, 214);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AddTodoDetailButton
            // 
            AddTodoDetailButton.Location = new Point(777, 342);
            AddTodoDetailButton.Name = "AddTodoDetailButton";
            AddTodoDetailButton.Size = new Size(95, 23);
            AddTodoDetailButton.TabIndex = 26;
            AddTodoDetailButton.Text = "세부할일추가";
            AddTodoDetailButton.UseVisualStyleBackColor = true;
            AddTodoDetailButton.Click += AddTodoDetailButton_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(777, 317);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(74, 19);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "수행여부";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(777, 259);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 24;
            label5.Text = "내용";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(777, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 23;
            // 
            // AddTodoButton
            // 
            AddTodoButton.Location = new Point(473, 123);
            AddTodoButton.Name = "AddTodoButton";
            AddTodoButton.Size = new Size(75, 23);
            AddTodoButton.TabIndex = 27;
            AddTodoButton.Text = "할일추가";
            AddTodoButton.UseVisualStyleBackColor = true;
            AddTodoButton.Click += AddTodoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 600);
            Controls.Add(AddTodoButton);
            Controls.Add(AddTodoDetailButton);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
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

        private CheckBox checkBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label2;
        private ListBox listBox2;
        private Label label1;
        private ListBox listBox1;
        private Button AddTodoDetailButton;
        private CheckBox checkBox2;
        private Label label5;
        private TextBox textBox3;
        private Button AddTodoButton;
    }
}