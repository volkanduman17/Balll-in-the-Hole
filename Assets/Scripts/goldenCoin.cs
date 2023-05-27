using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class goldenCoin : MonoBehaviour
{    
    public GameObject gold;
   
    void Start()
    {
        goldSpawn();      
    }

    void Update()
    {
        goldTurn();
    }

    public GameObject spawnlananGold;
    public void goldSpawn()
    {
        spawnlananGold= Instantiate(gold, new Vector3(Random.Range(-12f,12f), 1f, Random.Range(-6f,6f)),
            transform.rotation * Quaternion.Euler(55f, -10f, 7f));   
    }
    public void goldTurn()
    {        
           spawnlananGold.transform.Rotate(Vector3.forward * 50 * Time.deltaTime, Space.Self);
        
    }
}
