using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollisionController : MonoBehaviour
{
    // public UI_Currency_Manager _UI_Currency;

   
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            UICurrencyManager.Instance.GoldCollected();
           // DataManager.OnCurrencyUpdate.Invoke();
           // DataManager.Currency += 1;
            gameObject.SetActive(false);
        }
    }
}