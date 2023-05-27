using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    #region InstanceExample
    public static LevelManager instance;

     private void Awake()
     {
         if (instance != null)
         {
             Destroy(this);
             return;
         }
         instance = this;
     }
     
     #endregion
     

    public List<GameObject> Levels;
    //public static GameObject[] Levels;

    private void Start()
    {
        Instantiate(Levels[DataManager.Level]);
    }


    public void NextLevel()
    {
        SceneManager.LoadScene("GameScene");
        DataManager.Level++;
        Debug.Log("level arttýrýldý");
        Instantiate(Levels[DataManager.Level]);
        gameObject.SetActive(false);                
    }

}
