using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
public class ActionManager : MonoBehaviour
{
    //public static Action<float> onChangeZoomSpeed;
    //public static void Fire_onChangeZoomSpeed(float sens) { onChangeZoomSpeed?.Invoke(sens); }


    public static Action GoldHasCollected;

    public static void Fire_GoldHasCollected()
    {
        GoldHasCollected?.Invoke();
    }



    //public static Action tusaBasildiginda;
    //public static void Fire_tusaBasildiginda() 
    //{ 
    //    tusaBasildiginda?.Invoke(); 
    //}



    public static Action<int> onCurrencyChange;
    public static void Fire_onCurrencyChange(int coinAmount)
    {
        onCurrencyChange?.Invoke(coinAmount);
    }

}