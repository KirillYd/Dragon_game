using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LoadLevel
{
    private static int count;
    public static int Count
    {
        get { return count; }
        set { count = value; }
    }

    public static bool[] levels = new bool[4] {true, false ,false ,false };
}
