namespace ProjectPerekup
{
    partial class Confirm
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(456, 62);
            label1.TabIndex = 0;
            label1.Text = "Вы уверены, что хотите удалить весь прогресс?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(12, 138);
            button1.Name = "button1";
            button1.Size = new Size(205, 47);
            button1.TabIndex = 1;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(223, 138);
            button2.Name = "button2";
            button2.Size = new Size(218, 47);
            button2.TabIndex = 2;
            button2.Text = "Да";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Confirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 197);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(469, 236);
            MinimumSize = new Size(469, 236);
            Name = "Confirm";
            ShowInTaskbar = false;
            Text = "Вы уверены?";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}