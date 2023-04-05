namespace Task_7;

public class Car
{
    // объявляем поле типа int
    private int _fuel;
    private int _fuelMax  = 100;
    private int _fuelMin  = 0;
    public string _model = "";
    private int _doorCount;

    public int DoorCount {
        get {
            return _doorCount;
        }
        set
        {
            if ((value <= 5)&&(value != null))
            {
                _doorCount = value;
            }
            else
            {
                _doorCount = 4;
            }
        }
    }
    public string BrandCar {get; set; }
    
    
        

    // определяем 2 конструктора для введенныого уровня топлива
    public Car() {_fuel = 50;}
    public Car(int f) {_fuel = f;}
    public Car(int f,string model): this(f) { _model = model;}
    
    
    
    
    
    public int FuelNow()
    {
        return _fuel;
    }

    public int FuelUp( int fuelUp)
    {
        if ((_fuel + fuelUp) < _fuelMax)
        {
            Console.WriteLine($"Вы заправили {fuelUp}л");
            _fuel = _fuel + fuelUp;
            return _fuel;
        }
        else
        {
            Console.WriteLine("Вы не заправились бак будет переполнен");
            return _fuel;
        }
    }
    
    public int FuelDown( int fuelDown)
    {
        if ((_fuel - fuelDown) > _fuelMin)
        {
            Console.WriteLine($"Вы израсходовали {fuelDown}л");
            _fuel = _fuel - fuelDown;
            return _fuel;
        }
        else
        {
            Console.WriteLine("Вы не можете истратить топлива больше чем есть в баке");
            return _fuel;
        }
    }


}