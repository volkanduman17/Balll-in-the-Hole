using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTemplate : MonoBehaviour
{
    public Text TxtItemName;
    public Image itemimage;
    public Text TxtPrice;
    public int Id;
    [field: SerializeField] public SkinObject SkinObject { get; private set; }

    public void Initailize(SkinObject obje)
    {
        TxtItemName.text = obje.ItemName;
        itemimage.sprite = obje.ItemSprite;
        TxtPrice.text = "Buy: "+ obje.Price;
        SkinObject = obje;
    }


    void Update()
    {
        
    }
}
