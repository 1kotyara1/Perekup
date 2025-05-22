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
            editcarimg = new PictureBox();
            motorlabel = new Label();
            labelmoneyedit = new Label();
            motorbutton = new Button();
            transbutton = new Button();
            translabel = new Label();
            hodbutton = new Button();
            hodlabel = new Label();
            kusbutton = new Button();
            kuslabel = new Label();
            salonbutton = new Button();
            salonlabel = new Label();
            editname = new Label();
            editcond = new Label();
            cancelbutton = new Button();
            confirmbutton = new Button();
            editpricelabel = new Label();
            editprice = new Label();
            ((System.ComponentModel.ISupportInitialize)editcarimg).BeginInit();
            SuspendLayout();
            // 
            // editcarimg
            // 
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
            // 
            // transbutton
            // 
            transbutton.Font = new Font("Segoe UI", 14F);
            transbutton.Location = new Point(12, 175);
            transbutton.Name = "transbutton";
            transbutton.Size = new Size(222, 40);
            transbutton.TabIndex = 5;
            transbutton.Text = "Починить - 1000₽";
            transbutton.UseVisualStyleBackColor = true;
            // 
            // translabel
            // 
            translabel.Font = new Font("Segoe UI", 14F);
            translabel.Location = new Point(12, 120);
            translabel.Name = "translabel";
            translabel.Size = new Size(222, 52);
            translabel.TabIndex = 4;
            translabel.Text = "Трансмиссия        Повреждения: тяжелые";
            // 
            // hodbutton
            // 
            hodbutton.Font = new Font("Segoe UI", 14F);
            hodbutton.Location = new Point(12, 283);
            hodbutton.Name = "hodbutton";
            hodbutton.Size = new Size(222, 40);
            hodbutton.TabIndex = 7;
            hodbutton.Text = "Починить - 1000₽";
            hodbutton.UseVisualStyleBackColor = true;
            // 
            // hodlabel
            // 
            hodlabel.Font = new Font("Segoe UI", 14F);
            hodlabel.Location = new Point(12, 228);
            hodlabel.Name = "hodlabel";
            hodlabel.Size = new Size(222, 52);
            hodlabel.TabIndex = 6;
            hodlabel.Text = "Ходовая        Повреждения: тяжелые";
            hodlabel.Click += label2_Click;
            // 
            // kusbutton
            // 
            kusbutton.Font = new Font("Segoe UI", 14F);
            kusbutton.Location = new Point(550, 67);
            kusbutton.Name = "kusbutton";
            kusbutton.Size = new Size(222, 40);
            kusbutton.TabIndex = 9;
            kusbutton.Text = "Починить - 1000₽";
            kusbutton.UseVisualStyleBackColor = true;
            // 
            // kuslabel
            // 
            kuslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kuslabel.Font = new Font("Segoe UI", 14F);
            kuslabel.Location = new Point(550, 12);
            kuslabel.Name = "kuslabel";
            kuslabel.Size = new Size(222, 52);
            kuslabel.TabIndex = 8;
            kuslabel.Text = "Кузов        Повреждения: тяжелые";
            // 
            // salonbutton
            // 
            salonbutton.Font = new Font("Segoe UI", 14F);
            salonbutton.Location = new Point(550, 175);
            salonbutton.Name = "salonbutton";
            salonbutton.Size = new Size(222, 40);
            salonbutton.TabIndex = 11;
            salonbutton.Text = "Починить - 1000₽";
            salonbutton.UseVisualStyleBackColor = true;
            // 
            // salonlabel
            // 
            salonlabel.Font = new Font("Segoe UI", 14F);
            salonlabel.Location = new Point(550, 120);
            salonlabel.Name = "salonlabel";
            salonlabel.Size = new Size(222, 52);
            salonlabel.TabIndex = 10;
            salonlabel.Text = "Салон        Повреждения: тяжелые";
            // 
            // editname
            // 
            editname.Font = new Font("Segoe UI", 14F);
            editname.Location = new Point(240, 315);
            editname.Name = "editname";
            editname.Size = new Size(300, 31);
            editname.TabIndex = 12;
            editname.Text = "супермашинка";
            editname.TextAlign = ContentAlignment.TopCenter;
            // 
            // editcond
            // 
            editcond.Font = new Font("Segoe UI", 14F);
            editcond.Location = new Point(240, 377);
            editcond.Name = "editcond";
            editcond.Size = new Size(300, 31);
            editcond.TabIndex = 13;
            editcond.Text = "Состояние: норм";
            editcond.TextAlign = ContentAlignment.TopCenter;
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
            // 
            // editpricelabel
            // 
            editpricelabel.Font = new Font("Segoe UI", 14F);
            editpricelabel.Location = new Point(240, 464);
            editpricelabel.Name = "editpricelabel";
            editpricelabel.Size = new Size(300, 27);
            editpricelabel.TabIndex = 16;
            editpricelabel.Text = "Стоимость ремонта: 5000₽";
            editpricelabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // editprice
            // 
            editprice.Font = new Font("Segoe UI", 14F);
            editprice.Location = new Point(240, 346);
            editprice.Name = "editprice";
            editprice.Size = new Size(300, 31);
            editprice.TabIndex = 17;
            editprice.Text = "Стоимость машины: 3500₽";
            editprice.TextAlign = ContentAlignment.TopCenter;
            // 
            // CarEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(editprice);
            Controls.Add(editpricelabel);
            Controls.Add(confirmbutton);
            Controls.Add(cancelbutton);
            Controls.Add(editcond);
            Controls.Add(editname);
            Controls.Add(salonbutton);
            Controls.Add(salonlabel);
            Controls.Add(kusbutton);
            Controls.Add(kuslabel);
            Controls.Add(hodbutton);
            Controls.Add(hodlabel);
            Controls.Add(transbutton);
            Controls.Add(translabel);
            Controls.Add(motorbutton);
            Controls.Add(labelmoneyedit);
            Controls.Add(motorlabel);
            Controls.Add(editcarimg);
            MinimumSize = new Size(800, 600);
            Name = "CarEdit";
            Text = "CarEdit";
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
        private Button kusbutton;
        private Label kuslabel;
        private Button salonbutton;
        private Label salonlabel;
        private Label editname;
        private Label editcond;
        private Button cancelbutton;
        private Button confirmbutton;
        private Label editpricelabel;
        private Label editprice;
    }
}