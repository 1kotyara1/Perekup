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
    }
}
