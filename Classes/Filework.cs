using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerekup.Classes
{
    internal class Filework
    {
        private static string folder = "C:\\Users\\admin\\AppData\\Local\\ProjectPerekup";         // папка с сохранением
        private static string path = "C:\\Users\\admin\\AppData\\Local\\ProjectPerekup\\data.txt"; // путь к сохранению


        // сохранение
        public static void Save(in List<Car> cars, in long money, in int sold, in int bought, in ulong spent, in ulong recieved, in int[] skills, string[] skillsname)
        {
            // изменяет сохранение
            // если его нет то создает новое сохранение

            if (Directory.Exists(folder))
            {
                List<string> data = new List<string>();

                foreach (Car car in cars)
                {
                    data.Add(car.price.ToString());
                    data.Add(car.img.ToString());

                    data.Add(car.motor.ToString());
                    data.Add(car.trans.ToString());
                    data.Add(car.hod.ToString());
                    data.Add(car.kusov.ToString());
                    data.Add(car.salon.ToString());
                }

                data.Add(money.ToString());
                data.Add(sold.ToString());
                data.Add(bought.ToString());
                data.Add(spent.ToString());
                data.Add(recieved.ToString());

                foreach (int i in skills)
                {
                    data.Add(i.ToString());
                }

                File.WriteAllLines(path, data);
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(folder);
                List<string> data = new List<string>();

                foreach (Car car in cars)
                {
                    data.Add(car.price.ToString());
                    data.Add(car.img.ToString());

                    data.Add(car.motor.ToString());
                    data.Add(car.trans.ToString());
                    data.Add(car.hod.ToString());
                    data.Add(car.kusov.ToString());
                    data.Add(car.salon.ToString());
                }

                data.Add(money.ToString());
                data.Add(sold.ToString());
                data.Add(bought.ToString());
                data.Add(spent.ToString());
                data.Add(recieved.ToString());

                foreach (int i in skills)
                {
                    data.Add(i.ToString());
                }

                File.WriteAllLines(path, data);
            }
        }


        // чтение
        public static void Load(out List<Car> cars, out long money, out int sold, out int bought, out ulong spent, out ulong recieved, out int[] skills, string[] skillsname)
        {
            int carslen = 6;
            cars = new List<Car>();
            skills = new int[skillsname.Length];

            if (!Directory.Exists(folder))
            {
                DirectoryInfo di = Directory.CreateDirectory(folder);
            }

            // проверка на существование сохранения
            if (File.Exists(path))
            {
                // если читает и происходит ошибка - удаляет сохранение
                // не придумал что делать с плохим сохранением
                // ну вроде как оно должно ломаться только если человек плохо изменил вручную сови данные
                try
                {
                    string[] data = File.ReadAllLines(path);
                    int i = 0;

                    for (int j = 0; j < carslen; j++)
                    {
                        cars.Add(new Car(Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++])));
                    }

                    money = (long)Convert.ToDouble(data[i++]);
                    sold = Convert.ToInt32(data[i++]);
                    bought = Convert.ToInt32(data[i++]);
                    spent = Convert.ToUInt64(data[i++]);
                    recieved = Convert.ToUInt64(data[i++]);

                    for (int j = 0; j < skillsname.Length; j++)
                    {
                        skills[j] = Convert.ToInt32(data[i++]);
                    }
                }
                catch 
                {
                    CreateBlankFile(out cars, out money, out sold, out bought, out spent, out recieved, out skills, skillsname);
                }
            }
            else
            {
                // создание и загрузка пустых данных в приложение
                CreateBlankFile(out cars, out money, out sold, out bought, out spent, out recieved, out skills, skillsname);
            }
        }


        // удаление
        public static void DeleteFile()
        {
            // удалить
            File.Delete(path);
        }


        // создание
        public static void CreateBlankFile(out List<Car> cars, out long money, out int sold, out int bought, out ulong spent, out ulong recieved, out int[] skills, string[] skillsname)
        {
            // создает и загружает пустые данные в приложение и в сохранение

            if (!Directory.Exists(folder))
            {
                DirectoryInfo di = Directory.CreateDirectory(folder);
            }

            int carslen = 6;
            cars = new List<Car>();
            skills = new int[skillsname.Length];
            List<string> data = new List<string>();

            for (int j = 0; j < carslen; j++)
            {
                data.Add("0");
                data.Add("0");

                data.Add("0");
                data.Add("0");
                data.Add("0");
                data.Add("0");
                data.Add("0");
                cars.Add(new Car());
            }

            data.Add("100000");
            money = 100000;
            data.Add("0");
            sold = 0;
            data.Add("0");
            bought = 0;
            data.Add("0");
            spent = 0;
            data.Add("0");
            recieved = 0;

            for (int j = 0; j < skillsname.Length; j++)
            {
                data.Add("0");
                skills[j] = 0;
            }

            File.WriteAllLines(path, data);
        }
    }
}
