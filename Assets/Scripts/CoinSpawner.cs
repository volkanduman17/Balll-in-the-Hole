using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject goldPrefab;
    public int spawnCount;


    void Start()
    {      
            goldSpawn();       
    }

    public void goldSpawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {           
            float x = Random.Range(-12f, 12f);
            float y = 1;
            float z = Random.Range(-6f, 6f);
            Instantiate(goldPrefab,new Vector3(x,y,z),Quaternion.identity);
        }           
    } 
}
