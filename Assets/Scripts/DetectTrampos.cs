using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrampos : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject objectCollision = col.gameObject;
        // Si le player entre en contact avec le trampo
        if (objectCollision.tag == "Trampo")
        {
          Trampo  trampo = objectCollision.GetComponent<Trampo>();
            // Si un script Portal est présent sur le portail
            if (trampo != null)
            {
                print("trampoline");
                // il se téléporte sur le Portail associé
               int jump = trampo.jump;
                // on ajoute une force au rigidbody du player pour le faire sauter 
                Vector2 forcejump = new Vector2(0, trampo.jump);
               Rigidbody2D playerRG = GetComponent<Rigidbody2D>();
                playerRG.AddForce(forcejump); 
                
            }

        }
    }

}
