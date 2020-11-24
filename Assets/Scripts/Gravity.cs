using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private MovePlayer _movePlayer;

    private Rigidbody2D rg;

    public float gravityAmount = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        _movePlayer = GetComponent<MovePlayer>();
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_movePlayer.IsGrounded())
        {
            rg.AddForce(Vector2.down * gravityAmount);
        }
    }
}
