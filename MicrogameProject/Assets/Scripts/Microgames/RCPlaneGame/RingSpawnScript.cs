using UnityEngine;
using MicrogameCourse.Framework;


public class RingSpawnScript : MonoBehaviour
{

    public GameObject RingPrefabLow;
    public GameObject RingPrefabMid;
    public GameObject RingPrefabHigh;

    public void SpawnRingLow()
    {
        int spawnLocationX = Random.Range(-200, 200);
        int spawnLocationY = Random.Range(0, 50);
        int spawnLocationZ = Random.Range(1000, 2000);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabLow, spawnLocation, Quaternion.identity);
    }

    public void SpawnRingMid()
    {
        int spawnLocationX = Random.Range(-200, 200);
        int spawnLocationY = Random.Range(0, 50);
        int spawnLocationZ = Random.Range(200, 1500);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabMid, spawnLocation, Quaternion.identity);
    }

    public void SpawnRingHigh()
    {
        int spawnLocationX = Random.Range(-200, 200);
        int spawnLocationY = Random.Range(0, 50);
        int spawnLocationZ = Random.Range(1000, 2000);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabHigh, spawnLocation, Quaternion.identity);
    }
}
    
