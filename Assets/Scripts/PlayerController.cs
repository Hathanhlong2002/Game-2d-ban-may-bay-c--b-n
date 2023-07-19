using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Destroy(other.gameObject);
          
        }
       
    }    
}
    
    
