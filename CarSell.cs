using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPerekup.Classes;

namespace ProjectPerekup
{
    public partial class CarSell : Form
    {
        // создание окна(можете не смотреть сюда)
        private static CarSell _Instance = new CarSell();
        public static CarSell Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new CarSell();
                }
                return _Instance;
            }
        }
        public CarSell()
        {
            InitializeComponent();
        }
        private DateTime lastResize;
        private (int w, int h) lastsize;


        // массив состояний отдельных частей машины
        private string[] conditions = { " нет повреждений", " лёгкие повреждения", " средние повреждения", " тяжелые повреждения" };


        // баланс, машины, выбранная машина
        static long balance;
        static List<Car> cars;
        int selectedcar;


        // передача данных между окнами
        public static void SendData(long editbalance, List<Car> editcars) // данные идут из основного окна
        {
            balance = editbalance;
            cars = editcars;
            Instance.InitializeForm();
        }
        public static void RecieveData(out long sendbalance, out List<Car> sendcars) // данные идут в основное окно
        {
            sendbalance = balance;
            sendcars = cars;
        }
        private void InitializeForm() // загрузка данных в окно
        {
            selectedcar = cars.FindIndex(c => c.img != 0);

            car0img.MouseEnter += (sender, e) => car0text.Visible = true;
            car0img.MouseLeave += (sender, e) => hideCarText(0);
            car0img.Click += (sender, e) => { if (cars[0].img != 0) { if (selectedcar != 0) hideOtherCarText(); selectedcar = 0; loadStats(); } };
            if(selectedcar != 0) car0text.Visible = false;
            else car0text.Visible = true;

                car1img.MouseEnter += (sender, e) => car1text.Visible = true;
            car1img.MouseLeave += (sender, e) => hideCarText(1);
            car1img.Click += (sender, e) => { if (cars[1].img != 0) { if (selectedcar != 1) hideOtherCarText(); selectedcar = 1; loadStats(); } };
            if (selectedcar != 1) car1text.Visible = false;
            else car1text.Visible = true;

            car2img.MouseEnter += (sender, e) => car2text.Visible = true;
            car2img.MouseLeave += (sender, e) => hideCarText(2);
            car2img.Click += (sender, e) => { if (cars[2].img != 0) { if (selectedcar != 2) hideOtherCarText(); selectedcar = 2; loadStats(); } };
            if (selectedcar != 2) car2text.Visible = false;
            else car2text.Visible = true;

            car3img.MouseEnter += (sender, e) => car3text.Visible = true;
            car3img.MouseLeave += (sender, e) => hideCarText(3);
            car3img.Click += (sender, e) => { if (cars[3].img != 0) { if (selectedcar != 3) hideOtherCarText(); selectedcar = 3; loadStats(); } };
            if (selectedcar != 3) car3text.Visible = false;
            else car3text.Visible = true;

            car4img.MouseEnter += (sender, e) => car4text.Visible = true;
            car4img.MouseLeave += (sender, e) => hideCarText(4);
            car4img.Click += (sender, e) => { if (cars[4].img != 0) { if (selectedcar != 4) hideOtherCarText(); selectedcar = 4; loadStats(); } };
            if (selectedcar != 4) car4text.Visible = false;
            else car4text.Visible = true;

            car5img.MouseEnter += (sender, e) => car5text.Visible = true;
            car5img.MouseLeave += (sender, e) => hideCarText(5);
            car5img.Click += (sender, e) => { if (cars[5].img != 0) { if (selectedcar != 5) hideOtherCarText(); selectedcar = 5; loadStats(); } };
            if (selectedcar != 5) car5text.Visible = false;
            else car5text.Visible = true;

            car0img.Image = cars[0].getImg();
            if (cars[0].img == 0) car0text.Text = "Пусто";
            else car0text.Text = cars[0].ToString(0);

            car1img.Image = cars[1].getImg();
            if (cars[1].img == 0) car1text.Text = "Пусто";
            else car1text.Text = cars[1].ToString(0);

            car2img.Image = cars[2].getImg();
            if (cars[2].img == 0) car2text.Text = "Пусто";
            else car2text.Text = cars[2].ToString(0);

            car3img.Image = cars[3].getImg();
            if (cars[3].img == 0) car3text.Text = "Пусто";
            else car3text.Text = cars[3].ToString(0);

            car4img.Image = cars[4].getImg();
            if (cars[4].img == 0) car4text.Text = "Пусто";
            else car4text.Text = cars[4].ToString(0);

            car5img.Image = cars[5].getImg();
            if (cars[5].img == 0) car5text.Text = "Пусто";
            else car5text.Text = cars[5].ToString(0);

            loadStats();
            lastResize = DateTime.Now;
            resize();
        }

        // изменение размеров окна 
        private void CarSell_Resize(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (lastResize.Millisecond + lastResize.Second * 1000 - now.Millisecond - now.Second * 1000 < -500 || lastsize.h - Height < -100 || lastsize.h - Height > 100 || lastsize.w - Width < -100 || lastsize.w - Width > 100)
            {
                lastResize = DateTime.Now;
                resize();
            }
        }
        private void CarSell_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }
        private void resize()
        {
            lastsize = (Width, Height);

            int width = Width - 16;
            int height = Height - 39;

            car3img.Width = 120 + Convert.ToInt32((width - 784) / 20);
            car3img.Height = car3img.Width;
            car4img.Width = car3img.Width;
            car4img.Height = car3img.Width;
            car5img.Width = car3img.Width;
            car5img.Height = car3img.Width;
            car0img.Width = car3img.Width;
            car0img.Height = car3img.Width;
            car1img.Width = car3img.Width;
            car1img.Height = car3img.Width;
            car2img.Width = car3img.Width;
            car2img.Height = car3img.Width;

            car0text.Width = car3img.Width;
            car1text.Width = car3img.Width;
            car2text.Width = car3img.Width;
            car3text.Width = car3img.Width;
            car4text.Width = car3img.Width;
            car5text.Width = car3img.Width;

            cancelbutton.Width = car3img.Width;
            sellbutton.Width = car3img.Width;
            carprice.Width = car3img.Width * 2 + 6;

            car3img.Location = new Point(Convert.ToInt32(width / 2) + 3, 12);
            car3text.Location = new Point(car3img.Location.X, car3img.Height + 15);
            car4img.Location = new Point(car3img.Location.X + car3img.Width + 6, 12);
            car4text.Location = new Point(car4img.Location.X, car3text.Location.Y);
            car5img.Location = new Point(car4img.Location.X + car4img.Width + 6, 12);
            car5text.Location = new Point(car5img.Location.X, car3text.Location.Y);
            car2img.Location = new Point(car3img.Location.X - car2img.Width - 6, 12);
            car2text.Location = new Point(car2img.Location.X, car3text.Location.Y);
            car1img.Location = new Point(car2img.Location.X - car1img.Width - 6, 12);
            car1text.Location = new Point(car1img.Location.X, car3text.Location.Y);
            car0img.Location = new Point(car1img.Location.X - car0img.Width - 6, 12);
            car0text.Location = new Point(car0img.Location.X, car3text.Location.Y);

            cancelbutton.Location = new Point(car2img.Location.X, Height - 98);
            sellbutton.Location = new Point(car3img.Location.X, cancelbutton.Location.Y);
            carprice.Location = new Point(cancelbutton.Location.X, cancelbutton.Location.Y - 38);

            carstat0.Location = new Point(17, car0text.Location.Y + car0text.Height + Convert.ToInt32((carprice.Location.Y - (car0text.Location.Y + car0text.Height)) / 2) - Convert.ToInt32(carstat0.Height / 2));
        }


        // помощники
        private void hideCarText(int carnum) // скрытие описания(кроме выбранной машины)
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
        private void hideOtherCarText() // скрытие описаний(сразу всех кроме выбранной)
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
        private void loadStats() // загрузка данных выбранной машины
        {
            carstat0.Text = $"Мотор:{getCond(cars[selectedcar].motor)}\n" +
                            $"Трансмиссия:{getCond(cars[selectedcar].trans)}\n" +
                            $"Ходовая:{getCond(cars[selectedcar].hod)}\n" +
                            $"Кузов:{getCond(cars[selectedcar].kusov)}\n" +
                            $"Салон:{getCond(cars[selectedcar].salon)}\n";
            carprice.Text = $"Итоговая цена: {Convert.ToInt64(Convert.ToDouble(cars[selectedcar].price) * getCondMult(cars[selectedcar].getCondSum()))}₽";
        }
        private string getCond(int cond) // вывод состояния частей машины
        {
            if (cond >= 0)
            {
                return conditions[cond];
            }
            else
            {
                return $" {-cond} уровень";
            }
        }
        private void cancelbutton_Click(object sender, EventArgs e) // кнопка отмены
        {
            Instance.Close();
        }
        private void sellbutton_Click(object sender, EventArgs e) // продать
        {
            balance += Convert.ToInt64(Convert.ToDouble(cars[selectedcar].price) * getCondMult(cars[selectedcar].getCondSum()));
            cars[selectedcar] = new Car();

            Instance.DialogResult = DialogResult.OK;
            Instance.Close();
        }
        private double getCondMult(int sum) // возвращает множитель который опирается на состояния деталей
        {
            return 1.0 - 0.05 * sum;
        }
    }
}
