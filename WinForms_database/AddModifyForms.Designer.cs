namespace WinForms_database
{
    partial class AddModifyForms
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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CancelButton = new Button();
            OKButton = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(401, 274);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(401, 241);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(401, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(401, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(401, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(401, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 274);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 21;
            label6.Text = "State";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 243);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 20;
            label5.Text = "DateOfBirth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 181);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 19;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 212);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 119);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(426, 312);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "취소";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(299, 312);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 14;
            OKButton.Text = "확인";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // AddModifyForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Name = "AddModifyForms";
            Text = "AddModifyForms";
            Load += AddModifyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CancelButton;
        private Button OKButton;
    }
}