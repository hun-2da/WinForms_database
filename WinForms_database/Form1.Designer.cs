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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 390);
            Controls.Add(subject_listBox);
            Controls.Add(d_button);
            Controls.Add(u_button);
            Controls.Add(a_button);
            Controls.Add(student_listBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox student_listBox;
        private Button a_button;
        private Button u_button;
        private Button d_button;
        private ListBox subject_listBox;
    }
}