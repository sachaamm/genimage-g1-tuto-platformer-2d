using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Screen;

public static class Responsive
{
    public static float ResponsiveHeight()
    {
        return (float)Screen.height / 593;
    }
    
    public static float ResponsiveWidth()
    {
        return (float)Screen.width / 750;
    }

    public static float ResponsiveRatio()
    {
        return ResponsiveWidth() * ResponsiveHeight();
    }
    
}
