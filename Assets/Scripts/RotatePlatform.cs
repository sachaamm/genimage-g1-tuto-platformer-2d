using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    Vector3 rotation = new Vector3(0, 0, 1);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(rotation);

    }
}
