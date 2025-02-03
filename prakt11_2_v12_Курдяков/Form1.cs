using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt11_2_v12_Курдяков
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car Car = new car("Toyota ", 4, 150);
            Car.Sprg();
            Truck truck = new Truck("Volvo ", 6, 400, 10);
            truck.Sprg();
            Car.Brand("Mazda ");
            truck.Gruz(12);
            listBox1.Items.Add(Car.Sprg() + "\n\n");
            listBox1.Items.Add(truck.Sprg() + "\n\n");
        }
    }
}
