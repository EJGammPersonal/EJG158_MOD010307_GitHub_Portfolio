using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
using System.Collections.Generic;

public class SlotMachine2 : MonoBehaviour



{
    public bool GameOn;
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
    public bool Switch = false;
    public Transform slotLocation;
    
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
        int QualityOffset = 0;
        SlotValue = UnityEngine.Random.Range(1, 100); 

       for (int i = 0; i < weightedChance.Length; i++)
       {
        if (SlotValue <= weightedChance[i] + QualityOffset)
        {
            Instantiate(SlotResults[i], slotLocation.position, Quaternion.identity);
            return;
        }
         QualityOffset += weightedChance[i];
       }

    }
   
}