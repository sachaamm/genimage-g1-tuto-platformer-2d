using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
   public Vector3 rotation = new Vector3(0, 0, 1);
    public float speed = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(rotation * speed);
    }
}
