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
            label2 = new Label();
            listBox2 = new ListBox();
            label1 = new Label();
            listBox1 = new ListBox();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            DeleteButton = new Button();
            ModifyButton = new Button();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 42);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Call logs";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "08/08 17:12 <- (20min)" });
            listBox2.Location = new Point(421, 79);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(155, 334);
            listBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Contacts";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Barney (888 111 1234)" });
            listBox1.Location = new Point(179, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(178, 184);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(307, 79);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(54, 23);
            SearchButton.TabIndex = 13;
            SearchButton.Text = "검색";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(177, 79);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(124, 23);
            SearchTextBox.TabIndex = 12;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(179, 394);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(179, 365);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(178, 23);
            ModifyButton.TabIndex = 10;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(179, 336);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(178, 23);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 581);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(DeleteButton);
            Controls.Add(ModifyButton);
            Controls.Add(AddButton);
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

        private Label label2;
        private ListBox listBox2;
        private Label label1;
        private ListBox listBox1;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Button DeleteButton;
        private Button ModifyButton;
        private Button AddButton;
    }
}