using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class powerUps : MonoBehaviour
{
    public Player player;
    public Ball _ball;
    
    Rigidbody2D rb;
    public float fallSpeed;
   
    
    

    void Start()
    { 
        rb= GetComponent<Rigidbody2D>();
         
       
    }


    void Update()
    {     
        rb.velocity = new Vector2(0, fallSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null )
        {
          if(collision.gameObject.tag == "Player")
          {
                
                Instantiate(Resources.Load("ball"),  player.transform.position + new Vector3(0,0.5f,0), Quaternion.identity);
                Destroy(gameObject);
          }
          
        }
              
        if (collision.gameObject.tag == "downW")
        { Destroy(gameObject); }
    }
}
