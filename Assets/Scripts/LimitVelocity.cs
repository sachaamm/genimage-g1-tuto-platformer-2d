using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    public Rigidbody2D rg;
    public float ratio = 1f;
    public float ratioHorizontal = 1f;
    MovePlayer movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        movePlayer = GetComponent<MovePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movePlayer.IsMoving())
        {
            rg.velocity = new Vector3(rg.velocity.x , rg.velocity.y, 0) / ratio;
        }
        else
        {
            rg.velocity = new Vector3(rg.velocity.x / ratioHorizontal, rg.velocity.y, 0) / ratio;
        }

        // rg.velocity /= ratioHorizontal;
        
        rg.angularVelocity = rg.angularVelocity / ratio;
    }
}
