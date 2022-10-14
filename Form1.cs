using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_8_Winforms_And_Lists
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<Car> audis = new List<Car>();
        // Todays focus
        // Working with lists
        // Displaying information
        // Create class methods
        // Finding and displaying info from a list
        public Form1()
        {
            InitializeComponent();
            Preload();





        } // Form1

        public void Preload()
        {
            Car car1 = new Car("Hyundai", "Sonata");
            car1.Color = Color.Silver;
            car1.Year = 2011;
            car1.Mileage = 80000;

            Car car2 = new Car("Toyota", "4 Runner");
            car2.Color = Color.Red;
            car2.Year = 2011;
            car2.Mileage = 80000;

            Car car3 = new Car("Subaru", "Brat");
            car3.Color = Color.Orange;
            car3.Year = 2011;
            car3.Mileage = 80000;

            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));
            audis.Add(new Car("Audi", "TT"));

            cars.Add(car1);
            cars.Add(car3);
            cars.Add(car2);

            DisplayCars(audis);


        } // Preload()

        // Display cars in list
        public void DisplayCars(List<Car> list)
        {

            foreach (Car car in list)
            {
                rtbDisplay.Text += $"{car.Year} {car.Make} {car.Model}\n" +
                 $"Color: {car.Color}\n" +
                 $"Mileage: {car.Mileage}\n\n";
            }
        }


    } // class

} // namespace
