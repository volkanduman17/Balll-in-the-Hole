using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    
    [SerializeField] public SkinObject[] skinobjects;
    [SerializeField] public List<Material> Materials;


    public static ShopManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;

    }
}
