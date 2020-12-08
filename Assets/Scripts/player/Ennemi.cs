using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    GameObject player;
    public float distanceMin = 20;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
       
            float dist = Vector3.Distance(player.transform.position, transform.position);
            if ( dist < distanceMin)
            {
            transform.position = Vector3.Lerp(transform.position , player.transform.position , 0.5f);
            }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject objectCollision = col.gameObject;
        if (objectCollision.tag == "fire")
        {
            Destroy(transform.gameObject);
        }
    }
}
