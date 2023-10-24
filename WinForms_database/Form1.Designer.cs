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
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            right_button1 = new Button();
            left_button1 = new Button();
            left_button2 = new Button();
            right_button2 = new Button();
            add_order_button = new Button();
            update_order_button = new Button();
            delte_order_button = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            listBox4 = new ListBox();
            add_menu_button = new Button();
            update_menu_button = new Button();
            delete_menu_buttno = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(10, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(200, 52);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(140, 349);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(390, 52);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(140, 349);
            listBox3.TabIndex = 2;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "주문확인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 34);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "조리중";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 34);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "조리완료";
            // 
            // right_button1
            // 
            right_button1.Location = new Point(161, 110);
            right_button1.Name = "right_button1";
            right_button1.Size = new Size(28, 90);
            right_button1.TabIndex = 6;
            right_button1.Text = ">";
            right_button1.UseVisualStyleBackColor = true;
            // 
            // left_button1
            // 
            left_button1.Location = new Point(161, 219);
            left_button1.Name = "left_button1";
            left_button1.Size = new Size(28, 90);
            left_button1.TabIndex = 7;
            left_button1.Text = "<";
            left_button1.UseVisualStyleBackColor = true;
            // 
            // left_button2
            // 
            left_button2.Location = new Point(351, 219);
            left_button2.Name = "left_button2";
            left_button2.Size = new Size(28, 90);
            left_button2.TabIndex = 9;
            left_button2.Text = "<";
            left_button2.UseVisualStyleBackColor = true;
            // 
            // right_button2
            // 
            right_button2.Location = new Point(351, 110);
            right_button2.Name = "right_button2";
            right_button2.Size = new Size(28, 90);
            right_button2.TabIndex = 8;
            right_button2.Text = ">";
            right_button2.UseVisualStyleBackColor = true;
            // 
            // add_order_button
            // 
            add_order_button.Location = new Point(10, 423);
            add_order_button.Name = "add_order_button";
            add_order_button.Size = new Size(79, 29);
            add_order_button.TabIndex = 10;
            add_order_button.Text = "주문추가";
            add_order_button.UseVisualStyleBackColor = true;
            add_order_button.Click += add_order_button_Click;
            // 
            // update_order_button
            // 
            update_order_button.Location = new Point(95, 423);
            update_order_button.Name = "update_order_button";
            update_order_button.Size = new Size(79, 29);
            update_order_button.TabIndex = 11;
            update_order_button.Text = "주문수정";
            update_order_button.UseVisualStyleBackColor = true;
            update_order_button.Click += update_order_button_Click;
            // 
            // delte_order_button
            // 
            delte_order_button.Location = new Point(180, 423);
            delte_order_button.Name = "delte_order_button";
            delte_order_button.Size = new Size(79, 29);
            delte_order_button.TabIndex = 12;
            delte_order_button.Text = "주문삭제";
            delte_order_button.UseVisualStyleBackColor = true;
            delte_order_button.Click += delte_order_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 451);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 34);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "메뉴목록";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(588, 52);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(140, 349);
            listBox4.TabIndex = 14;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // add_menu_button
            // 
            add_menu_button.Location = new Point(734, 52);
            add_menu_button.Name = "add_menu_button";
            add_menu_button.Size = new Size(82, 39);
            add_menu_button.TabIndex = 16;
            add_menu_button.Text = "메뉴추가";
            add_menu_button.UseVisualStyleBackColor = true;
            add_menu_button.Click += add_menu_button_Click;
            // 
            // update_menu_button
            // 
            update_menu_button.Location = new Point(734, 106);
            update_menu_button.Name = "update_menu_button";
            update_menu_button.Size = new Size(82, 39);
            update_menu_button.TabIndex = 17;
            update_menu_button.Text = "메뉴수정";
            update_menu_button.UseVisualStyleBackColor = true;
            update_menu_button.Click += update_menu_button_Click;
            // 
            // delete_menu_buttno
            // 
            delete_menu_buttno.Location = new Point(734, 160);
            delete_menu_buttno.Name = "delete_menu_buttno";
            delete_menu_buttno.Size = new Size(82, 39);
            delete_menu_buttno.TabIndex = 18;
            delete_menu_buttno.Text = "메뉴삭제";
            delete_menu_buttno.UseVisualStyleBackColor = true;
            delete_menu_buttno.Click += delete_menu_buttno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 467);
            Controls.Add(delete_menu_buttno);
            Controls.Add(update_menu_button);
            Controls.Add(add_menu_button);
            Controls.Add(label4);
            Controls.Add(listBox4);
            Controls.Add(delte_order_button);
            Controls.Add(update_order_button);
            Controls.Add(add_order_button);
            Controls.Add(left_button2);
            Controls.Add(right_button2);
            Controls.Add(left_button1);
            Controls.Add(right_button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button right_button1;
        private Button left_button1;
        private Button left_button2;
        private Button right_button2;
        private Button add_order_button;
        private Button update_order_button;
        private Button delte_order_button;
        private GroupBox groupBox1;
        private Label label4;
        private ListBox listBox4;
        private Button add_menu_button;
        private Button update_menu_button;
        private Button delete_menu_buttno;
    }
}