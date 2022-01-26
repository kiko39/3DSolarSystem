using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collision : MonoBehaviour
{
   
    private GameObject InstantiatedExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider triggerCollider)
    {
        if(triggerCollider.tag == "X")
        {
           
            Destroy(triggerCollider.gameObject);
            score.points += 1; //apo to script score tn metavliti points pou exw kanei static
            Destroy(this.gameObject);
        }
        if (triggerCollider.tag == "sun")
        {
            Destroy(this.gameObject);
        }
    }
}
