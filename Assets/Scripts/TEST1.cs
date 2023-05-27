using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST1 : MonoBehaviour
{
    private void Awake()
    {
       ///ActionManager.tusaBasildiginda += SpaceeBasildi;
    }

    void SpaceeBasildi()
    {
        print("BASILDI");
    }


    void AltinTopla(int altin)
    {
        ActionManager.Fire_onCurrencyChange(altin);
    }

}