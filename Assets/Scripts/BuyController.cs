using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyController : MonoBehaviour
{
    private ItemTemplate ItemTemplate;
    [SerializeField]private Button BuyButton;

    private void Awake()
    {
        ItemTemplate = GetComponent<ItemTemplate>();
    }

    private void Start()
    {
        if (ItemTemplate.SkinObject.Price > DataManager.Currency)
        {
            BuyButton.interactable = false;
        }
        else
        {
            return;
        }
    }

    public void OnClickBuyButton()
    {
        if (DataManager.Currency >= ItemTemplate.SkinObject.Price)
        {
            DataManager.MaterialID = ItemTemplate.Id;
            DataManager.Currency -= ItemTemplate.SkinObject.Price;

            UICurrencyManager.Instance.OnCurrencyChange();
        }

    }
}
