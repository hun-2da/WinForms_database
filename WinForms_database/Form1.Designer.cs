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
            content_box = new TextBox();
            deletebutton = new Button();
            updatebutton = new Button();
            dateTimePicker1 = new DateTimePicker();
            addbutton = new Button();
            listBox_2 = new ListBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkbox = new CheckBox();
            listbox_1 = new ListBox();
            SuspendLayout();
            // 
            // content_box
            // 
            content_box.Location = new Point(247, 39);
            content_box.Name = "content_box";
            content_box.Size = new Size(200, 23);
            content_box.TabIndex = 24;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(277, 345);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(137, 47);
            deletebutton.TabIndex = 23;
            deletebutton.Text = "삭제";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(277, 263);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(137, 47);
            updatebutton.TabIndex = 22;
            updatebutton.Text = "수정";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(247, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(277, 181);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(137, 47);
            addbutton.TabIndex = 20;
            addbutton.Text = "추가";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // listBox_2
            // 
            listBox_2.FormattingEnabled = true;
            listBox_2.ItemHeight = 15;
            listBox_2.Location = new Point(30, 253);
            listBox_2.Name = "listBox_2";
            listBox_2.Size = new Size(169, 139);
            listBox_2.TabIndex = 19;
            listBox_2.SelectedIndexChanged += listBox_2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 213);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 18;
            label4.Text = "한일";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 7);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 17;
            label3.Text = "할일";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 7);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 16;
            label2.Text = "내용";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 105);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 15;
            label1.Text = "날짜";
            // 
            // checkbox
            // 
            checkbox.AutoSize = true;
            checkbox.Location = new Point(369, 88);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(78, 19);
            checkbox.TabIndex = 14;
            checkbox.Text = "완료 여부";
            checkbox.UseVisualStyleBackColor = true;
            // 
            // listbox_1
            // 
            listbox_1.FormattingEnabled = true;
            listbox_1.ItemHeight = 15;
            listbox_1.Location = new Point(30, 39);
            listbox_1.Name = "listbox_1";
            listbox_1.Size = new Size(169, 139);
            listbox_1.TabIndex = 13;
            listbox_1.SelectedIndexChanged += listbox_1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 413);
            Controls.Add(content_box);
            Controls.Add(deletebutton);
            Controls.Add(updatebutton);
            Controls.Add(dateTimePicker1);
            Controls.Add(addbutton);
            Controls.Add(listBox_2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkbox);
            Controls.Add(listbox_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox content_box;
        private Button deletebutton;
        private Button updatebutton;
        private DateTimePicker dateTimePicker1;
        private Button addbutton;
        private ListBox listBox_2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkbox;
        private ListBox listbox_1;
    }
}