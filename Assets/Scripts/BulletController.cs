using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] GameObject BulletPrefabs;
    [SerializeField] float bulletSpeed=10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet=Instantiate(BulletPrefabs,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity=bulletSpawnPoint.up*bulletSpeed;
            bullet.transform.SetParent(bulletSpawnPoint);
        }
    }
}
