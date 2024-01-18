using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCharge : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision coll)
    {
        GameObject Collided = coll.gameObject;
        if (Collided.tag == "Dragon Egg")
        {
      //      Destroy(Collided);
            //heroMana += heroMana + 1f / 3;
        }
    }

}
