using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    public float vitesseDeplacement = 0.05f;
    public float vitesseDeplacementAir = 0.05f;
    public float jumpPower = 0.2f;
    public Rigidbody2D rg;
    bool isGrounded = true;
    bool isMoving = false;
    public Animator animator;

    Vector3 forceDeplacement = new Vector3();
    
    // Start is called before the first frame update
    void Start()
    {
         Debug.Log("Screen height " + Screen.width);
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        // Si j'appuie sur la fleche de gauche
        // Je deplace le joueur à gauche

        forceDeplacement = new Vector3();
        Vector3 playerpos = transform.position;
        isMoving = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow);
        animator.SetBool("walk", isMoving);

        if ( Input.GetKey( KeyCode.LeftArrow))
        {
           if (isGrounded)
            {
                // rg.MovePosition(playerpos + new Vector3(-2, 0, 0) * vitesseDeplacement);
                forceDeplacement += new Vector3(-2, 0, 0) * vitesseDeplacement;
            }
            else
            {
                forceDeplacement += new Vector3(-2, 0, 0) * vitesseDeplacementAir;
            }
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
           if (isGrounded)
            {
                // rg.MovePosition(playerpos + new Vector3(2, 0, 0) * vitesseDeplacement);
                forceDeplacement += new Vector3(2, 0, 0) * vitesseDeplacement;
            }
           else 
            {
                forceDeplacement += new Vector3(2, 0, 0) * vitesseDeplacementAir;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            forceDeplacement += new Vector3(0, 1, 0) * jumpPower;         
        }
        
        rg.AddForce(forceDeplacement);
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
    
    public bool IsGrounded()
    {
        return isGrounded;
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
