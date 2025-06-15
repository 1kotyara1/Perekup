using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerekup.Classes
{
    public class Car
    {
        // массив машин
        private static List<List<(string name, Image img)>> cars = new List<List<(string, Image)>> //если хотите изменить и не наводить красоту то просто после изменения напишите яромиру об изменении этого массива
        {                            //Валерий                                        Яромир                                         Николай
            new List<(string, Image)>{("zero", Properties.Resources.car00)},                                                                                                   //0-нет
                                                                            
            new List<(string, Image)>{("Ford Focus",    Properties.Resources.car11),   ("Peel P50",     Properties.Resources.car12),  ("Москвич-400", Properties.Resources.car13)       },     //1-ужасное
            new List<(string, Image)>{("Dodge Caravan", Properties.Resources.car21_2), ("ВАЗ 2107",     Properties.Resources.car22),  ("Daewoo Matiz", Properties.Resources.car23)      },     //2-рыдван
            new List<(string, Image)>{("Dodge Stratus", Properties.Resources.car31),   ("Toyota RAV4",  Properties.Resources.car32),  ("Buick Special", Properties.Resources.car33)     },     //3-бывало и получше
            new List<(string, Image)>{("Ford Torino",   Properties.Resources.car41),   ("Maybah GLS",   Properties.Resources.car42),  ("Cadillac Brougham", Properties.Resources.car43) },     //4-добротное
            new List<(string, Image)>{("Buick Special", Properties.Resources.car51),   ("Бананомобиль", Properties.Resources.car52),  ("Buick Roadmaster", Properties.Resources.car53)  }      //5-идеальное состояние
        };

        // массив состояний машины
        private static string[] conditions = new string[] 
        {
            "",                 //0
            "ужасное",          //1
            "рыдван",           //2
            "нормальное", //3
            "добротное",        //4
            "идеальное"         //5
        };      

        // массив описаний для авито
        private static string[] descriptions = new string[]
        {
            //Ford Focus, Peel P50, Москвич-400
            "2014, 1.6 MT, не бит, ходовая отличная.", "пробег 90 ткм, один хозяин, ТО свежее, торг.", "полный пакет, климат, камера, идеальное состояние.",
            "Продаю тачку, ездит норм, торг, срочно!", "двс рабочий, кузов ржавый, но ездит.", "Машина дешево, без хлопот, бери и катайся!",
            "1956 год, полностью на ходу, родной двигатель.", "документы, оригинальный кузов, торг.", "1954, требует ремонта, полный комплект запчастей.",
            
            //Dodge Caravan, ВАЗ 2107, Daewoo Matiz
            "2012, 3.6L, автомат, 7 мест, кондей.", "в отличном состоянии, пробег 120 ткм, не бит.", "2015 полный пакет, DVD, подогревы, сервисная история.",
            "Не бита, один хозяин.", "ВАЗ 2107, Коробка автомат, чистая.", "ВАЗ 2107, экономичная, в хорошем состоянии.",
            "2008, 0.8 л, механика, расход 5л, не бита.", "Матиз, 2010, пробег 85 ткм, ходовая целая, торг уместен.", "2012, кондей, электростеклоподъемники, один хозяин.",
            
            //Dodge Stratus, Toyota RAV4, Buick Special
            "2003, 2.4L, автомат, кондей, не бит.", "Стратус в ходовом состоянии, пробег 150 ткм, торг.", "2005, полная электропакет, салон без дефектов.",
            "тойота рав4 кожаный салон, пробег 60 тыс.", "Toyota RAV4, гарантия до 2026.", "бизнес-комплектация, сервис у дилера.",
            "1965, требует ремонта, двигатель заводится.", "Спешиал в плохом состоянии, кузов с ржавчиной, на запчасти.", "Бьюик 60-х, не на ходу, редкий экземпляр для реставрации.",
            
            //Ford Torino, Maybah GLS, Cadillac Brougham
            "1972, V8 5.8L, оригинальный кузов, на ходу.", "Торино 1975, полный комплект, требует вложений, редкий.", "Torino GT, 1970, matching numbers, музейное состояние.",
            "GLS Maybach, 2021, 4.0 V8, индивидуальный заказ, идеальное состояние.", "Mercedes-Maybach GLS, 2023, полный фарш, пробег 45 тыс. км, как новый.", "Maybach GLS 600, 2022, VIP-комплектация, эксклюзивный салон, 1 владелец.",
            "Cadillac Brougham, 1987, 5.0L, кожа, электростеклоподъемники.", "1989, пробег 60 ткм, ухоженный, все опции.", "Caddy Brougham, 1992, последний год выпуска, коллекция.",
            
            //Buick Special, Бананомобиль, Buick Roadmaster
            "1967, полностью восстановлен, музейное состояние.", "Спешиал в идеале, родной двигатель, документы, коллекция.", "Бьюик 67 года, 100% оригинал, ухоженный салон, раритет.",
            "Самая лучшая машина в мире", "Многие хотят покататься на твоем банане", "Эксклюзивная отделка, полный привод, 500 л.с.",
            "1994, 5.7L V8, автомат, американский диван.", "Родмастер в хорошем состоянии, пробег 90 ткм, мощный мотор.", "Roadmaster, 1996, кожаный салон, хром, культовый седан 90-х.",
        };


        // общая информация
        public int price { get; set; }
        public int img { get; set; }
        // проблемы
        public int motor {  get; set; }
        public int trans {  get; set; }
        public int hod {  get; set; }
        public int kusov {  get; set; }
        public int salon {  get; set; }
        // запоминание номера описания в авито
        private int desc = 0; 


        // создание машин
        public Car() //для создания пустой машины
        { 
            img = 0;
            price = 0;

            motor = 0;
            trans = 0;
            hod = 0;
            kusov = 0;
            salon = 0;
        }
        public Car(int price, int img, int motor, int trans, int hod, int kusov, int salon) // передача машины
        {
            this.price = price;
            this.img = img;
            this.motor = motor;
            this.trans = trans;
            this.hod = hod;
            this.kusov = kusov;
            this.salon = salon;
        }
        public Car(Car c)
        {
            this.price = c.price;
            this.img = c.img;
            this.motor = c.motor;
            this.trans = c.trans;
            this.hod = c.hod;
            this.kusov = c.kusov;
            this.salon = c.salon;
        }
        public Car(int rand) // для создания случайных машин 
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


        // помощники
        public string getName() // вывод имени из массива
        { return cars[img/10][img%10].name; }
        public Image getImg() // вывод картинки
        { return cars[img/10][img%10].img; }
        public int getCond() // вывод номера состояния(по количеству проблем в машине)
        {
            if(getCondSum() > 9)
            {
                return 1;
            }
            else if(getCondSum() > 6)
            {
                return 2;
            }
            else if(getCondSum() > 3)
            {
                return 3;
            }
            else if(getCondSum() > 0)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        public string getCondText() // вывод текста состояния
        { return conditions[getCond()]; }
        public int getCondSum() // вывод суммы количества проблем в машине
        {
            return motor + trans + hod + kusov + salon;
        }
        private double getCondMult(int sum) // вывод множителя для цен(по количеству проблем в машине)
        {
            return 1.0 - 0.05 * sum;
        }
        public string generateDesc() // вывод описания в авито
        {
            var rand = new Random();
            if (desc == 0) desc = (img / 10 - 1) * 9 + (img % 10) * 3 + rand.Next(1, 3);
            return descriptions[desc];
        }
        public string PriceToString() // вывод цены машины в авито
        {
            string pric = Convert.ToInt64(Convert.ToDouble(price) * getCondMult(getCondSum())).ToString();

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
        public override string ToString() // вывод информации в гараже
        {
            return $"{cars[img / 10][img % 10].name}\nСостояние: {conditions[getCond()]}";
        }
        public string ToString(int a) // вывод информации при продаже
        {
            return $"{cars[img / 10][img % 10].name}\n{conditions[getCond()]}";
        }
    }
}
