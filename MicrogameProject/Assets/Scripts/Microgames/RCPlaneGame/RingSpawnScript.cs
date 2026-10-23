using UnityEngine;
using MicrogameCourse.Framework;


public class RingSpawnScript : MonoBehaviour
{

    public GameObject RingPrefabLow;
    public GameObject RingPrefabMid;
    public GameObject RingPrefabHigh;

    public void SpawnRingLow()
    {
        for (int i = 0; i < 10; i++ )
        {
        int spawnLocationX = Random.Range(-1000, 1000);
        int spawnLocationY = Random.Range(100, 400);
        int spawnLocationZ = Random.Range(200, 1000);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabLow, spawnLocation, Quaternion.identity);
        }
    }

    public void SpawnRingMid()
    {
        for (int i = 0; i < 5; i++ )
        {
        int spawnLocationX = Random.Range(-1000, 1000);
        int spawnLocationY = Random.Range(100, 500);
        int spawnLocationZ = Random.Range(300, 1100);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabMid, spawnLocation, Quaternion.identity);
        }
    }

    public void SpawnRingHigh()
    {
        for (int i = 0; i < 1; i++ )
        {
        int spawnLocationX = Random.Range(-200, 200);
        int spawnLocationY = Random.Range(200, 500);
        int spawnLocationZ = Random.Range(500, 1200);

        Vector3 spawnLocation = new Vector3(spawnLocationX, spawnLocationY, spawnLocationZ);
        Instantiate(RingPrefabHigh, spawnLocation, Quaternion.identity);
        }
    }
}
    
