using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPerekup
{
    public partial class LieCalc : Form
    {
        private string[] conditions = { "нет повреждений", "лёгкие повреждения", "средние повреждения", "тяжелые повреждения" };
        private static LieCalc _Instance = new LieCalc();
        public static LieCalc Instance
        {
            get
            {
                if (_Instance == null || _Instance.IsDisposed)
                {
                    _Instance = new LieCalc();
                }
                _Instance.Icon = (Icon)_Instance.resources.GetObject("$this.Icon");
                return _Instance;
            }
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perekup));


        private (PictureBox minus, Label num, PictureBox plus)[] buttons;
        public int[] lies;
        private int[] details;

        public LieCalc()
        {
            InitializeComponent();
        }

        public void LoadForm(int m, int t, int h, int k, int s)
        {
            lies = new int[5] { CarSell.lMotor, CarSell.lTrans, CarSell.lHod, CarSell.lKusov, CarSell.lSalon };
            details = new int[5] { m, t, h, k, s };

            if (buttons == null)
            {
                buttons = new (PictureBox minus, Label num, PictureBox plus)[6];

                for (int i = 0; i < buttons.Length - 1; i++)
                {
                    buttons[i].minus = new PictureBox();
                    buttons[i].minus.Image = Properties.Resources.minus;
                    buttons[i].minus.Width = label1.Height;
                    buttons[i].minus.Height = label1.Height;
                    buttons[i].minus.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttons[i].minus.BackColor = Color.FromArgb(200, 200, 200);
                    buttons[i].minus.BorderStyle = BorderStyle.FixedSingle;
                    Instance.Controls.Add(buttons[i].minus);

                    buttons[i].num = new Label();
                    buttons[i].num.Width = label1.Width - (label1.Height + 6) * 2;
                    buttons[i].num.Height = label1.Height;
                    buttons[i].num.BackColor = Color.FromArgb(200, 200, 200);
                    buttons[i].num.Font = new Font("Segoe UI", 14);
                    buttons[i].num.TextAlign = ContentAlignment.MiddleCenter;
                    buttons[i].num.BorderStyle = BorderStyle.FixedSingle;
                    Instance.Controls.Add(buttons[i].num);

                    buttons[i].plus = new PictureBox();
                    buttons[i].plus.Image = Properties.Resources.plus;
                    buttons[i].plus.Width = label1.Height;
                    buttons[i].plus.Height = label1.Height;
                    buttons[i].plus.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttons[i].plus.BackColor = Color.FromArgb(200, 200, 200);
                    buttons[i].plus.BorderStyle = BorderStyle.FixedSingle;
                    Instance.Controls.Add(buttons[i].plus);
                }

                /* добавляем функции для кнопок */
                {
                    buttons[0].minus.Click += (sender, e) => { minusClick(0); };
                    buttons[0].plus.Click += (sender, e) => { plusClick(0); };
                    buttons[1].minus.Click += (sender, e) => { minusClick(1); };
                    buttons[1].plus.Click += (sender, e) => { plusClick(1); };
                    buttons[2].minus.Click += (sender, e) => { minusClick(2); };
                    buttons[2].plus.Click += (sender, e) => { plusClick(2); };
                    buttons[3].minus.Click += (sender, e) => { minusClick(3); };
                    buttons[3].plus.Click += (sender, e) => { plusClick(3); };
                    buttons[4].minus.Click += (sender, e) => { minusClick(4); };
                    buttons[4].plus.Click += (sender, e) => { plusClick(4); };
                }

                /* инициализация кнопок для "везде" */
                {
                    buttons[5].minus = new PictureBox();
                    buttons[5].minus.Image = Properties.Resources.minus;
                    buttons[5].minus.Width = label1.Height;
                    buttons[5].minus.Height = label1.Height;
                    buttons[5].minus.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttons[5].minus.BackColor = Color.FromArgb(200, 200, 200);
                    buttons[5].minus.Click += (sender, e) => { minusClick(-1); };
                    buttons[5].minus.BorderStyle = BorderStyle.FixedSingle;
                    Instance.Controls.Add(buttons[5].minus);

                    buttons[5].plus = new PictureBox();
                    buttons[5].plus.Image = Properties.Resources.plus;
                    buttons[5].plus.Width = label1.Height;
                    buttons[5].plus.Height = label1.Height;
                    buttons[5].plus.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttons[5].plus.BackColor = Color.FromArgb(200, 200, 200);
                    buttons[5].plus.Click += (sender, e) => { plusClick(-1); };
                    buttons[5].plus.BorderStyle = BorderStyle.FixedSingle;
                    Instance.Controls.Add(buttons[5].plus);
                }
            }

            resize();
            updButton(-1);
        }

        private void resize()
        {
            buttons[0].minus.Location = new Point(14, 67);
            buttons[0].num.Location = new Point(72, 67);
            buttons[0].plus.Location = new Point(260, 67);

            buttons[1].minus.Location = new Point(14, 265);
            buttons[1].num.Location = new Point(72, 265);
            buttons[1].plus.Location = new Point(260, 265);

            buttons[2].minus.Location = new Point(14, 464);
            buttons[2].num.Location = new Point(72, 464);
            buttons[2].plus.Location = new Point(260, 464);

            buttons[3].minus.Location = new Point(321, 67);
            buttons[3].num.Location = new Point(379, 67);
            buttons[3].plus.Location = new Point(566, 67);

            buttons[4].minus.Location = new Point(321, 265);
            buttons[4].num.Location = new Point(379, 265);
            buttons[4].plus.Location = new Point(566, 265);

            buttons[5].minus.Location = new Point(416, 464);
            buttons[5].plus.Location = new Point(473, 464);
        }


        private void updButton(int i)
        {
            if (i == -1)
            {
                for (int j = 0; j < buttons.Length - 1; j++)
                {
                    buttons[j].num.Text = getCond(-lies[j] + details[j]);
                    if (lies[j] == 0) buttons[j].num.ForeColor = Color.Green;
                    else buttons[j].num.ForeColor = Color.Red;
                }
            }
            else
            {
                buttons[i].num.Text = getCond(-lies[i] + details[i]);
                if (lies[i] == 0) buttons[i].num.ForeColor = Color.Green;
                else buttons[i].num.ForeColor = Color.Red;
            }
        }
        private void minusClick(int i)
        {
            if (i == -1)
            {
                for (int j = 0; j < details.Length; j++)
                {
                    if (lies[j] != 0) lies[j]--;
                }
                updButton(-1);
            }
            else if (lies[i] != 0)
            {
                lies[i]--;
                updButton(i);
            }
        }
        private void plusClick(int i)
        {
            if (i == -1)
            {
                for (int j = 0; j < details.Length; j++)
                {
                    if (details[j] - lies[j] > -6) lies[j]++;
                }
                updButton(-1);
            }
            else if (details[i] - lies[i] > -6)
            {
                lies[i]++;
                updButton(i);
            }
        }
        private string getCond(int cond) // возвращает текст для label в зависимости от состояния определенного элемента машины
        {
            if (cond >= 0)
            {
                return $"{conditions[cond]}";
            }
            else
            {
                return $"{-cond} уровень";
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Instance.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            { lies[i] = 0; }
            Instance.Close();
        }
    }
}
