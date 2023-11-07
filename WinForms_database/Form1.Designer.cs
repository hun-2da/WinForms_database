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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 0;
            button1.Text = "주문 생성";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(208, 364);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "주문 내용";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "주문 생성";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(253, 74);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(208, 244);
            listBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 351);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "주문 합계";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 397);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "0 원";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
    }
}