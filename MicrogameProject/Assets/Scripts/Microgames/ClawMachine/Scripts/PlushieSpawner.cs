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
    public Transform spawnLocation;

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
        // int SpawnLocationX = 0;
        // int SpawnLocationY = 0;
        // int SpawnLocationZ = 0;
        // Vector3 SpawnLocation = new Vector3(SpawnLocationX, SpawnLocationY, SpawnLocationZ);
        Instantiate(plushieList[plushieIndex], spawnLocation.position, Quaternion.identity);
        Debug.Log("Spawns Attempted");

    }


}
