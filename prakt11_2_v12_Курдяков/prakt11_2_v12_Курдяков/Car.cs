using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11_2_v12_Курдяков
{
    public class Сar : Form1
    {
        private string brand;
        private int cilinder;
        private double power;
        public Сar() //конструктор по умолчанию
        {
            brand = "Toyota";
            cilinder = 0;
            power = 0.0;
        }
        public Сar(string brand, int cilinder, double power) //конструктор с параметрами
        {
            this.brand = brand;
            this.cilinder = cilinder;
            this.power = power;
        }
        ~Сar() //деструктор
        {
            //освобождение ресурсов
        }
        public virtual string Sprg() //печать
        {
            return $"Марка: {brand}.\n Цилиндры: {cilinder}.\n Мощность: {power}.";
        }
        public void Brand(string newBrand)
        {
            brand = newBrand;
        }
    }
}
