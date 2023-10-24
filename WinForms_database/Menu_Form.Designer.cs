namespace WinForms_database
{
    partial class Menu_Form
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
            button1 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(246, 187);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 204);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 18;
            label5.Text = "수량";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 166);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 16;
            label4.Text = "메뉴명";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(179, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 12;
            label2.Text = "날짜 및 시간(주문자 정보)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 11;
            label1.Text = "주문메뉴정보";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 23);
            textBox3.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(136, 126);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 129);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 21;
            label3.Text = "날짜 및 시간";
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 267);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu_Form";
            Text = "Menu_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private Label label3;
    }
}