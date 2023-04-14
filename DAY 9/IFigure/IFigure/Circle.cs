using System;



internal class Program
{
    private static void Main(string[] args)
    {
        IFigure fig = new Circle();
        fig.Dimension = 10;
        
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.perimeter());
    }
}

    class Circle : IFigure
{
    private int _Radius;
    private int Dimension
    {
        get { return _Radius; }
        set { _Radius = value; }
    }

   

    public double Area()
    {
        return Math.PI * _Radius * _Radius;
            
    }
    
    public double perimeter() 
    { 
        return Math.PI * 2 * _Radius;
    }
}
