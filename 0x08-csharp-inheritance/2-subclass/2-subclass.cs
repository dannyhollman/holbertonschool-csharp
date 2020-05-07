using System;
using System.Collections.Generic;

/// <summary> Obj class </summary>
class Obj
{
    /// <summary> Checks if derivedType is subclass of baseType </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}