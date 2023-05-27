using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ShopUI : MonoBehaviour
{

   [SerializeField] private TextMeshProUGUI CurrencyText;
    int goldAmount;
    public void OnClickHomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Awake()
    {
        ActionManager.onCurrencyChange += OnCurrencyChange;
    }


    private void Start()
    {
        CurrencyText.text = DataManager.Currency.ToString();
    }

    void OnCurrencyChange(int changeVal)
    {
        goldAmount += changeVal;
    }


}