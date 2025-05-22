using ProjectPerekup.Classes;
using System.Security.Cryptography.Xml;

namespace ProjectPerekup
{
    public partial class perekup : Form
    {
        private string[] skillsname = new string[] { "Любовь поторговаться", "Мастер продаж", "Знаток гаджетов", "Ремонтник", "Тюнинговщик", "Хитрец" };
        private int selectedcar = -1;
        private Car[] avitocars;

        List<Car> cars;
        private long money;
        private int sold;
        private int bought;
        private long spent;
        private long recieved;
        private int[] skills;
        private string test;




        public perekup()
        {
            Filework.Load(out cars, out money, out sold, out bought, out spent, out recieved, out skills, skillsname);
            InitializeComponent();
            InitializeGarage();
            InitializeBrowser();
            InitializeStatistics();
            reLoadGarage();
            updMoney();
        }

        private void Transform()
        {   
            if(garage.Height == 0)
            {
                return;
            }
            else if (tabs.SelectedIndex == 0)
            {
                garagetitle.Height = garage.Height / 10 + 8;
                garagetitle.Font = new Font("Segoe UI", garagetitle.Height / 2);

                buttoneditcar.Height = Convert.ToInt32(garage.Height / 8.48);
                buttoneditcar.Width = buttoneditcar.Height * 3;
                buttoneditcar.Font = new Font("Segoe UI", Convert.ToInt32(buttoneditcar.Height / 3.57));
                buttoneditcar.Location = new Point((garage.Width - buttoneditcar.Width) / 2, garage.Height - buttoneditcar.Height - 9);

                car1img.Height = Convert.ToInt32(120 + (garage.Height - 424) / 10);
                car1img.Width = car1img.Height;
                car1img.Location = new Point(12, (garage.Height - car1img.Height) / 2 + 19);
                car1text.Location = new Point(car1img.Location.X + car1img.Width + 7, car1img.Location.Y);

                car0img.Height = car1img.Height;
                car0img.Width = car1img.Height;
                car0img.Location = new Point(12, car1img.Location.Y - car0img.Height - 9);
                car0text.Location = new Point(car0img.Location.X + car1img.Width + 7, car0img.Location.Y);

                car2img.Height = car1img.Height;
                car2img.Width = car1img.Height;
                car2img.Location = new Point(12, car1img.Location.Y + car2img.Height + 9);
                car2text.Location = new Point(car2img.Location.X + car1img.Width + 7, car2img.Location.Y);

                car4img.Height = car1img.Height;
                car4img.Width = car1img.Height;
                car4img.Location = new Point(garage.Width - car4img.Width - 12, car1img.Location.Y);
                car4text.Location = new Point(garage.Width / 2 + 81, car1img.Location.Y);

                car3img.Height = car1img.Height;
                car3img.Width = car1img.Height;
                car3img.Location = new Point(car4img.Location.X, car4img.Location.Y - car3img.Height - 9);
                car3text.Location = new Point(car4text.Location.X, car0img.Location.Y);

                car5img.Height = car1img.Height;
                car5img.Width = car1img.Height;
                car5img.Location = new Point(car4img.Location.X, car4img.Location.Y + car3img.Height + 9);
                car5text.Location = new Point(car4text.Location.X, car2img.Location.Y);


                car0text.Width = garage.Width / 2 - 81 - car0text.Location.X;
                car0text.Height = car1img.Height;

                car1text.Width = car0text.Width;
                car1text.Height = car1img.Height;

                car2text.Width = car0text.Width;
                car2text.Height = car1img.Height;

                car3text.Width = car0text.Width;
                car3text.Height = car1img.Height;

                car4text.Width = car0text.Width;
                car4text.Height = car1img.Height;

                car5text.Width = car0text.Width;
                car5text.Height = car1img.Height;
                
            }
            else if (tabs.SelectedIndex == 1)
            {
                Vasiliybutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.091),
                                                     Convert.ToInt32(citypicture.Height * 0.605));

                Stepanichbutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.447),
                                                     Convert.ToInt32(citypicture.Height * 0.179));

                Fitservicebutton.Location = new Point(Convert.ToInt32(citypicture.Width * 0.806),
                                                      Convert.ToInt32(citypicture.Height * 0.457));
            }
            else if (tabs.SelectedIndex == 2)
            {
                avitocar0.Height = (browser.Height - 136 - 24) / 3;
                avitocar0img.Height = avitocar0.Height;
                avitocar0img.Width = avitocar0.Height;

                avitocar0name.Location = new Point(14 + avitocar0img.Width, avitocar0.Location.Y + 5);
                avitocar0name.Width = avitocar0.Width - avitocar0img.Width - 266;
                avitocar0name.Height = avitocar0.Height - 11;

                

                avitocar1.Location = new Point(6, 136 + avitocar0.Height + 8);
                avitocar1.Height = avitocar0.Height;
                avitocar1img.Location = avitocar1.Location;
                avitocar1img.Height = avitocar0.Height;
                avitocar1img.Width = avitocar0.Height;

                avitocar1name.Location = new Point(14 + avitocar1img.Width, avitocar1.Location.Y + 5);
                avitocar1name.Width = avitocar0name.Width;
                avitocar1name.Height = avitocar0name.Height;



                avitocar2.Location = new Point(6, avitocar1.Location.Y + avitocar1.Height + 8);
                avitocar2.Height = avitocar0.Height;
                avitocar2img.Location = avitocar2.Location;
                avitocar2img.Height = avitocar2.Height;
                avitocar2img.Width = avitocar2.Height;

                avitocar2name.Location = new Point(14 + avitocar2img.Width, avitocar2.Location.Y + 5);
                avitocar2name.Width = avitocar0name.Width;
                avitocar2name.Height = avitocar0name.Height;



                avitocar0buy.Location = new Point(browser.Width - 264, avitocar1.Location.Y - 53);
                avitocar0price.Location = new Point(avitocar0buy.Location.X, avitocar0buy.Location.Y - 37);

                avitocar1buy.Location = new Point(avitocar0buy.Location.X, avitocar2.Location.Y - 53);
                avitocar1price.Location = new Point(avitocar1buy.Location.X, avitocar1buy.Location.Y - 37);

                avitocar2buy.Location = new Point(avitocar0buy.Location.X, browser.Height - 51);
                avitocar2price.Location = new Point(avitocar2buy.Location.X, avitocar2buy.Location.Y - 37);
            }
            else if (tabs.SelectedIndex == 3)
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
            }
        }
        private void InitializeGarage()
        {
            car0img.MouseEnter += (sender, e) => car0text.Visible = true;
            car0img.MouseLeave += (sender, e) => hideCarText(0);
            car0img.Click += (sender, e) => { if (cars[0].img != 0) { hideOtherCarText(); selectedcar = 0; buttoneditcar.Visible = true; } };

            car1img.MouseEnter += (sender, e) => car1text.Visible = true;
            car1img.MouseLeave += (sender, e) => hideCarText(1);
            car1img.Click += (sender, e) => { if (cars[1].img != 0) { hideOtherCarText(); selectedcar = 1; buttoneditcar.Visible = true; } };

            car2img.MouseEnter += (sender, e) => car2text.Visible = true;
            car2img.MouseLeave += (sender, e) => hideCarText(2);
            car2img.Click += (sender, e) => { if (cars[2].img != 0) { hideOtherCarText(); selectedcar = 2; buttoneditcar.Visible = true; } };

            car3img.MouseEnter += (sender, e) => car3text.Visible = true;
            car3img.MouseLeave += (sender, e) => hideCarText(3);
            car3img.Click += (sender, e) => { if (cars[3].img != 0) { hideOtherCarText(); selectedcar = 3; buttoneditcar.Visible = true; } };

            car4img.MouseEnter += (sender, e) => car4text.Visible = true;
            car4img.MouseLeave += (sender, e) => hideCarText(4);
            car4img.Click += (sender, e) => { if (cars[4].img != 0) { hideOtherCarText(); selectedcar = 4; buttoneditcar.Visible = true; } };

            car5img.MouseEnter += (sender, e) => car5text.Visible = true;
            car5img.MouseLeave += (sender, e) => hideCarText(5);
            car5img.Click += (sender, e) => { if (cars[5].img != 0) { hideOtherCarText(); selectedcar = 5; buttoneditcar.Visible = true; } };


        }
        private void InitializeBrowser()
        {
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
        private void InitializeStatistics()
        {
            spentmoney.Text = $"Потрачено денег: {-1 * spent}₽";
            recievedmoney.Text = $"Получено денег: {recieved}₽";

            soldcars.Text = $"Потрачено денег: {sold}₽";
            boughtcars.Text = $"Потрачено денег: {bought}₽";

            skill0.Text = $"{skillsname[0]}: {skills[0]}";
            skill1.Text = $"{skillsname[1]}: {skills[1]}";
            skill2.Text = $"{skillsname[2]}: {skills[2]}";
            skill3.Text = $"{skillsname[3]}: {skills[3]}";
            skill4.Text = $"{skillsname[4]}: {skills[4]}";
            skill5.Text = $"{skillsname[5]}: {skills[5]}";
        }
        private void reLoadGarage()
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
        private void reLoadBrowser()
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
        private void updBrowser()
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
        private int findZero()
        {
            return cars.FindIndex(c => c.img == 0);
        }
        private void updMoney()
        {
            labelmoney.Text = $"Баланс: {money} ₽";
        }
        private void hideCarText(int carnum)
        {
            if (carnum != selectedcar)
            {
                if(carnum == 0)
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
        private void hideOtherCarText()
        {
            if(selectedcar == 0)
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



        private void Form1_Resize(object sender, EventArgs e)
        { Transform(); }
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(tabs.SelectedIndex == 0)
            {
                selectedcar = -1; 
                buttoneditcar.Visible = false; 
            }
            else if(tabs.SelectedIndex == 3)
            {
                InitializeStatistics(); 
            }
            Transform(); 
        }

        private void buttoneditcar_Click(object sender, EventArgs e)
        {
            


            buttoneditcar.Visible = false;
            Filework.Save(cars, money, sold, bought, spent, recieved, skills, skillsname);
            reLoadGarage();
        }

        private void reloadcars_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if(combosort.SelectedIndex == 0)
            {
                avitocars = new Car[] {
                    new Car(rand.Next(0, 100)),
                    new Car(rand.Next(0, 100)),
                    new Car(rand.Next(0, 100))
                };
            }
            else if(combosort.SelectedIndex == 1)
            {
                avitocars = new Car[] {
                    new Car(rand.Next(0, 10)),
                    new Car(rand.Next(0, 10)),
                    new Car(rand.Next(0, 10))
                };
            }
            else if(combosort.SelectedIndex == 2) { 
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
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[0];
                    money -= avitocars[0].price;
                    spent -= avitocars[0].price;
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
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[1];
                    money -= avitocars[1].price;
                    spent -= avitocars[1].price;
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
                int i = findZero();
                if (i != -1)
                {
                    cars[i] = avitocars[2];
                    money -= avitocars[2].price;
                    spent -= avitocars[2].price;
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
    }
}
