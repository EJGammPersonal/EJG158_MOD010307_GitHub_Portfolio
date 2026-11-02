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
    public int[] weightedChance = {50, 20, 15, 10, 5};

    // public int plushieIndex(int[] weight)
    // {
    //     if(weight == null || weight.Length == 0) return -1;
    //     int rarity;
    //     int weightSum = 0;
    //     for(rarity = 0; rarity < weight.Length; rarity++)
    //     {
    //         if(weight[rarity] >= 0) weightSum += weight[rarity];
    //     }

    //     float random = UnityEngine.Random.value;
    //     float score = 0f;

    //     for (rarity = 0; rarity < weight.Length; rarity++)
    //     {
    //         if(weight[rarity] <= 0f) continue; 
    //         score += (float)weight[rarity] / weightSum; 
    //         if (score >= random) return rarity; 
    //     }
    //     return -1; 
        
    // }

    public void Start()
    {
        plushieList.Add(PlushieSingle);
        plushieList.Add(PlushieDuo);
        plushieList.Add(PlushieTrio);
        plushieList.Add(PlushieBig);
        plushieList.Add(PlushieLegendary);

        // int plushieIndex = UnityEngine.Random.Range(1, 5);
        // Instantiate(plushieList[plushieIndex], spawnLocation.position, Quaternion.identity);
        SpawnPlush();
        Debug.Log("Spawns Attempted");
    }
    public void SpawnPlush()
    {
        int plushieIndex = UnityEngine.Random.Range(0, 4);
        // int SpawnLocationX = 0;
        // int SpawnLocationY = 0;
        // int SpawnLocationZ = 0;
        int QualityOffset = 0;
        // Vector3 spawnLocation = new Vector3(SpawnLocationX, SpawnLocatInstantiate(plushieList[plushieIndex], spawnLocation.position, Quaternion.identity);ionY, SpawnLocationZ);
        // 
        Debug.Log("Spawns Attempted");

       SpawnQuality = UnityEngine.Random.Range(1, 100); 

       for (int i = 0; i < weightedChance.Length; i++)
       {
        if (SpawnQuality <= weightedChance[i] + QualityOffset)
        {
            Instantiate(plushieList[i], spawnLocation.position, Quaternion.identity);
            return;
        }
         QualityOffset += weightedChance[i];
       }
       
    }




}
