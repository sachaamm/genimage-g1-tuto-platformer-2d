using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMove : MonoBehaviour
{
    public int cycle = 1000;
    public float moveAmount = 1;
    public Vector3 direction = new Vector3(1, 0, 0);

    private Rigidbody2D _rigidbody2D;

    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;
            
        // Si jamais "Time.FrameCount" % cycle < cycle/2: je vais vers le haut, sinon, je vais vers le bas.
        if (counter % cycle < cycle / 2)
        {
            // transform.position += direction * Time.deltaTime * moveAmount;
            _rigidbody2D.MovePosition(transform.position + (direction * Time.deltaTime * moveAmount));
            
        }
        else
        {
            // transform.position -= direction * Time.deltaTime * moveAmount;
            _rigidbody2D.MovePosition(transform.position - (direction * Time.deltaTime * moveAmount));
        }
    }
}
