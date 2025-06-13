using ProjectPerekup.Classes;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace ProjectPerekup
{
    public partial class perekup : Form
    {
        // -- данные страниц --
        private string[] skillsname = new string[] { "Любовь поторговаться", "Мастер продаж", "Знаток гаджетов", "Ремонтник", "Тюнинговщик", "Хитрец" };
        private int[] skillPrice = new int[] {15000, 100000, 500000, 5000000, 25000000, 250000000, 0 };
        private int selectedcar = -1;
        private Car[] avitocars;
        private DateTime lastResize;
        private (int w, int h) lastsize;
        private int maxSizeDifference = 200;

        // -- данные пользователя -- 
        List<Car> cars;
        private long money;
        private int sold;
        private int bought;
        private long spent;
        private long recieved;
        private int[] skills;



        // -- запуск --
        public perekup()
        {
            Filework.Load(out cars, out money, out sold, out bought, out spent, out recieved, out skills, skillsname);
            InitializeComponent();
            InitializeGarage();
            InitializeBrowser();
            InitializeSkills();
            InitializeStatistics();
            reLoadGarage();
            updMoney();

            lastResize = DateTime.Now; // запоминает время последнего изменения размера окна
            resize();
        }


        // -- изменение размера окна --
        private void Transform() // вызывается при изменении размера окна
        {
            DateTime now = DateTime.Now;
            if (lastResize.Millisecond + lastResize.Second * 1000 - now.Millisecond - now.Second * 1000 < -500 || lastsize.h - Height < -maxSizeDifference || lastsize.h - Height > maxSizeDifference || lastsize.w - Width < -maxSizeDifference || lastsize.w - Width > maxSizeDifference)
            {
                lastResize = DateTime.Now; // запоминает время последнего изменения размера окна

                resize();
            }
        }
        private void resize()
        {
            lastsize = (Width, Height);

            // скрыто
            if (garage.Height == 0)
            {
                return;
            }
            // гараж
            else if (tabs.SelectedIndex == 0)
            {
                if (Convert.ToDouble(garage.Width) > Convert.ToDouble(garage.Height) * 1.4335) // 3x2 сверху
                {
                    garagetitle.Height = garage.Height / 10 + 8;
                    garagetitle.Font = new Font("Segoe UI", garagetitle.Height / 2);

                    car0img.Height = Convert.ToInt32(((garage.Height - 24 - garagetitle.Height) / 2) * 0.519);
                    car1img.Height = car0img.Height;
                    car2img.Height = car0img.Height;
                    car3img.Height = car0img.Height;
                    car4img.Height = car0img.Height;
                    car5img.Height = car0img.Height;
                    car0img.Width = car0img.Height;
                    car1img.Width = car1img.Height;
                    car2img.Width = car2img.Height;
                    car3img.Width = car3img.Height;
                    car4img.Width = car4img.Height;
                    car5img.Width = car5img.Height;

                    car1img.Location = new Point((garage.Width - car1img.Width) / 2, garagetitle.Height + 24);
                    car1text.Width = (car1img.Width * 5) / 3;
                    car1text.Height = car1img.Height - 9;
                    car0img.Location = new Point(car1img.Location.X - car1text.Width, car1img.Location.Y);
                    car0text.Width = car1text.Width;
                    car0text.Height = car1text.Height;
                    car2img.Location = new Point(car1img.Location.X + car1text.Width, car1img.Location.Y);
                    car2text.Width = car1text.Width;
                    car2text.Height = car1text.Height;

                    car1text.Location = new Point(car1img.Location.X - (car1text.Width - car0img.Width) / 2, car1img.Location.Y + car1img.Height);

                    car4img.Location = new Point(car1img.Location.X, car1text.Location.Y + car1text.Height);
                    car4text.Width = car1text.Width;
                    car4text.Height = car1text.Height;
                    car3img.Location = new Point(car0img.Location.X, car4img.Location.Y);
                    car3text.Width = car1text.Width;
                    car3text.Height = car1text.Height;
                    car5img.Location = new Point(car2img.Location.X, car4img.Location.Y);
                    car5text.Width = car1text.Width;
                    car5text.Height = car1text.Height;

                    car0text.Location = new Point(car0img.Location.X - (car0text.Width - car0img.Width) / 2, car0img.Location.Y + car0img.Height);
                    car2text.Location = new Point(car2img.Location.X - (car2text.Width - car2img.Width) / 2, car2img.Location.Y + car2img.Height);
                    car3text.Location = new Point(car3img.Location.X - (car3text.Width - car3img.Width) / 2, car3img.Location.Y + car3img.Height);
                    car4text.Location = new Point(car4img.Location.X - (car4text.Width - car4img.Width) / 2, car4img.Location.Y + car4img.Height);
                    car5text.Location = new Point(car5img.Location.X - (car5text.Width - car5img.Width) / 2, car5img.Location.Y + car5img.Height);
                }
                else
                {
                    if (garage.Height - 100 > garage.Width) // 2x3 по середине
                    {
                        garagetitle.Height = garage.Height / 15 + 8;
                        garagetitle.Font = new Font("Segoe UI", garagetitle.Height / 2);

                        car0img.Height = (garage.Width - 240) / 10 * 3;
                        car1img.Height = car0img.Height;
                        car2img.Height = car0img.Height;
                        car3img.Height = car0img.Height;
                        car4img.Height = car0img.Height;
                        car5img.Height = car0img.Height;
                        car0img.Width = car0img.Height;
                        car1img.Width = car1img.Height;
                        car2img.Width = car2img.Height;
                        car3img.Width = car3img.Height;
                        car4img.Width = car4img.Height;
                        car5img.Width = car5img.Height;

                        car3img.Location = new Point((garage.Width / 2) + (car3img.Width * 2 / 3), (garage.Height - car3img.Height) / 2);
                        car2img.Location = new Point((garage.Width / 2) - (car2img.Width * 5 / 3), car3img.Location.Y);

                        car0img.Location = new Point(car2img.Location.X, car2img.Location.Y - Convert.ToInt32(car2img.Height * 1.7));
                        car1img.Location = new Point(car3img.Location.X, car0img.Location.Y);

                        car4img.Location = new Point(car2img.Location.X, car2img.Location.Y + Convert.ToInt32(car2img.Height * 1.7));
                        car5img.Location = new Point(car3img.Location.X, car4img.Location.Y);

                        car0text.Width = (car0img.Width * 5) / 3;
                        car0text.Height = car0img.Height - 9;
                        car1text.Width = car0text.Width;
                        car1text.Height = car0text.Height;
                        car2text.Width = car0text.Width;
                        car2text.Height = car0text.Height;
                        car3text.Width = car0text.Width;
                        car3text.Height = car0text.Height;
                        car4text.Width = car0text.Width;
                        car4text.Height = car0text.Height;
                        car5text.Width = car0text.Width;
                        car5text.Height = car0text.Height;

                        car0text.Location = new Point(car0img.Location.X - (car0text.Width - car0img.Width) / 2, car0img.Location.Y + car0img.Height);
                        car1text.Location = new Point(car1img.Location.X - (car1text.Width - car0img.Width) / 2, car1img.Location.Y + car1img.Height);
                        car2text.Location = new Point(car2img.Location.X - (car2text.Width - car2img.Width) / 2, car2img.Location.Y + car2img.Height);
                        car3text.Location = new Point(car3img.Location.X - (car3text.Width - car3img.Width) / 2, car3img.Location.Y + car3img.Height);
                        car4text.Location = new Point(car4img.Location.X - (car4text.Width - car4img.Width) / 2, car4img.Location.Y + car4img.Height);
                        car5text.Location = new Point(car5img.Location.X - (car5text.Width - car5img.Width) / 2, car5img.Location.Y + car5img.Height);
                    }
                    else //3x2 по середине
                    {
                        garagetitle.Height = garage.Height / 10 + 8;
                        garagetitle.Font = new Font("Segoe UI", garagetitle.Height / 2);

                        car0img.Height = Convert.ToInt32((garage.Width - 246) * 0.65764) / 3;
                        car1img.Height = car0img.Height;
                        car2img.Height = car0img.Height;
                        car3img.Height = car0img.Height;
                        car4img.Height = car0img.Height;
                        car5img.Height = car0img.Height;
                        car0img.Width = car0img.Height;
                        car1img.Width = car1img.Height;
                        car2img.Width = car2img.Height;
                        car3img.Width = car3img.Height;
                        car4img.Width = car4img.Height;
                        car5img.Width = car5img.Height;

                        car1img.Location = new Point((garage.Width - car1img.Width) / 2, (garage.Height - car1img.Height) / 2 - (126 + (garage.Height - 538) / 5));
                        car1text.Width = (car1img.Width * 5) / 3;
                        car1text.Height = car1img.Height - 9;
                        car0img.Location = new Point(car1img.Location.X - car1text.Width, car1img.Location.Y);
                        car0text.Width = car1text.Width;
                        car0text.Height = car1text.Height;
                        car2img.Location = new Point(car1img.Location.X + car1text.Width, car1img.Location.Y);
                        car2text.Width = car1text.Width;
                        car2text.Height = car1text.Height;

                        car1text.Location = new Point(car1img.Location.X - (car1text.Width - car0img.Width) / 2, car1img.Location.Y + car1img.Height);

                        car4img.Location = new Point(car1img.Location.X, car1text.Location.Y + car1text.Height);
                        car4text.Width = car1text.Width;
                        car4text.Height = car1text.Height;
                        car3img.Location = new Point(car0img.Location.X, car4img.Location.Y);
                        car3text.Width = car1text.Width;
                        car3text.Height = car1text.Height;
                        car5img.Location = new Point(car2img.Location.X, car4img.Location.Y);
                        car5text.Width = car1text.Width;
                        car5text.Height = car1text.Height;

                        car0text.Location = new Point(car0img.Location.X - (car0text.Width - car0img.Width) / 2, car0img.Location.Y + car0img.Height);
                        car2text.Location = new Point(car2img.Location.X - (car2text.Width - car2img.Width) / 2, car2img.Location.Y + car2img.Height);
                        car3text.Location = new Point(car3img.Location.X - (car3text.Width - car3img.Width) / 2, car3img.Location.Y + car3img.Height);
                        car4text.Location = new Point(car4img.Location.X - (car4text.Width - car4img.Width) / 2, car4img.Location.Y + car4img.Height);
                        car5text.Location = new Point(car5img.Location.X - (car5text.Width - car5img.Width) / 2, car5img.Location.Y + car5img.Height);
                    }
                }

                car0text.Font = new Font("Segoe UI", 14 + (car0text.Height + car0text.Width - 310) / 50);
                car1text.Font = new Font("Segoe UI", car0text.Font.Size);
                car2text.Font = new Font("Segoe UI", car0text.Font.Size);
                car3text.Font = new Font("Segoe UI", car0text.Font.Size);
                car4text.Font = new Font("Segoe UI", car0text.Font.Size);
                car5text.Font = new Font("Segoe UI", car0text.Font.Size);
            }
            // мастерские
            else if (tabs.SelectedIndex == 1)
            {
                citypicture.Height = Height - 76;
                citypicture.Width = Width - 18;

                Vasiliybutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.091),
                                                     Convert.ToInt32(citypicture.Height * 0.605));

                Stepanichbutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.447),
                                                     Convert.ToInt32(citypicture.Height * 0.179));

                Fitservicebutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.806),
                                                      Convert.ToInt32(citypicture.Height * 0.457));
            }
            // браузер
            else if (tabs.SelectedIndex == 2)
            {
                avitocar0.Height = (browser.Height - 150) / 3;
                avitocar0img.Height = avitocar0.Height;
                avitocar0img.Width = avitocar0.Height;

                avitocar0name.Location = new Point(11 + avitocar0img.Width, avitocar0.Location.Y + 5);
                avitocar0name.Width = avitocar0.Width - avitocar0img.Width - 263;
                avitocar0name.Height = avitocar0.Height - 11;



                avitocar1.Location = new Point(6, 143 + avitocar0.Height);
                avitocar1.Height = avitocar0.Height;
                avitocar1img.Location = avitocar1.Location;
                avitocar1img.Height = avitocar0.Height;
                avitocar1img.Width = avitocar0.Height;

                avitocar1name.Location = new Point(avitocar0name.Location.X, avitocar1.Location.Y + 5);
                avitocar1name.Width = avitocar0name.Width;
                avitocar1name.Height = avitocar0name.Height;



                avitocar2.Location = new Point(6, avitocar1.Location.Y + avitocar1.Height + 4);
                avitocar2.Height = avitocar0.Height;
                avitocar2img.Location = avitocar2.Location;
                avitocar2img.Height = avitocar2.Height;
                avitocar2img.Width = avitocar2.Height;

                avitocar2name.Location = new Point(avitocar0name.Location.X, avitocar2.Location.Y + 5);
                avitocar2name.Width = avitocar0name.Width;
                avitocar2name.Height = avitocar0name.Height;



                avitocar0buy.Location = new Point(browser.Width - 260, avitocar1.Location.Y - 49);
                avitocar0price.Location = new Point(avitocar0buy.Location.X, avitocar0buy.Location.Y - 37);

                avitocar1buy.Location = new Point(avitocar0buy.Location.X, avitocar2.Location.Y - 49);
                avitocar1price.Location = new Point(avitocar1buy.Location.X, avitocar1buy.Location.Y - 37);

                avitocar2buy.Location = new Point(avitocar0buy.Location.X, browser.Height - 49);
                avitocar2price.Location = new Point(avitocar2buy.Location.X, avitocar2buy.Location.Y - 37);
            }
            // навыки
            else if (tabs.SelectedIndex == 3)
            {
                skilltitle.Height = skill.Height / 10 + 8;
                skilltitle.Font = new Font("Segoe UI", skilltitle.Height / 2);

                skill0name.Location = new Point(Width / 2 - 126 - skill0name.Width, skilltitle.Height + 21);

                panelskillprogress[0].Location = new Point(skill0name.Location.X, skill0up.Location.Y);
                panelskillprogress[1].Location = new Point(skill1name.Location.X, skill1up.Location.Y);
                panelskillprogress[2].Location = new Point(skill2name.Location.X, skill2up.Location.Y);
                panelskillprogress[3].Location = new Point(skill3name.Location.X, skill3up.Location.Y);
                panelskillprogress[4].Location = new Point(skill4name.Location.X, skill4up.Location.Y);
                panelskillprogress[5].Location = new Point(skill5name.Location.X, skill5up.Location.Y);
            }
            // статистика
            else if (tabs.SelectedIndex == 4)
            {
                stattitle.Height = statistics.Height / 10 + 8;
                stattitle.Font = new Font("Segoe UI", stattitle.Height / 2);

                spentmoney.Location = new Point(12, stattitle.Height);
                recievedmoney.Location = new Point(12, stattitle.Height + spentmoney.Height);
                soldcars.Location = new Point(12, recievedmoney.Location.Y + recievedmoney.Height + 6);
                boughtcars.Location = new Point(12, soldcars.Location.Y + soldcars.Height);

                spentmoney.Width = Convert.ToInt32((statistics.Width - 42) / 2);
                recievedmoney.Width = spentmoney.Width;
                soldcars.Width = spentmoney.Width;
                boughtcars.Width = spentmoney.Width;

                clearData.Width = 100 + Convert.ToInt32(Width / 8);

                skillslabel.Location = new Point(32 + spentmoney.Width, spentmoney.Location.Y);
                skill0.Location = new Point(skillslabel.Location.X, skillslabel.Location.Y + skillslabel.Height + 4);
                skill1.Location = new Point(skillslabel.Location.X, skill0.Location.Y + skillslabel.Height);
                skill2.Location = new Point(skillslabel.Location.X, skill1.Location.Y + skillslabel.Height);
                skill3.Location = new Point(skillslabel.Location.X, skill2.Location.Y + skillslabel.Height);
                skill4.Location = new Point(skillslabel.Location.X, skill3.Location.Y + skillslabel.Height);
                skill5.Location = new Point(skillslabel.Location.X, skill4.Location.Y + skillslabel.Height);

                skillslabel.Width = spentmoney.Width;
                skill0.Width = spentmoney.Width;
                skill1.Width = spentmoney.Width;
                skill2.Width = spentmoney.Width;
                skill3.Width = spentmoney.Width;
                skill4.Width = spentmoney.Width;
                skill5.Width = spentmoney.Width;

                clearData.Location = new Point(Convert.ToInt32((Width - clearData.Width) / 2), Height - 135);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        { Transform(); }
        private void perekup_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedIndex == 0)
            {
                hideOtherCarText();
                selectedcar = -1;
            }
            else if (tabs.SelectedIndex == 3)
            {
                InitializeStatistics();
            }
            resize();
        }


        // -- помощники --
        private void InitializeGarage() // загрузка функций в элементы гаража
        {
            car0img.MouseEnter += (sender, e) => car0text.Visible = true;
            car0img.MouseLeave += (sender, e) => hideCarText(0);
            car0img.Click += (sender, e) => { if (cars[0].img != 0) { if (selectedcar != 0) hideOtherCarText(); selectedcar = 0; } };
            car0img.DoubleClick += (sender, e) => { if (cars[0].img != 00) { carimg_DoubleClick(); } };

            car1img.MouseEnter += (sender, e) => car1text.Visible = true;
            car1img.MouseLeave += (sender, e) => hideCarText(1);
            car1img.Click += (sender, e) => { if (cars[1].img != 0) { if (selectedcar != 1) hideOtherCarText(); selectedcar = 1; } };
            car1img.DoubleClick += (sender, e) => { if (cars[1].img != 00) { carimg_DoubleClick(); } };

            car2img.MouseEnter += (sender, e) => car2text.Visible = true;
            car2img.MouseLeave += (sender, e) => hideCarText(2);
            car2img.Click += (sender, e) => { if (cars[2].img != 0) { if (selectedcar != 2) hideOtherCarText(); selectedcar = 2; } };
            car2img.DoubleClick += (sender, e) => { if (cars[2].img != 00) { carimg_DoubleClick(); } };

            car3img.MouseEnter += (sender, e) => car3text.Visible = true;
            car3img.MouseLeave += (sender, e) => hideCarText(3);
            car3img.Click += (sender, e) => { if (cars[3].img != 0) { if (selectedcar != 3) hideOtherCarText(); selectedcar = 3; } };
            car3img.DoubleClick += (sender, e) => { if (cars[3].img != 00) { carimg_DoubleClick(); } };

            car4img.MouseEnter += (sender, e) => car4text.Visible = true;
            car4img.MouseLeave += (sender, e) => hideCarText(4);
            car4img.Click += (sender, e) => { if (cars[4].img != 0) { if (selectedcar != 4) hideOtherCarText(); selectedcar = 4; } };
            car4img.DoubleClick += (sender, e) => { if (cars[4].img != 00) { carimg_DoubleClick(); } };

            car5img.MouseEnter += (sender, e) => car5text.Visible = true;
            car5img.MouseLeave += (sender, e) => hideCarText(5);
            car5img.Click += (sender, e) => { if (cars[5].img != 0) { if (selectedcar != 5) hideOtherCarText(); selectedcar = 5; } };
            car5img.DoubleClick += (sender, e) => { if (cars[5].img != 00) { carimg_DoubleClick(); } };


        }
        private void InitializeBrowser()  // загрузка данных в элементы браузера
        {
            combosort.Items.Clear();
            combosort.Items.AddRange(new string[] {
                "Случайное",
                "Сначала дорогое",
                "Сначала дешевое"
            });
            combosort.SelectedIndex = 0;

            var rand = new Random();
            avitocars = new Car[] {
                new Car(rand.Next(0, 100)),
                new Car(rand.Next(0, 100)),
                new Car(rand.Next(0, 100))
            };

            reLoadBrowser();

            combosort.SelectedIndexChanged += reloadcars_Click;
        }
        private void InitializeStatistics()  // загрузка данных в элементы статистики
        {
            spentmoney.Text = $"Потрачено денег: {-1 * spent}₽";
            recievedmoney.Text = $"Получено денег: {recieved}₽";

            soldcars.Text = $"Продано машин: {sold}";
            boughtcars.Text = $"Куплено машин: {bought}";

            skill0.Text = $"{skillsname[0]}: {skills[0]}";
            skill1.Text = $"{skillsname[1]}: {skills[1]}";
            skill2.Text = $"{skillsname[2]}: {skills[2]}";
            skill3.Text = $"{skillsname[3]}: {skills[3]}";
            skill4.Text = $"{skillsname[4]}: {skills[4]}";
            skill5.Text = $"{skillsname[5]}: {skills[5]}";
        }
        private void InitializeSkills()  // загрузка функций и данных в элементы навыков
        {
            skill0up.Click += (sender, e) => { upgradeSkill(0); };
            skill1up.Click += (sender, e) => { upgradeSkill(1); };
            skill2up.Click += (sender, e) => { upgradeSkill(2); };
            skill3up.Click += (sender, e) => { upgradeSkill(3); };
            skill4up.Click += (sender, e) => { upgradeSkill(4); };
            skill5up.Click += (sender, e) => { upgradeSkill(5); };

            skill0name.Text = getSkillText(0);
            skill1name.Text = getSkillText(1);
            skill2name.Text = getSkillText(2);
            skill3name.Text = getSkillText(3);
            skill4name.Text = getSkillText(4);
            skill5name.Text = getSkillText(5);

            loadSkillsTab();
        }
        private void loadSkillsTab() // создание элементов в навыках
        {
            panelskillprogress = new Panel[6];
            for (int i = 0; i < panelskillprogress.Length; i++)
            {
                panelskillprogress[i] = new Panel();
                panelskillprogress[i].BackColor = Color.FromArgb(200, 200, 200);
                panelskillprogress[i].Name = "panel2";
                panelskillprogress[i].Size = new Size(168, 40);
                panelskillprogress[i].TabIndex = 11;
                panelskillprogress[i].BorderStyle = BorderStyle.FixedSingle;
                panelskillprogress[i].Resize += (sender, e) => { loadSkills(); };
                skill.Controls.Add(panelskillprogress[i]);
            }

            skillprogress = new Panel[6][];
            for (int x = 0; x < skillprogress.Length; x++)
            {
                skillprogress[x] = new Panel[6];
                for (int y = 0; y < skillprogress[0].Length; y++)
                {
                    skillprogress[x][y] = new Panel();
                    skillprogress[x][y].BorderStyle = BorderStyle.FixedSingle;
                    skillprogress[x][y].Parent = panelskillprogress[x];
                }
            }

            loadSkillsProgress(-1);
        }
        private void loadSkills() // редактирование элементов в навыках
        {
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    skillprogress[x][y].Height = 30;
                    skillprogress[x][y].Width = ((panelskillprogress[x].Width - 10) / 6) - 5;
                    skillprogress[x][y].Location = new Point(7 + (5 + skillprogress[x][y].Width) * y, 4);
                }
            }
        }
        private void loadSkillsProgress(int i) // загрузка прогресса навыков
        {
            if (i == -1)
            {
                for (int x = 0; x < 6; x++)
                {
                    for (int y = 0; y < skills[x]; y++)
                    {
                        skillprogress[x][y].BackColor = Color.Green;
                    }
                }
            }
            else
            {
                for (int y = 0; y < skills[i]; y++)
                {
                    skillprogress[i][y].BackColor = Color.Green;
                }
            }
        }
        private void DeleteSkills() // стирание прогресса навыков
        {

            for(int x = 0; x < 6; x++)
            {
                for (int y = 0; y < skillprogress[x].Length; y++)
                {
                    skillprogress[x][y].BackColor = Color.Transparent;
                }
            }
        }
        private void reLoadGarage() // обновление данных в гараже
        {
            car0img.Image = cars[0].getImg();
            if (cars[0].img == 0) car0text.Text = "Пусто";
            else car0text.Text = cars[0].ToString();

            car1img.Image = cars[1].getImg();
            if (cars[1].img == 0) car1text.Text = "Пусто";
            else car1text.Text = cars[1].ToString();

            car2img.Image = cars[2].getImg();
            if (cars[2].img == 0) car2text.Text = "Пусто";
            else car2text.Text = cars[2].ToString();

            car3img.Image = cars[3].getImg();
            if (cars[3].img == 0) car3text.Text = "Пусто";
            else car3text.Text = cars[3].ToString();

            car4img.Image = cars[4].getImg();
            if (cars[4].img == 0) car4text.Text = "Пусто";
            else car4text.Text = cars[4].ToString();

            car5img.Image = cars[5].getImg();
            if (cars[5].img == 0) car5text.Text = "Пусто";
            else car5text.Text = cars[5].ToString();
        }
        private void reLoadBrowser() // обновление предложений в браузере
        {
            if (combosort.SelectedIndex == 0) //случайное
            {
                updBrowser();
            }
            else if (combosort.SelectedIndex == 1) //сначала дорогое
            {
                avitocars = avitocars.OrderByDescending(c => c.price).ToArray();
                updBrowser();
            }
            else if (combosort.SelectedIndex == 2) //сначала дешевое
            {
                avitocars = avitocars.OrderBy(c => c.price).ToArray();
                updBrowser();
            }
        }
        private void updBrowser() // загружает данные предложений в элементы
        {
            avitocar0name.Text = $"{avitocars[0].getName()}\n{avitocars[0].generateDesc()}";
            avitocar0img.Image = avitocars[0].getImg();
            avitocar0price.Text = avitocars[0].PriceToString();
            avitocar0buy.Text = "Купить";

            avitocar1name.Text = $"{avitocars[1].getName()}\n{avitocars[1].generateDesc()}";
            avitocar1img.Image = avitocars[1].getImg();
            avitocar1price.Text = avitocars[1].PriceToString();
            avitocar1buy.Text = "Купить";

            avitocar2name.Text = $"{avitocars[2].getName()}\n{avitocars[2].generateDesc()}";
            avitocar2img.Image = avitocars[2].getImg();
            avitocar2price.Text = avitocars[2].PriceToString();
            avitocar2buy.Text = "Купить";
        }
        private void updMoney() // обновляет баланс
        {
            string mone = money.ToString();

            string returnmoney = "";
            for (int i = 0; i < mone.Length; i++)
            {
                returnmoney += mone[i];
                if ((mone.Length - i - 1) % 3 == 0)
                {
                    returnmoney += " ";
                }
            }

            labelmoney.Text = $"Баланс: {returnmoney} ₽";
        }
        private void hideCarText(int carnum) // прячет текст под машиной в гараже(кроме выбранной)
        {
            if (carnum != selectedcar)
            {
                if (carnum == 0)
                {
                    car0text.Visible = false;
                }
                else if (carnum == 1)
                {
                    car1text.Visible = false;
                }
                else if (carnum == 2)
                {
                    car2text.Visible = false;
                }
                else if (carnum == 3)
                {
                    car3text.Visible = false;
                }
                else if (carnum == 4)
                {
                    car4text.Visible = false;
                }
                else if (carnum == 5)
                {
                    car5text.Visible = false;
                }
            }
        }
        private void hideOtherCarText()  // прячет текст выбранной машины
        {
            if (selectedcar == 0)
            {
                car0text.Visible = false;
            }
            else if (selectedcar == 1)
            {
                car1text.Visible = false;
            }
            else if (selectedcar == 2)
            {
                car2text.Visible = false;
            }
            else if (selectedcar == 3)
            {
                car3text.Visible = false;
            }
            else if (selectedcar == 4)
            {
                car4text.Visible = false;
            }
            else if (selectedcar == 5)
            {
                car5text.Visible = false;
            }
        }
        private int findZero() // находит пустое место в гараже
        {
            return cars.FindIndex(c => c.img == 0);
        }
        private int findCar() // находит не пустое место в гараже
        {
            return cars.FindIndex(c => c.img != 0);
        }
        private double getCondMult(int sum) // возвращает множитель зависящий от количества повреждений
        {
            return 1.0 - 0.05 * sum;
        }
        private string getSkillText(int i) // возвращает текст навыка(имя и цена)
        {
            if (skillPrice[skills[i]] == 0)
            {
                return $"{skillsname[i]}\nМакс. уровень";
            }
            return $"{skillsname[i]}\n{PriceToString(skillPrice[skills[i]])}₽";
        }
        private void updateSkillText(int i) // обновляет текст навыка
        {
            if (i == 0) skill0name.Text = getSkillText(0);
            else if (i == 1) skill1name.Text = getSkillText(1);
            else if (i == 2) skill2name.Text = getSkillText(2);
            else if (i == 3) skill3name.Text = getSkillText(3);
            else if (i == 4) skill4name.Text = getSkillText(4);
            else if (i == 5) skill5name.Text = getSkillText(5);
        }
        public string PriceToString(int price) // делит сумму 1234567 -> 1 234 567
        {
            string strPrice = price.ToString();

            string returnprice = "";
            for (int i = 0; i < strPrice.Length; i++)
            {
                returnprice += strPrice[i];
                if ((strPrice.Length - i - 1) % 3 == 0)
                {
                    returnprice += " ";
                }
            }

            return returnprice;
        }




        // -- гараж -- {
        private void carimg_DoubleClick()
        {
            Car editcar;
            long editbal;

            if (money == 0)
            {
                MessageBox.Show("У вас нет денег", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CarEdit.SendData(money, cars[selectedcar]);
            if (CarEdit.Instance.ShowDialog() == DialogResult.OK)
            {
                CarEdit.RecieveData(out editbal, out editcar);
                spent -= (money - editbal);
                money = editbal;
                cars[selectedcar] = editcar;
                Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                reLoadGarage();
                updMoney();
            }
            hideOtherCarText();
            selectedcar = -1;
        }

        // -- карта --
        private void Vasiliybutton_Click(object sender, EventArgs e)
        {
            List<Car> editcars;
            long editbal;

            if (money == 0)
            {
                MessageBox.Show("У вас нет денег", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (findCar() == -1)
            {
                MessageBox.Show("У вас нет машин", "ааыаыыыыаыаааа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CarUpgrade.SendData(money, cars, Garage.vasya);
            if (CarUpgrade.Instance.ShowDialog() == DialogResult.OK)
            {
                CarUpgrade.RecieveData(out editbal, out editcars);
                spent -= (money - editbal);
                money = editbal;
                cars = editcars;
                Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                reLoadGarage();
                updMoney();
            }
        }
        private void Stepanichbutton_Click(object sender, EventArgs e)
        {
            List<Car> editcars;
            long editbal;

            if (money == 0)
            {
                MessageBox.Show("У вас нет денег", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (findCar() == -1)
            {
                MessageBox.Show("У вас нет машин", "ааыаыыыыаыаааа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CarUpgrade.SendData(money, cars, Garage.stepa);
            if (CarUpgrade.Instance.ShowDialog() == DialogResult.OK)
            {
                CarUpgrade.RecieveData(out editbal, out editcars);
                spent -= (money - editbal);
                money = editbal;
                cars = editcars;
                Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                reLoadGarage();
                updMoney();
            }
        }
        private void Fitservicebutton_Click(object sender, EventArgs e)
        {
            List<Car> editcars;
            long editbal;

            if (money == 0)
            {
                MessageBox.Show("У вас нет денег", "Недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (findCar() == -1)
            {
                MessageBox.Show("У вас нет машин", "ааыаыыыыаыаааа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CarUpgrade.SendData(money, cars, Garage.fits);
            if (CarUpgrade.Instance.ShowDialog() == DialogResult.OK)
            {
                CarUpgrade.RecieveData(out editbal, out editcars);
                spent -= (money - editbal);
                money = editbal;
                cars = editcars;
                Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                reLoadGarage();
                updMoney();
            }
        }

        // -- авито --
        private void buttonavitosell_Click(object sender, EventArgs e)
        {

            if (findCar() == -1)
            {
                MessageBox.Show("Нечего продавать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Car> editcars;
                long editbal;
                CarSell.SendData(money, cars);
                if (CarSell.Instance.ShowDialog() == DialogResult.OK)
                {
                    CarSell.RecieveData(out editbal, out editcars);
                    recieved += (editbal - money);
                    sold++;
                    money = editbal;
                    cars = editcars;
                    Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                    updMoney();
                    reLoadGarage();
                }
            }
        }
        private void reloadcars_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if (combosort.SelectedIndex == 0)
            {
                avitocars = new Car[] {
                    new Car(rand.Next(0, 100)),
                    new Car(rand.Next(0, 100)),
                    new Car(rand.Next(0, 100))
                };
            }
            else if (combosort.SelectedIndex == 1)
            {
                avitocars = new Car[] {
                    new Car(rand.Next(0, 10)),
                    new Car(rand.Next(0, 10)),
                    new Car(rand.Next(0, 10))
                };
            }
            else if (combosort.SelectedIndex == 2)
            {
                avitocars = new Car[] {
                    new Car(99),
                    new Car(99),
                    new Car(99)
                };
            }

            reLoadBrowser();
        }
        private void avitocar0buy_Click(object sender, EventArgs e)
        {
            if (avitocars[0] != null)
            {
                if (Convert.ToInt64(money) - Convert.ToInt64(Convert.ToDouble(avitocars[0].price) * getCondMult(avitocars[0].getCondSum())) < 0)
                {
                    MessageBox.Show($"не хватает денег", "Ошибка");
                    return;
                }
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[0];
                    money -= Convert.ToInt64(Convert.ToDouble(avitocars[0].price) * getCondMult(avitocars[0].getCondSum()));
                    spent -= Convert.ToInt64(Convert.ToDouble(avitocars[0].price) * getCondMult(avitocars[0].getCondSum()));
                    bought++;
                    avitocars[0] = null;
                    avitocar0buy.Text = "Куплено";
                    Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                    updMoney();
                    reLoadGarage();
                }
                else
                {
                    MessageBox.Show("Не хватает места в гараже", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Машина уже куплена", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void avitocar1buy_Click(object sender, EventArgs e)
        {
            if (avitocars[1] != null)
            {
                if (Convert.ToInt64(money) - Convert.ToInt64(Convert.ToDouble(avitocars[1].price) * getCondMult(avitocars[1].getCondSum())) < 0)
                {
                    MessageBox.Show($"не хватает денег", "Ошибка");
                    return;
                }
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[1];
                    money -= Convert.ToInt64(Convert.ToDouble(avitocars[1].price) * getCondMult(avitocars[1].getCondSum()));
                    spent -= Convert.ToInt64(Convert.ToDouble(avitocars[1].price) * getCondMult(avitocars[1].getCondSum()));
                    bought++;
                    avitocars[1] = null;
                    avitocar1buy.Text = "Куплено";
                    Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                    updMoney();
                    reLoadGarage();
                }
                else
                {
                    MessageBox.Show("Не хватает места в гараже", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Машина уже куплена", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void avitocar2buy_Click(object sender, EventArgs e)
        {
            if (avitocars[2] != null)
            {
                if (Convert.ToInt64(money) - Convert.ToInt64(Convert.ToDouble(avitocars[2].price) * getCondMult(avitocars[2].getCondSum())) < 0)
                {
                    MessageBox.Show($"не хватает денег", "Ошибка");
                    return;
                }
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[2];
                    money -= Convert.ToInt64(Convert.ToDouble(avitocars[2].price) * getCondMult(avitocars[2].getCondSum()));
                    spent -= Convert.ToInt64(Convert.ToDouble(avitocars[2].price) * getCondMult(avitocars[2].getCondSum()));
                    bought++;
                    avitocars[2] = null;
                    avitocar2buy.Text = "Куплено";
                    Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
                    updMoney();
                    reLoadGarage();
                }
                else
                {
                    MessageBox.Show("Не хватает места в гараже", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Машина уже куплена", "Ошибка", MessageBoxButtons.OK);
            }
        }

        // -- навыки --
        private void upgradeSkill(int i)
        {
            if (skills[i] != 6)
            {
                skills[i]++;
                skillprogress[i][skills[i] - 1].BackColor = Color.Green;
                Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);

                updateSkillText(i);
            }
            else
            {
                MessageBox.Show("Навык уже максимального уровня", "Ошибка");
            }
        }

        // -- статистика -- 
        private void clearData_Click(object sender, EventArgs e)
        {
            if (Confirm.Instance.ShowDialog() == DialogResult.OK)
            {
                Filework.DeleteFile();
                Filework.CreateBlankFile(out cars, out money, out sold, out bought, out spent, out recieved, out skills, skillsname);

                InitializeGarage();
                reLoadGarage();
                InitializeBrowser();
                InitializeStatistics();
                DeleteSkills();
                //loadSkillsProgress(-1);
                reLoadBrowser();
                updMoney();
            }
        }

    }
}
