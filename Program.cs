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
        Console.WriteLine($"{nexia.Name} avtomobilining {nexia.Year} yildan beri pasaygan narxi: {nexia.CalculateDepreciation(2025)}$");
    }
}