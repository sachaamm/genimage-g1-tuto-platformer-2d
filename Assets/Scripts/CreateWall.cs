using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        int wallWidth = 5;
        int wallHeight = 3;

        for (int y = 0; y < wallHeight; y++)
        {
            for (int i = 0; i < wallWidth; i++)
            {
                GameObject newCube = Instantiate(Cube);
                newCube.transform.position = new Vector3(i, y, 5);
            }
        }
    }

    void Update()
    {
        
    }
}