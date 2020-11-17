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
            for (int x = 0; x < wallWidth; x++)
            {
                GameObject newCube = Instantiate(Cube);
                newCube.transform.position = new Vector3(x, y, 5);
            }
        }
    }

    void Update()
    {

    }
}