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
            Instance.reloadForm();
            Instance.Text = car.getName();
            Instance.InitializeForm();
        }
        public static void RecieveData(out long sendbalance, out Car sendcar)
        {
            sendbalance = balance;
            sendcar = car;
        }
        private void reloadForm()
        {
            Instance.editsum = 0;
            motoredited = false;
            transedited = false;
            hodedited = false;
            kusovedited = false;
            salonedited = false;
        }

        public CarEdit()
        {
            InitializeComponent();
        }

        private void CarEdit_Resize(object sender, EventArgs e)
        {
            int width = Width - 16;
            int height = Height - 39;

            if (Convert.ToInt32((width - Height / 2 - 24) / 2) >= 230)
            {
                editcarimg.Height = Height / 2;
                editcarimg.Width = editcarimg.Height;
            }
            else
            {
                editcarimg.Width = Width - (motorlabel.Width * 2) - 56;
                editcarimg.Height = editcarimg.Width;
            }
            editcarlabel.Width = editcarimg.Width;
            cancelbutton.Width = Convert.ToInt32(editcarimg.Width / 2) - 6;
            confirmbutton.Width = cancelbutton.Width;
            editpricesum.Width = editcarimg.Width;

            editcarimg.Location = new Point(Convert.ToInt32((width - editcarimg.Width) / 2), 12);
            editcarlabel.Location = new Point(editcarimg.Location.X, editcarimg.Location.Y + editcarimg.Height + 3);

            motorlabel.Location = new Point(editcarimg.Location.X - 228, 12);
            motorbutton.Location = new Point(motorlabel.Location.X, 67);
            translabel.Location = new Point(motorlabel.Location.X, motorlabel.Location.Y + 95 + Convert.ToInt32((editcarimg.Height - 285) / 2));
            transbutton.Location = new Point(motorlabel.Location.X, translabel.Location.Y + 55);
            hodlabel.Location = new Point(motorlabel.Location.X, translabel.Location.Y + 95 + Convert.ToInt32((editcarimg.Height - 285) / 2));
            hodbutton.Location = new Point(motorlabel.Location.X, hodlabel.Location.Y + 55);
            kusovlabel.Location = new Point(editcarimg.Location.X + editcarimg.Width + 6, motorlabel.Location.Y);
            kusovbutton.Location = new Point(kusovlabel.Location.X, motorbutton.Location.Y);
            salonlabel.Location = new Point(kusovlabel.Location.X, translabel.Location.Y);
            salonbutton.Location = new Point(kusovlabel.Location.X, transbutton.Location.Y);

            cancelbutton.Location = new Point(editcarimg.Location.X, Height - 98);
            confirmbutton.Location = new Point(cancelbutton.Location.X + cancelbutton.Width + 12, cancelbutton.Location.Y);
            editpricesum.Location = new Point(cancelbutton.Location.X, cancelbutton.Location.Y - 38);

            labelmoneyedit.Width = cancelbutton.Location.X - 14;
            labelmoneyedit.Font = new Font("Segoe UI", 14 + Convert.ToInt32((Height + Width - 1400) / 300));
        }
        private void InitializeForm()
        {
            if (balance != 0)
            {
                motorprice = Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + car.motor) / 10);
                transprice = Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + car.trans) / 10);
                hodprice = Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + car.hod) / 10);
                kusovprice = Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + car.kusov) / 10);
                salonprice = Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + car.salon) / 10);
                motorlvl = car.motor;
                translvl = car.trans;
                hodlvl = car.hod;
                kusovlvl = car.kusov;
                salonlvl = car.salon;

                labelmoneyedit.Text = $"Баланс: {balance}₽";

                editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                editcarimg.Image = car.getImg();

                motorlabel.Text = $"Двигатель\n{getCond(car.motor)}";
                translabel.Text = $"Трансмиссия\n{getCond(car.trans)}";
                hodlabel.Text = $"Ходовая\n{getCond(car.hod)}";
                kusovlabel.Text = $"Кузов\n{getCond(car.kusov)}";
                salonlabel.Text = $"Салон\n{getCond(car.salon)}";

                if (car.motor <= 0) motorbutton.Text = "Недоступно";
                else motorbutton.Text = $"Починить - {motorprice}";

                if (car.trans <= 0) transbutton.Text = "Недоступно";
                else transbutton.Text = $"Починить - {transprice}";

                if (car.hod <= 0) hodbutton.Text = "Недоступно";
                else hodbutton.Text = $"Починить - {hodprice}";

                if (car.kusov <= 0) kusovbutton.Text = "Недоступно";
                else kusovbutton.Text = $"Починить - {kusovprice}";

                if (car.salon <= 0) salonbutton.Text = "Недоступно";
                else salonbutton.Text = $"Починить - {salonprice}";
            }

        }
        private string getCond(int cond)
        {
            if (cond >= 0)
            {
                return $"Повреждения:{conditions[cond]}";
            }
            else
            {
                return $"{-cond} уровень";
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
        private void Nullstats()
        {
            if (motoredited || transedited || hodedited || kusovedited || salonedited)
            {
                car.motor = motorlvl;
                car.trans = translvl;
                car.hod = hodlvl;
                car.kusov = kusovlvl;
                car.salon = salonlvl;
            }
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Nullstats();
            Instance.Close();
        }
        private void confirmbutton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(balance) - editsum < 0)
            {
                MessageBox.Show($"Ошибка:  не хватает денег");
                return;
            }
            balance -= editsum;
            Instance.DialogResult = DialogResult.OK;
            Instance.Close();
        }
    }
}