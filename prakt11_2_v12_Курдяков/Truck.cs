using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11_2_v12_Курдяков
{
    public class Truck : car
    {
        private double gruz; //конструктор по умолчанию
        public Truck() : base() //базовый конструктор
        {
            gruz = 0.0;
        }
        public Truck(string brand, int cilinder, double power, double gruz) : base(brand, cilinder, power)
        {
            this.gruz = gruz;
        }
        ~Truck() //деструктор
        {
            //освобождение ресурсов
        }
        public override string Sprg() //печать
        {
            return base.Sprg() + $" Грузоподъёмность: {gruz} тон.";
        }
        public void Gruz(double newGruz)
        {
            gruz = newGruz;
        }

    }
}
