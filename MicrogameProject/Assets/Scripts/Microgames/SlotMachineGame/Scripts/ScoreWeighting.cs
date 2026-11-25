using System;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWeighting : MonoBehaviour
{
    public enum ResultSprites{Cherry, Lemon, Melon, Heart, Bar, BarBar, BarBarBar, Clover, Cleat, Bell, Sevens}
    [SerializeField] private List<WinCons> winconditions = new List<WinCons>();
    public Dictionary<ResultSprites, WinCons> matchvaluecheck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    public struct WinCons
    {
       public ResultSprites resultSprites;
       public int twomatch;
       public int threematch;
       public int matchvalue;
    }

    

}
