using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDeadZone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject objectCollision = col.gameObject;
        if (objectCollision.tag == "DeadZone")
        {
            // Si player entre en contacte avec DeadZone, respawn
         
        }
    }
}
