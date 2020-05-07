using System;
using System.Collections.Generic;

/// <summary> Obj class </summary>
class Obj
{
    /// <summary> Checks if object is instance/inherits from Array </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}