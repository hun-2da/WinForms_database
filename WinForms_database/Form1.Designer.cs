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
            student_listBox = new ListBox();
            a_button = new Button();
            u_button = new Button();
            d_button = new Button();
            subject_listBox = new ListBox();
            date_box = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Grade_comboBox = new ComboBox();
            final_inputBox = new TextBox();
            min_inputBox = new TextBox();
            class_button = new Button();
            SuspendLayout();
            // 
            // student_listBox
            // 
            student_listBox.FormattingEnabled = true;
            student_listBox.ItemHeight = 15;
            student_listBox.Location = new Point(39, 36);
            student_listBox.Name = "student_listBox";
            student_listBox.Size = new Size(159, 304);
            student_listBox.TabIndex = 0;
            student_listBox.SelectedIndexChanged += student_listBox_SelectedIndexChanged;
            // 
            // a_button
            // 
            a_button.Location = new Point(237, 183);
            a_button.Name = "a_button";
            a_button.Size = new Size(169, 40);
            a_button.TabIndex = 1;
            a_button.Text = "추가하기";
            a_button.UseVisualStyleBackColor = true;
            a_button.Click += a_button_Click;
            // 
            // u_button
            // 
            u_button.Location = new Point(237, 242);
            u_button.Name = "u_button";
            u_button.Size = new Size(169, 40);
            u_button.TabIndex = 2;
            u_button.Text = "수정하기";
            u_button.UseVisualStyleBackColor = true;
            u_button.Click += u_button_Click;
            // 
            // d_button
            // 
            d_button.Location = new Point(237, 300);
            d_button.Name = "d_button";
            d_button.Size = new Size(169, 40);
            d_button.TabIndex = 3;
            d_button.Text = "삭제하기";
            d_button.UseVisualStyleBackColor = true;
            d_button.Click += d_button_Click;
            // 
            // subject_listBox
            // 
            subject_listBox.FormattingEnabled = true;
            subject_listBox.ItemHeight = 15;
            subject_listBox.Location = new Point(237, 36);
            subject_listBox.Name = "subject_listBox";
            subject_listBox.Size = new Size(169, 124);
            subject_listBox.TabIndex = 4;
            subject_listBox.SelectedIndexChanged += subject_listBox_SelectedIndexChanged;
            // 
            // date_box
            // 
            date_box.Location = new Point(555, 36);
            date_box.Name = "date_box";
            date_box.Size = new Size(200, 23);
            date_box.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 42);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "Joined";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "MidScore";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 156);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "FinalScore";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 216);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Grade";
            // 
            // Grade_comboBox
            // 
            Grade_comboBox.FormattingEnabled = true;
            Grade_comboBox.Items.AddRange(new object[] { "a", "b", "c", "d", "e" });
            Grade_comboBox.Location = new Point(555, 213);
            Grade_comboBox.Name = "Grade_comboBox";
            Grade_comboBox.Size = new Size(121, 23);
            Grade_comboBox.TabIndex = 10;
            // 
            // final_inputBox
            // 
            final_inputBox.Location = new Point(555, 148);
            final_inputBox.Name = "final_inputBox";
            final_inputBox.Size = new Size(100, 23);
            final_inputBox.TabIndex = 11;
            // 
            // min_inputBox
            // 
            min_inputBox.Location = new Point(555, 96);
            min_inputBox.Name = "min_inputBox";
            min_inputBox.Size = new Size(100, 23);
            min_inputBox.TabIndex = 12;
            // 
            // class_button
            // 
            class_button.Location = new Point(643, 279);
            class_button.Name = "class_button";
            class_button.Size = new Size(112, 35);
            class_button.TabIndex = 13;
            class_button.Text = "확인";
            class_button.UseVisualStyleBackColor = true;
            class_button.Click += class_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 390);
            Controls.Add(class_button);
            Controls.Add(min_inputBox);
            Controls.Add(final_inputBox);
            Controls.Add(Grade_comboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date_box);
            Controls.Add(subject_listBox);
            Controls.Add(d_button);
            Controls.Add(u_button);
            Controls.Add(a_button);
            Controls.Add(student_listBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox student_listBox;
        private Button a_button;
        private Button u_button;
        private Button d_button;
        private ListBox subject_listBox;
        private DateTimePicker date_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Grade_comboBox;
        private TextBox final_inputBox;
        private TextBox min_inputBox;
        private Button class_button;
    }
}