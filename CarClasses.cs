using System;
using System.ComponentModel;
namespace CarClasses
{
    class Car
    {
        string _model = "None";
        int _year = 0;
        decimal _price = 0m;
        decimal _speed = 0m;
        public string Model { get {return _model;} set {_model = value;} }
        public int Year { get {return _year;} set {_year = value;} }
        public decimal Price { get {return _price;} set {_price = value;} }
        public decimal Speed { get {return _speed;} set {_speed = value;} }
        public string Name { get; set; }
        public Car(string CarNames, string CarModels, int CarYears, decimal CarPrices)
        {
            Name = CarNames;
            Model = CarModels;
            Year = CarYears;
            Price = CarPrices;
        }
        public string GetCarInfo()
        {
            return $"       < {Name.ToUpper()} avtomobili > \nModeli: {_model} \nIshlab chiqarilgan yili: {_year} \nNarxi: {_price}$";
        }
        public double CalculateDepreciation(int PassYears)
        {
            const double percent = 0.1;
            double reduction = (double)Price*Math.Pow((1-percent), (PassYears-Year));
            return reduction;
        }
    }
}