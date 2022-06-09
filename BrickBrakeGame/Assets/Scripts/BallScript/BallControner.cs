using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControner : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    float speed = 500f ;
   
    [SerializeField]
    bool inPlay;
    
    [SerializeField]
    Transform ballStartPos;

    GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager=Object.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager.gameOver)
        {
            return;
        }

        if (!inPlay)
        {
            transform.position = ballStartPos.position;
        }
        
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true; 
            rb.AddForce(Vector2.up * speed); 
        }
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag=="bottom")
        {
            rb.velocity = Vector2.zero;
            gameManager.UpdateLives(-1);
            
            inPlay = false;


        }
    }


}
