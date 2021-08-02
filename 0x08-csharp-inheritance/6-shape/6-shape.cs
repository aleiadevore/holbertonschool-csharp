using System;

class Shape
{
    /// Throws and exception
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets and sets the private int width</summary>
    public int Width
    {
        get => width;
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
            {
                width = value;
            }
        }
    }

    /// <summary>Gets and sets the private int height</summary>
    public int Height
    {
        get => height;
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
            {
                height = value;
            }
        }
    }
}