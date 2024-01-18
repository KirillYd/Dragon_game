using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Image manaBar;
    public float heroMana = 0f;
    public float maxMana = 1f;
    public bool isFullMana = false;

    // Start is called before the first frame update
    void Start()
    {
        manaBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        heroMana += 0.001f;
        manaBar.fillAmount = heroMana / maxMana;
        if (heroMana >= maxMana) 
        {
            isFullMana = true;
        }
    }
}
