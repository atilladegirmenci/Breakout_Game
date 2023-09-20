using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class brick : MonoBehaviour
{
    
    public TextMeshProUGUI brickCountLeft;
    public int numberOfBricks;
    public Ball _ball;
    public GameObject powerUp;
    void Start()
    {
        
      
    }

   
    void Update()
    {
        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;
        brickCountLeft.text = numberOfBricks.ToString();
        if (numberOfBricks <= 0)
        {  
          SceneManager.LoadScene("level complate scene");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {   
          
            Destroy(gameObject);
            if (numberOfBricks <= 1)
            {
                SceneManager.LoadScene("level complate scene");
            }
            
            if (Random.Range(0, 100) < 10)
            {
                
                Instantiate(powerUp, transform.position, transform.rotation);
               
            }
        }
        
    }
    
}
