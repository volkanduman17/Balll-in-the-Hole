using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowBrick : MonoBehaviour
{
    public Renderer BrickRenderer;
    public Collider BrickCollider;


    void Start()
    {
        if (this.tag=="yellowBrick")
        {

        BrickCollider = GetComponent<Collider>();
        BrickRenderer = GetComponent<Renderer>();
        InvokeRepeating("ToggleVisibility", 1f, 1f); // Her 1 saniyede bir ToggleVisibility metodunu çaðýrýr.
        }

        if (this.tag=="yellowBrick_2")
        {
            BrickCollider = GetComponent<Collider>();
            BrickRenderer = GetComponent<Renderer>();
            InvokeRepeating("ToggleVisibility", 0f, 1f);
        }

    }

    public void ToggleVisibility()
    {
        BrickRenderer.enabled = !BrickRenderer.enabled; // Renderer'ýn etkinliðini ters çevirdik.
        BrickCollider.enabled = !BrickCollider.enabled; // Collider'ýn etkinliðini ters çevirdik.   
    }
}
