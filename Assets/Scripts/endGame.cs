using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "finish")
        {
            UIManager.Instance.youWin.gameObject.SetActive(true);
        }
    }
}
