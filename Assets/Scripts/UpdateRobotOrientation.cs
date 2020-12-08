using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateRobotOrientation : MonoBehaviour
{
     GameObject platform;
    public GameObject robot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (platform != null)
        {
            Vector3 RobotPosition = robot.transform.position;
            Vector3 LookTo; 
            LookTo = new Vector3(robot.transform.position.x , platform.transform.position.y , robot.transform.position.z);
            robot.transform.LookAt(platform.transform);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform")
        {
            platform = collision.transform.gameObject;
        }
    }
}
