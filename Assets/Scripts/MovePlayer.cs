using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    public float vitesseDeplacement = 0.05f;
    public float jumpPower = 0.2f;

        
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Si j'appuie sur la fleche de gauche
        // Je deplace le joueur à gauche
        if( Input.GetKey( KeyCode.LeftArrow))
        {
            player.transform.Translate(new Vector3(-2, 0, 0) * vitesseDeplacement);
           
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(new Vector3(2, 0, 0) * vitesseDeplacement);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.Translate(new Vector3(0, 1, 0) * jumpPower);
        }
}
}
