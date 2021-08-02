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

    /// <summary>Overrides Area() method in base class to return the area of the rectangle </summary>
    public new int Area()
    {
        return this.width * this.height;
    }

    /// <summary>Returns string with width and height of rectangle</summary>
    public override string ToString()
    {
        return $"[Rectangle] {this.width} / {this.height}";
    }
}
