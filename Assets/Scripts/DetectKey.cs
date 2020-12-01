using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKey : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // on va effacer une deadzone lorsque nous récupérons la clé
        GameObject objectCollision = collision.gameObject;
        // Si le player entre en contact avec une clé
        if (objectCollision.tag == "Key")
        {
            Key key = objectCollision.GetComponent<Key>();
            if (key != null)
            {
                GameObject[] deadZones = key.deadZones;
                for(int i = 0; i < deadZones.Length; i++)
                {
                    Destroy(deadZones[i]);
                }

                Destroy(objectCollision);
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
