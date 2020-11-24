using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour
 
{
    public string nextLevel = "toto";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject objectCollision = col.gameObject;
        if (objectCollision.tag == "EndLevel")
        {
            // Si player entre en contacte avec DeadZone, respawn
            LevelEnd();
        }
    }
    void LevelEnd()
    {
        
        SceneManager.LoadScene(nextLevel);
    }
}
