using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBull : MonoBehaviour
{
    // Start is called before the first frame update
    // private GameController instance;
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameController.instance.DiaLog.SetActive(true);
        }
        if(other.gameObject.tag=="Floor")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.tag=="EnemyBullet")
        {
            Destroy(other.gameObject);
        }
        // Destroy(gameObject);
    }
    
}
