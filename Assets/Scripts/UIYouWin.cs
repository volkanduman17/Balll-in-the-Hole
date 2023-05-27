using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIYouWin : MonoBehaviour
{
    public Button NextLevelButton;



    public void Start()
    {
        //NextLevelButton.onClick.AddListener(OnClickNextLevelButton);
        //levelManager.GetComponent<LevelManager>();
        //levelGoldAmount = GetComponent<Text>();
        // ---------- SUBS ÖRNEÐÝ -----------------     DataManager.OnCurrencyUpdate += nextLevelButton;
    }

    public void OnClickNextLevelButton()
    {
        LevelManager.instance.NextLevel();
        DataManager.Currency += UICurrencyManager.Instance.currentCoin;
        // UI_Currency_Manager.Instance.totalGoldAmount = DataManager.Currency.ToString();
        // SceneManager.LoadScene(sceneBuildIndex: currentScene+1);
        // totalCoin += coinAmount;
        // currentScene += 1;
        // coinAmount = 0;
    }


}
