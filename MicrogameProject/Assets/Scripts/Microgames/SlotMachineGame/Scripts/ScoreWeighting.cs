using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWeighting : MonoBehaviour
{
    public enum ResultSprite { Cherry, Lemon, Melon, Heart, Bar, BarBar, BarBarBar, Cleat, Bell, Sevens}

    public ResultSprite a;
    public ResultSprite b;
    public ResultSprite c;
    public Text Scoretext;
    public int CheckLine(ResultSprite[] lineResults)
{
    if (lineResults == null || lineResults.Length < 3) return 0;

    ResultSprite a = lineResults[0];
    ResultSprite b = lineResults[1];
    ResultSprite c = lineResults[2];


    if (a == b && b == c)
    {
        return a switch
        {
            ResultSprite.Cherry => 100,
            ResultSprite.Lemon => 200,
            ResultSprite.Melon => 300,
            ResultSprite.Heart => 400,
            ResultSprite.Bar => 1000,
            ResultSprite.BarBar => 2000,
            ResultSprite.BarBarBar => 3000,
            ResultSprite.Cleat => 5000,
            ResultSprite.Bell => 6000,
            ResultSprite.Sevens => 7777,
            _ => 50
        };
    }
    
        

    if (a == ResultSprite.Cherry && b == ResultSprite.Cherry)
    {
        return 10;
    }
    if (a == ResultSprite.Lemon && b == ResultSprite.Lemon)
    {
        return 20;
    }
    if (a == ResultSprite.Melon && b == ResultSprite.Melon)
    {
        return 30;
    }
    if (a == ResultSprite.Heart && b == ResultSprite.Heart)
    {
        return 40;
    }
    if (a == ResultSprite.Bar && b == ResultSprite.Bar)
    {
        return 100;
    }
    if (a == ResultSprite.BarBar && b == ResultSprite.BarBar)
    {
        return 200;
    }
    if (a == ResultSprite.BarBarBar && b == ResultSprite.BarBarBar)
    {
        return 300;
    }
    if (a == ResultSprite.Cleat && b == ResultSprite.Cleat)
    {
        return 500;
    }
    if (a == ResultSprite.Bell && b == ResultSprite.Bell)
    {
        return 600;
    }
    if (a == ResultSprite.Sevens && b == ResultSprite.Sevens)
    {
        return 777;
    }
    

    return 0;
    //Forgot to make it work if A and C matched. Oops.
}
}