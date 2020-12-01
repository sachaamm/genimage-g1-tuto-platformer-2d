using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPortals : MonoBehaviour
{

    // public GameObject portalB;
    public GameObject player;
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject objectCollision = col.gameObject;
        // Si le player entre en contact avec un Portail
        if (objectCollision.tag == "Portal")
        {
            Portal portal = objectCollision.GetComponent<Portal>();
            // Si un script Portal est présent sur le portail
            if (portal != null)
            {
                // il se téléporte sur le Portail associé
                GameObject otherPortal = portal.otherPortal;
                Vector3 otherPortalPosition = otherPortal.transform.position;
                player.transform.position = otherPortalPosition;
            }
            
        }
    }
    
    
}
