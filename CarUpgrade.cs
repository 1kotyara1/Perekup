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
        private string[] conditions = { " нет повреждений", " лёгкие повреждения", " средние повреждения", " тяжелые повреждения" };
        private string[] garages = { "Гараж Василия", "Гараж Степаныча", "FitService" };

        private static CarUpgrade _Instance = new CarUpgrade();
        public static CarUpgrade Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new CarUpgrade();
                }
                return _Instance;
            }
        }

        static long balance;
        static List<Car> cars;
        int selectedcar;

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

        public CarUpgrade()
        {
            InitializeComponent();
        }

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

            labelmoneyedit.Text = $"Баланс: {balance} ₽";

            loadStats();
        }

        private void CarUpgrade_Resize(object sender, EventArgs e)
        {
            if(Height + 165 < Width)
            {

            }
            else
            {

            }
        }


        private void Nullstats()
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
        private void loadStats()
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

        private void IniCarText()
        {
            editcarlabel.Text = $"{cars[selectedcar].getName()}\nСтоимость: {cars[selectedcar].price}₽\nСостояние: {cars[selectedcar].getCondText()}";
            editpricesum.Text = $"Стоимость: {editsum}₽";
        }
        private void Inimotor()
        {
            motorlabel.Text = $"Двигатель\n{getCond(cars[selectedcar].motor)}";
            if (cars[selectedcar].motor == -3 && motoredited == false) motorbutton.Text = "Недоступно";
            else if (cars[selectedcar].motor == -3 && motoredited == true) motorbutton.Text = "Отмена";
            else motorbutton.Text = $"{getButtonText(cars[selectedcar].motor)}";
        }
        private void Initrans()
        {
            translabel.Text = $"Трансмиссия\n{getCond(cars[selectedcar].trans)}";
            if (cars[selectedcar].trans == -3 && transedited == false) transbutton.Text = "Недоступно";
            else if (cars[selectedcar].trans == -3 && transedited == true) transbutton.Text = "Отмена";
            else transbutton.Text = $"{getButtonText(cars[selectedcar].trans)}";
        }
        private void Inihod()
        {
            hodlabel.Text = $"Ходовая\n{getCond(cars[selectedcar].hod)}";
            if (cars[selectedcar].hod == -3 && hodedited == false) hodbutton.Text = "Недоступно";
            else if (cars[selectedcar].hod == -3 && hodedited == true) hodbutton.Text = "Отмена";
            else hodbutton.Text = $"{getButtonText(cars[selectedcar].hod)}";
        }
        private void Inikusov()
        {
            kusovlabel.Text = $"Кузов\n{getCond(cars[selectedcar].kusov)}";
            if (cars[selectedcar].kusov == -3 && kusovedited == false) kusovbutton.Text = "Недоступно";
            else if (cars[selectedcar].kusov == -3 && kusovedited == true) kusovbutton.Text = "Отмена";
            else kusovbutton.Text = $"{getButtonText(cars[selectedcar].kusov)}";
        }
        private void Inisalon()
        {
            salonlabel.Text = $"Салон\n{getCond(cars[selectedcar].salon)}";
            if (cars[selectedcar].salon == -3 && salonedited == false) salonbutton.Text = "Недоступно";
            else if (cars[selectedcar].salon == -3 && salonedited == true) salonbutton.Text = "Отмена";
            else salonbutton.Text = $"{getButtonText(cars[selectedcar].salon)}";
        }

        private string getButtonText(int lvl)
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
        private string getCond(int cond)
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
        private int fits()
        {
            if (Instance.Text == "FitService")
            {
                return 1;
            }
            return 0;
        }
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

    public enum Garage
    {
        vasya,
        stepa,
        fits
    }
}
