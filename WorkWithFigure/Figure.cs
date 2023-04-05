namespace WorkWithFigure;

public class Figure
{
    private double _a,_b,_c;
    private double _perimetr;
 

    public double Perimetr
    {
        get => _perimetr;
        set => _perimetr = value;
    }
     
    
     
    public Figure()
    {
    }

    public Figure(double a)
    {
        _a = a;
    }

    public Figure(double a, double b)
    {
        _a = a;
        _b = b;
    }

    public Figure(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double perimetrCyrcle(double a)
    {
        // а = диаметр
        double perimetr = 3.141592 * a;
        return perimetr;
    }

    public double perimetrSquare(double a, double b)
    {
        double perimetr = (a * 2) + (b * 2);
        return perimetr;
    }

    public double perimetrTriangl(double a, double b, double c)
    {
        double perimetr = (a + b + c);    
        return perimetr;                    
    }



    
    
}    


