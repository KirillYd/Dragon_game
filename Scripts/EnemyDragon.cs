using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;

public class EnemyDragon : MonoBehaviour
{
    public GameObject dragonEggPrefab;

    public float speed = 1;
    public float timeBetweenDrops = 1f;
    public float leftRightDistance = 10f;
    public float chanceDirection = 0.1f;
    public float dragonHP = 1f;
    public float maxHP = 1f;
    public GameObject win;
    public GameObject menu;

    void Start()
    {
        Invoke("DropEgg", 2f);   
    }

    void DropEgg()
    {
        Vector3 myVector = new Vector3(0.0f, 5.0f, 0.0f);
        GameObject egg = Instantiate<GameObject>(dragonEggPrefab);
        egg.transform.position = this.transform.position + myVector;
        Invoke("DropEgg", timeBetweenDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftRightDistance)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftRightDistance) 
        {
            speed = -Mathf.Abs(speed);
        }



        if (dragonHP <= 0)
        {
            win.gameObject.SetActive(true);

            Time.timeScale = 0;
            menu.gameObject.SetActive(true);
            LoadLevel.Count += 1;

        }
      
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceDirection)
        {
            speed *= -1;
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject Collided = coll.gameObject;
        if (Collided.tag == "FireBall")
        {
            Destroy(Collided);
            dragonHP = dragonHP - 1f / 3;
        }
        
        
        
     
    }
}
