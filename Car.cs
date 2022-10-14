using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Winforms_And_Lists
{
    public class Car
    {

        // fields 
        string _make;
        string _model;
        Color _color;
        int _year;
        double _mileage;

        // constructor
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
        }



        // property
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public Color Color { get => _color; set => _color = value; }
        public int Year { get => _year; set => _year = value; }
        public double Mileage { get => _mileage; set => _mileage = value; }





        // method


    } // class

} // namespace
