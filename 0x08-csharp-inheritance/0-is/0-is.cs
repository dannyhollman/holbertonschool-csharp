using System;

/// <summary> Obj class </summary>
class Obj
{
    /// <summary> Checks if object is int </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        return false;
    }
}