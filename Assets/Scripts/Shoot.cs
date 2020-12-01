using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;

    public GameObject bulletSpawnPoint;
    
    private int counter = 0;
    public int cycleShoot = 40;

    public float shootPower = 200;

    public float bulletLifetime = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter % cycleShoot == 0)
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = bulletSpawnPoint.transform.position;
            Rigidbody2D newBulletRg = newBullet.GetComponent<Rigidbody2D>();
            newBulletRg.AddForce(new Vector2(0,1) * shootPower);
            
            Destroy(newBullet, bulletLifetime);
        }
    }
}
