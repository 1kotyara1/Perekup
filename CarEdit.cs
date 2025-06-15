using ProjectPerekup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                _Instance.Icon = (Icon)_Instance.resources.GetObject("$this.Icon");
                return _Instance;
            }
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));
        private DateTime lastResize;
        private (int w, int h) lastsize;

        private static long balance;
        private static Car car;

        private int[] skills;
        private int editsum = 0;
        private int motorprice = 0;
        private int transprice = 0;
        private int hodprice = 0;
        private int kusovprice = 0;
        private int salonprice = 0;
        private int motorupprice;
        private int transupprice;
        private int hodupprice;
        private int kusovupprice;
        private int salonupprice;
        private int motorlvl;
        private int translvl;
        private int hodlvl;
        private int kusovlvl;
        private int salonlvl;
        private bool motoredited;
        private bool transedited;
        private bool hodedited;
        private bool kusovedited;
        private bool salonedited;

        public static void SendData(in long editbalance, in Car editcar, in int[] skills)
        {
            balance = editbalance;
            car = editcar;
            Instance.reloadForm();
            Instance.Text = car.getName();
            Instance.InitializeForm(skills);
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
            editsum = 0;
            motorprice = 0;
            transprice = 0;
            hodprice = 0;
            kusovprice = 0;
            salonprice = 0;

        }

        public CarEdit()
        {
            InitializeComponent();
        }

        private void InitializeForm(int[] sk)
        {
            if (balance != 0)
            {
                skills = sk;

                motorlvl = car.motor;
                translvl = car.trans;
                hodlvl = car.hod;
                kusovlvl = car.kusov;
                salonlvl = car.salon;

                labelmoneyedit.Text = $"Баланс: {PriceToString(balance)}₽";

                editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {car.price}₽\nСостояние: {car.getCondText()}";
                editpricesum.Text = $"Стоимость ремонта: {editsum}₽";
                editcarimg.Image = car.getImg();

                updateInterface(-1);

                lastResize = DateTime.Now;
                resize();
            }

        }
        private void CarEdit_Resize(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (lastResize.Millisecond + lastResize.Second * 1000 - now.Millisecond - now.Second * 1000 < -500 || lastsize.h - Height < -100 || lastsize.h - Height > 100 || lastsize.w - Width < -100 || lastsize.w - Width > 100)
            {
                lastResize = DateTime.Now;
                resize();
            }
        }
        private void CarEdit_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }
        private void resize()
        {
            lastsize = (Width, Height);

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
        private int getButtonPrice(int cond)
        {
            if (cond > 0)
            {
                return Convert.ToInt32(car.price / 7 * Convert.ToDouble(3 + cond) * (1.0 - 0.05 * skills[3])) / 10;
            }
            else
            {
                if (skills[4] > -cond)
                    return Convert.ToInt32((car.price * (2.2 + Convert.ToDouble(-cond)) * (0.9 - Convert.ToDouble(cond) / 15) / 70) * (1.0 - 0.05 * skills[2]));
                else
                    return -1;
            }
        }
        private void updateInterface(int i)
        {
            if (i == 0)
            {
                motorupprice = getButtonPrice(car.motor);

                if (motorupprice == -1 && !motoredited) motorbutton.Text = "Недоступно";
                else if (motorupprice == -1 && motoredited) motorbutton.Text = "Отмена";
                else if (car.motor > 0) motorbutton.Text = $"Починить - {PriceToString(motorupprice)}";
                else motorbutton.Text = $"Улучшить - {PriceToString(motorupprice)}";

                motorlabel.Text = $"Двигатель\n{getCond(car.motor)}";
            }
            else if (i == 1)
            {
                transupprice = getButtonPrice(car.trans);

                if (transupprice == -1 && !transedited) transbutton.Text = "Недоступно";
                else if (transupprice == -1 && transedited) transbutton.Text = "Отмена";
                else if (car.trans > 0) transbutton.Text = $"Починить - {PriceToString(transupprice)}";
                else transbutton.Text = $"Улучшить - {PriceToString(transupprice)}";

                translabel.Text = $"Трансмиссия\n{getCond(car.trans)}";
            }
            else if (i == 2)
            {
                hodupprice = getButtonPrice(car.hod);

                if (hodupprice == -1 && !hodedited) hodbutton.Text = "Недоступно";
                else if (hodupprice == -1 && hodedited) hodbutton.Text = "Отмена";
                else if (car.hod > 0) hodbutton.Text = $"Починить - {PriceToString(hodupprice)}";
                else hodbutton.Text = $"Улучшить - {PriceToString(hodupprice)}";

                hodlabel.Text = $"Ходовая\n{getCond(car.hod)}";
            }
            else if (i == 3)
            {
                kusovupprice = getButtonPrice(car.kusov);

                if (kusovupprice == -1 && !kusovedited) kusovbutton.Text = "Недоступно";
                else if (kusovupprice == -1 && kusovedited) kusovbutton.Text = "Отмена";
                else if (car.kusov > 0) kusovbutton.Text = $"Починить - {PriceToString(kusovupprice)}";
                else kusovbutton.Text = $"Улучшить - {PriceToString(kusovupprice)}";

                kusovlabel.Text = $"Кузов\n{getCond(car.kusov)}";
            }
            else if (i == 4)
            {
                salonupprice = getButtonPrice(car.salon);

                if (salonupprice == -1 && !salonedited) salonbutton.Text = "Недоступно";
                else if (salonupprice == -1 && salonedited) salonbutton.Text = "Отмена";
                else if (car.salon > 0) salonbutton.Text = $"Починить - {PriceToString(salonupprice)}";
                else salonbutton.Text = $"Улучшить - {PriceToString(salonupprice)}";

                salonlabel.Text = $"Салон\n{getCond(car.salon)}";
            }
            else
            {
                motorupprice = getButtonPrice(car.motor);
                transupprice = getButtonPrice(car.trans);
                hodupprice = getButtonPrice(car.hod);
                kusovupprice = getButtonPrice(car.kusov);
                salonupprice = getButtonPrice(car.salon);

                if (motorupprice == -1 && !motoredited) motorbutton.Text = "Недоступно";
                else if (motorupprice == -1 && motoredited) motorbutton.Text = "Отмена";
                else if (car.motor > 0) motorbutton.Text = $"Починить - {PriceToString(motorupprice)}";
                else motorbutton.Text = $"Улучшить - {PriceToString(motorupprice)}";

                if (transupprice == -1 && !transedited) transbutton.Text = "Недоступно";
                else if (transupprice == -1 && transedited) transbutton.Text = "Отмена";
                else if (car.trans > 0) transbutton.Text = $"Починить - {PriceToString(transupprice)}";
                else transbutton.Text = $"Улучшить - {PriceToString(transupprice)}";

                if (hodupprice == -1 && !hodedited) hodbutton.Text = "Недоступно";
                else if (hodupprice == -1 && hodedited) hodbutton.Text = "Отмена";
                else if (car.hod > 0) hodbutton.Text = $"Починить - {PriceToString(hodupprice)}";
                else hodbutton.Text = $"Улучшить - {PriceToString(hodupprice)}";

                if (kusovupprice == -1 && !kusovedited) kusovbutton.Text = "Недоступно";
                else if (kusovupprice == -1 && kusovedited) kusovbutton.Text = "Отмена";
                else if (car.kusov > 0) kusovbutton.Text = $"Починить - {PriceToString(kusovupprice)}";
                else kusovbutton.Text = $"Улучшить - {PriceToString(kusovupprice)}";

                if (salonupprice == -1 && !salonedited) salonbutton.Text = "Недоступно";
                else if (salonupprice == -1 && salonedited) salonbutton.Text = "Отмена";
                else if (car.salon > 0) salonbutton.Text = $"Починить - {PriceToString(salonupprice)}";
                else salonbutton.Text = $"Улучшить - {PriceToString(salonupprice)}";

                motorlabel.Text = $"Двигатель\n{getCond(car.motor)}";
                translabel.Text = $"Трансмиссия\n{getCond(car.trans)}";
                hodlabel.Text = $"Ходовая\n{getCond(car.hod)}";
                kusovlabel.Text = $"Кузов\n{getCond(car.kusov)}";
                salonlabel.Text = $"Салон\n{getCond(car.salon)}";
            }
        }
        private void updateCarText()
        {
            editpricesum.Text = $"Стоимость ремонта: {PriceToString(editsum)}₽";
            editcarlabel.Text = $"{car.getName()}\nСтоимость машины: {PriceToString(car.price)}₽\nСостояние: {car.getCondText()}";
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
        public string PriceToString(long price) // делит сумму 1234567 -> 1 234 567
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

        private void motorbutton_Click(object sender, EventArgs e)
        {
            if (motorbutton.Text != "Недоступно")
            {
                if (motorbutton.Text == "Отмена")
                {
                    motoredited = false;
                    editsum -= motorprice;
                    motorprice = 0;
                    car.motor = motorlvl;
                    updateCarText();
                    updateInterface(0);
                }
                else if (car.motor > 0)
                {
                    motoredited = true;
                    editsum += motorupprice;
                    motorprice += motorupprice;
                    car.motor = 0;
                    updateCarText();
                    updateInterface(0);
                }
                else
                {
                    motoredited = true;
                    editsum += motorupprice;
                    motorprice += motorupprice;
                    car.motor--;
                    updateCarText();
                    updateInterface(0);
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
                    car.trans = translvl;
                    updateCarText();
                    updateInterface(1);
                }
                else if (car.trans > 0)
                {
                    transedited = true;
                    editsum += transupprice;
                    transprice += transupprice;
                    car.trans = 0;
                    updateCarText();
                    updateInterface(1);
                }
                else
                {
                    transedited = true;
                    editsum += transupprice;
                    transprice += transupprice;
                    car.trans--;
                    updateCarText();
                    updateInterface(1);
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
                    car.hod = hodlvl;
                    updateCarText();
                    updateInterface(2);
                }
                else if (car.hod > 0)
                {
                    hodedited = true;
                    editsum += hodupprice;
                    hodprice += hodupprice;
                    car.hod = 0;
                    updateCarText();
                    updateInterface(2);
                }
                else
                {
                    hodedited = true;
                    editsum += hodupprice;
                    hodprice += hodupprice;
                    car.hod--;
                    updateCarText();
                    updateInterface(2);
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
                    car.kusov = kusovlvl;
                    updateCarText();
                    updateInterface(3);
                }
                else if (car.kusov > 0)
                {
                    kusovedited = true;
                    editsum += kusovupprice;
                    kusovprice += kusovupprice;
                    car.kusov = 0;
                    updateCarText();
                    updateInterface(3);
                }
                else
                {
                    kusovedited = true;
                    editsum += kusovupprice;
                    kusovprice += kusovupprice;
                    car.kusov--;
                    updateCarText();
                    updateInterface(3);
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
                    car.salon = salonlvl;
                    updateCarText();
                    updateInterface(4);
                }
                else if (car.salon > 0)
                {
                    salonedited = true;
                    editsum += salonupprice;
                    salonprice += salonupprice;
                    car.salon = 0;
                    updateCarText();
                    updateInterface(4);
                }
                else
                {
                    salonedited = true;
                    editsum += salonupprice;
                    salonprice += salonupprice;
                    car.salon--;
                    updateCarText();
                    updateInterface(4);
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
    }
}