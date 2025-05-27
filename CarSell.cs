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

        static long balance;
        static List<Car> cars;

        public static void SendData(long editbalance, List<Car> editcars)
        {
            balance = editbalance;
            cars = editcars;
            Instance.InitializeForm();
        }
        public static void RecieveData(out long sendbalance, out List<Car> sendcars)
        {
            sendbalance = balance;
            sendcars = cars;
        }

        public CarSell()
        {
            InitializeComponent();
        }

        private void InitializeForm()
        {

        }
        private void CarSell_Resize(object sender, EventArgs e)
        {
            int width = Width - 16;
            int height = Height - 39;

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
        }

    }
}
