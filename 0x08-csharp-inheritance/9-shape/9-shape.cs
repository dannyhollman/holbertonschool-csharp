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
    /// <summary> Returns the rectangles area </summary>
    public new int Area()
    {
        return height * width;
    }
    /// <summary> ToString override </summary>
    public override string ToString()
    {
        string temp = String.Format("[Rectangle] {0} / {1}", width, height);
        return temp;
    }
}
/// <summary> Square class, inherits from rectangle </summary>
class Square : Rectangle
{
    /// Square size
    private int size;

    /// <summary> Size constructor for Square </summary>
    public int Size
    {
        get
        {
            return size;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            this.Width = value;
            this.Height = value;
        }
    }
    /// <summary> ToString override </summary>
    public override string ToString()
    {
        string temp = String.Format("[Square] {0} / {0}", size);
        return temp;
    }

}