using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;
        Vector3 playerpos = player.transform.position;
        Vector3 newCamPos = new Vector3(player.transform.position.x , player.transform.position.y, camPos.z );
        transform.position = newCamPos;
    }
}
