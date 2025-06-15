namespace ProjectPerekup
{
    partial class LieCalc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            confirm = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(298, 52);
            label1.TabIndex = 0;
            label1.Text = "Мотор";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(320, 11);
            label2.Name = "label2";
            label2.Size = new Size(298, 50);
            label2.TabIndex = 1;
            label2.Text = "Кузов";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(320, 211);
            label3.Name = "label3";
            label3.Size = new Size(298, 50);
            label3.TabIndex = 3;
            label3.Text = "Салон";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(14, 211);
            label4.Name = "label4";
            label4.Size = new Size(298, 50);
            label4.TabIndex = 2;
            label4.Text = "Трансмиссия";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(14, 410);
            label5.Name = "label5";
            label5.Size = new Size(298, 50);
            label5.TabIndex = 4;
            label5.Text = "Ходовая";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(321, 410);
            label6.Name = "label6";
            label6.Size = new Size(298, 50);
            label6.TabIndex = 5;
            label6.Text = "Везде";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirm
            // 
            confirm.Location = new Point(321, 569);
            confirm.Name = "confirm";
            confirm.Size = new Size(182, 52);
            confirm.TabIndex = 9;
            confirm.Text = "Наврать";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(133, 569);
            cancel.Name = "cancel";
            cancel.Size = new Size(182, 52);
            cancel.TabIndex = 10;
            cancel.Text = "Отмена";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // LieCalc
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 633);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 17F);
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(648, 672);
            MinimumSize = new Size(648, 672);
            Name = "LieCalc";
            ShowInTaskbar = false;
            Text = "Никто не должен узнать";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button confirm;
        private Button cancel;
    }
}