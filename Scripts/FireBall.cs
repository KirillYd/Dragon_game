using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public static float topY = 20f;
    public float speed = 30f;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        /*ParticleSystem ps = GetComponent<ParticleSystem>();
        var em = ps.emission;
        em.enabled = true;

        Renderer rend;
        rend = GetComponent<Renderer>();
        rend.enabled = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topY)
        {
            Destroy(this.gameObject);
            PeopleFireball apScr = Camera.main.GetComponent<PeopleFireball>();
            apScr.FireBallDestroyed();
        }
    }

}
