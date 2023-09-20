using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ball : MonoBehaviour
{
    private AudioSource bounceSound;
    public brick brick;
    public int numberOfBall;
    public bool powerUpCheck;
    public float force;
    public Rigidbody2D rb;
    public float dirXSpeed;
    void Start()
    {
         bounceSound = GetComponent<AudioSource>();
         
       
        rb = GetComponent<Rigidbody2D>();
        dirXSpeed= GenerateRndm();
        if(dirXSpeed == 0)
        {
           dirXSpeed= GenerateRndm();
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
       
        rb.velocity =new  Vector2(dirXSpeed, force);
        numberOfBall = GameObject.FindGameObjectsWithTag("Ball").Length;
       
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        brick brick = collision.gameObject.GetComponent<brick>();
        Player player = collision.gameObject.GetComponent<Player>();

        if(collision.gameObject.tag =="Player")
        {
            bounceSound.Play();
            force = force * -1;
            if(player != null)
            {             
                if (player.dirX < 0)
                {
                    dirXSpeed -= 1;
                }
                else if (player.dirX > 0)
                {                  
                    dirXSpeed += 1;
                } 
            }            
        }
        if (collision.gameObject.tag == "brick") 
        {
            bounceSound.Play();
            dirXSpeed = GenerateRndm();
            force = force * -1;           
        }     
        if(collision.gameObject.tag == "rightW")
        {
            dirXSpeed *= -1;
        }     
        if (collision.gameObject.tag == "leftW") 
        {
            dirXSpeed *= -1;
        }
        if (collision.gameObject.tag =="upW")
        {
            force *= -1;
        }
        
        if (collision.gameObject.tag == "downW") 
        {
            Destroy(gameObject);
            if (numberOfBall <= 1)
            {
                SceneManager.LoadScene("you lost scene");
            }
        }
        

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
       
    }
    public float GenerateRndm()
    {
        float newSpeed;
        newSpeed = UnityEngine.Random.Range(-1.4f, 1.4f);
        return newSpeed;
    }

    

   
}
