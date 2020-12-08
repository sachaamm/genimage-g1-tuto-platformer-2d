using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneMove : MonoBehaviour
{
    public int cycle = 1000;
    public float moveAmount = 1;

    private int counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        
        // Si jamais "Time.FrameCount" % cycle < cycle/2: je vais vers le haut, sinon, je vais vers le bas.
        if (counter % cycle < cycle / 2)
        {
            transform.position += new Vector3(0, 1, 0) * (moveAmount );
        }
        else
        {
            transform.position += new Vector3(0, -1, 0) * (moveAmount );
        }
    }
}
