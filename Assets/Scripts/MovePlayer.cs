using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    float vitesse = 0.05f;

        
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
            player.transform.Translate(new Vector3(-2, 0, 0) * vitesse);
           
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(new Vector3(2, 0, 0) * vitesse);
        }
    }
}
