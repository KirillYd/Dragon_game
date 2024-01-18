using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleFireball : MonoBehaviour
{
    public GameObject fireBallPrefab;
    public float ballSpeed = 20f;
    public ManaBar manaInstanse;
    public GameObject manaObject;
    public GameObject fireReady;
   
    //public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        manaInstanse = manaObject.GetComponent<ManaBar>();
        var isFull = manaInstanse.isFullMana;

        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = -mousePos3D.x;

        if (isFull)
        {
            fireReady.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.W))
            {

                var posit = new Vector3(-mousePos3D.x, -4, 0);
                GameObject ball = Instantiate(fireBallPrefab, posit, Quaternion.identity);
                Rigidbody rb = ball.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, ballSpeed, 0);
                //manaBar.heroMana = 0f;
                manaInstanse.heroMana = 0f;
                manaInstanse.isFullMana = false;
                fireReady.gameObject.SetActive(false);
            }
        }

        /* if (Input.GetKeyDown(KeyCode.W))
         {

             var posit = new Vector3(mousePos3D.x, -4, 0);
             GameObject ball = Instantiate(fireBallPrefab, posit, Quaternion.identity);
             Rigidbody rb = ball.GetComponent<Rigidbody>();
             rb.velocity = new Vector3(0, ballSpeed, 0);
             //manaBar.heroMana = 0f;
         }*/

        //GameObject[] tBallsArr = GameObject.FindGameObjectsWithTag("FireBall");

    }

    public void FireBallDestroyed()
    {
        GameObject[] tBallsArr = GameObject.FindGameObjectsWithTag("FireBall");
        foreach (GameObject tGO in tBallsArr)
        {
            Destroy(tGO);
        }
    }
   
}
