using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    public Rigidbody2D rg;
    public float ratio = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = rg.velocity / ratio;
        rg.angularVelocity = rg.angularVelocity / ratio;
    }
}
