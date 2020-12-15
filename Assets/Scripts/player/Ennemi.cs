using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    GameObject player;
    public float distanceToFollow = 20;
    public float distanceToExplode = 1;
    public int cycle = 1000;
    public float moveAmount = 1;
    public Vector3 direction = new Vector3(1, 0, 0);
    private Rigidbody2D _rigidbody2D;
    private int counter = 0;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
  
    void Update()
    {
        counter++;
       
        if (counter % cycle < cycle / 2)
        {           
            _rigidbody2D.MovePosition(transform.position + (direction * moveAmount));
        }
        else
        {            
            _rigidbody2D.MovePosition(transform.position - (direction * moveAmount));
        }
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if ( dist < distanceToFollow)
        {
            transform.position = Vector3.Lerp(transform.position , player.transform.position , 0.05f);
        }
        if ( dist < distanceToExplode)
        {
            Destroy(transform.gameObject);
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
