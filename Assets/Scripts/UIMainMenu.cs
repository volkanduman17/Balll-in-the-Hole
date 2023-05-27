using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button StartButton;
    public Button ShopButton;
    public LevelManager levelManager;
    void Start()
    {
        StartButton.onClick.AddListener(OnClickStartButton);
        ShopButton.onClick.AddListener(OnClickShopButon);
    }


    public static UnityAction LoadLevelAction;

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickShopButon()
    {
        SceneManager.LoadScene("Shop");
    }
}
