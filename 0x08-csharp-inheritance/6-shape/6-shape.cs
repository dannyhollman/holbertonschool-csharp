using System;

/// <summary> Shape class </summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> Rectangle class, inherits from Shape </summary>
class Rectangle : Shape
{
    /// rectangle width
    private int width;
    /// rectangle height
    private int height;

    /// <summary> Rectangle width constructor </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    /// <summary> Rectanlge height constructor </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}