using System;



        class Square : IFigure
{
            
            public int _Dimension
            {
                get { return _Dimension; }
                        
                set { _Dimension = value; }
            }

   

    public double Area()
            {
                return _Dimension * _Dimension;

            }
            public double perimeter()
            {
                return   4 * _Dimension;
            }
        }
    

