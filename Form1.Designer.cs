namespace ProjectPerekup
{
    partial class perekup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));
            tabs = new TabControl();
            garage = new TabPage();
            car3img = new PictureBox();
            car4img = new PictureBox();
            car5img = new PictureBox();
            car0img = new PictureBox();
            car1img = new PictureBox();
            car2img = new PictureBox();
            car0text = new Label();
            car1text = new Label();
            car2text = new Label();
            car3text = new Label();
            car4text = new Label();
            car5text = new Label();
            garagetitle = new Label();
            workshops = new TabPage();
            Stepanichbutton = new Button();
            Fitservicebutton = new Button();
            Vasiliybutton = new Button();
            citypicture = new PictureBox();
            browser = new TabPage();
            buySellInfo = new Label();
            avitocar2price = new Label();
            avitocar1price = new Label();
            avitocar0price = new Label();
            avitocar2buy = new Button();
            avitocar1buy = new Button();
            avitocar0buy = new Button();
            avitocar2name = new Label();
            avitocar1name = new Label();
            avitocar0name = new Label();
            avitocar2img = new PictureBox();
            avitocar1img = new PictureBox();
            avitocar0img = new PictureBox();
            reloadcars = new PictureBox();
            avitocar0 = new ListView();
            avitocar1 = new ListView();
            avitocar2 = new ListView();
            combosort = new ComboBox();
            buttonavitosell = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            skill = new TabPage();
            skill3up = new PictureBox();
            skill4up = new PictureBox();
            skill5up = new PictureBox();
            skill2up = new PictureBox();
            skill1up = new PictureBox();
            skill0up = new PictureBox();
            skill5name = new Label();
            skill4name = new Label();
            skill3name = new Label();
            skill2name = new Label();
            skill1name = new Label();
            skill0name = new Label();
            skilltitle = new Label();
            statistics = new TabPage();
            clearData = new Button();
            recievedmoney = new Label();
            spentmoney = new Label();
            skill5 = new Label();
            skill4 = new Label();
            skill3 = new Label();
            skill2 = new Label();
            skill1 = new Label();
            skill0 = new Label();
            boughtcars = new Label();
            skillslabel = new Label();
            soldcars = new Label();
            stattitle = new Label();
            labelmoney = new Label();
            tabs.SuspendLayout();
            garage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)car3img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car4img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car5img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car0img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car1img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car2img).BeginInit();
            workshops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)citypicture).BeginInit();
            browser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avitocar2img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avitocar1img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avitocar0img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reloadcars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            skill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skill3up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skill4up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skill5up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skill2up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skill1up).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skill0up).BeginInit();
            statistics.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabs.Controls.Add(garage);
            tabs.Controls.Add(workshops);
            tabs.Controls.Add(browser);
            tabs.Controls.Add(skill);
            tabs.Controls.Add(statistics);
            tabs.Font = new Font("Segoe UI", 14F);
            tabs.ItemSize = new Size(120, 30);
            tabs.Location = new Point(-4, 0);
            tabs.Name = "tabs";
            tabs.Padding = new Point(12, 3);
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(790, 576);
            tabs.TabIndex = 0;
            tabs.SelectedIndexChanged += tabs_SelectedIndexChanged;
            // 
            // garage
            // 
            garage.Controls.Add(car3img);
            garage.Controls.Add(car4img);
            garage.Controls.Add(car5img);
            garage.Controls.Add(car0img);
            garage.Controls.Add(car1img);
            garage.Controls.Add(car2img);
            garage.Controls.Add(car0text);
            garage.Controls.Add(car1text);
            garage.Controls.Add(car2text);
            garage.Controls.Add(car3text);
            garage.Controls.Add(car4text);
            garage.Controls.Add(car5text);
            garage.Controls.Add(garagetitle);
            garage.Location = new Point(4, 34);
            garage.Name = "garage";
            garage.Padding = new Padding(3);
            garage.Size = new Size(782, 538);
            garage.TabIndex = 0;
            garage.Text = "Гараж";
            garage.UseVisualStyleBackColor = true;
            // 
            // car3img
            // 
            car3img.BorderStyle = BorderStyle.FixedSingle;
            car3img.Cursor = Cursors.Hand;
            car3img.Image = Properties.Resources.car00;
            car3img.Location = new Point(123, 300);
            car3img.Name = "car3img";
            car3img.Size = new Size(120, 120);
            car3img.SizeMode = PictureBoxSizeMode.StretchImage;
            car3img.TabIndex = 6;
            car3img.TabStop = false;
            // 
            // car4img
            // 
            car4img.BorderStyle = BorderStyle.FixedSingle;
            car4img.Cursor = Cursors.Hand;
            car4img.Image = Properties.Resources.car00;
            car4img.Location = new Point(331, 300);
            car4img.Name = "car4img";
            car4img.Size = new Size(120, 120);
            car4img.SizeMode = PictureBoxSizeMode.StretchImage;
            car4img.TabIndex = 5;
            car4img.TabStop = false;
            // 
            // car5img
            // 
            car5img.BorderStyle = BorderStyle.FixedSingle;
            car5img.Cursor = Cursors.Hand;
            car5img.Image = Properties.Resources.car00;
            car5img.Location = new Point(539, 300);
            car5img.Name = "car5img";
            car5img.Size = new Size(120, 120);
            car5img.SizeMode = PictureBoxSizeMode.StretchImage;
            car5img.TabIndex = 4;
            car5img.TabStop = false;
            // 
            // car0img
            // 
            car0img.BorderStyle = BorderStyle.FixedSingle;
            car0img.Cursor = Cursors.Hand;
            car0img.Image = Properties.Resources.car00;
            car0img.Location = new Point(123, 64);
            car0img.Name = "car0img";
            car0img.Size = new Size(120, 120);
            car0img.SizeMode = PictureBoxSizeMode.StretchImage;
            car0img.TabIndex = 3;
            car0img.TabStop = false;
            // 
            // car1img
            // 
            car1img.BorderStyle = BorderStyle.FixedSingle;
            car1img.Cursor = Cursors.Hand;
            car1img.Image = Properties.Resources.car00;
            car1img.Location = new Point(331, 64);
            car1img.Name = "car1img";
            car1img.Size = new Size(120, 120);
            car1img.SizeMode = PictureBoxSizeMode.StretchImage;
            car1img.TabIndex = 2;
            car1img.TabStop = false;
            // 
            // car2img
            // 
            car2img.BorderStyle = BorderStyle.FixedSingle;
            car2img.Cursor = Cursors.Hand;
            car2img.Image = Properties.Resources.car00;
            car2img.Location = new Point(539, 64);
            car2img.Name = "car2img";
            car2img.Size = new Size(120, 120);
            car2img.SizeMode = PictureBoxSizeMode.StretchImage;
            car2img.TabIndex = 1;
            car2img.TabStop = false;
            // 
            // car0text
            // 
            car0text.BackColor = Color.Transparent;
            car0text.Location = new Point(83, 187);
            car0text.Name = "car0text";
            car0text.Size = new Size(205, 111);
            car0text.TabIndex = 10;
            car0text.Text = "label1";
            car0text.TextAlign = ContentAlignment.TopCenter;
            car0text.Visible = false;
            // 
            // car1text
            // 
            car1text.BackColor = Color.Transparent;
            car1text.Location = new Point(291, 187);
            car1text.Name = "car1text";
            car1text.Size = new Size(200, 111);
            car1text.TabIndex = 9;
            car1text.Text = "label1";
            car1text.TextAlign = ContentAlignment.TopCenter;
            car1text.Visible = false;
            // 
            // car2text
            // 
            car2text.BackColor = Color.Transparent;
            car2text.Location = new Point(494, 187);
            car2text.Name = "car2text";
            car2text.Size = new Size(205, 111);
            car2text.TabIndex = 8;
            car2text.Text = "label1";
            car2text.TextAlign = ContentAlignment.TopCenter;
            car2text.Visible = false;
            // 
            // car3text
            // 
            car3text.BackColor = Color.Transparent;
            car3text.Location = new Point(83, 423);
            car3text.Name = "car3text";
            car3text.Size = new Size(205, 111);
            car3text.TabIndex = 11;
            car3text.Text = "label1";
            car3text.TextAlign = ContentAlignment.TopCenter;
            car3text.Visible = false;
            // 
            // car4text
            // 
            car4text.BackColor = Color.Transparent;
            car4text.Location = new Point(291, 423);
            car4text.Name = "car4text";
            car4text.Size = new Size(205, 111);
            car4text.TabIndex = 12;
            car4text.Text = "label1";
            car4text.TextAlign = ContentAlignment.TopCenter;
            car4text.Visible = false;
            // 
            // car5text
            // 
            car5text.BackColor = Color.Transparent;
            car5text.Location = new Point(494, 423);
            car5text.Name = "car5text";
            car5text.Size = new Size(205, 111);
            car5text.TabIndex = 13;
            car5text.Text = "label1";
            car5text.TextAlign = ContentAlignment.TopCenter;
            car5text.Visible = false;
            // 
            // garagetitle
            // 
            garagetitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            garagetitle.Font = new Font("Segoe UI", 25F);
            garagetitle.Location = new Point(0, 0);
            garagetitle.Name = "garagetitle";
            garagetitle.Size = new Size(786, 50);
            garagetitle.TabIndex = 0;
            garagetitle.Text = "Ваш гараж";
            garagetitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // workshops
            // 
            workshops.Controls.Add(Stepanichbutton);
            workshops.Controls.Add(Fitservicebutton);
            workshops.Controls.Add(Vasiliybutton);
            workshops.Controls.Add(citypicture);
            workshops.Location = new Point(4, 34);
            workshops.Name = "workshops";
            workshops.Padding = new Padding(3);
            workshops.Size = new Size(782, 538);
            workshops.TabIndex = 1;
            workshops.Text = "Мастерские";
            workshops.UseVisualStyleBackColor = true;
            // 
            // Stepanichbutton
            // 
            Stepanichbutton.Font = new Font("Segoe UI", 10F);
            Stepanichbutton.Location = new Point(373, 79);
            Stepanichbutton.Name = "Stepanichbutton";
            Stepanichbutton.Size = new Size(83, 27);
            Stepanichbutton.TabIndex = 3;
            Stepanichbutton.Text = "Степаныч";
            Stepanichbutton.UseVisualStyleBackColor = true;
            Stepanichbutton.Click += Stepanichbutton_Click;
            // 
            // Fitservicebutton
            // 
            Fitservicebutton.Font = new Font("Segoe UI", 10F);
            Fitservicebutton.Location = new Point(631, 269);
            Fitservicebutton.Name = "Fitservicebutton";
            Fitservicebutton.Size = new Size(77, 27);
            Fitservicebutton.TabIndex = 2;
            Fitservicebutton.Text = "FitService";
            Fitservicebutton.UseVisualStyleBackColor = true;
            Fitservicebutton.Click += Fitservicebutton_Click;
            // 
            // Vasiliybutton
            // 
            Vasiliybutton.Font = new Font("Segoe UI", 10F);
            Vasiliybutton.Location = new Point(79, 283);
            Vasiliybutton.Name = "Vasiliybutton";
            Vasiliybutton.Size = new Size(73, 26);
            Vasiliybutton.TabIndex = 1;
            Vasiliybutton.Text = "Василий";
            Vasiliybutton.UseVisualStyleBackColor = true;
            Vasiliybutton.Click += Vasiliybutton_Click;
            // 
            // citypicture
            // 
            citypicture.Image = Properties.Resources.город;
            citypicture.InitialImage = null;
            citypicture.Location = new Point(0, 0);
            citypicture.Name = "citypicture";
            citypicture.Size = new Size(782, 538);
            citypicture.SizeMode = PictureBoxSizeMode.StretchImage;
            citypicture.TabIndex = 0;
            citypicture.TabStop = false;
            // 
            // browser
            // 
            browser.Controls.Add(buySellInfo);
            browser.Controls.Add(avitocar2price);
            browser.Controls.Add(avitocar1price);
            browser.Controls.Add(avitocar0price);
            browser.Controls.Add(avitocar2buy);
            browser.Controls.Add(avitocar1buy);
            browser.Controls.Add(avitocar0buy);
            browser.Controls.Add(avitocar2name);
            browser.Controls.Add(avitocar1name);
            browser.Controls.Add(avitocar0name);
            browser.Controls.Add(avitocar2img);
            browser.Controls.Add(avitocar1img);
            browser.Controls.Add(avitocar0img);
            browser.Controls.Add(reloadcars);
            browser.Controls.Add(avitocar0);
            browser.Controls.Add(avitocar1);
            browser.Controls.Add(avitocar2);
            browser.Controls.Add(combosort);
            browser.Controls.Add(buttonavitosell);
            browser.Controls.Add(label1);
            browser.Controls.Add(pictureBox1);
            browser.Location = new Point(4, 34);
            browser.Name = "browser";
            browser.Padding = new Padding(3);
            browser.Size = new Size(782, 538);
            browser.TabIndex = 2;
            browser.Text = "Браузер";
            browser.UseVisualStyleBackColor = true;
            // 
            // buySellInfo
            // 
            buySellInfo.AccessibleDescription = "";
            buySellInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buySellInfo.Location = new Point(483, 69);
            buySellInfo.Name = "buySellInfo";
            buySellInfo.Size = new Size(293, 64);
            buySellInfo.TabIndex = 25;
            buySellInfo.Text = "label2";
            buySellInfo.Click += buySellInfo_Click;
            // 
            // avitocar2price
            // 
            avitocar2price.BackColor = SystemColors.ScrollBar;
            avitocar2price.Location = new Point(522, 337);
            avitocar2price.Name = "avitocar2price";
            avitocar2price.Size = new Size(250, 37);
            avitocar2price.TabIndex = 24;
            avitocar2price.Text = "0";
            avitocar2price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // avitocar1price
            // 
            avitocar1price.BackColor = SystemColors.ScrollBar;
            avitocar1price.Location = new Point(522, 241);
            avitocar1price.Name = "avitocar1price";
            avitocar1price.Size = new Size(250, 37);
            avitocar1price.TabIndex = 23;
            avitocar1price.Text = "0";
            avitocar1price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // avitocar0price
            // 
            avitocar0price.BackColor = SystemColors.ScrollBar;
            avitocar0price.Location = new Point(522, 145);
            avitocar0price.Name = "avitocar0price";
            avitocar0price.Size = new Size(250, 37);
            avitocar0price.TabIndex = 22;
            avitocar0price.Text = "0";
            avitocar0price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // avitocar2buy
            // 
            avitocar2buy.Font = new Font("Segoe UI", 16F);
            avitocar2buy.Location = new Point(522, 377);
            avitocar2buy.Name = "avitocar2buy";
            avitocar2buy.Size = new Size(250, 39);
            avitocar2buy.TabIndex = 21;
            avitocar2buy.Text = "Купить";
            avitocar2buy.UseVisualStyleBackColor = true;
            // 
            // avitocar1buy
            // 
            avitocar1buy.Font = new Font("Segoe UI", 16F);
            avitocar1buy.Location = new Point(522, 281);
            avitocar1buy.Name = "avitocar1buy";
            avitocar1buy.Size = new Size(250, 39);
            avitocar1buy.TabIndex = 20;
            avitocar1buy.Text = "Купить";
            avitocar1buy.UseVisualStyleBackColor = true;
            // 
            // avitocar0buy
            // 
            avitocar0buy.Font = new Font("Segoe UI", 16F);
            avitocar0buy.Location = new Point(522, 185);
            avitocar0buy.Name = "avitocar0buy";
            avitocar0buy.Size = new Size(250, 39);
            avitocar0buy.TabIndex = 19;
            avitocar0buy.Text = "Купить";
            avitocar0buy.UseVisualStyleBackColor = true;
            // 
            // avitocar2name
            // 
            avitocar2name.Location = new Point(102, 337);
            avitocar2name.Name = "avitocar2name";
            avitocar2name.Size = new Size(414, 79);
            avitocar2name.TabIndex = 15;
            avitocar2name.Text = "Пусто";
            // 
            // avitocar1name
            // 
            avitocar1name.Location = new Point(102, 241);
            avitocar1name.Name = "avitocar1name";
            avitocar1name.Size = new Size(414, 79);
            avitocar1name.TabIndex = 14;
            avitocar1name.Text = "Пусто";
            // 
            // avitocar0name
            // 
            avitocar0name.Location = new Point(102, 145);
            avitocar0name.Name = "avitocar0name";
            avitocar0name.Size = new Size(414, 79);
            avitocar0name.TabIndex = 13;
            avitocar0name.Text = "Пусто";
            // 
            // avitocar2img
            // 
            avitocar2img.BorderStyle = BorderStyle.FixedSingle;
            avitocar2img.Image = Properties.Resources.car00;
            avitocar2img.Location = new Point(6, 332);
            avitocar2img.Name = "avitocar2img";
            avitocar2img.Size = new Size(90, 90);
            avitocar2img.SizeMode = PictureBoxSizeMode.StretchImage;
            avitocar2img.TabIndex = 12;
            avitocar2img.TabStop = false;
            // 
            // avitocar1img
            // 
            avitocar1img.BorderStyle = BorderStyle.FixedSingle;
            avitocar1img.Image = Properties.Resources.car00;
            avitocar1img.Location = new Point(6, 236);
            avitocar1img.Name = "avitocar1img";
            avitocar1img.Size = new Size(90, 90);
            avitocar1img.SizeMode = PictureBoxSizeMode.StretchImage;
            avitocar1img.TabIndex = 11;
            avitocar1img.TabStop = false;
            // 
            // avitocar0img
            // 
            avitocar0img.BorderStyle = BorderStyle.FixedSingle;
            avitocar0img.Image = Properties.Resources.car00;
            avitocar0img.Location = new Point(6, 140);
            avitocar0img.Name = "avitocar0img";
            avitocar0img.Size = new Size(90, 90);
            avitocar0img.SizeMode = PictureBoxSizeMode.StretchImage;
            avitocar0img.TabIndex = 10;
            avitocar0img.TabStop = false;
            // 
            // reloadcars
            // 
            reloadcars.Cursor = Cursors.Hand;
            reloadcars.Image = Properties.Resources.reloadcars;
            reloadcars.Location = new Point(185, 100);
            reloadcars.Name = "reloadcars";
            reloadcars.Size = new Size(33, 33);
            reloadcars.SizeMode = PictureBoxSizeMode.StretchImage;
            reloadcars.TabIndex = 9;
            reloadcars.TabStop = false;
            reloadcars.Click += reloadcars_Click;
            // 
            // avitocar0
            // 
            avitocar0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            avitocar0.BackColor = SystemColors.ScrollBar;
            avitocar0.Location = new Point(6, 140);
            avitocar0.Name = "avitocar0";
            avitocar0.Size = new Size(770, 90);
            avitocar0.TabIndex = 8;
            avitocar0.UseCompatibleStateImageBehavior = false;
            // 
            // avitocar1
            // 
            avitocar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            avitocar1.BackColor = SystemColors.ScrollBar;
            avitocar1.Location = new Point(6, 236);
            avitocar1.Name = "avitocar1";
            avitocar1.Size = new Size(770, 90);
            avitocar1.TabIndex = 7;
            avitocar1.UseCompatibleStateImageBehavior = false;
            // 
            // avitocar2
            // 
            avitocar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            avitocar2.BackColor = SystemColors.ScrollBar;
            avitocar2.Location = new Point(6, 332);
            avitocar2.Name = "avitocar2";
            avitocar2.Size = new Size(770, 90);
            avitocar2.TabIndex = 6;
            avitocar2.UseCompatibleStateImageBehavior = false;
            // 
            // combosort
            // 
            combosort.FormattingEnabled = true;
            combosort.Location = new Point(6, 100);
            combosort.Name = "combosort";
            combosort.Size = new Size(173, 33);
            combosort.TabIndex = 3;
            // 
            // buttonavitosell
            // 
            buttonavitosell.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonavitosell.BackColor = Color.FromArgb(11, 121, 234);
            buttonavitosell.Cursor = Cursors.Hand;
            buttonavitosell.FlatStyle = FlatStyle.Popup;
            buttonavitosell.ForeColor = SystemColors.Control;
            buttonavitosell.Location = new Point(483, 25);
            buttonavitosell.Name = "buttonavitosell";
            buttonavitosell.Size = new Size(293, 41);
            buttonavitosell.TabIndex = 2;
            buttonavitosell.Text = "Разместить объявление";
            buttonavitosell.UseVisualStyleBackColor = false;
            buttonavitosell.Click += buttonavitosell_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(92, -2);
            label1.Name = "label1";
            label1.Size = new Size(480, 80);
            label1.TabIndex = 1;
            label1.Text = "Автомаркет";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.avitocarproject;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // skill
            // 
            skill.Controls.Add(skill3up);
            skill.Controls.Add(skill4up);
            skill.Controls.Add(skill5up);
            skill.Controls.Add(skill2up);
            skill.Controls.Add(skill1up);
            skill.Controls.Add(skill0up);
            skill.Controls.Add(skill5name);
            skill.Controls.Add(skill4name);
            skill.Controls.Add(skill3name);
            skill.Controls.Add(skill2name);
            skill.Controls.Add(skill1name);
            skill.Controls.Add(skill0name);
            skill.Controls.Add(skilltitle);
            skill.Location = new Point(4, 34);
            skill.Name = "skill";
            skill.Padding = new Padding(3);
            skill.Size = new Size(782, 538);
            skill.TabIndex = 4;
            skill.Text = "Навыки";
            skill.UseVisualStyleBackColor = true;
            // 
            // skill3up
            // 
            skill3up.BackColor = Color.FromArgb(200, 200, 200);
            skill3up.BorderStyle = BorderStyle.FixedSingle;
            skill3up.Image = Properties.Resources.plus;
            skill3up.Location = new Point(695, 128);
            skill3up.Name = "skill3up";
            skill3up.Size = new Size(40, 40);
            skill3up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill3up.TabIndex = 10;
            skill3up.TabStop = false;
            // 
            // skill4up
            // 
            skill4up.BackColor = Color.FromArgb(200, 200, 200);
            skill4up.BorderStyle = BorderStyle.FixedSingle;
            skill4up.Image = Properties.Resources.plus;
            skill4up.Location = new Point(695, 273);
            skill4up.Name = "skill4up";
            skill4up.Size = new Size(40, 40);
            skill4up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill4up.TabIndex = 10;
            skill4up.TabStop = false;
            // 
            // skill5up
            // 
            skill5up.BackColor = Color.FromArgb(200, 200, 200);
            skill5up.BorderStyle = BorderStyle.FixedSingle;
            skill5up.Image = Properties.Resources.plus;
            skill5up.Location = new Point(695, 418);
            skill5up.Name = "skill5up";
            skill5up.Size = new Size(40, 40);
            skill5up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill5up.TabIndex = 10;
            skill5up.TabStop = false;
            // 
            // skill2up
            // 
            skill2up.BackColor = Color.FromArgb(200, 200, 200);
            skill2up.BorderStyle = BorderStyle.FixedSingle;
            skill2up.Image = Properties.Resources.plus;
            skill2up.Location = new Point(221, 418);
            skill2up.Name = "skill2up";
            skill2up.Size = new Size(40, 40);
            skill2up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill2up.TabIndex = 10;
            skill2up.TabStop = false;
            // 
            // skill1up
            // 
            skill1up.BackColor = Color.FromArgb(200, 200, 200);
            skill1up.BorderStyle = BorderStyle.FixedSingle;
            skill1up.Image = Properties.Resources.plus;
            skill1up.Location = new Point(221, 273);
            skill1up.Name = "skill1up";
            skill1up.Size = new Size(40, 40);
            skill1up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill1up.TabIndex = 10;
            skill1up.TabStop = false;
            // 
            // skill0up
            // 
            skill0up.BackColor = Color.FromArgb(200, 200, 200);
            skill0up.BorderStyle = BorderStyle.FixedSingle;
            skill0up.Image = Properties.Resources.plus;
            skill0up.Location = new Point(221, 128);
            skill0up.Name = "skill0up";
            skill0up.Size = new Size(40, 40);
            skill0up.SizeMode = PictureBoxSizeMode.StretchImage;
            skill0up.TabIndex = 8;
            skill0up.TabStop = false;
            // 
            // skill5name
            // 
            skill5name.Location = new Point(521, 365);
            skill5name.Name = "skill5name";
            skill5name.Size = new Size(214, 50);
            skill5name.TabIndex = 7;
            skill5name.Text = "Хитрец  100₽";
            skill5name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill4name
            // 
            skill4name.Location = new Point(521, 220);
            skill4name.Name = "skill4name";
            skill4name.Size = new Size(214, 50);
            skill4name.TabIndex = 6;
            skill4name.Text = "Тюнинговщик  100₽";
            skill4name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill3name
            // 
            skill3name.Location = new Point(521, 75);
            skill3name.Name = "skill3name";
            skill3name.Size = new Size(214, 50);
            skill3name.TabIndex = 5;
            skill3name.Text = "          Ремонтник            100₽";
            skill3name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill2name
            // 
            skill2name.Location = new Point(47, 365);
            skill2name.Name = "skill2name";
            skill2name.Size = new Size(214, 50);
            skill2name.TabIndex = 4;
            skill2name.Text = "Знаток гаджетов  100₽";
            skill2name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill1name
            // 
            skill1name.Location = new Point(47, 220);
            skill1name.Name = "skill1name";
            skill1name.Size = new Size(214, 50);
            skill1name.TabIndex = 3;
            skill1name.Text = "Мастер продаж  100₽";
            skill1name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill0name
            // 
            skill0name.Location = new Point(47, 75);
            skill0name.Name = "skill0name";
            skill0name.Size = new Size(214, 50);
            skill0name.TabIndex = 2;
            skill0name.Text = "Любовь поторговаться 100₽";
            skill0name.TextAlign = ContentAlignment.TopCenter;
            // 
            // skilltitle
            // 
            skilltitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            skilltitle.Font = new Font("Segoe UI", 25F);
            skilltitle.Location = new Point(3, 0);
            skilltitle.Name = "skilltitle";
            skilltitle.Size = new Size(783, 50);
            skilltitle.TabIndex = 1;
            skilltitle.Text = " Ваши навыки";
            skilltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statistics
            // 
            statistics.Controls.Add(clearData);
            statistics.Controls.Add(recievedmoney);
            statistics.Controls.Add(spentmoney);
            statistics.Controls.Add(skill5);
            statistics.Controls.Add(skill4);
            statistics.Controls.Add(skill3);
            statistics.Controls.Add(skill2);
            statistics.Controls.Add(skill1);
            statistics.Controls.Add(skill0);
            statistics.Controls.Add(boughtcars);
            statistics.Controls.Add(skillslabel);
            statistics.Controls.Add(soldcars);
            statistics.Controls.Add(stattitle);
            statistics.Location = new Point(4, 34);
            statistics.Name = "statistics";
            statistics.Padding = new Padding(3);
            statistics.Size = new Size(782, 538);
            statistics.TabIndex = 5;
            statistics.Text = "Статистика";
            statistics.UseVisualStyleBackColor = true;
            // 
            // clearData
            // 
            clearData.Location = new Point(303, 479);
            clearData.Name = "clearData";
            clearData.Size = new Size(200, 50);
            clearData.TabIndex = 12;
            clearData.Text = "Стереть данные";
            clearData.UseVisualStyleBackColor = true;
            clearData.Click += clearData_Click;
            // 
            // recievedmoney
            // 
            recievedmoney.Location = new Point(12, 79);
            recievedmoney.Name = "recievedmoney";
            recievedmoney.Size = new Size(358, 29);
            recievedmoney.TabIndex = 11;
            recievedmoney.Text = "Получено денег: 0₽";
            recievedmoney.TextAlign = ContentAlignment.TopCenter;
            // 
            // spentmoney
            // 
            spentmoney.Location = new Point(12, 50);
            spentmoney.Name = "spentmoney";
            spentmoney.Size = new Size(358, 29);
            spentmoney.TabIndex = 10;
            spentmoney.Text = "Потрачено денег: 0₽";
            spentmoney.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill5
            // 
            skill5.Location = new Point(439, 228);
            skill5.Name = "skill5";
            skill5.Size = new Size(337, 29);
            skill5.TabIndex = 9;
            skill5.Text = "Название: 0 уровень";
            skill5.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill4
            // 
            skill4.Location = new Point(439, 199);
            skill4.Name = "skill4";
            skill4.Size = new Size(337, 29);
            skill4.TabIndex = 8;
            skill4.Text = "Название: 0 уровень";
            skill4.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill3
            // 
            skill3.Location = new Point(439, 170);
            skill3.Name = "skill3";
            skill3.Size = new Size(337, 29);
            skill3.TabIndex = 7;
            skill3.Text = "Название: 0 уровень";
            skill3.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill2
            // 
            skill2.Location = new Point(439, 141);
            skill2.Name = "skill2";
            skill2.Size = new Size(337, 29);
            skill2.TabIndex = 6;
            skill2.Text = "Название: 0 уровень";
            skill2.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill1
            // 
            skill1.Location = new Point(439, 112);
            skill1.Name = "skill1";
            skill1.Size = new Size(337, 29);
            skill1.TabIndex = 5;
            skill1.Text = "Название: 0 уровень";
            skill1.TextAlign = ContentAlignment.TopCenter;
            // 
            // skill0
            // 
            skill0.Location = new Point(439, 83);
            skill0.Name = "skill0";
            skill0.Size = new Size(337, 29);
            skill0.TabIndex = 4;
            skill0.Text = "Название: 0 уровень";
            skill0.TextAlign = ContentAlignment.TopCenter;
            // 
            // boughtcars
            // 
            boughtcars.Location = new Point(12, 143);
            boughtcars.Name = "boughtcars";
            boughtcars.Size = new Size(358, 29);
            boughtcars.TabIndex = 3;
            boughtcars.Text = "Куплено машин: 0";
            boughtcars.TextAlign = ContentAlignment.TopCenter;
            // 
            // skillslabel
            // 
            skillslabel.Location = new Point(439, 50);
            skillslabel.Name = "skillslabel";
            skillslabel.Size = new Size(337, 29);
            skillslabel.TabIndex = 2;
            skillslabel.Text = "Навыки:";
            skillslabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // soldcars
            // 
            soldcars.Location = new Point(12, 114);
            soldcars.Name = "soldcars";
            soldcars.Size = new Size(358, 29);
            soldcars.TabIndex = 1;
            soldcars.Text = "Продано машин: 0";
            soldcars.TextAlign = ContentAlignment.TopCenter;
            // 
            // stattitle
            // 
            stattitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stattitle.Font = new Font("Segoe UI", 25F);
            stattitle.Location = new Point(0, 0);
            stattitle.Name = "stattitle";
            stattitle.Size = new Size(782, 50);
            stattitle.TabIndex = 0;
            stattitle.Text = "Ваша статистика";
            stattitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelmoney
            // 
            labelmoney.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelmoney.BackColor = Color.Transparent;
            labelmoney.Font = new Font("Segoe UI", 16F);
            labelmoney.Location = new Point(521, 0);
            labelmoney.Name = "labelmoney";
            labelmoney.Size = new Size(261, 32);
            labelmoney.TabIndex = 25;
            labelmoney.Text = "Баланс: 0 ₽";
            labelmoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // perekup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 575);
            Controls.Add(labelmoney);
            Controls.Add(tabs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 614);
            Name = "perekup";
            Text = "Симулятор перекупа";
            ResizeEnd += perekup_ResizeEnd;
            Resize += Form1_Resize;
            tabs.ResumeLayout(false);
            garage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)car3img).EndInit();
            ((System.ComponentModel.ISupportInitialize)car4img).EndInit();
            ((System.ComponentModel.ISupportInitialize)car5img).EndInit();
            ((System.ComponentModel.ISupportInitialize)car0img).EndInit();
            ((System.ComponentModel.ISupportInitialize)car1img).EndInit();
            ((System.ComponentModel.ISupportInitialize)car2img).EndInit();
            workshops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)citypicture).EndInit();
            browser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avitocar2img).EndInit();
            ((System.ComponentModel.ISupportInitialize)avitocar1img).EndInit();
            ((System.ComponentModel.ISupportInitialize)avitocar0img).EndInit();
            ((System.ComponentModel.ISupportInitialize)reloadcars).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            skill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)skill3up).EndInit();
            ((System.ComponentModel.ISupportInitialize)skill4up).EndInit();
            ((System.ComponentModel.ISupportInitialize)skill5up).EndInit();
            ((System.ComponentModel.ISupportInitialize)skill2up).EndInit();
            ((System.ComponentModel.ISupportInitialize)skill1up).EndInit();
            ((System.ComponentModel.ISupportInitialize)skill0up).EndInit();
            statistics.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage garage;
        private TabPage workshops;
        private TabPage browser;
        private Label garagetitle;
        private PictureBox citypicture;
        private Button Stepanichbutton;
        private Button Fitservicebutton;
        private Button Vasiliybutton;
        private PictureBox car0img;
        private PictureBox car1img;
        private PictureBox car2img;
        private PictureBox car3img;
        private PictureBox car4img;
        private PictureBox car5img;
        private Label car5text;
        private Label car4text;
        private Label car3text;
        private Label car0text;
        private Label car2text;
        private Label car1text;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonavitosell;
        private ComboBox combosort;
        private ListView avitocar2;
        private ListView avitocar0;
        private ListView avitocar1;
        private PictureBox reloadcars;
        private PictureBox avitocar0img;
        private PictureBox avitocar2img;
        private PictureBox avitocar1img;
        private Label avitocar2name;
        private Label avitocar1name;
        private Label avitocar0name;
        private Button avitocar0buy;
        private Button avitocar2buy;
        private Button avitocar1buy;
        private Label avitocar0price;
        private Label avitocar2price;
        private Label avitocar1price;
        private Label labelmoney;
        private TabPage skill;
        private Label skilltitle;
        private Label skill0name;
        private Label skill5name;
        private Label skill4name;
        private Label skill3name;
        private Label skill2name;
        private Label skill1name;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private PictureBox skill5up;
        private PictureBox skill4up;
        private PictureBox skill3up;
        private PictureBox skill2up;
        private PictureBox skill1up;
        private PictureBox skill0up;
        private Panel[] panelskillprogress;
        private Panel[][] skillprogress;
        private TabPage statistics;
        private Button clearData;
        private Label recievedmoney;
        private Label spentmoney;
        private Label skill5;
        private Label skill4;
        private Label skill3;
        private Label skill2;
        private Label skill1;
        private Label skill0;
        private Label boughtcars;
        private Label skillslabel;
        private Label soldcars;
        private Label stattitle;
        private Label buySellInfo;
    }
}
