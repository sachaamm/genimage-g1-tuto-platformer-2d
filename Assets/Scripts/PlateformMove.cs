using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMove : MonoBehaviour
{
    public int cycle = 1000;
    public float moveAmount = 1;
    public Vector3 direction = new Vector3(1, 0, 0);

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
            transform.position += direction * Time.deltaTime * moveAmount;
        }
        else
        {
            transform.position -= direction * Time.deltaTime * moveAmount;
        }
    }
}
