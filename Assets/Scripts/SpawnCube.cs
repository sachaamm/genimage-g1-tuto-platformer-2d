using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        // Je crée un GameObject à partir de la fonction Instantiate

        // Une boucle 
        // via trois mot clés : while et for et foreach

        // la boucle for parcoure un index 
        // valeur de départ 0
        // valeur maximale 100
        // incrementation : de combien on incremente i a chaque execution de la boucle

    }

    void Update()
    {
        // on détruit tous les cubes
        // on récupère tous les cubes à partir d'un tag
        // Destroy()

        GameObject[] cubesTableau = GameObject.FindGameObjectsWithTag("Cube");


        for (int i = 0; i < cubesTableau.Length; i++)
        {
            Destroy(cubesTableau[i]);
        }
        for (int i = 0; i < 10; i++)
        {
            int y = Random.Range(-5, 5);
            GameObject newCube = Instantiate(cube);
            newCube.transform.position = new Vector3(i, y, 15);
            newCube.transform.name = "cube" + i;
        }
    }
}