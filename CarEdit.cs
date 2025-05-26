using ProjectPerekup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjectPerekup
{
    public partial class CarEdit : Form
    {
        private string[] conditions = { " нулевые", " лёгкие", " средние", " тяжелые" };

        private static CarEdit _Instance = new CarEdit();
        public static CarEdit Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new CarEdit();
                }
                return _Instance;
            }
        }

        static long balance;
        static Car car;

        private int editsum = 0;
        private int motorprice;
        private int transprice;
        private int hodprice;
        private int kusovprice;
        private int salonprice;
        private int motorlvl;
        private int translvl;
        private int hodlvl;
        private int kusovlvl;
        private int salonlvl;
        private bool motoredited = false;
        private bool transedited = false;
        private bool hodedited = false;
        private bool kusovedited = false;
        private bool salonedited = false;

        public static void SendData(long editbalance, Car editcar)
        {
            balance = editbalance;
            car = editcar;
            Instance.InitializeForm();
        }
        public static void RecieveData(out long sendbalance, out Car sendcar)
        {
            sendbalance = balance;
            sendcar = car;
        }

        public CarEdit()
        {
            InitializeComponent();
        }

        private void InitializeForm()
        {
            if (balance != 0)
            {
                motorprice = Convert.ToInt32(car.price / 5 * Convert.ToDouble(8 + car.motor) / 10);
                transprice = Convert.ToInt32(car.price / 5 * Convert.ToDouble(8 + car.trans) / 10);
                hodprice = Convert.ToInt32(car.price / 5 * Convert.ToDouble(8 + car.hod) / 10);
                kusovprice = Convert.ToInt32(car.price / 5 * Convert.ToDouble(8 + car.kusov) / 10);
                salonprice = Convert.ToInt32(car.price / 5 * Convert.ToDouble(8 + car.salon) / 10);
                motorlvl = car.motor;
                translvl = car.trans;
                hodlvl = car.hod;
                kusovlvl = car.kusov;
                salonlvl = car.salon;

                labelmoneyedit.Text = $"Баланс: {balance}₽";

                editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                editcarimg.Image = car.getImg();

                motorlabel.Text = $"Двигатель\nПовреждения:{conditions[car.motor]}";
                translabel.Text = $"Трансмиссия\nПовреждения:{conditions[car.trans]}";
                hodlabel.Text = $"Ходовая\nПовреждения:{conditions[car.hod]}";
                kusovlabel.Text = $"Кузов\nПовреждения:{conditions[car.kusov]}";
                salonlabel.Text = $"Салон\nПовреждения:{conditions[car.salon]}";

                if (car.motor == 0) motorbutton.Text = "Недоступно";
                else motorbutton.Text = $"Починить - {motorprice}";

                if (car.trans == 0) transbutton.Text = "Недоступно";
                else transbutton.Text = $"Починить - {transprice}";

                if (car.hod == 0) hodbutton.Text = "Недоступно";
                else hodbutton.Text = $"Починить - {hodprice}";

                if (car.kusov == 0) kusovbutton.Text = "Недоступно";
                else kusovbutton.Text = $"Починить - {kusovprice}";

                if (car.salon == 0) salonbutton.Text = "Недоступно";
                else salonbutton.Text = $"Починить - {salonprice}";
            }

        }

        private void motorbutton_Click(object sender, EventArgs e)
        {
            if (motorbutton.Text != "Недоступно")
            {
                if (!motoredited)
                {
                    motorbutton.Text = $"Отмена ремонта";
                    editsum += motorprice;
                    car.motor = 0;
                    motoredited = true;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
                else
                {
                    motorbutton.Text = $"Починить - {motorprice}";
                    editsum -= motorprice;
                    car.motor = motorlvl;
                    motoredited = false;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
            }
        }
        private void transbutton_Click(object sender, EventArgs e)
        {
            if (transbutton.Text != "Недоступно")
            {
                if (!transedited)
                {
                    transbutton.Text = $"Отмена ремонта";
                    editsum += transprice;
                    car.trans = 0;
                    transedited = true;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
                else
                {
                    transbutton.Text = $"Починить - {transprice}";
                    editsum -= transprice;
                    car.trans = translvl;
                    transedited = false;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
            }
        }
        private void hodbutton_Click(object sender, EventArgs e)
        {
            if (hodbutton.Text != "Недоступно")
            {
                if (!hodedited)
                {
                    hodbutton.Text = $"Отмена ремонта";
                    editsum += hodprice;
                    car.hod = 0;
                    hodedited = true;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
                else
                {
                    hodbutton.Text = $"Починить - {hodprice}";
                    editsum -= hodprice;
                    car.hod = hodlvl;
                    hodedited = false;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
            }
        }
        private void kusovbutton_Click(object sender, EventArgs e)
        {
            if (kusovbutton.Text != "Недоступно")
            {
                if (!kusovedited)
                {
                    kusovbutton.Text = $"Отмена ремонта";
                    editsum += kusovprice;
                    car.kusov = 0;
                    kusovedited = true;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
                else
                {
                    kusovbutton.Text = $"Починить - {kusovprice}";
                    editsum -= kusovprice;
                    car.kusov = kusovlvl;
                    kusovedited = false;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
            }
        }
        private void salonbutton_Click(object sender, EventArgs e)
        {
            if (salonbutton.Text != "Недоступно")
            {
                if (!salonedited)
                {
                    salonbutton.Text = $"Отмена ремонта";
                    editsum += salonprice;
                    car.salon = 0;
                    salonedited = true;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
                else
                {
                    salonbutton.Text = $"Починить - {salonprice}";
                    editsum -= salonprice;
                    car.salon = salonlvl;
                    salonedited = false;
                    editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                    editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Instance.Close();
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            balance -= editsum;
            Instance.DialogResult = DialogResult.OK;
            Instance.Close();
        }
    }
}