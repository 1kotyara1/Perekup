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
        private static string path = ".\\data.txt";

        public static void Save(in List<Car> cars, in long money, in int sold, in int bought, in long spent, in long recieved, in int[] skills, string[] skillsname)
        {
            List<string> data = new List<string>();

            foreach (Car car in cars) 
            {
                data.Add(car.price.ToString());
                data.Add(car.cond.ToString());
                data.Add(car.img.ToString());
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

        public static void Load(out List<Car> cars, out long money, out int sold, out int bought, out long spent, out long recieved, out int[] skills, string[] skillsname)
        {
            int carslen = 6;
            cars = new List<Car>();
            skills = new int[skillsname.Length];

            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);
                int i = 0;

                for(int j = 0; j < carslen; j++)
                {
                    cars.Add(new Car(Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++]), Convert.ToInt32(data[i++])));
                }

                money = (long)Convert.ToDouble(data[i++]);
                sold = Convert.ToInt32(data[i++]);
                bought = Convert.ToInt32(data[i++]);
                spent = Convert.ToInt32(data[i++]);
                recieved = Convert.ToInt32(data[i++]);

                for (int j = 0;j < skillsname.Length; j++)
                {
                    skills[j] = Convert.ToInt32(data[i++]);
                }
            }
            else
            {
                List<string> data = new List<string>();

                for(int j = 0; j < carslen; j++)
                {
                    data.Add("0");
                    data.Add("0");
                    data.Add("0");
                    cars.Add(new Car());
                }

                data.Add("0");
                money = 0;
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
}
