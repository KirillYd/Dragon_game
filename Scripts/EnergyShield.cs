using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnergyShield : MonoBehaviour
{
    //public GameObject fireBallPrefab;
    public TextMeshProUGUI scoreGT;
    public AudioSource audioSource;
    public int localScore = 0;
    public int speed = 1;
 




    private void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<TextMeshProUGUI>();
        scoreGT.text = "0";
        //fireBallPrefab.transform.position = new Vector3(0f, 1f, 0f);
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = -mousePos3D.x;
        this.transform.position = pos;

       /* if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 y = new Vector3(0f, 3f, 0f);
            GameObject ball = Instantiate(fireBallPrefab, transform.position + y, Quaternion.identity);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            ballRigidbody.velocity = new Vector3(0f, ballSpeed, 0f);
        }*/


    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject Collided = coll.gameObject;
        if (Collided.tag == "Dragon Egg")
        {
            Destroy(Collided);
            //hero.heroMana += hero.heroMana + 1f / 3;
        }

        int score = int.Parse(scoreGT.text);
        score += 1;
        localScore += 1;
        scoreGT.text = score.ToString();

       /* if (localScore >= 3)
        {
            fireReady.text = "Огненный шар готов!";
            localScore = 0;
        }*/


        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }


    
}
