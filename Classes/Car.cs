using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerekup.Classes
{
    public class Car
    {
        private static List<List<(string name, Image img)>> cars = new List<List<(string, Image)>> //если хотите изменить и не наводить красоту то просто после изменения напишите яромиру об изменении этого массива
        {                            //Валерий                                        Яромир                                         Николай
            new List<(string, Image)>{("zero", Properties.Resources.car00)},                                                                                                   //0-нет
                                                                            
            new List<(string, Image)>{("Ford Focus",    Properties.Resources.car11),   ("Peel P50",     Properties.Resources.car12),  ("13", Properties.Resources.car00) },     //1-ужасное
            new List<(string, Image)>{("Dodge Caravan", Properties.Resources.car21_2), ("ВАЗ 2107",     Properties.Resources.car22),  ("23", Properties.Resources.car00) },     //2-рыдван
            new List<(string, Image)>{("Dodge Stratus", Properties.Resources.car31),   ("Toyota RAV4",  Properties.Resources.car32),  ("33", Properties.Resources.car00) },     //3-бывало и получше
            new List<(string, Image)>{("Ford Torino",   Properties.Resources.car41),   ("Maybah GLS",   Properties.Resources.car42),  ("43", Properties.Resources.car00) },     //4-добротное
            new List<(string, Image)>{("Buick Special", Properties.Resources.car51),   ("Бананомобиль", Properties.Resources.car52),  ("53", Properties.Resources.car00) }      //5-идеальное состояние
        };

        private static string[] conditions = new string[] 
        {
            "",                 //0
            "ужасное",          //1
            "рыдван",           //2
            "бывало и получше", //3
            "добротное",        //4
            "идеальное"         //5
        };      

        private static string[] descriptions = new string[]
        {
            //11, Peel P50, 13
            "11", "11", "11",
            "Продаю тачку, ездит норм, торг, срочно!", "двс рабочий, кузов ржавый, но ездит.", "Машина дешево, без хлопот, бери и катайся!",
            "13", "13", "13",
            
            //21, ВАЗ 2107, 23
            "21", "21", "21",
            "Не бита, один хозяин.", "ВАЗ 2107, Коробка автомат, чистая.", "ВАЗ 2107, экономичная, в хорошем состоянии.",
            "23", "23", "23",
            
            //31, Toyota RAV4, 33
            "31", "31", "31",
            "тойота рав4 кожаный салон, пробег 60 тыс.", "Toyota RAV4, гарантия до 2026.", "бизнес-комплектация, сервис у дилера.",
            "33", "33", "33",
            
            //Ford Torino, Maybah GLS, 43
            "41", "41", "41",
            "GLS Maybach, 2021, 4.0 V8, индивидуальный заказ, идеальное состояние.", "Mercedes-Maybach GLS, 2023, полный фарш, пробег 45 тыс. км, как новый.", "Maybach GLS 600, 2022, VIP-комплектация, эксклюзивный салон, 1 владелец.",
            "43", "43", "43",
            
            //Buick Special, Бананомобиль, 53
            "51", "51", "51",
            "Самая лучшая машина в мире", "Многие хотят покататься на твоем банане", "Эксклюзивная отделка, полный привод, 500 л.с.",
            "53", "53", "53",
        };


        public int price { get; set; }
        public int img { get; set; }
        public int motor {  get; set; }
        public int trans {  get; set; }
        public int hod {  get; set; }
        public int kusov {  get; set; }
        public int salon {  get; set; }
        private int desc = 0;

        public Car() { //для создания пустого места в гараже
            img = 0;
            price = 0;

            motor = 0;
            trans = 0;
            hod = 0;
            kusov = 0;
            salon = 0;
        }

        public Car(int price, int img, int motor, int trans, int hod, int kusov, int salon)
        {
            this.price = price;
            this.img = img;
            this.motor = motor;
            this.trans = trans;
            this.hod = hod;
            this.kusov = kusov;
            this.salon = salon;
        }

        public Car(int rand) //для создания случайных машин
        {
            var random = new Random();
            if(rand >= 50)
            {
                this.img = 10 + random.Next(0, 3);
                this.price = random.Next(100, 500); //это в тысячах

                for(int i = 0; i < 12; i++)
                {
                    int selected = random.Next(0, 5);

                    if (selected == 0)
                    {
                        if (motor < 3)
                        {
                            this.motor++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 1)
                    {
                        if (trans < 3)
                        {
                            this.trans++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 2)
                    {
                        if (hod < 3)
                        {
                            this.hod++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 3)
                    {
                        if (kusov < 3)
                        {
                            this.kusov++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 4)
                    {
                        if (salon < 3)
                        {
                            this.salon++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            else if(rand >= 25)
            {
                this.img = 20 + random.Next(0, 3);
                this.price = random.Next(500, 2500);

                for (int i = 0; i < 9; i++)
                {
                    int selected = random.Next(0, 5);

                    if (selected == 0)
                    {
                        if (motor < 3)
                        {
                            this.motor++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 1)
                    {
                        if (trans < 3)
                        {
                            this.trans++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 2)
                    {
                        if (hod < 3)
                        {
                            this.hod++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 3)
                    {
                        if (kusov < 3)
                        {
                            this.kusov++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 4)
                    {
                        if (salon < 3)
                        {
                            this.salon++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            else if(rand >= 12)
            {
                this.img = 30 + random.Next(0, 3);
                this.price = random.Next(2500, 12500);

                for (int i = 0; i < 6; i++)
                {
                    int selected = random.Next(0, 5);

                    if (selected == 0)
                    {
                        if (motor < 3)
                        {
                            this.motor++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 1)
                    {
                        if (trans < 3)
                        {
                            this.trans++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 2)
                    {
                        if (hod < 3)
                        {
                            this.hod++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 3)
                    {
                        if (kusov < 3)
                        {
                            this.kusov++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 4)
                    {
                        if (salon < 3)
                        {
                            this.salon++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            else if(rand >= 4)
            {
                this.img = 40 + random.Next(0, 3);
                this.price = random.Next(12500, 62500);

                for (int i = 0; i < 3; i++)
                {
                    int selected = random.Next(0, 5);

                    if (selected == 0)
                    {
                        if (motor < 3)
                        {
                            this.motor++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 1)
                    {
                        if (trans < 3)
                        {
                            this.trans++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 2)
                    {
                        if (hod < 3)
                        {
                            this.hod++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 3)
                    {
                        if (kusov < 3)
                        {
                            this.kusov++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    else if (selected == 4)
                    {
                        if (salon < 3)
                        {
                            this.salon++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
            }
            else
            {
                this.img = 50 + random.Next(0, 3);
                this.price = random.Next(62500, 625000);
            }
            this.price *= 1000;
        }

        public string getName() //будем брать из массива модели по номеру картинки
        { return cars[img/10][img%10].name; }

        public Image getImg() //будем брать из массива модели по номеру картинки
        { return cars[img/10][img%10].img; }

        public int getCond()
        {
            if(motor + trans + hod + kusov + salon > 9)
            {
                return 1;
            }
            else if(motor + trans + hod + kusov + salon > 6)
            {
                return 2;
            }
            else if(motor + trans + hod + kusov + salon > 3)
            {
                return 3;
            }
            else if(motor + trans + hod + kusov + salon > 0)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        public string getCondText()
        { return conditions[getCond()]; }

        public override string ToString()
        {
            return $"{cars[img / 10][img % 10].name}\nСостояние: {conditions[getCond()]}";
        }
        public string PriceToString()
        {
            string pric = price.ToString();

            string returnprice = "";
            for (int i = 0; i < pric.Length; i++)
            {
                returnprice += pric[i];
                if ((pric.Length - i - 1) % 3 == 0)
                {
                    returnprice += " ";
                }
            }

            return returnprice;
        }
        public string generateDesc()
        {
            var rand = new Random();
            if (desc == 0) desc = (img / 10 - 1) * 9 + (img % 10) * 3 + rand.Next(1, 3);
            return descriptions[desc];
        }
    }
}
