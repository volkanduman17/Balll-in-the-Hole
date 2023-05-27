using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{

    private static string LevelKey = "LevelDataKey";
    private static int DefaultLevelValue = 0;
    private static Material BallMaterial;

    public static int Level
    {
        get => PlayerPrefs.GetInt(LevelKey, DefaultLevelValue);
        set => PlayerPrefs.SetInt(LevelKey, value);
    }
        

    public static UnityAction OnCurrencyUpdate;



    private static string coinKey = "CoinKey";
    private static string materialIdKey = "materialIdKey";
    private static int DefaultCoinValue = 0;

    public static int MaterialID
    {
        get => PlayerPrefs.GetInt(materialIdKey, 0);
        set
        {
            PlayerPrefs.SetInt(materialIdKey, value);

        }
    }

    public static int Currency
    {
        get => PlayerPrefs.GetInt(coinKey, DefaultCoinValue);
        set {
                
                PlayerPrefs.SetInt(coinKey, value);
                OnCurrencyUpdate?.Invoke();

            }
    }

}
