using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
  
    private int counter = 0;
    public int cycleShoot = 40;

    public float shootPower = 200;

    public float bulletLifetime = 5;

    UpdateRobotOrientation robotOrientation;

    // Start is called before the first frame update
    void Start()
    {
        robotOrientation = GetComponent<UpdateRobotOrientation>();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter % cycleShoot == 0 && Input.GetMouseButton(1))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 bulletSpawnPoint = transform.position + robotOrientation.BulletSpawnPointOffset();
            Vector3 diff = bulletSpawnPoint - mousePos;            
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = bulletSpawnPoint;
            Rigidbody2D newBulletRg = newBullet.GetComponent<Rigidbody2D>();
            newBulletRg.AddForce(-diff.normalized * shootPower);
            
            Destroy(newBullet, bulletLifetime);
        }
    }
}
