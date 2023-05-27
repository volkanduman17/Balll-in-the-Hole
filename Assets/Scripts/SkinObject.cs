using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newObject")]

public class SkinObject : ScriptableObject
{
    public int ID;
    public string ItemName;
    public int Price;
    public Sprite ItemSprite;
    public Material ItemMaterial;

    private string unlockKey = "BallSkinUnlocked";
    private bool IsDefault = false;
    

    public bool IsUnlocked
    {
        get => IsDefault ? true : PlayerPrefs.GetInt(unlockKey, IsDefault? 1 : 0) == 1;
        set => PlayerPrefs.SetInt(unlockKey, value ? 1 : 0);
    }
     
}
 
