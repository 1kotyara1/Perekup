using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPerekup.Classes;

namespace ProjectPerekup
{
    public partial class CarUpgrade : Form
    {
        // для создания окна
        private static CarUpgrade _Instance = new CarUpgrade();
        public static CarUpgrade Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new CarUpgrade();
                }
                _Instance.Icon = (Icon)_Instance.resources.GetObject("$this.Icon");
                return _Instance;
            }
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));



        // прсто информация
        private string[] conditions = { " нет повреждений", " лёгкие повреждения", " средние повреждения", " тяжелые повреждения" };
        private string[] garages = { "Гараж Василия", "Гараж Степаныча", "FitService" };
        private DateTime lastResize;
        private (int w, int h) lastsize;

        // данные о пользователе
        static long balance;
        static List<Car> cars;
        int selectedcar;

        // данные об изменениях в машине
        private int editsum;
        private int motorlvl;
        private int translvl;
        private int hodlvl;
        private int kusovlvl;
        private int salonlvl;
        private int motorprice;
        private int transprice;
        private int hodprice;
        private int kusovprice;
        private int salonprice;
        private bool motoredited = false;
        private bool transedited = false;
        private bool hodedited = false;
        private bool kusovedited = false;
        private bool salonedited = false;


        // запуск
        public CarUpgrade()
        {
            InitializeComponent();
        }
        private void InitializeForm(Garage gar)
        {
            Instance.Text = garages[Convert.ToInt32(gar)];
            selectedcar = cars.FindIndex(c => c.img != 0);

            car0img.Image = cars[0].getImg();
            car1img.Image = cars[1].getImg();
            car2img.Image = cars[2].getImg();
            car3img.Image = cars[3].getImg();
            car4img.Image = cars[4].getImg();
            car5img.Image = cars[5].getImg();

            car0img.Click += (sender, e) => { if (cars[0].img != 0) { Nullstats(); selectedcar = 0; loadStats(); } };
            car1img.Click += (sender, e) => { if (cars[1].img != 0) { Nullstats(); selectedcar = 1; loadStats(); } };
            car2img.Click += (sender, e) => { if (cars[2].img != 0) { Nullstats(); selectedcar = 2; loadStats(); } };
            car3img.Click += (sender, e) => { if (cars[3].img != 0) { Nullstats(); selectedcar = 3; loadStats(); } };
            car4img.Click += (sender, e) => { if (cars[4].img != 0) { Nullstats(); selectedcar = 4; loadStats(); } };
            car5img.Click += (sender, e) => { if (cars[5].img != 0) { Nullstats(); selectedcar = 5; loadStats(); } };

            Resize += (sender, e) => CarUpgrade_Resize();

            labelmoneyedit.Text = $"Баланс: {balance} ₽";

            loadStats();
            lastResize = DateTime.Now;
            resize();
        }


        // отправка и получение информации
        public static void SendData(long editbalance, List<Car> editcars, Garage gar)
        {
            balance = editbalance;
            cars = editcars;
            Instance.InitializeForm(gar);
        }
        public static void RecieveData(out long sendbalance, out List<Car> sendcars)
        {
            sendbalance = balance;
            sendcars = cars;
        }


        // изменение размеров окна
        private void CarUpgrade_Resize()
        {
            DateTime now = DateTime.Now;
            if (lastResize.Millisecond + lastResize.Second*1000 - now.Millisecond - now.Second*1000 < -500 || lastsize.h - Height < -100 || lastsize.h - Height > 100 || lastsize.w - Width < -100 || lastsize.w - Width > 100)
            {
                lastResize = DateTime.Now;
                resize();
            }
        }
        private void CarUpgrade_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }
        private void resize()
        {
            lastsize = (Width, Height);

            int height = Height - 15;
            int width = Width - 16;

            // окно широкое
            if (Height * 1.2777 < Width)
            {
                car0img.Height = Convert.ToInt32(Height * 0.1904); // опираемся на высоту
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

                car3img.Location = new Point((width + 6) / 2, 12);
                car4img.Location = new Point(car3img.Location.X + car3img.Width + 6, 12);
                car5img.Location = new Point(car4img.Location.X + car4img.Width + 6, 12);

                car2img.Location = new Point((width - 6) / 2 - car2img.Width, 12);
                car1img.Location = new Point(car2img.Location.X - car2img.Width - 6, 12);
                car0img.Location = new Point(car1img.Location.X - car1img.Width - 6, 12);
            }
            // окно высокое
            else
            {
                car0img.Height = Convert.ToInt32(Width * 0.149); // опираемся на ширину
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

                car3img.Location = new Point((width + 6) / 2, 12);
                car4img.Location = new Point(car3img.Location.X + car3img.Width + 6, 12);
                car5img.Location = new Point(car4img.Location.X + car4img.Width + 6, 12);

                car2img.Location = new Point((width - 6) / 2 - car2img.Width, 12);
                car1img.Location = new Point(car2img.Location.X - car2img.Width - 6, 12);
                car0img.Location = new Point(car1img.Location.X - car1img.Width - 6, 12);
            }

            /* конпки починки, информация о выбранной машине и кнопки снизу */ {
                editcarimg.Width = car0img.Width * 2 + 6;
                editcarimg.Height = editcarimg.Width;
                editcarimg.Location = new Point(car2img.Location.X, car2img.Location.Y + car2img.Height + 6);
                editcarlabel.Width = editcarimg.Width;
                editcarlabel.Height = editcarimg.Width / 3;
                editcarlabel.Location = new Point(editcarimg.Location.X, editcarimg.Location.Y + editcarimg.Height + 2);

                cancelbutton.Width = car0img.Width;
                cancelbutton.Height = Convert.ToInt32(cancelbutton.Width * 0.416);
                cancelbutton.Location = new Point(car2img.Location.X, Height - cancelbutton.Height - 43);
                confirmbutton.Width = car0img.Width;
                confirmbutton.Height = cancelbutton.Height;
                confirmbutton.Location = new Point(car3img.Location.X, cancelbutton.Location.Y);
                editpricesum.Width = editcarimg.Width;
                editpricesum.Height = editpricesum.Width / 10;
                editpricesum.Location = new Point(cancelbutton.Location.X, cancelbutton.Location.Y - 6 - editpricesum.Height);

                motorlabel.Width = editcarimg.Width;
                motorlabel.Height = 52 + (motorlabel.Width - 246) / 10;
                motorlabel.Location = new Point(car0img.Location.X, editcarimg.Location.Y);
                motorbutton.Width = editcarimg.Width;
                motorbutton.Height = 40 + (motorbutton.Width - 246) / 10;
                motorbutton.Location = new Point(car0img.Location.X, motorlabel.Location.Y + motorlabel.Height + 3);

                translabel.Width = motorlabel.Width;
                translabel.Height = motorlabel.Height;
                translabel.Location = new Point(motorlabel.Location.X, motorbutton.Location.Y + motorbutton.Height + 7);
                transbutton.Width = editcarimg.Width;
                transbutton.Height = motorbutton.Height;
                transbutton.Location = new Point(car0img.Location.X, translabel.Location.Y + translabel.Height + 3);

                hodlabel.Width = motorlabel.Width;
                hodlabel.Height = motorlabel.Height;
                hodlabel.Location = new Point(translabel.Location.X, transbutton.Location.Y + transbutton.Height + 7);
                hodbutton.Width = editcarimg.Width;
                hodbutton.Height = motorbutton.Height;
                hodbutton.Location = new Point(car0img.Location.X, hodlabel.Location.Y + hodlabel.Height + 3);

                kusovlabel.Width = motorlabel.Width;
                kusovlabel.Height = motorlabel.Height;
                kusovlabel.Location = new Point(car4img.Location.X, motorlabel.Location.Y);
                kusovbutton.Width = editcarimg.Width;
                kusovbutton.Height = motorbutton.Height;
                kusovbutton.Location = new Point(car4img.Location.X, kusovlabel.Location.Y + kusovlabel.Height + 3);

                salonlabel.Width = kusovlabel.Width;
                salonlabel.Height = kusovlabel.Height;
                salonlabel.Location = new Point(kusovlabel.Location.X, kusovbutton.Location.Y + kusovbutton.Height + 7);
                salonbutton.Width = editcarimg.Width;
                salonbutton.Height = kusovbutton.Height;
                salonbutton.Location = new Point(car4img.Location.X, salonlabel.Location.Y + salonlabel.Height + 3);
            }
        }


        // загрузка или обновление информации о выбранной машине на экране
        private void Nullstats() // сбрасывает
        {
            if (motoredited || transedited || hodedited || kusovedited || salonedited)
            {
                cars[selectedcar].motor = motorlvl;
                cars[selectedcar].trans = translvl;
                cars[selectedcar].hod = hodlvl;
                cars[selectedcar].kusov = kusovlvl;
                cars[selectedcar].salon = salonlvl;
            }
        }
        private void loadStats() // загружает
        {
            editsum = 0;
            motorprice = 0;
            transprice = 0;
            hodprice = 0;
            kusovprice = 0;
            salonprice = 0;

            motorlvl = cars[selectedcar].motor;
            translvl = cars[selectedcar].trans;
            hodlvl = cars[selectedcar].hod;
            kusovlvl = cars[selectedcar].kusov;
            salonlvl = cars[selectedcar].salon;

            motoredited = false;
            transedited = false;
            hodedited = false;
            kusovedited = false;
            salonedited = false;

            IniCarText();
            editcarimg.Image = cars[selectedcar].getImg();

            Inimotor();
            Initrans();
            Inihod();
            Inikusov();
            Inisalon();
        }


        // загрузка данных на определенные элементы окна
        private void IniCarText()
        {
            editcarlabel.Text = $"{cars[selectedcar].getName()}\nСтоимость: {cars[selectedcar].price}₽\nСостояние: {cars[selectedcar].getCondText()}";
            editpricesum.Text = $"Стоимость: {editsum}₽";
        }
        private void Inimotor()
        {
            motorlabel.Text = $"Двигатель\n{getCond(cars[selectedcar].motor)}";
            if (cars[selectedcar].motor <= -3 && motoredited == false) motorbutton.Text = "Недоступно";
            else if (cars[selectedcar].motor == -3 && motoredited == true) motorbutton.Text = "Отмена";
            else motorbutton.Text = $"{getButtonText(cars[selectedcar].motor)}";
        }
        private void Initrans()
        {
            translabel.Text = $"Трансмиссия\n{getCond(cars[selectedcar].trans)}";
            if (cars[selectedcar].trans <= -3 && transedited == false) transbutton.Text = "Недоступно";
            else if (cars[selectedcar].trans == -3 && transedited == true) transbutton.Text = "Отмена";
            else transbutton.Text = $"{getButtonText(cars[selectedcar].trans)}";
        }
        private void Inihod()
        {
            hodlabel.Text = $"Ходовая\n{getCond(cars[selectedcar].hod)}";
            if (cars[selectedcar].hod <= -3 && hodedited == false) hodbutton.Text = "Недоступно";
            else if (cars[selectedcar].hod == -3 && hodedited == true) hodbutton.Text = "Отмена";
            else hodbutton.Text = $"{getButtonText(cars[selectedcar].hod)}";
        }
        private void Inikusov()
        {
            kusovlabel.Text = $"Кузов\n{getCond(cars[selectedcar].kusov)}";
            if (cars[selectedcar].kusov <= -3 && kusovedited == false) kusovbutton.Text = "Недоступно";
            else if (cars[selectedcar].kusov == -3 && kusovedited == true) kusovbutton.Text = "Отмена";
            else kusovbutton.Text = $"{getButtonText(cars[selectedcar].kusov)}";
        }
        private void Inisalon()
        {
            salonlabel.Text = $"Салон\n{getCond(cars[selectedcar].salon)}";
            if (cars[selectedcar].salon <= -3 && salonedited == false) salonbutton.Text = "Недоступно";
            else if (cars[selectedcar].salon == -3 && salonedited == true) salonbutton.Text = "Отмена";
            else salonbutton.Text = $"{getButtonText(cars[selectedcar].salon)}";
        }

        private string getButtonText(int lvl) // возвращает текст для кнопки в зависимости от состояния определенного элемента машины
        {
            if (lvl > 0)
            {
                return $"Починить - {Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + lvl)) / 10)}";
            }
            else
            {
                return $"Улучшить - {Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - lvl)) / 10) * (0.9 - Convert.ToDouble(lvl) / 15))}";
            }
        }
        private string getCond(int cond) // возвращает текст для label в зависимости от состояния определенного элемента машины
        {
            if (cond >= 0)
            {
                return $"Повреждения: {conditions[cond]}";
            }
            else
            {
                return $"{-cond} уровень";
            }
        }
        private int fits() // проверка на мастерскую
        {
            return Instance.Text == "FitService" ? 1 : 0;
        }


        // нажатие кнопок
        private void motorbutton_Click(object sender, EventArgs e)
        {
            if (motorbutton.Text != "Недоступно")
            {
                if (motorbutton.Text == "Отмена")
                {
                    motoredited = false;
                    editsum -= motorprice;
                    motorprice = 0;
                    cars[selectedcar].motor = motorlvl;
                    IniCarText();
                    Inimotor();
                }
                else if (cars[selectedcar].motor > 0)
                {
                    motoredited = true;
                    int price = Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + cars[selectedcar].motor)) / 10);
                    editsum += price;
                    motorprice += price;
                    cars[selectedcar].motor = 0;
                    Inimotor();
                    IniCarText();
                }
                else
                {
                    motoredited = true;
                    int price = Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - cars[selectedcar].motor)) / 10) * (0.9 - Convert.ToDouble(cars[selectedcar].motor) / 15));
                    editsum += price;
                    motorprice += price;
                    cars[selectedcar].motor--;
                    Inimotor();
                    IniCarText();
                }
            }
        }
        private void transbutton_Click(object sender, EventArgs e)
        {
            if (transbutton.Text != "Недоступно")
            {
                if (transbutton.Text == "Отмена")
                {
                    transedited = false;
                    editsum -= transprice;
                    transprice = 0;
                    cars[selectedcar].trans = translvl;
                    IniCarText();
                    Initrans();
                }
                else if (cars[selectedcar].trans > 0)
                {
                    transedited = true;
                    int price = Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + cars[selectedcar].trans)) / 10);
                    editsum += price;
                    transprice += price;
                    cars[selectedcar].trans = 0;
                    Initrans();
                    IniCarText();
                }
                else
                {
                    transedited = true;
                    int price = Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - cars[selectedcar].trans)) / 10) * (0.9 - Convert.ToDouble(cars[selectedcar].trans) / 15));
                    editsum += price;
                    transprice += price;
                    cars[selectedcar].trans--;
                    Initrans();
                    IniCarText();
                }
            }
        }
        private void hodbutton_Click(object sender, EventArgs e)
        {
            if (hodbutton.Text != "Недоступно")
            {
                if (hodbutton.Text == "Отмена")
                {
                    hodedited = false;
                    editsum -= hodprice;
                    hodprice = 0;
                    cars[selectedcar].hod = hodlvl;
                    IniCarText();
                    Inihod();
                }
                else if (cars[selectedcar].hod > 0)
                {
                    hodedited = true;
                    int price = Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + cars[selectedcar].hod)) / 10);
                    editsum += price;
                    hodprice += price;
                    cars[selectedcar].hod = 0;
                    Inihod();
                    IniCarText();
                }
                else
                {
                    hodedited = true;
                    int price = Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - cars[selectedcar].hod)) / 10) * (0.9 - Convert.ToDouble(cars[selectedcar].hod) / 15));
                    editsum += price;
                    hodprice += price;
                    cars[selectedcar].hod--;
                    Inihod();
                    IniCarText();
                }
            }
        }
        private void kusovbutton_Click(object sender, EventArgs e)
        {
            if (kusovbutton.Text != "Недоступно")
            {
                if (kusovbutton.Text == "Отмена")
                {
                    kusovedited = false;
                    editsum -= kusovprice;
                    kusovprice = 0;
                    cars[selectedcar].kusov = kusovlvl;
                    IniCarText();
                    Inikusov();
                }
                else if (cars[selectedcar].kusov > 0)
                {
                    kusovedited = true;
                    int price = Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + cars[selectedcar].kusov)) / 10);
                    editsum += price;
                    kusovprice += price;
                    cars[selectedcar].kusov = 0;
                    Inikusov();
                    IniCarText();
                }
                else
                {
                    kusovedited = true;
                    int price = Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - cars[selectedcar].kusov)) / 10) * (0.9 - Convert.ToDouble(cars[selectedcar].kusov) / 15));
                    editsum += price;
                    kusovprice += price;
                    cars[selectedcar].kusov--;
                    Inikusov();
                    IniCarText();
                }
            }
        }
        private void salonbutton_Click(object sender, EventArgs e)
        {
            if (salonbutton.Text != "Недоступно")
            {
                if (salonbutton.Text == "Отмена")
                {
                    salonedited = false;
                    editsum -= salonprice;
                    salonprice = 0;
                    cars[selectedcar].salon = salonlvl;
                    IniCarText();
                    Inisalon();
                }
                else if (cars[selectedcar].salon > 0)
                {
                    salonedited = true;
                    int price = Convert.ToInt32(cars[selectedcar].price / 7 * (3.5 + Convert.ToDouble(fits() + cars[selectedcar].salon)) / 10);
                    editsum += price;
                    salonprice += price;
                    cars[selectedcar].salon = 0;
                    Inisalon();
                    IniCarText();
                }
                else
                {
                    salonedited = true;
                    int price = Convert.ToInt32((cars[selectedcar].price / 7 * (2.0 + Convert.ToDouble(fits() - cars[selectedcar].salon)) / 10) * (0.9 - Convert.ToDouble(cars[selectedcar].salon) / 15));
                    editsum += price;
                    salonprice += price;
                    cars[selectedcar].salon--;
                    Inisalon();
                    IniCarText();
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Nullstats();
            Instance.Close();
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(balance) - editsum < 0)
            {
                MessageBox.Show($"Ошибка:  не хватает денег");
                return;
            }
            balance -= editsum;
            Instance.DialogResult = DialogResult.OK;
            Instance.Close();
        }
    }


    // для понимания в каком гараже мы находимся
    public enum Garage
    {
        vasya,
        stepa,
        fits
    }
}
