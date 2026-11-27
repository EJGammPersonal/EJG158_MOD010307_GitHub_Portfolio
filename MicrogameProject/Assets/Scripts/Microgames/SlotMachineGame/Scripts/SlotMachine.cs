using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;

public class SlotMachine : MonoBehaviour



{
    public bool GameOn;
    public ScoreWeighting scoreWeighting;
    public int SlotValue; 
    public int SlotSpinCount;
    public GameObject Cherry;
    public GameObject Melon;
    public GameObject Lemon;
    public GameObject Heart;
    public GameObject Bar;
    public GameObject BarBar;
    public GameObject BarBarBar;
    public GameObject Cleat;
    public GameObject Bell;
    public GameObject Clover;
    public GameObject Sevens;
    public GameObject SlotCylinder;
    public bool Switch = false;
    public Transform slotLocation;
    private GameObject currentResult;
    
    [SerializeField] private GameObject[] SlotSprites;
    List<GameObject> SlotResults = new List<GameObject>();
    public int[] weightedChance = {15, 15, 15, 15, 15, 10, 5, 5, 2, 2, 1};
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public void Start()
    {
        SlotResults.Add(Cherry);
        SlotResults.Add(Melon);
        SlotResults.Add(Lemon);
        SlotResults.Add(Heart);
        SlotResults.Add(Bar);
        SlotResults.Add(BarBar);
        SlotResults.Add(BarBarBar);
        SlotResults.Add(Cleat);
        SlotResults.Add(Bell);
        SlotResults.Add(Clover);
        SlotResults.Add(Sevens);

        GameOn = true;

        Debug.Log("SpinsAttempted");
    }

    public void SwitchUsed()
    {
        {
            ShowResults();
            SlotSpinCount--;
            Switch = true;
        }
        
    }
    public void ShowResults()

    {
        SlotCylinder.SetActive(false);
        int QualityOffset = 0;
        SlotValue = UnityEngine.Random.Range(1, 100); 

       for (int i = 0; i < weightedChance.Length; i++)
       {
    
         if (SlotResults[i] == Cherry)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Cherry;
            }
        if (SlotResults[i] == Melon)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Melon;
            }
        if (SlotResults[i] == Lemon)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Lemon;
            }
        if (SlotResults[i] == Heart)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Heart;
            }
        if (SlotResults[i] == Bar)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Bar;
            }
        if (SlotResults[i] == BarBar)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.BarBar;
            }
        if (SlotResults[i] == BarBarBar)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.BarBarBar;
            }
        if (SlotResults[i] == Cleat)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Cleat;
            }
        if (SlotResults[i] == Clover)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Clover;
            }
        if (SlotResults[i] == Bell)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Bell;
            }
        if (SlotResults[i] == Sevens)
            {
                scoreWeighting.a = ScoreWeighting.ResultSprite.Sevens;
            }
        if (SlotValue <= weightedChance[i] + QualityOffset)
        {
            currentResult = Instantiate(SlotResults[i], slotLocation.position, Quaternion.identity);
            return;
        }
         QualityOffset += weightedChance[i];
         
       }

    }
    public void Reset()
    {
        Switch = false;
        SlotCylinder.SetActive(true);
        Destroy(currentResult);
    }

}