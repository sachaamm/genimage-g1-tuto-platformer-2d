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
        for (int i = 0; i < 100; i++)
        {
            Instantiate(cube);
        }
        
    }
    
    void Update()
    {
        
    }
}
