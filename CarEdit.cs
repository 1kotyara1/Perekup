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
        private static CarEdit _Instance = new CarEdit();
        public static CarEdit Instance
        {
            get
            {
                if (_Instance == null && _Instance.IsDisposed)
                {
                    _Instance = new CarEdit();
                }
                else
                {
                    _Instance = new CarEdit();
                }
                return _Instance;
            }
        }

        static long balance;
        static Car car;
        

        static void RecieveData(long editbalance, Car editcar)
        {
            balance = editbalance;
            car = editcar;
        }
        static void sendData(out long sendbalance, out Car sendcar)
        {
            sendbalance = balance;
            sendcar = car;
        }

        public CarEdit()
        {
            InitializeComponent();
        }

        
    }
}