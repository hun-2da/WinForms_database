namespace WinForms_database
{
    partial class SJ_Form
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
            n_button = new Button();
            y_button = new Button();
            alllistbox = new ListBox();
            SuspendLayout();
            // 
            // n_button
            // 
            n_button.Location = new Point(153, 308);
            n_button.Name = "n_button";
            n_button.Size = new Size(95, 42);
            n_button.TabIndex = 5;
            n_button.Text = "취소";
            n_button.UseVisualStyleBackColor = true;
            n_button.Click += n_button_Click;
            // 
            // y_button
            // 
            y_button.Location = new Point(33, 308);
            y_button.Name = "y_button";
            y_button.Size = new Size(95, 42);
            y_button.TabIndex = 4;
            y_button.Text = "확인";
            y_button.UseVisualStyleBackColor = true;
            y_button.Click += y_button_Click;
            // 
            // alllistbox
            // 
            alllistbox.FormattingEnabled = true;
            alllistbox.ItemHeight = 15;
            alllistbox.Location = new Point(33, 25);
            alllistbox.Name = "alllistbox";
            alllistbox.Size = new Size(215, 259);
            alllistbox.TabIndex = 3;
            // 
            // SJ_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 381);
            Controls.Add(n_button);
            Controls.Add(y_button);
            Controls.Add(alllistbox);
            Name = "SJ_Form";
            Text = "SJ_Form";
            Load += SJ_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button n_button;
        private Button y_button;
        private ListBox alllistbox;
    }
}