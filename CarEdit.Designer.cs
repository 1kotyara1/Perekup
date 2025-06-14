namespace ProjectPerekup
{
    partial class CarEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));
            editcarimg = new PictureBox();
            motorlabel = new Label();
            labelmoneyedit = new Label();
            motorbutton = new Button();
            transbutton = new Button();
            translabel = new Label();
            hodbutton = new Button();
            hodlabel = new Label();
            kusovbutton = new Button();
            kusovlabel = new Label();
            salonbutton = new Button();
            salonlabel = new Label();
            editcarlabel = new Label();
            cancelbutton = new Button();
            confirmbutton = new Button();
            editpricesum = new Label();
            ((System.ComponentModel.ISupportInitialize)editcarimg).BeginInit();
            SuspendLayout();
            // 
            // editcarimg
            // 
            editcarimg.BorderStyle = BorderStyle.FixedSingle;
            editcarimg.Image = Properties.Resources.car00;
            editcarimg.Location = new Point(240, 12);
            editcarimg.Name = "editcarimg";
            editcarimg.Size = new Size(300, 300);
            editcarimg.SizeMode = PictureBoxSizeMode.StretchImage;
            editcarimg.TabIndex = 0;
            editcarimg.TabStop = false;
            // 
            // motorlabel
            // 
            motorlabel.BackColor = SystemColors.Control;
            motorlabel.Font = new Font("Segoe UI", 14F);
            motorlabel.Location = new Point(12, 12);
            motorlabel.Name = "motorlabel";
            motorlabel.Size = new Size(222, 52);
            motorlabel.TabIndex = 1;
            motorlabel.Text = "Двигатель        Повреждения: тяжелые";
            // 
            // labelmoneyedit
            // 
            labelmoneyedit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelmoneyedit.Font = new Font("Segoe UI", 14F);
            labelmoneyedit.Location = new Point(12, 509);
            labelmoneyedit.Name = "labelmoneyedit";
            labelmoneyedit.Size = new Size(227, 43);
            labelmoneyedit.TabIndex = 2;
            labelmoneyedit.Text = "Баланс: 0₽";
            labelmoneyedit.TextAlign = ContentAlignment.BottomLeft;
            // 
            // motorbutton
            // 
            motorbutton.Font = new Font("Segoe UI", 14F);
            motorbutton.Location = new Point(12, 67);
            motorbutton.Name = "motorbutton";
            motorbutton.Size = new Size(222, 40);
            motorbutton.TabIndex = 3;
            motorbutton.Text = "Починить - 1000₽";
            motorbutton.UseVisualStyleBackColor = true;
            motorbutton.Click += motorbutton_Click;
            // 
            // transbutton
            // 
            transbutton.Font = new Font("Segoe UI", 14F);
            transbutton.Location = new Point(12, 168);
            transbutton.Name = "transbutton";
            transbutton.Size = new Size(222, 40);
            transbutton.TabIndex = 5;
            transbutton.Text = "Починить - 1000₽";
            transbutton.UseVisualStyleBackColor = true;
            transbutton.Click += transbutton_Click;
            // 
            // translabel
            // 
            translabel.Font = new Font("Segoe UI", 14F);
            translabel.Location = new Point(12, 113);
            translabel.Name = "translabel";
            translabel.Size = new Size(222, 52);
            translabel.TabIndex = 4;
            translabel.Text = "Трансмиссия        Повреждения: тяжелые";
            // 
            // hodbutton
            // 
            hodbutton.Font = new Font("Segoe UI", 14F);
            hodbutton.Location = new Point(12, 271);
            hodbutton.Name = "hodbutton";
            hodbutton.Size = new Size(222, 40);
            hodbutton.TabIndex = 7;
            hodbutton.Text = "Починить - 1000₽";
            hodbutton.UseVisualStyleBackColor = true;
            hodbutton.Click += hodbutton_Click;
            // 
            // hodlabel
            // 
            hodlabel.Font = new Font("Segoe UI", 14F);
            hodlabel.Location = new Point(12, 216);
            hodlabel.Name = "hodlabel";
            hodlabel.Size = new Size(222, 52);
            hodlabel.TabIndex = 6;
            hodlabel.Text = "Ходовая        Повреждения: тяжелые";
            // 
            // kusovbutton
            // 
            kusovbutton.Font = new Font("Segoe UI", 14F);
            kusovbutton.Location = new Point(546, 67);
            kusovbutton.Name = "kusovbutton";
            kusovbutton.Size = new Size(222, 40);
            kusovbutton.TabIndex = 9;
            kusovbutton.Text = "Починить - 1000₽";
            kusovbutton.UseVisualStyleBackColor = true;
            kusovbutton.Click += kusovbutton_Click;
            // 
            // kusovlabel
            // 
            kusovlabel.Font = new Font("Segoe UI", 14F);
            kusovlabel.Location = new Point(546, 12);
            kusovlabel.Name = "kusovlabel";
            kusovlabel.Size = new Size(222, 52);
            kusovlabel.TabIndex = 8;
            kusovlabel.Text = "Кузов        Повреждения: тяжелые";
            // 
            // salonbutton
            // 
            salonbutton.Font = new Font("Segoe UI", 14F);
            salonbutton.Location = new Point(546, 169);
            salonbutton.Name = "salonbutton";
            salonbutton.Size = new Size(222, 40);
            salonbutton.TabIndex = 11;
            salonbutton.Text = "Починить - 1000₽";
            salonbutton.UseVisualStyleBackColor = true;
            salonbutton.Click += salonbutton_Click;
            // 
            // salonlabel
            // 
            salonlabel.Font = new Font("Segoe UI", 14F);
            salonlabel.Location = new Point(546, 114);
            salonlabel.Name = "salonlabel";
            salonlabel.Size = new Size(222, 52);
            salonlabel.TabIndex = 10;
            salonlabel.Text = "Салон        Повреждения: тяжелые";
            // 
            // editcarlabel
            // 
            editcarlabel.BackColor = SystemColors.Control;
            editcarlabel.Font = new Font("Segoe UI", 14F);
            editcarlabel.Location = new Point(240, 315);
            editcarlabel.Name = "editcarlabel";
            editcarlabel.Size = new Size(300, 149);
            editcarlabel.TabIndex = 12;
            editcarlabel.Text = "            супермашинка                         цена:миллеард           состояние: по кайфу";
            editcarlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // cancelbutton
            // 
            cancelbutton.Font = new Font("Segoe UI", 14F);
            cancelbutton.Location = new Point(240, 502);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(146, 50);
            cancelbutton.TabIndex = 14;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;
            // 
            // confirmbutton
            // 
            confirmbutton.Font = new Font("Segoe UI", 14F);
            confirmbutton.Location = new Point(394, 502);
            confirmbutton.Name = "confirmbutton";
            confirmbutton.Size = new Size(146, 50);
            confirmbutton.TabIndex = 15;
            confirmbutton.Text = "Изменить";
            confirmbutton.UseVisualStyleBackColor = true;
            confirmbutton.Click += confirmbutton_Click;
            // 
            // editpricesum
            // 
            editpricesum.Font = new Font("Segoe UI", 14F);
            editpricesum.Location = new Point(240, 464);
            editpricesum.Name = "editpricesum";
            editpricesum.Size = new Size(300, 27);
            editpricesum.TabIndex = 16;
            editpricesum.Text = "Стоимость ремонта: 5000₽";
            editpricesum.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CarEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Controls.Add(editpricesum);
            Controls.Add(editcarlabel);
            Controls.Add(salonlabel);
            Controls.Add(kusovlabel);
            Controls.Add(hodlabel);
            Controls.Add(labelmoneyedit);
            Controls.Add(translabel);
            Controls.Add(motorlabel);
            Controls.Add(confirmbutton);
            Controls.Add(cancelbutton);
            Controls.Add(salonbutton);
            Controls.Add(kusovbutton);
            Controls.Add(hodbutton);
            Controls.Add(transbutton);
            Controls.Add(motorbutton);
            Controls.Add(editcarimg);
            MinimumSize = new Size(800, 600);
            Name = "CarEdit";
            Text = "CarEdit";
            ResizeEnd += CarEdit_ResizeEnd;
            Resize += CarEdit_Resize;
            ((System.ComponentModel.ISupportInitialize)editcarimg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox editcarimg;
        private Label motorlabel;
        private Label labelmoneyedit;
        private Button motorbutton;
        private Button transbutton;
        private Label translabel;
        private Button hodbutton;
        private Label hodlabel;
        private Button kusovbutton;
        private Label kusovlabel;
        private Button salonbutton;
        private Label salonlabel;
        private Label editcarlabel;
        private Button cancelbutton;
        private Button confirmbutton;
        private Label editpricesum;
    }
}