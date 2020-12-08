using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int life = 100;
    public HealthBar lifeBar;
    
    // Start is called before the first frame update
    void Start()
    {
        lifeBar.SetMaxHealth(life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RecevoirDegats(int degats)
    {
        life -= degats;
        lifeBar.SetHealth(life);
    }
}
