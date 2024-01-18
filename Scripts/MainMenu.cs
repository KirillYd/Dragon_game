using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 1;
    }
    /*public void Update()
    {
        var prevCount = 0;
        if (LoadLevel.Count > prevCount)
        {
            LevelOpen button = level.GetComponent<LevelOpen>();
            Button[] buts = button.GetComponents<Button>();

            prevCount = LoadLevel.Count;
            //GameObject[] buttons = level.GetComponentsInChildren<GameObject>(includeInactive: true);
            buts[prevCount].gameObject.SetActive(true);
        }
    }*/

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainScene() 
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        if (SceneManager.GetActiveScene().buildIndex < 4)
            LoadLevel.levels[SceneManager.GetActiveScene().buildIndex] = true;
            
        SceneManager.LoadScene(0);
    }
}
