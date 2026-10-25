using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using MicrogameCourse.Framework;
using System;
using MicrogameCourse.Microgames;
using System.Collections.Generic;


public class PlushieSpawner : MonoBehaviour
{
    List<GameObject> plushieList = new List<GameObject>();
    public GameObject PlushieSingle;
    public GameObject PlushieDuo;
    public GameObject PlushieTrio;
    public GameObject PlushieBig;
    public GameObject PlushieLegendary;

    public int SpawnQuality; 
    public int SpawnCount;
    public bool GameOn;
   
    public void Start()
    {
        plushieList.Add(PlushieSingle);
        plushieList.Add(PlushieDuo);
        plushieList.Add(PlushieTrio);
        plushieList.Add(PlushieBig);
        plushieList.Add(PlushieLegendary);
        int plushieIndex = UnityEngine.Random.Range(1, 5);
        Instantiate(plushieList[plushieIndex]);
        Debug.Log("Spawns Attempted");
    }
    
    public void SpawnPlush()
    {
        int plushieIndex = UnityEngine.Random.Range(1, 5);
        Instantiate(plushieList[plushieIndex]);
        Debug.Log("Spawns Attempted");

    }


}
