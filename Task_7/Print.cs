namespace Task_7;

public class Print
{
    public static void  PrintCar(Car automobile)
    {
        Console.WriteLine($"Авмобиль            марки: {automobile.BrandCar}");
        Console.WriteLine($"                   модель: {automobile._model}");
        Console.WriteLine($"        количество дверей: {automobile.DoorCount}");
        Console.WriteLine($"       количество топлива: {automobile.FuelNow()}");
        Console.WriteLine();

    }
}