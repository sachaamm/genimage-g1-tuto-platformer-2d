﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    public float vitesseDeplacement = 0.05f;
    public float jumpPower = 0.2f;
    public Rigidbody2D rg;
    bool isGrounded = true;
        
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Si j'appuie sur la fleche de gauche
        // Je deplace le joueur à gauche
        Vector3 playerpos = transform.position;
        if( Input.GetKey( KeyCode.LeftArrow) && isGrounded)
        {
           // rg.(new Vector3(-2, 0, 0) * vitesseDeplacement);
           rg.MovePosition(playerpos + new Vector3(-2, 0, 0) * vitesseDeplacement);

        }
        if (Input.GetKey(KeyCode.RightArrow) && isGrounded)
        {
           // player.transform.Translate(new Vector3(2, 0, 0) * vitesseDeplacement);
           rg.MovePosition(playerpos + new Vector3(2, 0, 0) * vitesseDeplacement);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // player.transform.Translate(new Vector3(0, 1, 0) * jumpPower);
            rg.AddForce(new Vector3(0, 1, 0) * jumpPower);
        }
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
