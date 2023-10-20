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
            dateTimePicker1 = new DateTimePicker();
            add_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 324);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // add_button
            // 
            add_button.Location = new Point(247, 157);
            add_button.Name = "add_button";
            add_button.Size = new Size(86, 36);
            add_button.TabIndex = 1;
            add_button.Text = "추가";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += addbutton_Click;
            // 
            // update_button
            // 
            update_button.Location = new Point(247, 211);
            update_button.Name = "update_button";
            update_button.Size = new Size(86, 34);
            update_button.TabIndex = 2;
            update_button.Text = "수정";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(247, 272);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(86, 27);
            delete_button.TabIndex = 3;
            delete_button.Text = "삭제";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(372, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "친구";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 184);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 272);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(207, 199);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "친구";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 10;
            label2.Text = "친구아님";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 483);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(add_button);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button add_button;
        private Button update_button;
        private Button delete_button;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
    }
}