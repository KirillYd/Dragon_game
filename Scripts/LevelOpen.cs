using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelOpen : MonoBehaviour
{
    public void Start()
    {
        Button[] buttons = GetComponentsInChildren<Button>(includeInactive: true);
        for (int i = 0; i < buttons.Length; i++) 
        {
            buttons[i].gameObject.SetActive(LoadLevel.levels[i]);
        }
    }
    // Start is called before the first frame update
    public void Play1Level() 
    {
        SceneManager.LoadScene(1);
    }

    public void Play2Level()
    {
        SceneManager.LoadScene(2);
    }

    public void Play3Level()
    {
        SceneManager.LoadScene(3);
    }

    public void Play4Level()
    {
        SceneManager.LoadScene(4);
    }
}
