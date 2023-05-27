using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST2 : MonoBehaviour
{
    int goldAmount;
    private void Awake()
    {
        ActionManager.onCurrencyChange += OnCurrecyChange;
    }
    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    ActionManager.Fire_tusaBasildiginda();
        //}
    }


    void OnCurrecyChange(int changeVal)
    {
        goldAmount += changeVal;
    }

}
