using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    LevelManager _levelman;


    public static UIManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public bool isCollected = false;
    public Text levelText;

    public Button RestartButton;
    public Button HomeButton;
    public LevelManager _levelManager;
    public UIYouWin youWin;

    private void Start()
    {
        RestartButton.onClick.AddListener(OnClickRestartButton);
        HomeButton.onClick.AddListener(OnClickHomeButton);
        _levelman = GetComponent<LevelManager>();
        levelText.text = "Level: " + ((DataManager.Level) + 1).ToString();
    }

    public void OnClickRestartButton()
    {
        SceneManager.LoadScene("GameScene");
        //coinAmount = 0;

    }

    public void OnClickHomeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
