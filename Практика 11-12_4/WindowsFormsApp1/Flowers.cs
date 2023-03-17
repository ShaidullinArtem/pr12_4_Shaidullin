using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Flowers
    {
        public string name;
        public string type;
        public string color;
        public string createCountry;
        private double price;
        public int countFlowers;
        public double priceOneFlower;
        public int dayWeek;
        private double sales;
        private double lenght;
        public double GetPrice
        {
            get
            {
                price = priceOneFlower * countFlowers * sales;
                return price;
            }
            set
            {
                price = priceOneFlower * countFlowers * sales;
            }
        }
        public double GetLenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }
        public string GetInfo()
        {
            string result = $"Название: {name}\nТип: {type}\nОттенок: {color}\n" +
                $"Старана-производитель: {createCountry}\nЦена за 1 цветок: {priceOneFlower}\n" +
                $"Длина стебеля: {GetLenght}\nДень недели: {dayWeek}\nСтоимость: {GetPrice}";
            return result;
        }

        public double Sale()
        {
            if (dayWeek == 6 || dayWeek == 7) sales = 0.9;
            else sales = 1;
            return sales;
        }
    }
}
