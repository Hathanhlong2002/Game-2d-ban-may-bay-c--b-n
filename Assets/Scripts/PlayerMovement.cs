using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed=5f;
    private Rigidbody2D rb2d;
        // Start is called before the first frame update
    void Start()
    {   
        rb2d=GetComponent<Rigidbody2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        // Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        // gameObject.transform.position += movement*speed*Time.deltaTime;
        rb2d.velocity = new Vector2(moveHorizontal*speed,moveVertical*speed);
        


        Checksize();
        
    }
    private void Checksize()
    {
        float objectWidth = GetComponent<Renderer>().bounds.size.x; // Lấy chiều rộng của vật thể
        float objectHeight = GetComponent<Renderer>().bounds.size.y; // Lấy chiều cao của vật thể
        float screenWidth = Camera.main.aspect * Camera.main.orthographicSize; // Tính giới hạn màn hình theo chiều ngang
        float screenHeight = Camera.main.orthographicSize; // Tính giới hạn màn hình theo chiều dọc
        // Kiểm tra và giới hạn vật thể đi qua trái
        if (transform.position.x - objectWidth / 2 < -screenWidth)
        {
            transform.position = new Vector3(-screenWidth + objectWidth / 2, transform.position.y, transform.position.z);
        }
        // Kiểm tra và giới hạn vật thể đi qua phải
        if (transform.position.x + objectWidth / 2 > screenWidth)
        {
            transform.position = new Vector3(screenWidth - objectWidth / 2, transform.position.y, transform.position.z);
        }
        // Kiểm tra và giới hạn vật thể đi qua bên trên
        if (transform.position.y + objectHeight / 2 > screenHeight)
        {
            transform.position = new Vector3(transform.position.x, screenHeight - objectHeight / 2, transform.position.z);
        }
        // Kiểm tra và giới hạn vật thể đi qua bên dưới
        if (transform.position.y - objectHeight / 2 < -screenHeight)
        {
            transform.position = new Vector3(transform.position.x, -screenHeight + objectHeight / 2, transform.position.z);
        }
    }

}
