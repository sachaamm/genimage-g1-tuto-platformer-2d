using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    GameObject player;
    public float distanceToFollow = 20;
    public float distanceToExplode = 1;
    public float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
       
            float dist = Vector3.Distance(player.transform.position, transform.position);
            if ( dist < distanceToFollow)
            {
            // transform.position = Vector3.Lerp(transform.position , player.transform.position , 0.01f);
            Vector3 diff = player.transform.position - transform.position;
            transform.Translate(diff.normalized * moveSpeed);
            }
            if ( dist < distanceToExplode)
            {
            //  todo
            Health health;
            health = player.GetComponent<Health>();
            health.RecevoirDegats(1);
            Destroy(this.gameObject);
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
