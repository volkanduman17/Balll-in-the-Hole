using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICurrencyManager : MonoBehaviour
{

    public static UICurrencyManager Instance;


    private void Awake()
    {
        ActionManager.GoldHasCollected += GoldCollected;

        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }


    public Text levelGoldAmount;
    public Text totalGoldAmount;
    public int currentCoin = 0;
    void Start()
    {
        totalGoldAmount.text = DataManager.Currency.ToString();
    }


    public void GoldCollected()
    {
        currentCoin++;
        levelGoldAmount.text = currentCoin.ToString();
    }

    void Update()
    {
        //levelGoldAmount.text = DataManager.Currency.ToString();
    }
    public void IncreaseCurrency()
    {
        DataManager.Currency += 1;
    }

    public void OnCurrencyChange()
    {
        int currentCurrency = DataManager.Currency;

        totalGoldAmount.text = currentCurrency.ToString();

    }
}
