using System;
using CarClasses;
class Program
{
    static void Main()
    {
        Car nexia = new Car("Neksiya II", "Daewoo", 2014, 1100);
        nexia.Speed = 250;
        Console.WriteLine(nexia.GetCarInfo());
        Console.WriteLine($"Tezligi: {nexia.Speed} km/h");
        Console.WriteLine($"{nexia.Name} avtomobilining {nexia.Year} - 2025-yil oraliqdagi pasaygan narxi: {nexia.CalculateDepreciation(2025)}$");
        nexia.Price = Convert.ToDecimal(nexia.CalculateDepreciation(2020));
        Console.WriteLine(nexia.Price);
    }
}