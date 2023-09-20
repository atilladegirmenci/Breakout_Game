using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public float moveSpeed;
    public Rigidbody2D rb;
    public float dirX;

    // Start is called before the first frame update
    void Start()
    {
     rb= GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {

       
       

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y) ;
        
    }
}
