using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public GameObject ItemTemplate;
    //public GameObject Slot;

    private void Start()
    {
        ShowTheShop();
    }

    public void ShowTheShop()
    {

        for (int i = 0; i < ShopManager.Instance.skinobjects.Length; i++)
        {
            ItemTemplate Slot = Instantiate(ItemTemplate, transform).GetComponent<ItemTemplate>();
            Slot.Initailize(ShopManager.Instance.skinobjects[i]);
            Slot.Id = i;

           // Slot.GetComponent<Image>().sprite = ShopManager.Instance.skinobjects[i].ItemSprite;
        }
    } 
}
