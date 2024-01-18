using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{

    public Image healthBar;
    public EnemyDragon enemyDragon;
    // Start is called before the first frame update
    private void Awake()
    {
        healthBar = GetComponent<Image>();
        enemyDragon = FindObjectOfType<EnemyDragon>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = enemyDragon.dragonHP / enemyDragon.maxHP;
    }
}
