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
    public Transform PlushieSpawnOne;
    public Transform PlushieSpawnTwo;
    public Transform PlushieSpawnThree;

    public GameObject PlushieSingle;
    public GameObject PlushieDuo;
    public GameObject PlushieTrio;
    public GameObject PlushieBig;
    public GameObject PlushieLegendary;

    public int SpawnQuality; 
    public int SpawnCount;
   
    public void Start()
    {
        plushieList.Add(PlushieSingle);
        plushieList.Add(PlushieDuo);
        plushieList.Add(PlushieTrio);
        plushieList.Add(PlushieBig);
        plushieList.Add(PlushieLegendary);
    }
    
    public void SpawnPlush()
    {
        int plushieIndex = UnityEngine.Random.Range(1, 100);
        Instantiate(plushieList[plushieIndex]);
    }


}
