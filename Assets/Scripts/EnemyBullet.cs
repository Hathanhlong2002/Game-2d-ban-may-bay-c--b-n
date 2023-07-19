
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] GameObject BulletPrefabs;
    [SerializeField] float bulletSpeed = 10f;

    private void Start()
    {
        StartCoroutine(SpawnBulletWithDelay(2.0f));
    }

    private IEnumerator SpawnBulletWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

            GameObject bullet = Instantiate(BulletPrefabs, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = -bulletSpawnPoint.up * bulletSpeed;
            bullet.transform.parent=bulletSpawnPoint;
            Destroy(bullet,10f);
        }
    }
}

