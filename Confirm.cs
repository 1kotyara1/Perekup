using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPerekup
{
    public partial class Confirm : Form
    {
        // создание окна
        private static Confirm _Instance = new Confirm();
        public static Confirm Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new Confirm();
                }
                _Instance.Icon = (Icon)_Instance.resources.GetObject("$this.Icon");
                return _Instance;
            }
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));


        public Confirm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // удалить
        {
            DialogResult = DialogResult.OK;
            Instance.Close();
        }

        private void button1_Click(object sender, EventArgs e) // отмена
        {
            DialogResult = DialogResult.Cancel;
            Instance.Close();
        }
    }
}
