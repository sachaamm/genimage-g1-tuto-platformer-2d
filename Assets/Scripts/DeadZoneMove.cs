using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneMove : MonoBehaviour
{
    public int cycle = 1000;
    public float moveAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si jamais "Time.FrameCount" % cycle < cycle/2: je vais vers le haut, sinon, je vais vers le bas.
        if (Time.frameCount % cycle < cycle / 2)
        {
            transform.position += new Vector3(0, 1 * Time.deltaTime, 0) * moveAmount * Responsive.ResponsiveHeight();
        }
        else
        {
            transform.position += new Vector3(0, -1 * Time.deltaTime, 0) * moveAmount * Responsive.ResponsiveHeight();
        }
    }
}
